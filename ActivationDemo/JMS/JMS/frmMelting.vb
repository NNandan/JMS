﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class frmMelting
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private mFr_State As FormState

    Dim strSQL As String = Nothing
    Dim TempRow As Integer

    Dim GridDoubleClick As Boolean

    Dim dbManager As New SqlHelper(ConfigurationManager.ConnectionStrings("ConString").ToString())
    Dim Objcn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConString").ToString())

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
                    txtMeltingNo.Visible = False
                Case FormState.EStateMode
                    CType(Me.ParentForm, frmMain).FormMode.Text = "Edit"
                    Me.btnSave.Text = "&Update"
                    Me.btnDelete.Enabled = True
                    lblLotNo.Visible = True
                    txtMeltingNo.Visible = True
            End Select
        End Set
    End Property
    Private Sub Clear_Form()
        Try

            '' For Header Field Start
            txtMeltingNo.Tag = ""
            txtMeltingNo.Clear()
            TransDt.Value = DateTime.Now

            cmbItem.SelectedIndex = 0
            txtMelting.Clear()
            txtIssuePr.Clear()

            txtFrKarigar.Tag = ""
            txtFrKarigar.Clear()
            cmbTLabour.SelectedIndex = 0
            '' For Header Field End

            '' For Detail Field Start
            txtSrNo.Text = 1

            cmbItemType.Text = ""

            Rmccmb.Text = ""

            txtItemName.Tag = ""
            txtItemName.Clear()
            txtIssueWt.Tag = ""
            txtIssueWt.Clear()
            txtIssuePr.Clear()
            txtFineWt.Tag = ""
            txtFineWt.Clear()

            dgvMelting.RowCount = 0

            '' For Detail Field End

            GridDoubleClick = False

            txtSilverPr.Clear()

            lblTotal.Text = 0.0
            lblAlloyTotal.Text = 0.0
            lblGrossTotal.Text = 0.0

            lblTotalFineWt.Text = 0.00
            lblTotalSilverWt.Text = 0.00

            Me.bindListView()

            btnSave.Text = "&Save"

            Fr_Mode = FormState.AStateMode

            btnSave.Enabled = True
            btnDelete.Enabled = False

            txtFrKarigar.Tag = CInt(UserId)
            txtFrKarigar.Text = Convert.ToString(KarigarName.Trim)

            txtMelting.Focus()
            txtMelting.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub frmMelting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.filltemName()
        Me.fillLabour()

        Me.SetupListView()
        Me.bindListView()

        Me.Clear_Form()

        txtFrKarigar.Tag = CInt(UserId)
        txtFrKarigar.Text = Convert.ToString(KarigarName.Trim)
    End Sub
    Private Sub filltemName()

        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "FillItemName", DbType.String))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_ItemMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)

        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbItem.DataSource = dt
            cmbItem.DisplayMember = "ItemName"
            cmbItem.ValueMember = "ItemId"

            cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbItem.AutoCompleteDataSource = AutoCompleteSource.ListItems
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
            .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
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
            ''cmbTLabour.Enabled = False
        End Try
    End Sub
    Private Sub SetupListView()
        lstMelting.View = View.Details
        lstMelting.LabelEdit = True
        lstMelting.AllowColumnReorder = True
        lstMelting.FullRowSelect = True
        lstMelting.GridLines = True
        lstMelting.Sorting = SortOrder.Ascending
        lstMelting.Columns.Add("Melting No", 75, HorizontalAlignment.Left)
        lstMelting.Columns.Add("Melting Date", 85, HorizontalAlignment.Left)
        lstMelting.Columns.Add("Item Name", 345, HorizontalAlignment.Left)
        lstMelting.Columns.Add("Lot Number", 110, HorizontalAlignment.Left)
        lstMelting.Columns.Add("Gross Wt.", 75, HorizontalAlignment.Right)
        lstMelting.Columns.Add("Required %", 100, HorizontalAlignment.Right)
    End Sub
    Private Sub bindListView()
        Dim dtable As DataTable = fetchAllRecords()

        lstMelting.Items.Clear()
        lstMelting.LabelEdit = False

        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)

            If drow.RowState <> DataRowState.Deleted Then
                Dim lvi As ListViewItem = New ListViewItem(drow("MeltingId").ToString())
                lvi.SubItems.Add(drow("MeltingDt").ToString())
                lvi.SubItems.Add(drow("ItemName").ToString())
                lvi.SubItems.Add(drow("LotNo").ToString())
                lvi.SubItems.Add(drow("GrossWt").ToString())
                lvi.SubItems.Add(drow("RequirePr").ToString())
                lstMelting.Items.Add(lvi)
            End If
        Next
    End Sub
    Private Function fetchAllRecords() As DataTable

        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()
            parameters.Clear()

            With parameters
                .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Melting_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData

    End Function
    Private Function fetchAllRecords(ByVal intMeltingId As Integer) As DataTable
        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()
            parameters.Clear()

            With parameters
                .Add(dbManager.CreateParameter("@MId", CInt(intMeltingId), DbType.Int16))
                .Add(dbManager.CreateParameter("@ActionType", "FetchDetailRecord", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Melting_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData
    End Function
    Sub fillGrid()

        If GridDoubleClick = False Then
            dgvMelting.Rows.Add(Val(txtSrNo.Text.Trim),
                                    cmbItemType.Text.Trim(),
                                    CStr(Rmccmb.Text.Trim),
                                    txtItemName.Tag,
                                    txtItemName.Text.Trim(),
                                    Format(Val(txtIssueWt.Text.Trim), "0.00"),
                                    Format(Val(txtIssuePr.Text.Trim), "0.00"),
                                    Format(Val(txtFineWt.Text.Trim), "0.000"),
                                    Val(txtIssuePr.Tag),
                                    Val(txtFineWt.Tag),
                                    Val(txtSrNo.Tag))

            GetSrNo(dgvMelting)
        Else
            dgvMelting.Rows(TempRow).Cells(0).Value = txtSrNo.Text.Trim
            dgvMelting.Rows(TempRow).Cells(1).Value = cmbItemType.Text.Trim
            dgvMelting.Rows(TempRow).Cells(2).Value = CStr(Rmccmb.Text.Trim)
            dgvMelting.Rows(TempRow).Cells(3).Value = txtItemName.Tag
            dgvMelting.Rows(TempRow).Cells(4).Value = txtItemName.Text.Trim
            dgvMelting.Rows(TempRow).Cells(5).Value = Format(Val(txtIssueWt.Text.Trim), "0.00")
            dgvMelting.Rows(TempRow).Cells(6).Value = Format(Val(txtIssuePr.Text.Trim), "0.00")
            dgvMelting.Rows(TempRow).Cells(7).Value = Format(Val(txtFineWt.Text.Trim), "0.000")
            dgvMelting.Rows(TempRow).Cells(8).Value = Val(txtIssuePr.Tag)
            dgvMelting.Rows(TempRow).Cells(9).Value = Val(txtFineWt.Tag)
            dgvMelting.Rows(TempRow).Cells(10).Value = Val(txtSrNo.Tag)
            GridDoubleClick = False
        End If

        Me.Total()

        dgvMelting.TableElement.ScrollToRow(dgvMelting.Rows.Last)

        txtSrNo.Text = dgvMelting.RowCount + 1
        cmbItemType.Text = ""
        Rmccmb.Text = ""

        txtItemName.Tag = ""
        txtIssuePr.Tag = ""
        txtFineWt.Tag = ""
        txtSrNo.Tag = ""

        txtItemName.Clear()
        txtIssueWt.Clear()
        txtIssuePr.Clear()
        txtFineWt.Clear()

        cmbItemType.Focus()
    End Sub
    Sub GetSrNo(ByRef grid As Telerik.WinControls.UI.RadGridView)
        Try
            For Each rowInfo As GridViewRowInfo In dgvMelting.Rows
                rowInfo.Cells(0).Value = rowInfo.Index + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function ChkDuplicate() As Boolean
        Dim exists As Boolean = False

        If GridDoubleClick = False Then
            For Each itm As GridViewRowInfo In dgvMelting.Rows
                If itm.Cells(4).Value = CStr(txtItemName.Text.Trim) Then
                    exists = True
                End If
            Next
        End If

        Return exists

    End Function
    Sub Total()
        Dim dblTempTotal As Double = 0

        Try
            lblTotal.Text = 0.00
            lblAlloyTotal.Text = 0.00
            lblGrossTotal.Text = 0.00

            lblTotalFineWt.Text = 0.000

            For Each row As GridViewRowInfo In dgvMelting.Rows
                lblTotal.Text = Format(Val(lblTotal.Text) + Val(row.Cells(5).Value), "0.00")
                lblTotalFineWt.Text = Format(Val(lblTotalFineWt.Text) + Val(row.Cells(7).Value), "0.000")
                lblGrossTotal.Text = Format(Val(lblTotalFineWt.Text * 100) / Val(txtMelting.Text), "0.00")

                lblAlloyTotal.Text = Format(Val(lblGrossTotal.Text) - Val(lblTotal.Text), "0.00")
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cmbItemType_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cmbItemType.SelectedIndexChanged
        If cmbItemType.Items.Count > 0 Then
            If cmbItemType.SelectedIndex = 0 Then
                Me.fillBags()
            ElseIf cmbItemType.SelectedIndex = 1 Then
                Me.fillVoucher()
            ElseIf cmbItemType.SelectedIndex = 2 Then
                Me.fillLotAddition()
            End If
        End If
    End Sub
    Private Sub fillBags()
        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
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
        Rmccmb.Columns(9).IsVisible = False
        Rmccmb.Columns(10).IsVisible = False

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
        parameters.Clear()

        With parameters
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
        Rmccmb.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(7).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(8).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(9).TextAlignment = ContentAlignment.MiddleRight
        Rmccmb.Columns(11).TextAlignment = ContentAlignment.MiddleRight

        Rmccmb.Columns(0).IsVisible = False
        Rmccmb.Columns(2).IsVisible = False
        Rmccmb.Columns(3).IsVisible = False
        Rmccmb.Columns(4).IsVisible = False
        Rmccmb.Columns(9).IsVisible = False
        Rmccmb.Columns(10).IsVisible = False

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
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "GetStockData", DbType.String))
        End With

        dt = dbManager.GetDataTable("SP_LotAdditionReceive_Select", CommandType.StoredProcedure, parameters.ToArray())

        'Assign DataTable as DataSource.
        Rmccmb.DataSource = Nothing

        Rmccmb.DataSource = dt
        Rmccmb.DisplayMember = "LotNo"
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim TmpLotNo As String = Nothing

        If Not Validate_Fields() Then Exit Sub

        Try
            If Fr_Mode = FormState.AStateMode Then
                Dim Dt As DataTable = Me.SaveData()

                TmpLotNo = Dt.Rows(0).Item(0)

                MessageBoxTimer(TmpLotNo)
            Else
                Me.UpdateData()
            End If

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            Me.btnCancel_Click(sender, e)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Call Clear_Form()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function SaveData() As DataTable
        Dim Dt As DataTable = Nothing

        Dim alParaval As New ArrayList

        Dim GridSrNo As String = Nothing

        Dim ReceiptId As String = Nothing
        Dim ReceiptDetailId As String = Nothing
        Dim UsedBagId As String = Nothing

        Dim ItemType As String = Nothing
        Dim SlipBagNo As String = Nothing
        Dim ItemId As String = Nothing
        Dim GrossWt As String = Nothing
        Dim ReceivePr As String = Nothing
        Dim FineWt As String = Nothing

        Dim SilverPr As String = Nothing
        Dim SilverWt As String = Nothing
        Dim AlloyWt As String = Nothing

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        ''For Master
        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(cmbItem.SelectedValue)
        alParaval.Add(txtMelting.Text)
        alParaval.Add(lblGrossTotal.Text)
        alParaval.Add(txtSilverPr.Text)
        alParaval.Add(lblTotalSilverWt.Text)
        alParaval.Add(lblAlloyTotal.Text)

        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedValue)

        ''For Details
        For Each row As GridViewRowInfo In dgvMelting.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemType = Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = Convert.ToString(row.Cells(2).Value)
                    ItemId = Val(row.Cells(3).Value)
                    GrossWt = Val(row.Cells(5).Value)
                    ReceivePr = Val(row.Cells(6).Value)
                    FineWt = Val(row.Cells(7).Value)
                    ReceiptId = Val(row.Cells(8).Value)
                    ReceiptDetailId = Val(row.Cells(9).Value)
                    UsedBagId = Val(row.Cells(10).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemType = ItemType & "|" & Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = SlipBagNo & "|" & Convert.ToString(row.Cells(2).Value)
                    ItemId = ItemId & "|" & Val(row.Cells(3).Value)
                    GrossWt = GrossWt & "|" & Val(row.Cells(5).Value)
                    ReceivePr = ReceivePr & "|" & Val(row.Cells(6).Value)
                    FineWt = FineWt & "|" & Val(row.Cells(7).Value)
                    ReceiptId = ReceiptId & "|" & Val(row.Cells(8).Value)
                    ReceiptDetailId = ReceiptDetailId & "|" & Val(row.Cells(9).Value)
                    UsedBagId = UsedBagId & "|" & Val(row.Cells(10).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemType)
        alParaval.Add(SlipBagNo)
        alParaval.Add(ItemId)
        alParaval.Add(GrossWt)
        alParaval.Add(ReceivePr)
        alParaval.Add(FineWt)
        alParaval.Add(ReceiptId)
        alParaval.Add(ReceiptDetailId)
        alParaval.Add(UsedBagId)

        Try
            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@HMeltingDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HItemId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HPercent", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HGrossWt", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HSilverPercent", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HSilverWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HAlloyWt", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))
                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@HIsOpening", 1, DbType.Boolean))

                ''Details Start
                .Add(dbManager.CreateParameter("@DItemType", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DSlipBagNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemBagId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DGrossWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DGrossPr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DReceiptId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceiptDetailsId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DUsedBagId", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            Dt = dbManager.GetDataTable("SP_Melting_Save", CommandType.StoredProcedure, Hparameters.ToArray())

            MessageBox.Show("Data Saved !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try

        Return Dt

    End Function
    Private Sub txtFineWt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFineWt.Validating
        Try
            If cmbItemType.Text.Trim <> "" And txtMelting.Text.Trim <> "" And txtItemName.Text.Trim <> "" And Val(txtIssueWt.Text.Trim) > 0 And Val(txtIssuePr.Text.Trim) > 0 Then
                Me.fillGrid()
                Me.Total()
            Else
                MsgBox("Enter Proper Details")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub txtGrossWt_TextChanged(sender As Object, e As EventArgs) Handles txtIssueWt.TextChanged
        Try
            txtFineWt.Text = Format((Val(txtIssueWt.Text) * Val(txtIssuePr.Text)) / 100, "0.000")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub txtGrossWt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIssueWt.KeyPress
        numdotkeypress(e, txtIssueWt, Me)
    End Sub
    Private Sub lstMelting_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstMelting.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5}

        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lstMelting.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    Private Sub txtGrossWt_Leave(sender As Object, e As EventArgs) Handles txtIssueWt.Leave
        txtIssueWt.Text = Format(Val(txtIssueWt.Text), "0.00")
    End Sub
    Private Sub txtRequirePr_TextChanged(sender As Object, e As EventArgs) Handles txtMelting.TextChanged
        Me.Total()
    End Sub
    Private Sub txtRequirePr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMelting.KeyPress
        numdotkeypress(e, txtMelting, Me)
    End Sub
    Private Sub txtRequirePr_Leave(sender As Object, e As EventArgs) Handles txtMelting.Leave
        txtMelting.Text = Format(Val(txtMelting.Text), "0.00")
    End Sub
    Private Sub UpdateData()

        Dim alParaval As New ArrayList

        Dim GridSrNo As String = Nothing
        Dim LineNo As String = Nothing
        Dim ItemType As String = Nothing
        Dim SlipBagNo As String = Nothing
        Dim LotNo As String = Nothing
        Dim ItemId As String = Nothing
        Dim GrossWt As String = Nothing
        Dim ReceivePr As String = Nothing
        Dim FineWt As String = Nothing

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        ''For Master
        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(txtMeltingNo.Text)
        alParaval.Add(cmbItem.SelectedValue)
        alParaval.Add(txtMelting.Text)
        alParaval.Add(lblGrossTotal.Text)
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedValue)

        ''For Details
        For Each row As GridViewRowInfo In dgvMelting.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemType = Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = Convert.ToString(row.Cells(2).Value)
                    ItemId = Val(row.Cells(3).Value)
                    GrossWt = Val(row.Cells(5).Value)
                    ReceivePr = Val(row.Cells(6).Value)
                    FineWt = Val(row.Cells(7).Value)
                    LineNo = Val(row.Cells(8).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemType = ItemType & "|" & Convert.ToString(row.Cells(1).Value)
                    SlipBagNo = SlipBagNo & "|" & Convert.ToString(row.Cells(2).Value)
                    ItemId = ItemId & "|" & Val(row.Cells(3).Value)
                    GrossWt = GrossWt & "|" & Val(row.Cells(5).Value)
                    ReceivePr = ReceivePr & "|" & Val(row.Cells(6).Value)
                    FineWt = FineWt & "|" & Val(row.Cells(7).Value)
                    LineNo = LineNo & "|" & Val(row.Cells(8).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemType)
        alParaval.Add(SlipBagNo)
        alParaval.Add(ItemId)
        alParaval.Add(GrossWt)
        alParaval.Add(ReceivePr)
        alParaval.Add(FineWt)
        alParaval.Add(LineNo)

        Try
            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@HMeltingDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HMeltingLot", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HItemId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HPercent", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HGrossWt", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@MId", txtMeltingNo.Tag, DbType.Int16))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))
                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@HIsOpening", 1, DbType.Boolean))

                ''Details Start
                .Add(dbManager.CreateParameter("@DItemType", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DSlipBagNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemBagId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DGrossWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DGrossPr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DLineNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            dbManager.Insert("SP_Melting_Update", CommandType.StoredProcedure, Hparameters.ToArray())

            MessageBox.Show("Data Updated !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try
    End Sub
    Private Function Validate_Fields() As Boolean
        Try
            If Not dgvMelting.RowCount > 0 Then
                MessageBox.Show("Cannot Save Without Detail Information!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            End If

            If lblGrossTotal.Text.StartsWith("A") Then
                MessageBox.Show("Negative Cannot be Save !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            ElseIf cmbItem.SelectedIndex = -1 Or cmbItem.SelectedIndex = 0 Then
                MessageBox.Show("Select Item Name !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbItem.Focus()
                Return False
            ElseIf txtMelting.Text.Trim.Length = 0 Then
                MessageBox.Show("Enter Required Percent !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtMelting.Focus()
                Return False
            ElseIf Val(txtMelting.Text) < 75 Or Val(txtMelting.Text) >= 100 Then
                MessageBox.Show("Enter Required Percent in Between 75 to 100 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtMelting.Focus()
                txtMelting.SelectAll()
                Return False
            ElseIf cmbTLabour.SelectedIndex = -1 Or cmbTLabour.SelectedIndex = 0 Then
                MessageBox.Show("Select To Employee !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbTLabour.Focus()
                Return False
            ElseIf lblAlloyTotal.Text < 0 Then
                MessageBox.Show("Alloy Wt. Cannaot be Negative !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub Rmccmb_GotFocus(sender As Object, e As EventArgs) Handles Rmccmb.GotFocus
        Me.Rmccmb.MultiColumnComboBoxElement.ShowPopup()
    End Sub
    Private Sub dgvMelting_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvMelting.CellDoubleClick
        Try
            If e.RowIndex = -1 Then Exit Sub

            If e.RowIndex >= 0 And dgvMelting.Rows(e.RowIndex).Cells(0).Value <> Nothing Then
                GridDoubleClick = True
                txtSrNo.Text = dgvMelting.Rows(e.RowIndex).Cells(0).Value.ToString()
                cmbItemType.Text = dgvMelting.Rows(e.RowIndex).Cells(1).Value.ToString()
                Rmccmb.Text = CStr(dgvMelting.Rows(e.RowIndex).Cells(2).Value)
                txtItemName.Tag = CInt(dgvMelting.Rows(e.RowIndex).Cells(3).Value)
                txtItemName.Text = dgvMelting.Rows(e.RowIndex).Cells(4).Value.ToString()
                txtIssueWt.Tag = dgvMelting.Rows(e.RowIndex).Cells(5).Value.ToString()
                txtIssueWt.Text = dgvMelting.Rows(e.RowIndex).Cells(5).Value.ToString()
                txtIssuePr.Text = dgvMelting.Rows(e.RowIndex).Cells(6).Value.ToString()
                txtFineWt.Text = dgvMelting.Rows(e.RowIndex).Cells(7).Value.ToString()
                TempRow = e.RowIndex
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub lstMelting_DoubleClick(sender As Object, e As EventArgs) Handles lstMelting.DoubleClick
        If lstMelting.SelectedItems.Count = 0 Then Exit Sub

        If lstMelting.Items.Count > 0 Then

            Dim MeltingId As Integer = lstMelting.SelectedItems(0).SubItems(0).Text

            Me.Clear_Form()

            Fr_Mode = FormState.EStateMode

            Me.fillHeaderFromListView(MeltingId)

            Me.fillDetailsFromListView(MeltingId)

            Me.TbMelting.SelectedIndex = 0
        End If
    End Sub
    Private Sub fillHeaderFromListView(ByVal intMeltingId As Integer)

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "FetchHeaderRecord", DbType.String))
            .Add(dbManager.CreateParameter("@MId", CInt(intMeltingId), DbType.Int16))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_Melting_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

        If dr.HasRows = False Then
            Exit Sub
        Else
            dr.Read()
            txtMeltingNo.Tag = dr.Item("MeltingId").ToString
            txtMeltingNo.Text = dr.Item("LotNo").ToString()
            TransDt.Text = dr.Item("MeltingDt").ToString
            cmbItem.SelectedIndex = dr.Item("ItemId").ToString
            txtMelting.Text = dr.Item("RequirePr").ToString()
            lblAlloyTotal.Text = dr.Item("GrossWt").ToString
            txtSilverPr.Text = dr.Item("SilverPr").ToString
            lblTotalSilverWt.Text = dr.Item("SilverWt").ToString
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
    Private Sub fillDetailsFromListView(ByVal MeltingId As Integer)
        Dim dttable As New DataTable
        dttable = fetchAllRecords(CInt(MeltingId))

        For Each ROW As DataRow In dttable.Rows
            dgvMelting.Rows.Add(1, CStr(ROW("ItemType")), CStr(ROW("SlipBagNo")), Val(ROW("ItemBagId")), CStr(ROW("ItemName")), Format(Val(ROW("GrossWt")), "0.00"), Format(Val(ROW("GrossPr")), "0.00"), Format(Val(ROW("FineWt")), "0.000"), Val(ROW("ReceiptId")), Val(ROW("ReceiptDetailsId")), Val(ROW("UsedBagId")))
        Next

        Me.GetSrNo(dgvMelting)
        Me.Total()

        dgvMelting.ReadOnly = True
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub txtRequirePr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMelting.KeyDown
        If e.KeyCode = Keys.Tab Then
            cmbItem.Focus()
        End If
    End Sub
    Private Sub txtGrossWt_Validating(sender As Object, e As CancelEventArgs) Handles txtIssueWt.Validating
        Dim dsumOfWt As Double = 0

        If GridDoubleClick = True Then
            dsumOfWt = CDbl(Val(txtIssueWt.Tag) + Val(lblTotal.Text))

            If Val(txtIssueWt.Text) > Val(dsumOfWt) Then
                e.Cancel = True
                Objerr.SetError(txtIssueWt, "Wt should not be greather than Balance Wt. !")
            Else
                Objerr.Clear()
            End If
        Else
            If Val(txtIssueWt.Text) > Val(txtIssueWt.Tag) Then
                e.Cancel = True
                Objerr.SetError(txtIssueWt, "Wt should not be greather than Balance Wt. !")
            Else
                Objerr.Clear()
            End If
        End If
    End Sub
    Private Sub Rmccmb_DropDownClosed(sender As Object, args As RadPopupClosedEventArgs) Handles Rmccmb.DropDownClosed
        'If Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 0 Then
        '    txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
        '    txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString
        '    txtGrossWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        '    txtGrossWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        '    txtGrossPr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReportPr").Value.ToString
        '    txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString
        'ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 1 Then
        '    txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
        '    txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString
        '    txtGrossWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        '    txtGrossWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        '    txtGrossPr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString
        '    txtFineWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("IssueId").Value.ToString
        '    txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString
        'ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 2 Then
        '    txtFineWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("IssueId").Value.ToString
        '    txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
        '    txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString
        '    txtGrossPr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString
        '    txtGrossWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        '    txtGrossWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
        'End If

        If Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 0 Then      ''Bag
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            txtIssueWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString

            txtIssuePr.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptDetaild").Value.ToString
            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReportPr").Value.ToString

            txtFineWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptId").Value.ToString
            txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("FineWt").Value.ToString

            txtSrNo.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("UsedBagId").Value.ToString

        ElseIf Me.Rmccmb.SelectedIndex > -1 And cmbItemType.SelectedIndex = 1 Then      ''Voucher
            txtItemName.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemId").Value.ToString
            txtItemName.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ItemName").Value.ToString

            txtIssueWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString
            txtIssueWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalanceWt").Value.ToString

            txtIssuePr.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptDetaild").Value.ToString
            txtIssuePr.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceivePr").Value.ToString

            txtFineWt.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("ReceiptId").Value.ToString
            txtFineWt.Text = Me.Rmccmb.EditorControl.CurrentRow.Cells("BalFineWt").Value.ToString

            txtSrNo.Tag = Me.Rmccmb.EditorControl.CurrentRow.Cells("UsedBagId").Value.ToString
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(txtMeltingNo.Tag) Then

            If (MsgBox("[DELETION] Are You Sure To Delete This Entry ?", vbYesNo + vbDefaultButton2 + vbQuestion, "Attn : " + UserName.Trim()) = vbYes) Then

                Try
                    Dim parameters = New List(Of SqlParameter)()
                    parameters.Clear()

                    With parameters
                        .Add(dbManager.CreateParameter("@AId", txtMeltingNo.Tag, DbType.Int16))
                    End With

                    dbManager.Delete("SP_AccountMaster_Delete", CommandType.StoredProcedure, parameters.ToArray())

                    MessageBox.Show("Data Deleted !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Clear_Form()

                Catch ex As Exception
                    MessageBox.Show("Error:- " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please Select A Record !!!")
        End If
    End Sub
    Private Sub txtSilverPr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSilverPr.KeyPress
        numdotkeypress(e, txtMelting, Me)
    End Sub
    Private Sub txtSilverPr_TextChanged(sender As Object, e As EventArgs) Handles txtSilverPr.TextChanged
        Try
            lblTotalSilverWt.Text = Format((Val(lblAlloyTotal.Text) * Val(txtSilverPr.Text)) / 100, "0.00")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub frmMelting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Keys.Escape) Then   'for Exit
                If MsgBox("Wish To Exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Me.Close()
            ElseIf e.KeyCode = Keys.Tab Then
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

            With dgvMelting
                If e.KeyCode = Keys.F12 Then
                    .Rows.Remove(.CurrentRow)
                End If
                Me.Total()
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub frmMelting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Me.Parent = Nothing
        e.Cancel = True
    End Sub
    Sub MessageBoxTimer(ByVal strMsg As String)
        Dim AckTime As Integer, InfoBox As Object
        InfoBox = CreateObject("WScript.Shell")
        'Set the message box to close after 1 seconds
        AckTime = 1
        Select Case InfoBox.Popup("Click OK (Chain Saved Successfully With New Lot Number = " & strMsg.ToString(),
        AckTime, "Newly Created Lot Number", 0)
            Case 1, -1
                Exit Sub
        End Select
    End Sub

End Class