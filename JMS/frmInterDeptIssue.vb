﻿Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmInterDeptIssue
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private mFr_State As FormState

    Dim strSQL As String = Nothing
    Dim TempRow As Integer
    Dim GridDoubleClick As Boolean

    Dim dbltempCalculate As Double = 0

    Dim dbManager As New SqlHelper()
    Dim Objcn As SqlConnection = New SqlConnection()

    Dim iReceiptId As Int16
    Dim iReceiptDetailId As Int16
    Dim iIssueId As Int16
    Dim iUsedBagId As Int16
    Dim iTransId As Int16

    Dim dBalanceWt As Double

    Private Objerr As New ErrorProvider()
    Private Property Fr_Mode() As FormState
        Get
            Return mFr_State
        End Get
        Set(ByVal value As FormState)
            mFr_State = value
            Select Case mFr_State
                Case FormState.AStateMode
                    CType(Me.ParentForm, frmMain).FormMode.Text = "New"
                    Me.btnSave.Enabled = True
                    Me.btnSave.Text = "&Save"
                    Me.btnDelete.Enabled = False
                    lblLotNo.Visible = False
                    txtVocucherNo.Visible = False
                Case FormState.EStateMode
                    CType(Me.ParentForm, frmMain).FormMode.Text = "Edit"
                    Me.btnSave.Text = "&Update"
                    Me.btnDelete.Enabled = True
                    lblLotNo.Visible = True
                    txtVocucherNo.Visible = True
            End Select
        End Set
    End Property
    Private Sub frmNewInterDeptIssue_Load(sender As Object, e As EventArgs) Handles Me.Load
        If dtUserRights.Rows.Count > 0 Then
            Dim DtRow() As DataRow = dtUserRights.Select("FormName = 'ACCOUNT MASTER'")
            USERADD = DtRow(0).Item(3)
            USEREDIT = DtRow(0).Item(4)
            USERVIEW = DtRow(0).Item(5)
            USERDELETE = DtRow(0).Item(6)
            DeptId = DtRow(0).Item(7)

            If USEREDIT = False And USERDELETE = False Then
                MsgBox("Insufficient Rights")
                btnDelete.Enabled = False
            End If
        End If

        Me.fillDepartment()
        Me.fillLabour()

        Me.Clear_Form()
    End Sub
    Private Sub fillDepartment()

        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_DepartmentMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)
        Dim Odt As DataTable = New DataTable()

        Odt.Load(dr)

        Dim Cdt As DataTable = Odt.Copy()

        Try
            ''Insert the Default Item to DataTable.
            Dim frow As DataRow = Odt.NewRow()
            frow(0) = 0
            frow(1) = "---Select---"
            Odt.Rows.InsertAt(frow, 0)

            ''Assign DataTable as DataSource.
            cmbfDepartment.DataSource = Odt
            cmbfDepartment.DisplayMember = "DepartmentName"
            cmbfDepartment.ValueMember = "DepartmentId"

            ''Insert the Default Item to DataTable.
            Dim trow As DataRow = Cdt.NewRow()
            trow(0) = 0
            trow(1) = "---Select---"
            Cdt.Rows.InsertAt(trow, 0)

            cmbtDepartment.DataSource = Cdt
            cmbtDepartment.DisplayMember = "DepartmentName"
            cmbtDepartment.ValueMember = "DepartmentId"
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub
    Private Sub fillLabour()
        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FillLabour", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_LabourMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), Objcn)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            ''Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbTLabour.DataSource = dt
            cmbTLabour.DisplayMember = "LabourName"
            cmbTLabour.ValueMember = "LabourId"

            cmbTLabour.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbTLabour.AutoCompleteDataSource = AutoCompleteSource.ListItems
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            Objcn.Close()
        End Try
    End Sub
    Private Sub bindDataGridView()
        Dim dtdata As DataTable = fetchAllRecords()

        Try
            dgvInterDeptIssue.DataSource = dtdata
            dgvInterDeptIssue.EnableFiltering = True
            dgvInterDeptIssue.MasterTemplate.ShowFilteringRow = False
            dgvInterDeptIssue.MasterTemplate.ShowHeaderCellButtons = True
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
        End Try
    End Sub
    Private Sub cmbItemType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cmbItemType.SelectedIndexChanged
        If cmbItemType.Items.Count > 0 Then
            If cmbItemType.SelectedIndex = 0 Then
                FillBags()
            ElseIf cmbItemType.SelectedIndex = 1 Then
                FillVoucher()
            ElseIf cmbItemType.SelectedIndex = 2 Then
                FillFinishedLots()
            ElseIf cmbItemType.SelectedIndex = 3 Then
                FillLotAddition()
            End If
        End If
    End Sub
    Private Sub Clear_Form()
        Try
            '' For Header Field Start
            txtVocucherNo.Tag = ""
            txtVocucherNo.Clear()
            TransDt.Value = DateTime.Now

            cmbfDepartment.SelectedIndex = 0
            cmbtDepartment.SelectedIndex = 0

            txtFrKarigar.Tag = ""
            txtFrKarigar.Clear()
            cmbTLabour.SelectedIndex = 0
            '' For Header Field End

            '' For Detail Field Start
            txtSrNo.Text = 1

            cmbItemType.SelectedIndex = -1
            Rmccmb.Text = Nothing

            txtItemName.Tag = ""
            txtItemName.Clear()

            txtIssueWt.Tag = ""
            txtIssueWt.Clear()
            txtIssuePr.Clear()
            txtFineWt.Tag = ""
            txtFineWt.Clear()

            dgvIssue.RowCount = 0
            '' For Detail Field End

            GridDoubleClick = False

            lblTotalGrossWt.Text = 0.0
            lblTotalGrossPr.Text = 0.0

            lblTotalStockAdd.Text = 0.0

            Me.bindDataGridView()

            Fr_Mode = FormState.AStateMode

            ''Setting Values Start

            cmbtDepartment.SelectedIndex = DeptId
            cmbtDepartment.Enabled = False

            cmbfDepartment.SelectedIndex = 4
            cmbfDepartment.Enabled = False

            txtFrKarigar.Tag = CInt(UserId)
            txtFrKarigar.Text = Convert.ToString(KarigarName.Trim)

            TransDt.Focus()
            TransDt.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function fetchAllRecords() As DataTable

        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Issue_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData

    End Function
    Sub GetSrNo(ByRef grid As Telerik.WinControls.UI.RadGridView)
        Try
            For Each rowInfo As GridViewRowInfo In dgvIssue.Rows
                rowInfo.Cells(0).Value = rowInfo.Index + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub fillBags()
        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "GetStockData", DbType.String))
        End With

        dt = dbManager.GetDataTable("SP_UsedBags_Select", CommandType.StoredProcedure, parameters.ToArray())

        'Assign DataTable as DataSource.
        Rmccmb.DataSource = Nothing
        Rmccmb.DataSource = dt
        Rmccmb.DisplayMember = "BagSrNo"
        Rmccmb.ValueMember = "IssueId"

        Rmccmb.Columns(1).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(3).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(4).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(5).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(7).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(8).TextAlignment = ContentAlignment.MiddleRight

        Rmccmb.Columns(0).IsVisible = False
        Rmccmb.Columns(3).IsVisible = False
        'Rmccmb.Columns(9).IsVisible = False
        'Rmccmb.Columns(10).IsVisible = False

        Me.Rmccmb.AutoCompleteMode = AutoCompleteMode.Append
        Me.Rmccmb.AutoSizeDropDownToBestFit = True

        Me.Rmccmb.AutoFilter = True
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.Rmccmb.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.Rmccmb.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub
    Private Sub fillVoucher()
        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "GetStockData", DbType.String))
        End With

        dt = dbManager.GetDataTable("SP_Receipt_Select", CommandType.StoredProcedure, parameters.ToArray())

        'Assign DataTable as DataSource.
        Rmccmb.DataSource = Nothing
        Rmccmb.DataSource = dt
        Rmccmb.DisplayMember = "VoucherNo"
        Rmccmb.ValueMember = "IssueId"

        Rmccmb.Columns(1).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(5).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(7).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(8).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(9).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(10).TextAlignment = ContentAlignment.MiddleRight

        Rmccmb.Columns(0).IsVisible = False
        Rmccmb.Columns(2).IsVisible = False
        Rmccmb.Columns(3).IsVisible = False
        Rmccmb.Columns(4).IsVisible = False
        Rmccmb.Columns(6).IsVisible = False
        Rmccmb.Columns(11).IsVisible = False

        Me.Rmccmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.Rmccmb.AutoSizeDropDownToBestFit = True

        Me.Rmccmb.AutoFilter = True
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.Rmccmb.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.Rmccmb.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub
    Private Sub fillLotAddition()
        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "GetStockData", DbType.String))
        End With

        dt = dbManager.GetDataTable("SP_LotAdditionReceive_Select", CommandType.StoredProcedure, parameters.ToArray())

        'Assign DataTable as DataSource.
        Rmccmb.DataSource = Nothing

        Rmccmb.DataSource = dt
        Rmccmb.DisplayMember = "LotAdditionNo"
        Rmccmb.ValueMember = "ItemId"

        Rmccmb.Columns(1).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(3).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(4).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(5).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(7).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(8).TextAlignment = ContentAlignment.MiddleRight

        Rmccmb.Columns(0).IsVisible = False
        Rmccmb.Columns(2).IsVisible = False
        Rmccmb.Columns(3).IsVisible = False

        Me.Rmccmb.AutoCompleteMode = AutoCompleteMode.Append
        Me.Rmccmb.AutoSizeDropDownToBestFit = True

        Me.Rmccmb.AutoFilter = True
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.Rmccmb.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.Rmccmb.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub
    Private Sub fillFinishedLots()
        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "GetFinishedLots", DbType.String))
        End With

        dt = dbManager.GetDataTable("SP_Transaction_Select", CommandType.StoredProcedure, parameters.ToArray())

        'Assign DataTable as DataSource.
        Rmccmb.DataSource = Nothing

        Rmccmb.DataSource = dt
        Rmccmb.DisplayMember = "LotNo"
        Rmccmb.ValueMember = "ItemId"

        Rmccmb.Columns(2).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(4).TextAlignment = ContentAlignment.MiddleLeft
        Rmccmb.Columns(5).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(7).TextAlignment = ContentAlignment.MiddleRight

        Rmccmb.Columns(0).IsVisible = False
        Rmccmb.Columns(1).IsVisible = False
        Rmccmb.Columns(3).IsVisible = False

        Me.Rmccmb.AutoCompleteMode = AutoCompleteMode.Append
        Me.Rmccmb.AutoSizeDropDownToBestFit = True

        Me.Rmccmb.AutoFilter = True
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.Rmccmb.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.Rmccmb.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    End Sub
    Private Sub Rmccmb_GotFocus(sender As Object, e As EventArgs) Handles Rmccmb.GotFocus
        Me.Rmccmb.MultiColumnComboBoxElement.ShowPopup()
    End Sub
    Private Sub txtStockAdd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStockAdd.Validating
        Try
            If txtItemName.Text.Trim <> "" And Val(txtIssueWt.Text.Trim) > 0 And Val(txtIssuePr.Text.Trim) > 0 And Val(txtFineWt.Text) > 0 Then
                If dgvIssue.Rows.Count > 0 AndAlso ChkDuplicate() = True Then
                    MsgBox("Duplicate Data")
                Else
                    Me.fillGrid()
                    Me.Total()
                End If
            Else
                MsgBox("Enter Proper Details")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cmbItemType_GotFocus(sender As Object, e As EventArgs) Handles cmbItemType.GotFocus
        cmbItemType.ShowDropDown()
    End Sub
    Private Sub txtIssueWt_TextChanged(sender As Object, e As EventArgs) Handles txtIssueWt.TextChanged
        Try
            If txtIssuePr.Text <> "" Then
                txtFineWt.Text = Format((Val(txtIssueWt.Text) * Val(txtIssuePr.Text)) / 100, "0.000")
            Else
                txtFineWt.Text = Format((Val(txtIssueWt.Text) * Val(txtConversion.Text)) / 100, "0.000")
            End If

            dbltempCalculate = 0

            dbltempCalculate = Format((Val(txtIssueWt.Text) * Val(txtIssuePr.Text)) / 100, "0.00")
            txtStockAdd.Text = Format(Val(txtFineWt.Text) - Val(dbltempCalculate), "0.00")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim TmpLotNo As String = Nothing

        If Not Validate_Fields() Then Exit Sub

        Try
            If Fr_Mode = FormState.AStateMode Then
                Dim Dt As DataTable = Me.SaveData()

                Me.btnCancel_Click(sender, e)
            Else
                Me.UpdateData()
                Me.btnCancel_Click(sender, e)
            End If

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try
    End Sub
    Private Sub cmbtKarigar_GotFocus(sender As Object, e As EventArgs) Handles cmbTLabour.GotFocus
        cmbTLabour.ShowDropDown()
    End Sub
    Sub fillGrid()

        If GridDoubleClick = False Then

            dbltempCalculate = txtStockAdd.Text.Trim()

            dgvIssue.Rows.Add(Val(txtSrNo.Text.Trim),
                                    cmbItemType.Text.Trim(),
                                    CStr(Rmccmb.Text.Trim),
                                    txtItemName.Tag,
                                    txtItemName.Text.Trim(),
                                    Format(Val(txtIssueWt.Text.Trim), "0.00"),
                                    Format(Val(txtIssuePr.Text.Trim), "0.00"),
                                    Format(Val(txtConversion.Text.Trim), "0.00"),
                                    Format(Val(txtFineWt.Text.Trim), "0.000"),
                                    Format(dbltempCalculate, "0.00"),
                                    Val(iReceiptId),
                                    Val(iReceiptDetailId),
                                    Val(iUsedBagId),
                                    Val(iIssueId),
                                    Val(iTransId))
            GetSrNo(dgvIssue)
        Else
            dgvIssue.Rows(TempRow).Cells(0).Value = txtSrNo.Text.Trim
            dgvIssue.Rows(TempRow).Cells(1).Value = cmbItemType.Text.Trim()
            dgvIssue.Rows(TempRow).Cells(2).Value = CStr(Rmccmb.Text.Trim)
            dgvIssue.Rows(TempRow).Cells(3).Value = txtItemName.Tag
            dgvIssue.Rows(TempRow).Cells(4).Value = txtItemName.Text.Trim()
            dgvIssue.Rows(TempRow).Cells(5).Value = Format(Val(txtIssueWt.Text.Trim), "0.00")
            dgvIssue.Rows(TempRow).Cells(6).Value = Format(Val(txtIssuePr.Text.Trim), "0.00")
            dgvIssue.Rows(TempRow).Cells(7).Value = Format(Val(txtConversion.Text.Trim), "0.00")
            dgvIssue.Rows(TempRow).Cells(8).Value = Format(Val(txtFineWt.Text.Trim), "0.00")
            dgvIssue.Rows(TempRow).Cells(9).Value = Format(Val(txtStockAdd.Text.Trim), "0.00")
            dgvIssue.Rows(TempRow).Cells(10).Value = Val(iReceiptId)
            dgvIssue.Rows(TempRow).Cells(11).Value = Val(iReceiptDetailId)
            dgvIssue.Rows(TempRow).Cells(12).Value = Val(iUsedBagId)
            dgvIssue.Rows(TempRow).Cells(13).Value = Val(iIssueId)
            dgvIssue.Rows(TempRow).Cells(14).Value = Val(iTransId)

            GridDoubleClick = False
        End If

        Me.Total()

        dgvIssue.TableElement.ScrollToRow(dgvIssue.Rows.Last)

        txtSrNo.Text = dgvIssue.RowCount + 1

        cmbItemType.SelectedIndex = 0
        Rmccmb.Text = ""

        txtItemName.Tag = ""
        txtIssueWt.Tag = ""
        txtIssuePr.Tag = ""
        txtConversion.Tag = ""

        txtItemName.Clear()
        txtIssueWt.Clear()
        txtIssuePr.Clear()
        txtConversion.Clear()
        txtFineWt.Clear()
        txtStockAdd.Clear()

        cmbItemType.Focus()
    End Sub
    Sub Total()
        lblTotalGrossWt.Text = 0.00
        lblTotalGrossPr.Text = 0.00
        lblTotalStockAdd.Text = 0.00

        Try
            For Each row As GridViewRowInfo In dgvIssue.Rows
                lblTotalGrossWt.Text = Format(Val(lblTotalGrossWt.Text) + Val(row.Cells(5).Value), "0.00")
                lblTotalGrossPr.Text = Format(Val(lblTotalGrossPr.Text) + Val(row.Cells(8).Value), "0.00")

                lblTotalStockAdd.Text = Format(Val(lblTotalStockAdd.Text) + Val(row.Cells(9).Value), "0.00")
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Call Clear_Form()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(txtVocucherNo.Tag) Then

            Try
                Dim parameters = New List(Of SqlParameter)()

                With parameters
                    .Clear()
                    .Add(dbManager.CreateParameter("@IId", CInt(txtVocucherNo.Tag), DbType.Int16))
                End With

                dbManager.Delete("SP_InterDeptIssue_Delete", CommandType.StoredProcedure, parameters.ToArray())

                MessageBox.Show("Data Deleted !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Clear_Form()

            Catch ex As Exception
                MessageBox.Show("Error:- " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please Select A Record !!!")
        End If
    End Sub
    Private Sub dgvIssue_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvIssue.KeyDown
        Try
            If e.KeyCode = Keys.Delete And dgvIssue.RowCount > 0 Then
                'dont allow user if any of the grid line is in edit mode.....
                If GridDoubleClick = True Then
                    MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
                    Exit Sub
                End If
                'end of block

                dgvIssue.Rows.RemoveAt(dgvIssue.CurrentRow.Index)

                Me.Total()
                Me.GetSrNo(dgvIssue)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function Validate_Fields() As Boolean
        Try
            If Not dgvIssue.RowCount > 0 Then
                MessageBox.Show("Cannot Save Without Detail Information!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
                Exit Function
            End If

            If cmbfDepartment.SelectedIndex = 0 Then
                MessageBox.Show("Select Department !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbfDepartment.Focus()
                Return False
            ElseIf cmbTLabour.SelectedIndex = -1 Or cmbTLabour.SelectedIndex = 0 Then
                MessageBox.Show("Select To Employee !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbTLabour.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub txtIssueWt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIssueWt.KeyPress
        numdotkeypress(e, txtIssueWt, Me)
    End Sub
    Private Sub fillHeaderFromListView(ByVal intIssueId As Integer)
        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FetchHeaderRecord", DbType.String))
            .Add(dbManager.CreateParameter("@IId", CInt(intIssueId), DbType.Int16))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_Issue_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

        If dr.HasRows = False Then
            Exit Sub
        Else
            dr.Read()
            txtVocucherNo.Tag = dr.Item("IssueId").ToString()
            txtVocucherNo.Text = dr.Item("VoucherNo").ToString()
            TransDt.Text = dr.Item("IssueDt").ToString()
            cmbfDepartment.SelectedIndex = dr.Item("FrDeptId").ToString()
            cmbtDepartment.SelectedIndex = dr.Item("ToDeptId").ToString()
            txtFrKarigar.Tag = dr.Item("FrKarigarId").ToString
            txtFrKarigar.Text = dr.Item("FrKarigar").ToString
            cmbTLabour.SelectedIndex = dr.Item("ToKarigarId").ToString
        End If

        dr.Close()
        Objcn.Close()

        Exit Sub
ErrHandler:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    Private Sub fillDetailsFromListView(ByVal intIssueId As Integer)
        Dim dttable As New DataTable
        dttable = fetchAllRecords(CInt(intIssueId))

        For Each ROW As DataRow In dttable.Rows
            dgvIssue.Rows.Add(1, CStr(ROW("ItemType")), CStr(ROW("SlipBagNo")), Val(ROW("ItemId")), CStr(ROW("ItemName")), Format(Val(ROW("IssueWt")), "0.00"), Format(Val(ROW("IssuePr")), "0.00"), Format(Val(ROW("ConvPr")), "0.00"), Format(Val(ROW("FineWt")), "0.00"), Format(Val(ROW("StockAdd")), "0.00"))
        Next

        Me.GetSrNo(dgvIssue)
        Me.Total()

        dgvIssue.ReadOnly = True

    End Sub
    Private Function fetchAllRecords(ByVal intIssueId As Integer) As DataTable
        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@IId", CInt(intIssueId), DbType.Int16))
                .Add(dbManager.CreateParameter("@ActionType", "FetchDetailRecord", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Issue_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData
    End Function
    Private Function SaveData() As DataTable
        Dim Dt As DataTable = Nothing

        Dim alParaval As New ArrayList

        Dim GridSrNo As String = ""
        Dim ItemType As String = Nothing
        Dim SlipBagNo As String = Nothing
        Dim ItemId As String = ""
        Dim IssueWt As String = ""
        Dim IssuePr As String = ""

        Dim ConvPr As String = ""
        Dim FineWt As String = ""
        Dim StockAdd As String = ""

        Dim ReceiptId As String = Nothing
        Dim ReceiptDetailId As String = Nothing
        Dim UsedBagId As String = Nothing
        Dim IssueId As String = Nothing
        Dim TransId As String = Nothing

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(cmbfDepartment.SelectedValue)
        alParaval.Add(cmbtDepartment.SelectedIndex)
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedValue)

        For Each row As GridViewRowInfo In dgvIssue.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemType = Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = Convert.ToString(row.Cells(2).Value)
                    ItemId = row.Cells(3).Value
                    IssueWt = row.Cells(5).Value
                    IssuePr = row.Cells(6).Value
                    ConvPr = row.Cells(7).Value
                    FineWt = row.Cells(8).Value
                    StockAdd = row.Cells(9).Value
                    ReceiptId = Val(row.Cells(10).Value)
                    ReceiptDetailId = Val(row.Cells(11).Value)
                    UsedBagId = Val(row.Cells(12).Value)
                    IssueId = Val(row.Cells(13).Value)
                    TransId = Val(row.Cells(14).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemType = ItemType & "|" & Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = SlipBagNo & "|" & Convert.ToString(row.Cells(2).Value)
                    ItemId = ItemId & "|" & row.Cells(3).Value
                    IssueWt = IssueWt & "|" & row.Cells(5).Value
                    IssuePr = IssuePr & "|" & row.Cells(6).Value

                    ConvPr = ConvPr & "|" & row.Cells(7).Value
                    FineWt = FineWt & "|" & row.Cells(8).Value
                    StockAdd = StockAdd & "|" & row.Cells(9).Value
                    ReceiptId = ReceiptId & "|" & Val(row.Cells(10).Value)
                    ReceiptDetailId = ReceiptDetailId & "|" & Val(row.Cells(11).Value)
                    UsedBagId = UsedBagId & "|" & Val(row.Cells(12).Value)
                    IssueId = IssueId & "|" & Val(row.Cells(13).Value)
                    TransId = TransId & "|" & Val(row.Cells(14).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemType)
        alParaval.Add(SlipBagNo)
        alParaval.Add(ItemId)
        alParaval.Add(IssueWt)
        alParaval.Add(IssuePr)

        alParaval.Add(ConvPr)
        alParaval.Add(FineWt)
        alParaval.Add(StockAdd)
        alParaval.Add(ReceiptId)
        alParaval.Add(ReceiptDetailId)
        alParaval.Add(UsedBagId)
        alParaval.Add(IssueId)
        alParaval.Add(TransId)

        Try
            Dim tparameters = New List(Of SqlParameter)()
            tparameters.Clear()

            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@HIssueDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HfDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HtDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))
                .Add(dbManager.CreateParameter("@HIsOpening", 1, DbType.Boolean))

                .Add(dbManager.CreateParameter("@DItemType", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DSlipBagNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssueWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssuePr", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DConvPr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DStockAdd", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DReceiptId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceiptDetailsId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DUsedBagId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssueId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DTransId", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            dbManager.Insert("SP_Issue_Save", CommandType.StoredProcedure, Hparameters.ToArray())

            If cmbItemType.Text = "Finished Lots" Then
                Hparameters.Add(dbManager.CreateParameter("@ActionType", "UpdateIsDelivered", DbType.String))
                Hparameters.Add(dbManager.CreateParameter("@TLotNo", cmbItemType.Text, DbType.String))
                tparameters.Add(dbManager.CreateParameter("@TFinalLot", 0, DbType.Boolean))
                dbManager.Insert("SP_Transaction_FinalLot", CommandType.StoredProcedure, tparameters.ToArray())
            End If

            MessageBox.Show("Data Saved !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try

        Return Dt

    End Function
    Private Sub dgvIssue_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvIssue.CellDoubleClick
        Try
            If e.RowIndex = -1 Then Exit Sub

            If e.RowIndex >= 0 And dgvIssue.Rows(e.RowIndex).Cells(0).Value <> Nothing Then
                GridDoubleClick = True
                txtSrNo.Text = dgvIssue.Rows(e.RowIndex).Cells(0).Value.ToString()
                cmbItemType.Text = dgvIssue.Rows(e.RowIndex).Cells(1).Value.ToString()
                Rmccmb.Text = CStr(dgvIssue.Rows(e.RowIndex).Cells(2).Value)
                txtItemName.Tag = CInt(dgvIssue.Rows(e.RowIndex).Cells(3).Value)
                txtItemName.Text = dgvIssue.Rows(e.RowIndex).Cells(4).Value.ToString()
                txtIssueWt.Text = dgvIssue.Rows(e.RowIndex).Cells(5).Value.ToString()
                txtIssueWt.Tag = dgvIssue.Rows(e.RowIndex).Cells(13).Value.ToString()
                txtIssuePr.Text = dgvIssue.Rows(e.RowIndex).Cells(6).Value.ToString()
                txtConversion.Text = dgvIssue.Rows(e.RowIndex).Cells(7).Value.ToString()
                txtFineWt.Text = dgvIssue.Rows(e.RowIndex).Cells(8).Value.ToString()
                txtStockAdd.Text = dgvIssue.Rows(e.RowIndex).Cells(9).Value.ToString()

                iReceiptId = dgvIssue.Rows(e.RowIndex).Cells(10).Value.ToString()
                iReceiptDetailId = dgvIssue.Rows(e.RowIndex).Cells(11).Value.ToString()
                iUsedBagId = dgvIssue.Rows(e.RowIndex).Cells(12).Value.ToString()
                iIssueId = dgvIssue.Rows(e.RowIndex).Cells(13).Value.ToString()
                iTransId = dgvIssue.Rows(e.RowIndex).Cells(14).Value.ToString()

                TempRow = e.RowIndex
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub UpdateData()
        Dim alParaval As New ArrayList

        Dim GridSrNo As String = ""
        Dim ItemType As String = Nothing
        Dim LotNo As String = ""
        Dim ItemId As String = ""
        Dim IssueWt As String = ""
        Dim IssuePr As String = ""

        Dim ConvPr As String = ""
        Dim FineWt As String = ""
        Dim StockAdd As String = ""
        Dim LineNo As String = Nothing

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(cmbfDepartment.SelectedValue)
        alParaval.Add(cmbtDepartment.SelectedIndex)
        alParaval.Add(txtVocucherNo.Text.Trim)
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedValue)

        For Each row As GridViewRowInfo In dgvIssue.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemType = Convert.ToString(row.Cells(1).Value)
                    LotNo = Convert.ToString(row.Cells(2).Value)
                    ItemId = row.Cells(3).Value
                    IssueWt = row.Cells(5).Value
                    IssuePr = row.Cells(6).Value

                    ConvPr = row.Cells(7).Value
                    FineWt = row.Cells(8).Value
                    StockAdd = row.Cells(9).Value
                    LineNo = Val(row.Cells(10).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemType = ItemType & "|" & Convert.ToString(row.Cells(1).Value)
                    LotNo = LotNo & "|" & Convert.ToString(row.Cells(2).Value)
                    ItemId = ItemId & "|" & row.Cells(3).Value
                    IssueWt = IssueWt & "|" & row.Cells(5).Value
                    IssuePr = IssuePr & "|" & row.Cells(6).Value

                    ConvPr = ConvPr & "|" & row.Cells(7).Value
                    FineWt = FineWt & "|" & row.Cells(8).Value
                    StockAdd = StockAdd & "|" & row.Cells(9).Value
                    LineNo = LineNo & "|" & Val(row.Cells(10).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemType)
        alParaval.Add(LotNo)
        alParaval.Add(ItemId)
        alParaval.Add(IssueWt)
        alParaval.Add(IssuePr)

        alParaval.Add(ConvPr)
        alParaval.Add(FineWt)
        alParaval.Add(StockAdd)
        alParaval.Add(LineNo)

        Try
            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@HIssueDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HfDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HtDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@IId", Val(txtVocucherNo.Tag), DbType.Int16))
                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))
                .Add(dbManager.CreateParameter("@HIsOpening", 1, DbType.Boolean))

                .Add(dbManager.CreateParameter("@DItemType", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DLotNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssueWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssuePr", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DConvPr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DStockAdd", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DLineNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            dbManager.Update("SP_Issue_Update", CommandType.StoredProcedure, Hparameters.ToArray())

            MessageBox.Show("Data Updated !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try
    End Sub
    Private Sub txtIssueWt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIssueWt.Validating
        'If Val(txtIssueWt.Text) > Val(txtIssueWt.Tag) Then
        '    e.Cancel = True
        '    Objerr.SetError(txtIssueWt, "Wt should not be greather than Balance Wt. !")
        'Else
        '    Objerr.Clear()
        'End If
    End Sub
    Private Sub frmNewInterDeptIssue_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Keys.Escape) Then   'for Exit
                If MsgBox("Wish To Exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CType(Me.ParentForm, frmMain).FormMode.Text = ""
                    Me.Close()
                End If
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            ElseIf e.KeyCode = Keys.OemQuotes Or e.KeyCode = Keys.OemPipe Then
                e.SuppressKeyPress = True
            End If

            If (e.Alt AndAlso (e.KeyCode = Keys.S)) Then
                ' When Alt + S is pressed, the Click event for the print
                ' button is raised.
                btnSave().PerformClick()
            End If

            If e.KeyCode = Keys.F2 Then
                cmbItemType.Text = ""
                Rmccmb.Text = ""
                txtItemName.Tag = ""
                txtItemName.Clear()
                txtIssueWt.Clear()
                txtIssuePr.Clear()
                txtFineWt.Tag = ""
                txtFineWt.Clear()
                cmbItemType.Focus()
            End If

            With dgvIssue
                If e.KeyCode = Keys.F12 Then
                    .Rows.Remove(.CurrentRow)
                End If
                Me.Total()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub txtIssuePr_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIssuePr.Validating
        If Val(txtIssuePr.Text) < 1 Or Val(txtIssuePr.Text) > 100 Then
            e.Cancel = True
            Objerr.SetError(txtIssuePr, "Percent in Between 0 to 100 !")
        Else
            Objerr.Clear()
        End If
    End Sub
    Private Sub Rmccmb_LostFocus(sender As Object, e As EventArgs) Handles Rmccmb.LostFocus
        txtIssueWt.Focus()
    End Sub
    Private Sub dgvIssue_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles dgvIssue.CellEndEdit
        Try
            For Each row As GridViewRowInfo In dgvIssue.Rows
                row.Cells("colFineWt").Value = Format(Val(row.Cells("colIssueWt").Value) * Val(row.Cells("colIssuePr").Value) / 100, "0.000")
            Next
            Me.Total()
        Catch ex As Exception
            MessageBox.Show("Issue Wt. Can't Be Blank")
        End Try
    End Sub
    Private Sub dgvInterDeptIssue_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvInterDeptIssue.CellDoubleClick

        If dgvInterDeptIssue.SelectedRows.Count = 0 Then Exit Sub

        If dgvInterDeptIssue.Rows.Count > 0 Then

            Dim IssueId As Integer = Me.dgvInterDeptIssue.SelectedRows(0).Cells(0).Value

            Me.Clear_Form()

            Fr_Mode = FormState.EStateMode

            Me.fillHeaderFromListView(IssueId)

            Me.fillDetailsFromListView(IssueId)

            btnSave.Text = "Update"

            Me.TbIDeptIssue.SelectedIndex = 0
        End If
    End Sub
    Private Sub txtConversion_TextChanged(sender As Object, e As EventArgs) Handles txtConversion.TextChanged
        'Try
        '    If cmbConversion.SelectedIndex = 0 Then
        '        txtFineWt.Text = Format((Val(txtIssueWt.Text) * Val(txtIssuePr.Text)) / 100, "0.000")
        '    Else
        '        txtFineWt.Text = Format((Val(txtIssueWt.Text) * Val(cmbConversion.Text)) / 100, "0.000")
        '        dbltempCalculate = 0
        '        txtStockAdd.Text = Format(Val(txtFineWt.Text) - Val(dbltempCalculate), "0.00")
        '    End If

        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub
    Private Sub Rmccmb_DropDownClosed(sender As Object, args As RadPopupClosedEventArgs) Handles Rmccmb.DropDownClosed

        If Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 0 Then  ''Bag
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            dBalanceWt = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString

            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReportPr").Value.ToString

            iUsedBagId = Me.Rmccmb.EditorControl.CurrentRow.Cells("UsedBagId").Value.ToString
            txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString
        ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 1 Then      ''Voucher
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            dBalanceWt = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString

            iReceiptId = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptId").Value.ToString
            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString

            iReceiptDetailId = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptDetaild").Value.ToString
            ''txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalFineWt").Value.ToString
        ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 2 Then       ''Finished Lots
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiveWt").Value.ToString

            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString

            iTransId = Me.Rmccmb.EditorControl.CurrentRow.Cells("TransId").Value.ToString
            txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString
        ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 3 Then       ''Lot Addition Stock
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            iIssueId = Me.Rmccmb.EditorControl.CurrentRow.Cells("IssueId").Value.ToString
            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString

            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString

            txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString
        End If
    End Sub
    Private Function ChkDuplicate() As Boolean
        Dim exists As Boolean = False

        If GridDoubleClick = False Then
            For Each itm As GridViewRowInfo In dgvIssue.Rows
                If itm.Cells(2).Value = CStr(Rmccmb.Text.Trim) Or itm.Cells(4).Value = CStr(txtItemName.Text.Trim) Then
                    exists = True
                End If
            Next
        End If

        Return exists

    End Function
End Class