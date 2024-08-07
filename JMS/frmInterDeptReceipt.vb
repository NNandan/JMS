﻿Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class frmInterDeptReceipt
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Private mFr_State As FormState

    Dim strSQL As String = Nothing
    Dim TempRow As Integer
    Dim GridDoubleClick As Boolean

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
                Case FormState.EStateMode
                    CType(Me.ParentForm, frmMain).FormMode.Text = "Edit"
                    Me.btnSave.Text = "&Update"
            End Select
        End Set
    End Property
    Private Sub frmInterDeptReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dtUserRights.Rows.Count > 0 Then
            Dim DtRow() As DataRow = dtUserRights.Select("FormName = 'ACCOUNT MASTER'")
            USERADD = DtRow(0).Item(3)
            USEREDIT = DtRow(0).Item(4)
            USERVIEW = DtRow(0).Item(5)
            USERDELETE = DtRow(0).Item(6)
            DeptId = DtRow(0).Item(7)
        End If

        Me.fillDepartment()
        Me.fillLabour()
        Me.fillVoucherNo()

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
            ''cmbTLabour.Enabled = False
        End Try
    End Sub
    Private Sub fillVoucherNo()
        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@ActionType", "FetchVoucherNo", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_StockIssue_Select", CommandType.StoredProcedure, parameters.ToArray(), Objcn)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            ''Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbVoucherNo.DataSource = dt
            cmbVoucherNo.DisplayMember = "VoucherNo"
            cmbVoucherNo.ValueMember = "IssueId"
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            Objcn.Close()
        End Try
    End Sub
    Sub Total()
        Dim sRPrTotal As Single = 0

        Try
            lblTotalGrossWt.Text = 0.00
            lblTotalGrossPr.Text = 0.00
            lblTotalFineWt.Text = 0.00

            For Each row As GridViewRowInfo In dgvFinal.Rows
                lblTotalGrossWt.Text = Format(Val(lblTotalGrossWt.Text) + CDbl(row.Cells(6).Value), "0.00")
                lblTotalFineWt.Text = Format(Val(lblTotalFineWt.Text) + Val(row.Cells(8).Value), "0.000")
            Next

            If lblTotalFineWt.Text > 0 Then
                sRPrTotal = Format((Val(lblTotalFineWt.Text) / Val(lblTotalGrossWt.Text)) * 100, "0.00")
            End If

            lblTotalGrossPr.Text = Format(sRPrTotal, "0.00")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub GetSrNo(ByRef grid As Telerik.WinControls.UI.RadGridView)
        Try
            For Each rowInfo As GridViewRowInfo In dgvReceipt.Rows
                rowInfo.Cells(0).Value = rowInfo.Index + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim TmpLotNo As String = Nothing
        Try
            If Fr_Mode = FormState.AStateMode Then
                If Not Validate_Fields() Then Exit Sub
                Dim Dt As DataTable = SaveData()

                TmpLotNo = Dt.Rows(0).Item(0)

                MessageBoxTimer(TmpLotNo)
                Me.btnCancel_Click(sender, e)
            Else
                If Not Validate_EditFields() Then Exit Sub
                Me.UpdateData()
                Me.btnCancel_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try
    End Sub
    Sub MessageBoxTimer(ByVal strMsg As String)
        Dim AckTime As Integer, InfoBox As Object
        InfoBox = CreateObject("WScript.Shell")
        'Set the message box to close after 1 seconds
        AckTime = 1
        Select Case InfoBox.Popup("Receipt Number = " & strMsg.ToString(),
        AckTime, "Newly Created Receipt Number", 0)
            Case 1, -1
                Exit Sub
        End Select
    End Sub
    Private Function fetchAllRecords() As DataTable

        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchData", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Receipt_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData

    End Function
    Private Function fetchAllRecords(ByVal intReceiptId As Integer) As DataTable
        Dim dtData As DataTable = New DataTable()

        Try
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@RId", CInt(intReceiptId), DbType.Int16))
                .Add(dbManager.CreateParameter("@ActionType", "FetchDetailRecord", DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_Receipt_Select", CommandType.StoredProcedure, parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

        Return dtData
    End Function
    Private Function SaveData() As DataTable
        Dim Dt As DataTable = Nothing
        Dim alParaval As New ArrayList

        Dim IssueId As String = ""
        Dim PartyName As String = ""
        Dim ItemName As String = ""
        Dim ReceivePr As String = ""
        Dim ReceiveWt As String = ""
        Dim FineWt As String = ""
        Dim ForMelting As String = Nothing
        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(cmbfDepartment.SelectedValue)
        alParaval.Add(cmbtDepartment.SelectedValue)
        alParaval.Add(cmbVoucherNo.Text.Trim())
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.SelectedValue)

        For Each row As GridViewRowInfo In dgvFinal.Rows
            If row.Cells(0).Value <> Nothing Then
                If IssueId = "" Then
                    IssueId = Val(row.Cells(1).Value)
                    PartyName = Convert.ToString(row.Cells(3).Value)
                    ItemName = Convert.ToString(row.Cells(5).Value)
                    ReceiveWt = Val(row.Cells(6).Value)
                    ReceivePr = Val(row.Cells(7).Value)
                    FineWt = Val(row.Cells(8).Value)
                    ForMelting = row.Cells(9).Value
                Else
                    IssueId = IssueId & "|" & Val(row.Cells(1).Value)
                    PartyName = PartyName & "|" & Convert.ToString(row.Cells(3).Value)
                    ItemName = ItemName & "|" & Convert.ToString(row.Cells(5).Value)
                    ReceiveWt = ReceiveWt & "|" & row.Cells(6).Value
                    ReceivePr = ReceivePr & "|" & row.Cells(7).Value
                    FineWt = FineWt & "|" & row.Cells(8).Value
                    ForMelting = ForMelting & "|" & row.Cells(9).Value
                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(IssueId)
        alParaval.Add(PartyName)
        alParaval.Add(ItemName)
        alParaval.Add(ReceiveWt)
        alParaval.Add(ReceivePr)
        alParaval.Add(FineWt)
        alParaval.Add(ForMelting)
        Try
            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@HReceiptDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HfDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HtDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HVoucherNo", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))

                .Add(dbManager.CreateParameter("@DLotNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DPartyName", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemName", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceiveWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceivePr", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DChkforMelting", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            Dt = dbManager.GetDataTable("SP_Receipt_Save", CommandType.StoredProcedure, Hparameters.ToArray())
            MessageBox.Show("Data Saved !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try
        Return Dt

    End Function
    Private Sub UpdateData()
        Dim alParaval As New ArrayList

        Dim IssueId As String = ""
        Dim PartyName As String = ""
        Dim ItemName As String = ""
        Dim ReceivePr As String = ""
        Dim ReceiveWt As String = ""
        Dim FineWt As String = ""
        Dim ForMelting As String = Nothing
        Dim IRowCount As Integer = 0
        Dim iValue As Integer = 0

        alParaval.Add(TransDt.Value.ToString())
        alParaval.Add(cmbfDepartment.SelectedValue)
        alParaval.Add(cmbtDepartment.SelectedValue)
        alParaval.Add(cmbVoucherNo.Text.Trim())
        alParaval.Add(txtFrKarigar.Tag)
        alParaval.Add(cmbTLabour.Tag)

        For Each row As GridViewRowInfo In dgvFinal.Rows
            If row.Cells(0).Value <> Nothing Then
                If IssueId = "" Then
                    IssueId = Val(row.Cells(1).Value)
                    PartyName = Convert.ToString(row.Cells(3).Value)
                    ItemName = Convert.ToString(row.Cells(5).Value)
                    ReceiveWt = Val(row.Cells(6).Value)
                    ReceivePr = Val(row.Cells(7).Value)
                    FineWt = Val(row.Cells(8).Value)
                    ForMelting = row.Cells(9).Value

                Else
                    IssueId = IssueId & "|" & Val(row.Cells(1).Value)
                    PartyName = PartyName & "|" & Convert.ToString(row.Cells(3).Value)
                    ItemName = ItemName & "|" & Convert.ToString(row.Cells(5).Value)
                    ReceiveWt = ReceiveWt & "|" & row.Cells(6).Value
                    ReceivePr = ReceivePr & "|" & row.Cells(7).Value
                    FineWt = FineWt & "|" & row.Cells(8).Value
                    ForMelting = ForMelting & "|" & row.Cells(9).Value

                End If
            End If
            IRowCount += 1
        Next

        alParaval.Add(IssueId)
        alParaval.Add(PartyName)
        alParaval.Add(ItemName)
        alParaval.Add(ReceiveWt)
        alParaval.Add(ReceivePr)
        alParaval.Add(FineWt)
        alParaval.Add(ForMelting)

        Try
            Dim Hparameters = New List(Of SqlParameter)()
            Hparameters.Clear()

            With Hparameters
                .Add(dbManager.CreateParameter("@RId", Val(txtId.Tag), DbType.Int16))
                .Add(dbManager.CreateParameter("@HReceiptDt", alParaval.Item(iValue), DbType.DateTime))
                iValue += 1
                .Add(dbManager.CreateParameter("@HfDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HtDeptId ", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HVoucherNo", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@HFrKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1
                .Add(dbManager.CreateParameter("@HToKarigarId", alParaval.Item(iValue), DbType.Int16))
                iValue += 1

                .Add(dbManager.CreateParameter("@HCreatedBy", UserName.Trim(), DbType.String))
                .Add(dbManager.CreateParameter("@GridCount", IRowCount, DbType.Int16))

                .Add(dbManager.CreateParameter("@DLotNo", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DPartyName", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DItemName", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceiveWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DReceivePr", alParaval.Item(iValue), DbType.String))
                iValue += 1

                .Add(dbManager.CreateParameter("@DFineWt", alParaval.Item(iValue), DbType.String))
                iValue += 1
                .Add(dbManager.CreateParameter("@DChkforMelting", alParaval.Item(iValue), DbType.String))
                iValue += 1
            End With

            dbManager.Insert("SP_Receipt_Update", CommandType.StoredProcedure, Hparameters.ToArray())
            MessageBox.Show("Data Updated !!!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        End Try

    End Sub
    Private Function ChkDuplicate() As Boolean
        Dim exists As Boolean = False

        For Each row As GridViewRowInfo In dgvReceipt.Rows
            'If row.Cells(2).Value = cmbGridItemName.Text Then
            '    exists = True
            'End If
        Next

        Return exists
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Call Clear_Form()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmInterDeptReceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cmbVoucherNo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cmbVoucherNo.SelectedIndexChanged
        Dim dtData As DataTable = New DataTable()

        If cmbVoucherNo.SelectedIndex <> -1 Then
            Dim parameters = New List(Of SqlParameter)()

            With parameters
                .Clear()
                .Add(dbManager.CreateParameter("@ActionType", "FetchVoucherNoWiseDetails", DbType.String))
                .Add(dbManager.CreateParameter("@VouNo", cmbVoucherNo.Text.Trim(), DbType.String))
            End With

            dtData = dbManager.GetDataTable("SP_StockIssue_Select", CommandType.StoredProcedure, parameters.ToArray())

            Try

                If dtData.Rows.Count > 0 Then
                    dgvReceipt.DataSource = dtData
                End If

                Me.Total()

            Catch ex As Exception
                MessageBox.Show("Error:- " & ex.Message)
            Finally

            End Try
        End If
    End Sub
    Private Sub dgvReceipt_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles dgvReceipt.ViewCellFormatting
        If e.CellElement.ColumnInfo.Name = "colSrNo" AndAlso e.CellElement.Value Is Nothing Then
            e.CellElement.Value = e.CellElement.RowIndex + 1
        End If
    End Sub
    Private Sub cmbTLabour_Enter(sender As Object, e As EventArgs) Handles cmbTLabour.Enter
        cmbTLabour.ShowDropDown()
    End Sub
    Private Sub EnableControls(enable As Boolean)
        TransDt.Enabled = enable
        cmbVoucherNo.Enabled = enable

        cmbfDepartment.Enabled = enable
        cmbtDepartment.Enabled = enable

        txtFrKarigar.Enabled = enable
        cmbTLabour.Enabled = enable

        dgvReceipt.Enabled = enable
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub dgvReceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvReceipt.KeyDown
        Try
            If e.KeyCode = Keys.Delete And dgvReceipt.RowCount > 0 Then
                'dont allow user if any of the grid line is in edit mode.....
                If GridDoubleClick = True Then
                    MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
                    Exit Sub
                End If
                'end of block

                If TypeOf dgvReceipt.CurrentRow Is Telerik.WinControls.UI.GridViewNewRowInfo Then
                    Exit Sub
                End If

                Me.dgvReceipt.Rows.RemoveAt(dgvReceipt.CurrentRow.Index)

                Me.Total()
                Me.GetSrNo(dgvReceipt)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(txtId.Tag) Then

            If (MsgBox("[DELETION] Are You Sure To Delete This Entry ?", vbYesNo + vbDefaultButton2 + vbQuestion, "Attn : " + UserName.Trim()) = vbYes) Then

                Try
                    Dim parameters = New List(Of SqlParameter)()

                    With parameters
                        .Clear()
                        .Add(dbManager.CreateParameter("@RId", txtId.Tag, DbType.Int16))
                        .Add(dbManager.CreateParameter("@VouNo", cmbVoucherNo.Text.Trim, DbType.String))
                    End With

                    dbManager.Delete("SP_Receipt_Delete", CommandType.StoredProcedure, parameters.ToArray())

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
    Private Sub Clear_Form()
        Try

            '' For Header Field Start
            cmbVoucherNo.Enabled = True
            cmbVoucherNo.SelectedIndex = 0
            TransDt.Value = DateTime.Now

            cmbfDepartment.SelectedIndex = 0
            cmbtDepartment.SelectedIndex = 0

            txtFrKarigar.Tag = ""
            txtFrKarigar.Clear()
            cmbTLabour.SelectedIndex = 0
            '' For Header Field End

            '' For Detail Field Start
            dgvReceipt.DataSource = Nothing
            dgvReceipt.Rows.Clear()
            '' For Detail Field End
            dgvFinal.DataSource = Nothing
            dgvFinal.Rows.Clear()
            GridDoubleClick = False

            lblTotalGrossWt.Text = 0.0
            lblTotalGrossPr.Text = 0.0

            lblTotalFineWt.Text = 0.0

            Me.bindDataGridView()

            Fr_Mode = FormState.AStateMode

            cmbfDepartment.SelectedIndex = DeptId
            cmbfDepartment.Enabled = False

            cmbtDepartment.SelectedIndex = 4
            cmbtDepartment.Enabled = False

            txtFrKarigar.Tag = CInt(UserId)
            txtFrKarigar.Text = Convert.ToString(KarigarName.Trim)

            TransDt.Focus()
            TransDt.Select()

            Me.fillVoucherNo()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function Validate_Fields() As Boolean
        Try
            If Not dgvFinal.RowCount > 0 Then
                MessageBox.Show("Cannot Save Without Detail Information!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
                Exit Function
            End If

            If cmbTLabour.SelectedIndex = -1 Or cmbTLabour.SelectedIndex = 0 Then
                MessageBox.Show("Select Employee !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbTLabour.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Function Validate_EditFields() As Boolean
        Try
            If Not dgvFinal.RowCount > 0 Then
                MessageBox.Show("Cannot Save Without Detail Information!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
                Exit Function
            End If

            If cmbTLabour.Text = "" Then
                If cmbTLabour.Text = "---Select---" Then
                    MessageBox.Show("Select Employee !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    cmbTLabour.Focus()
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub cmbVoucherNo_GotFocus(sender As Object, e As EventArgs) Handles cmbVoucherNo.GotFocus
        cmbVoucherNo.ShowDropDown()
    End Sub
    Private Sub dgvInterDeptReceipt_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvInterDeptReceipt.CellDoubleClick
        If dgvInterDeptReceipt.SelectedRows.Count = 0 Then Exit Sub

        If dgvInterDeptReceipt.Rows.Count > 0 Then

            Dim ReceiptId As Integer = Me.dgvInterDeptReceipt.SelectedRows(0).Cells(0).Value

            Me.Clear_Form()

            Fr_Mode = FormState.EStateMode

            Me.fillHeaderFromListView(ReceiptId)

            Me.fillDetailsFromListView(ReceiptId)

            btnSave.Text = "&Update"

            Me.TbDeptReceipt.SelectedIndex = 0
        End If

    End Sub
    Private Sub FRWD_Click(sender As Object, e As EventArgs) Handles FRWD.Click
        If dgvReceipt.RowCount > 0 Then
            Try

                With dgvReceipt
                    If GridDoubleClick = False Then
                        With dgvReceipt
                            .SelectedRows.Contains(.CurrentRow)
                        End With
                    Else
                        .Rows.Remove(.CurrentRow)
                    End If
                End With
                With dgvFinal
                    GridDoubleClick = False
                End With
                Me.fillGrid()
            Catch
            End Try
        End If
    End Sub
    Private Sub dgvReceipt_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvReceipt.CellDoubleClick
        Try
            If e.RowIndex = -1 Then Exit Sub
            If e.RowIndex >= 0 And dgvReceipt.Rows(e.RowIndex).Cells(0).Value <> Nothing Then
                GridDoubleClick = True
                txtSrNo.Text = dgvReceipt.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtSrNo.Tag = dgvReceipt.Rows(e.RowIndex).Cells(1).Value.ToString()
                txtPartyName.Tag = dgvReceipt.Rows(e.RowIndex).Cells(2).Value.ToString()
                txtPartyName.Text = dgvReceipt.Rows(e.RowIndex).Cells(3).Value.ToString()
                txtItemName.Tag = dgvReceipt.Rows(e.RowIndex).Cells(4).Value.ToString()
                txtItemName.Text = dgvReceipt.Rows(e.RowIndex).Cells(5).Value.ToString
                txtReceiveWt.Text = dgvReceipt.Rows(e.RowIndex).Cells(6).Value.ToString()
                txtReceivePr.Text = dgvReceipt.Rows(e.RowIndex).Cells(7).Value.ToString()

                txtFineWt.Text = dgvReceipt.Rows(e.RowIndex).Cells(8).Value.ToString()

                If IsNothing(dgvReceipt.Rows(e.RowIndex).Cells(9).Value) OrElse String.IsNullOrEmpty(dgvReceipt.Rows(e.RowIndex).Cells(9).Value) Then
                    chkForMelting.Checked = False
                Else
                    chkForMelting.Checked = True
                End If
                TempRow = e.RowIndex
            End If
            BackWrd.Enabled = False
            FRWD.Enabled = True
            chkForMelting.Enabled = True
            'With dgvReceipt
            '    If GridDoubleClick = False Then
            '        With dgvReceipt
            '            .SelectedRows.Contains(.CurrentRow)
            '        End With
            '    Else
            '        .Rows.Remove(.CurrentRow)
            '    End If
            'End With
            'With GRDFinal
            '    GridDoubleClick = False
            'End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub fillGrid()
        Try
            If txtSrNo.Text.Trim() = "" Then
                dgvFinal.DataSource = False
            Else
                dgvFinal.Rows.Add(Val(txtSrNo.Text.Trim), Val(txtSrNo.Tag), Val(txtPartyName.Tag), (txtPartyName.Text.Trim), Val(txtItemName.Tag), (txtItemName.Text.Trim), Format(Val(txtReceiveWt.Text.Trim), "0.00"), Format(Val(txtReceivePr.Text.Trim), "0.00"), Format(Val(txtFineWt.Text.Trim), "0.00"), chkForMelting.CheckState)
                Me.Total()
                txtSrNo.Clear()
                txtPartyName.Clear()
                txtItemName.Clear()
                txtReceiveWt.Clear()
                txtReceivePr.Clear()
                txtFineWt.Clear()
                chkForMelting.CheckState = False
            End If
        Catch
        End Try
    End Sub
    Private Sub fillHeaderFromListView(ByVal intReceiptId As Integer)

        Dim parameters = New List(Of SqlParameter)()

        With parameters
            .Clear()
            .Add(dbManager.CreateParameter("@RId", CInt(intReceiptId), DbType.Int16))
            .Add(dbManager.CreateParameter("@ActionType", "FetchHeaderRecord", DbType.String))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_Receipt_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

        If dr.HasRows = False Then
            Exit Sub
        Else
            dr.Read()
            txtId.Tag = dr.Item("ReceiptId").ToString
            cmbVoucherNo.Text = dr.Item("VoucherNo").ToString()
            TransDt.Text = dr.Item("ReceiptDt").ToString
            cmbfDepartment.SelectedIndex = dr.Item("FrDeptId").ToString()
            cmbtDepartment.SelectedIndex = dr.Item("ToDeptId").ToString()
            txtFrKarigar.Tag = dr.Item("FrKarigarId").ToString()
            txtFrKarigar.Text = dr.Item("FrKarigar").ToString()

            cmbTLabour.SelectedIndex = dr.Item("ToKarigarId").ToString()
            cmbTLabour.Text = CStr(dr.Item("ToKarigar"))
        End If

        dr.Close()
        Objcn.Close()

        Exit Sub
ErrHandler:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    Private Sub fillDetailsFromListView(ByVal intReceiptId As Integer)
        Dim dttable As New DataTable
        dttable = fetchAllRecords(CInt(intReceiptId))

        For Each ROW As DataRow In dttable.Rows
            dgvReceipt.Rows.Add(1, CStr(ROW("IssueId")), Val(ROW("PartyId")), CStr(ROW("PartyName")), Val(ROW("ItemId")), CStr(ROW("ItemName")), Format(Val(ROW("ReceiveWt")), "0.00"), Format(Val(ROW("ReceivePr")), "0.00"), Format(Val(ROW("FineWt")), "0.00"))
        Next

        Me.GetSrNo(dgvReceipt)
        Me.Total()

        dgvReceipt.ReadOnly = True

    End Sub
    Private Sub bindDataGridView()
        Dim dtdata As DataTable = fetchAllRecords()

        Try
            dgvInterDeptReceipt.DataSource = dtdata
            dgvInterDeptReceipt.EnableFiltering = True
            dgvInterDeptReceipt.MasterTemplate.ShowFilteringRow = False
            dgvInterDeptReceipt.MasterTemplate.ShowHeaderCellButtons = True
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
        End Try
    End Sub
End Class