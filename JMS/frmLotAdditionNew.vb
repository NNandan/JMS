﻿Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls.UI
Public Class frmLotAdditionNew
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private mFr_State As FormState

    Dim strSQL As String = Nothing
    Dim TempRow As Integer
    Dim GridDoubleClick As Boolean
    Dim dttable As DataTable = New DataTable()

    Dim dbManager As New SqlHelper()
    Dim Objcn As SqlConnection = New SqlConnection()
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
                Case FormState.EStateMode
                    CType(Me.ParentForm, frmMain).FormMode.Text = "Edit"
                    Me.btnSave.Text = "&Update"
                    Me.btnDelete.Enabled = True
            End Select
        End Set
    End Property
    Private Sub frmLotAdditionNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Clear_Form()

        Me.fillLotNo()
        Me.fillLabour()
        Me.fillGridItemName()

        Me.bindDataGridView()
    End Sub
    Private Sub fillLotNo()
        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FetchLotNoForLotAddition", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_Transaction_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbLotNo.DataSource = dt
            cmbLotNo.DisplayMember = "LotNo"
            cmbLotNo.ValueMember = "TransId"
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub
    Private Sub fillltemName()
        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_ItemMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbGridItem.DataSource = dt
            cmbGridItem.DisplayMember = "ItemName"
            cmbGridItem.ValueMember = "ItemId"
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub
    Private Sub fillGridItemName()
        Dim connection As SqlConnection = Nothing

        Dim dt As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FillOnlyItemName", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_ItemMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)

        dt.Load(dr)

        Try
            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbGridItem.DataSource = dt
            cmbGridItem.DisplayMember = "ItemName"
            cmbGridItem.ValueMember = "ItemId"
            cmbGridItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbGridItem.AutoCompleteDataSource = AutoCompleteSource.ListItems
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub
    Private Sub getLastLotNoAmt()

        Dim sIPr As Single = 0
        Dim sIWt As Single = 0
        Dim sFWt As Single = 0

        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()

        strSQL = Nothing
        strSQL = "SELECT * FROM udf_GetMaxLotTransNo('" & cmbLotNo.Text.Trim() & "') ORDER BY MaxTransId"

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@TLotNo", cmbLotNo.Text.Trim(), DbType.String))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader(strSQL, CommandType.Text, Objcn, parameters.ToArray())

        Try
            If dr.Read = False Then
                Exit Sub
            Else
                txtReceivePr.Text = Format(Val(dr("ReceivePr")), "0.00")
                txtReceiveWt.Text = Format(Val(dr("ReceiveWt")), "0.00")
                lblFineWt.Text = Format(Val(txtReceivePr.Text) * Val(txtReceiveWt.Text) / 100, "0.000")
                txtFrKarigar.Tag = dr("ToLabourId").ToString()
                txtFrKarigar.Text = dr("toKarigarName").ToString()
                txtItemName.Tag = dr("ItemId").ToString()
                txtItemName.Text = dr("ItemName").ToString()

                sIWt = Format(Val(dr("ReceiveWt")), "0.00")
                sIPr = Format(Val(dr("ReceivePr")), "0.00")
                sFWt = Format(Val(txtReceivePr.Text) * Val(txtReceiveWt.Text) / 100, "0.000")

                txtIssueWt.Text = Format(Val(sIWt), "0.00")
                txtIssuePr.Text = Format(Val(sIPr), "0.00")
                txtFineWt.Text = Format(Val(sFWt), "0.000")
            End If
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            Objcn.Close()
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Call Clear_Form()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtReceivePr_TextChanged(sender As Object, e As EventArgs)
        txtIssueWt.Text = Format(txtReceiveWt.Text, "0.00")
    End Sub
    Private Sub txtReceiveWt_TextChanged(sender As Object, e As EventArgs)
        txtIssueWt.Text = Format(txtReceivePr.Text, "0.00")
    End Sub
    Private Sub fillGrid()

        If GridDoubleClick = False Then
            dgvLotAddition.Rows.Add(Val(txtSrNo.Text.Trim),
                                    Convert.ToInt32(cmbGridItem.SelectedValue),
                                    cmbGridItem.Text.Trim(),
                                    Format(Val(txtIssueWt.Text.Trim), "0.000"),
                                    Format(Val(txtIssuePr.Text.Trim), "0.000"),
                                    Format(Val(txtFineWt.Text.Trim), "0.000"),
                                    txtRemark.Text.Trim())
            GetSrNo(dgvLotAddition)
        Else
            dgvLotAddition.Rows(TempRow).Cells(0).Value = txtSrNo.Text.Trim
            dgvLotAddition.Rows(TempRow).Cells(1).Value = Val(cmbGridItem.SelectedIndex)
            dgvLotAddition.Rows(TempRow).Cells(1).Value = cmbGridItem.Text.Trim
            dgvLotAddition.Rows(TempRow).Cells(3).Value = Format(Val(txtIssueWt.Text.Trim), "0.000")
            dgvLotAddition.Rows(TempRow).Cells(4).Value = Format(Val(txtIssuePr.Text.Trim), "0.000")
            dgvLotAddition.Rows(TempRow).Cells(5).Value = Format(Val(txtFineWt.Text.Trim), "0.000")
            dgvLotAddition.Rows(TempRow).Cells(6).Value = txtRemark.Text.Trim()
            GridDoubleClick = False
        End If

        dgvLotAddition.TableElement.ScrollToRow(dgvLotAddition.Rows.Last)

        txtSrNo.Text = dgvLotAddition.RowCount + 1

        cmbGridItem.Text = ""
        txtIssueWt.Clear()
        txtIssuePr.Clear()
        txtFineWt.Clear()
        txtRemark.Clear()
        cmbGridItem.Focus()

    End Sub
    Private Sub fillLabour()

        Dim parameters = New List(Of SqlParameter)()

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
    Sub GetSrNo(ByRef grid As Telerik.WinControls.UI.RadGridView)
        Try
            For Each rowInfo As GridViewRowInfo In dgvLotAddition.Rows
                rowInfo.Cells(0).Value = rowInfo.Index + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub GridTotal()
        Try
            Dim dSumOfTotalIssuePr As Double = 0
            Dim dSumOfTotalIssueWt As Double = 0
            Dim dSumOfTotalFineWt As Double = 0

            For Each row As GridViewRowInfo In dgvLotAddition.Rows
                dSumOfTotalIssuePr += Convert.ToDecimal(row.Cells(3).Value)
                dSumOfTotalIssueWt += Convert.ToDecimal(row.Cells(4).Value)
                dSumOfTotalFineWt += Convert.ToString(row.Cells(5).Value)
            Next

            If dgvLotAddition.RowCount > 0 Then
                lblTotalIssueWt.Text = Format(dSumOfTotalIssueWt, "0.00")
                lblTotalFineWt.Text = Format(dSumOfTotalFineWt, "0.000")

                lblTotalIssuePr.Text = Format(Val(lblTotalFineWt.Text) / Val(lblTotalIssueWt.Text) * 100, "0.00")

                lblGTotalIssueWt.Text = Format(Val(lblTotalIssueWt.Text) + Val(txtReceivePr.Text), "0.00")
                lbGlTotalFineWt.Text = Format(Val(lblTotalFineWt.Text) + Val(lblFineWt.Text), "0.000")

                lblGTotalIssuePr.Text = Format(Val(lbGlTotalFineWt.Text) / Val(lblGTotalIssueWt.Text) * 100, "0.00")
            Else
                lblTotalIssueWt.Text = Format(dSumOfTotalIssueWt, "0.00")
                lblTotalFineWt.Text = Format(dSumOfTotalFineWt, "0.000")

                lblTotalIssuePr.Text = "0.00"

                lblGTotalIssueWt.Text = Format(Val(lblTotalIssueWt.Text) + Val(txtReceivePr.Text), "0.00")
                lbGlTotalFineWt.Text = Format(Val(lblTotalFineWt.Text) + Val(lblFineWt.Text), "0.000")

                lblGTotalIssuePr.Text = Format(Val(lbGlTotalFineWt.Text) / Val(lblGTotalIssueWt.Text) * 100, "0.00")
            End If
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
    Private Function SaveData() As DataTable
        Dim Dt As DataTable = Nothing

        Dim alParaval As New ArrayList

        Dim iOperationId As Integer = 21     ''Operation Id for Lot Addition Create
        Dim iOperationTypeId As Integer = 8  ''Operation Type Id for Lot Addition Create

        Dim GridSrNo As String = ""
        Dim ItemId As String = ""
        Dim IssuePr As String = ""
        Dim IssueWt As String = ""
        Dim FineWt As String = Nothing
        Dim Remarks As String = ""

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(iOperationId)
        alParaval.Add(iOperationTypeId)
        alParaval.Add(cmbLotNo.Text.Trim)
        alParaval.Add(txtItemName.Tag)
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedIndex)

        For Each row As GridViewRowInfo In dgvLotAddition.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemId = Val(row.Cells(1).Value)
                    IssueWt = Val(row.Cells(3).Value)
                    IssuePr = Val(row.Cells(4).Value)
                    FineWt = Val(row.Cells(5).Value)
                    Remarks = (row.Cells(6).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemId = ItemId & "|" & Val(row.Cells(1).Value)
                    IssueWt = IssuePr & "|" & Val(row.Cells(3).Value)
                    IssuePr = IssueWt & "|" & Val(row.Cells(4).Value)
                    FineWt = FineWt & "|" & Val(row.Cells(5).Value)
                    Remarks = Remarks & "|" & (row.Cells(6).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemId)
        alParaval.Add(IssueWt)
        alParaval.Add(IssuePr)
        alParaval.Add(FineWt)
        alParaval.Add(Remarks)

        Try
            Dim Hparameters = New List(Of SqlParameter)()

            With Hparameters
                .Clear()
                .Add(dbManager.CreateParameter("@HLotAdditionDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1

                .Add(dbManager.CreateParameter("@HOperationId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HOperationTypeId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HLotNumber", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HItemId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@FrKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@ToKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))

                'For Transaction
                .Add(dbManager.CreateParameter("@TReceiveWt", txtReceiveWt.Text.Trim, DbType.String))
                .Add(dbManager.CreateParameter("@TReceivePr", txtReceivePr.Text.Trim, DbType.String))

                .Add(dbManager.CreateParameter("@TIssueWt", txtReceiveWt.Text.Trim, DbType.String))
                .Add(dbManager.CreateParameter("@TIssuePr", txtReceivePr.Text.Trim, DbType.String))
                'For Transaction

                .Add(dbManager.CreateParameter("@DItemId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssueWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssuePr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DRemarks", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            Dt = dbManager.GetDataTable("SP_LotAdditionNew_Save", CommandType.StoredProcedure, Hparameters.ToArray())

            MessageBox.Show("Data Saved !!!", "Chain", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try

        Return Dt
    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not String.IsNullOrEmpty(txtLotIssueId.Tag) Then

            Try
                Dim parameters = New List(Of SqlParameter)()

                With parameters
                    .Clear()
                    .Add(dbManager.CreateParameter("@LId", txtLotIssueId.Tag, DbType.Int16))
                End With

                dbManager.Delete("SP_LotAdditionIssue_Delete", CommandType.StoredProcedure, parameters.ToArray())

                MessageBox.Show("Data Deleted !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Clear_Form()

            Catch ex As Exception
                MessageBox.Show("Error:- " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please Select A Record !!!")
        End If
    End Sub
    Private Sub bindDataGridView()
        Dim dtdata As DataTable = fetchAllRecords()

        Try
            dgvLotCreate.DataSource = dtdata
            dgvLotCreate.EnableFiltering = True
            dgvLotCreate.MasterTemplate.ShowFilteringRow = False
            dgvLotCreate.MasterTemplate.ShowHeaderCellButtons = True
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
        End Try
    End Sub
    Private Function fetchAllRecords() As DataTable

        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchDataForC", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_LotAdditionIssue_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData

    End Function
    Private Sub frmLotAdditionNew_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.KeyCode = Keys.Escape) Then   'for Exit
                If MsgBox("Wish To Exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CType(Me.ParentForm, frmMain).FormMode.Text = ""
                    Me.Close()
                End If
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function fetchAllRecords(ByVal intLotIssueId As Integer) As DataTable
        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchDetailRecord", DbType.String))
                .Add(dbManager.CreateParameter("@LId", CInt(intLotIssueId), DbType.Int16))
            End With

            dtData = dbManager.GetDataTable("SP_LotAdditionIssue_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData
    End Function
    Private Function fetchAllRecords(ByVal strLotNo As String) As DataTable
        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchCrDetailRecord", DbType.String))
                .Add(dbManager.CreateParameter("@LotNo", CStr(strLotNo), DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_LotAdditionIssue_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData
    End Function
    Private Sub fillHeaderFromListView(ByVal strLotNo As String)

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@LotNo", CStr(strLotNo), DbType.String))
            .Add(dbManager.CreateParameter("@ActionType", "FetchHeaderRecord", DbType.String))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_LotAdditionIssue_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

        If dr.Read = False Then
            Exit Sub
        Else
            txtLotIssueId.Tag = dr.Item("LotAdditionId").ToString()
            txtLotIssueId.Text = dr.Item("LotAdditionNo").ToString()
            TransDt.Value = dr.Item("LotAdditionDt").ToString
            cmbLotNo.Text = dr.Item("LotNo").ToString
            txtItemName.Tag = dr.Item("ItemId").ToString
            txtItemName.Text = dr.Item("ItemName").ToString
            txtReceiveWt.Text = dr.Item("IssueWt").ToString
            txtReceivePr.Text = dr.Item("IssuePr").ToString
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
    Private Sub fillDetailsFromListView(ByVal strLotNo As String)
        Dim dttable As New DataTable
        dttable = FetchAllRecords(CStr(strLotNo))

        For Each ROW As DataRow In dttable.Rows
            dgvLotAddition.Rows.Add(1, Val(ROW("ItemId")), CStr(ROW("ItemName")), Format(Val(ROW("IssuePr")), "0.00"), Format(Val(ROW("IssueWt")), "0.00"), Format(Val(ROW("FineWt")), "0.00"), ROW("Remarks").ToString())
        Next

        Me.GetSrNo(dgvLotAddition)
        Me.GridTotal()

        dgvLotAddition.ReadOnly = True
    End Sub
    Private Sub dgvLotAddition_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvLotAddition.KeyDown
        Try
            If e.KeyCode = Keys.Delete And dgvLotAddition.RowCount > 0 Then
                'dont allow user if any of the grid line is in edit mode.....
                If GridDoubleClick = True Then
                    MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
                    Exit Sub
                End If
                'end of block

                dgvLotAddition.Rows.RemoveAt(dgvLotAddition.CurrentRow.Index)
                Me.GetSrNo(dgvLotAddition)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub txtReceivePr_KeyPress(sender As Object, e As KeyPressEventArgs)
        numdotkeypress(e, txtReceiveWt, Me)
    End Sub
    Private Sub txtReceiveWt_KeyPress(sender As Object, e As KeyPressEventArgs)
        numdotkeypress(e, txtReceivePr, Me)
    End Sub
    Private Sub txtRemark_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRemark.Validating
        Try
            If cmbGridItem.SelectedIndex > 0 And Val(txtIssueWt.Text.Trim) > 0 And Val(txtIssuePr.Text.Trim) > 0 Then
                Me.fillGrid()
                Me.GridTotal()
            Else
                MsgBox("Enter Proper Details")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cmbLotNo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cmbLotNo.SelectedIndexChanged
        If cmbLotNo.Text.Trim <> "" Then
            Me.getLastLotNoAmt()
            'If blnCheckExists() = False Then
            '    Me.GetMaxLotNo()
            'End If
        End If
    End Sub
    Private Sub dgvLotAddition_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvLotAddition.CellDoubleClick
        Try
            If e.RowIndex = -1 Then Exit Sub

            If e.RowIndex >= 0 And dgvLotAddition.Rows(e.RowIndex).Cells(0).Value <> Nothing Then
                GridDoubleClick = True
                txtSrNo.Text = dgvLotAddition.Rows(e.RowIndex).Cells(0).Value.ToString()
                cmbGridItem.SelectedIndex = dgvLotAddition.Rows(e.RowIndex).Cells(1).Value.ToString()
                cmbGridItem.Text = dgvLotAddition.Rows(e.RowIndex).Cells(2).Value.ToString()
                txtIssueWt.Text = CStr(dgvLotAddition.Rows(e.RowIndex).Cells(3).Value)
                txtIssuePr.Text = CStr(dgvLotAddition.Rows(e.RowIndex).Cells(4).Value)
                txtFineWt.Text = CStr(dgvLotAddition.Rows(e.RowIndex).Cells(5).Value)
                txtRemark.Text = CStr(dgvLotAddition.Rows(e.RowIndex).Cells(6).Value)
                TempRow = e.RowIndex
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Clear_Form()
        Try

            ''EP.Clear()

            '' For Header Field Start
            txtLotIssueId.Tag = ""
            txtLotIssueId.Clear()
            TransDt.Value = DateTime.Now()

            'cmbLotNo.Items.Clear()
            cmbLotNo.SelectedIndex = -1

            txtItemName.Tag = ""
            txtItemName.Clear()
            txtFrKarigar.Tag = ""
            txtFrKarigar.Clear()
            cmbTLabour.SelectedIndex = 0
            txtReceiveWt.Clear()
            txtReceivePr.Clear()
            txtFineWt.Clear()
            '' For Header Field End

            '' For Detail Field Start
            txtSrNo.Text = 1
            cmbGridItem.SelectedIndex = 0
            txtIssueWt.Clear()
            txtIssuePr.Clear()
            txtRemark.Clear()

            lblTotalIssuePr.Text = "0.00"
            lblTotalIssueWt.Text = "0.00"
            lblTotalFineWt.Text = "0.00"

            dgvLotAddition.RowCount = 0

            '' For Detail Field End

            GridDoubleClick = False

            Me.bindDataGridView()

            lblFineWt.Text = "0.00"
            lblGTotalIssuePr.Text = "0.00"
            lblGTotalIssueWt.Text = "0.00"
            lbGlTotalFineWt.Text = "0.00"

            Fr_Mode = FormState.AStateMode

            TransDt.Focus()
            TransDt.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function Validate_Fields() As Boolean
        Try
            If Not dgvLotAddition.RowCount > 0 Then
                MessageBox.Show("Cannot Save Without Detail Information!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbLotNo.Focus()
                Return False
            End If

            If cmbLotNo.Text.Trim() = "" Then
                MessageBox.Show("Enter Lot Number !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbLotNo.Focus()
                Return False
            ElseIf cmbTLabour.SelectedIndex = 0 Or cmbTLabour.SelectedIndex = -1 Then
                MessageBox.Show("Select To Employee  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbTLabour.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub UpdateData()
        Dim alParaval As New ArrayList

        Dim iOperationId As Integer = 5 ''Operation Id for Lot Addition Create
        Dim iOperationTypeId As Integer = 8 ''Operation Type Id for Lot Addition Create

        Dim GridSrNo As String = ""
        Dim ItemId As String = ""
        Dim IssuePr As String = ""
        Dim IssueWt As String = ""
        Dim FineWt As String = Nothing
        Dim Remarks As String = ""

        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(iOperationId)
        alParaval.Add(iOperationTypeId)
        alParaval.Add(cmbLotNo.Text.Trim)
        alParaval.Add(txtItemName.Tag)
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedIndex)

        For Each row As GridViewRowInfo In dgvLotAddition.Rows
            If row.Cells(0).Value <> Nothing Then
                If GridSrNo = "" Then
                    GridSrNo = Val(row.Cells(0).Value)
                    ItemId = Val(row.Cells(1).Value)
                    IssueWt = Val(row.Cells(3).Value)
                    IssuePr = Val(row.Cells(4).Value)
                    FineWt = Val(row.Cells(5).Value)
                    Remarks = (row.Cells(6).Value)
                Else
                    GridSrNo = GridSrNo & "|" & Val(row.Cells(0).Value)
                    ItemId = ItemId & "|" & Val(row.Cells(1).Value)
                    IssueWt = IssuePr & "|" & Val(row.Cells(3).Value)
                    IssuePr = IssueWt & "|" & Val(row.Cells(4).Value)
                    FineWt = FineWt & "|" & Val(row.Cells(5).Value)
                    Remarks = Remarks & "|" & (row.Cells(6).Value)
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(ItemId)
        alParaval.Add(IssueWt)
        alParaval.Add(IssuePr)
        alParaval.Add(FineWt)
        alParaval.Add(Remarks)

        Try
            Dim Hparameters = New List(Of SqlParameter)()

            With Hparameters
                .Clear()
                .Add(dbManager.CreateParameter("@HLotAdditionDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1

                .Add(dbManager.CreateParameter("@HOperationId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HOperationTypeId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HLotNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@HItemId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                '.Add(dbManager.CreateParameter("@HLotAdditionNumber", alParaval.Item(iValue), DbType.String))
                'iValue += 1

                .Add(dbManager.CreateParameter("@FrKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@ToKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HLotAdditionId", Val(txtLotIssueId.Tag), DbType.Int16))
                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))

                'For Transaction
                .Add(dbManager.CreateParameter("@TReceiveWt", txtReceivePr.Text.Trim, DbType.String))
                .Add(dbManager.CreateParameter("@TReceivePr", txtReceiveWt.Text.Trim, DbType.String))

                .Add(dbManager.CreateParameter("@TIssueWt", txtReceivePr.Text.Trim, DbType.String))
                .Add(dbManager.CreateParameter("@TIssuePr", txtReceiveWt.Text.Trim, DbType.String))
                'For Transaction

                .Add(dbManager.CreateParameter("@DItemId", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssueWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DIssuePr", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DRemarks", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            dbManager.Insert("SP_LotAdditionNew_Update", CommandType.StoredProcedure, Hparameters.ToArray())

            MessageBox.Show("Data Updated !!!", "Chain", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try
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
    Private Sub dgvLotCreate_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvLotCreate.CellDoubleClick
        If dgvLotCreate.SelectedRows.Count = 0 Then Exit Sub

        If dgvLotCreate.Rows.Count > 0 Then
            Dim strLotNo As String = Me.dgvLotCreate.SelectedRows(0).Cells(2).Value

            Me.Clear_Form()

            Fr_Mode = FormState.EStateMode

            Me.fillHeaderFromListView(strLotNo)

            Me.fillDetailsFromListView(strLotNo)

            Me.TbLotAddition.SelectedIndex = 0
        End If
    End Sub
End Class