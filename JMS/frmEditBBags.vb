﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls.UI
Imports System.Management
Public Class frmEditBBags
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private mFr_State As FormState

    Dim strSQL As String = Nothing

    Dim dbManager As New SqlHelper(ConfigurationManager.ConnectionStrings("ConString").ToString())

    Dim Objcn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConString").ToString())

    Private Sub frmEditSBags_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.fillBagType()
    End Sub

    Private Sub btnCExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub fillBagType()

        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "FillBhukaBag", DbType.String))
        End With

        Dim dr = dbManager.GetDataReader("SP_BagMaster_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            cmbEBagtype.DataSource = Nothing
            cmbEBagtype.Items.Clear()

            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbEBagtype.DataSource = dt
            cmbEBagtype.DisplayMember = "ItemName"
            cmbEBagtype.ValueMember = "ItemId"
            cmbEBagtype.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub

    Private Sub cmbRBagNo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cmbRBagNo.SelectedIndexChanged
        If Convert.ToInt32(cmbRBagNo.SelectedIndex) > -1 Then
            Me.BindCreateBhukaBag()
        End If
    End Sub

    Private Sub cmbEBagtype_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cmbEBagtype.SelectedIndexChanged
        If Convert.ToInt32(cmbEBagtype.SelectedIndex) > 0 Then
            Me.fillAllBhukaBag()
        End If
    End Sub

    Private Sub BindCreateBhukaBag()
        Dim dtdata As DataTable = New DataTable()

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "GetEditBhukaData", DbType.String))
            .Add(dbManager.CreateParameter("@BagNo", CStr(cmbRBagNo.SelectedItem.Text), DbType.String))
        End With

        dtdata = dbManager.GetDataTable("SP_EditBags_Select", CommandType.StoredProcedure, parameters.ToArray())

        Try
            dgvBhukaBag.DataSource = dtdata
            dgvBhukaBag.EnableFiltering = True
            dgvBhukaBag.MasterTemplate.ShowFilteringRow = False
            dgvBhukaBag.MasterTemplate.ShowHeaderCellButtons = True
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub fillAllBhukaBag()

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "GetAllBhukaBag", DbType.String))
            .Add(dbManager.CreateParameter("@BId", Val(cmbEBagtype.SelectedValue), DbType.Int16))
        End With

        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_EditBags_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

        If dr.HasRows = False Then
            MessageBox.Show("No Data Exists !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Exit Sub
        End If

        cmbRBagNo.Items.Clear()
        cmbRBagNo.ResetText()

        Try

            While dr.Read
                If Not IsDBNull(dr.Item("BhukaBagNo")) Then
                    cmbRBagNo.Items.Add(dr.Item("BhukaBagNo"))
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            Objcn.Close()
        End Try
    End Sub

    Private Sub dgvBhukaBag_CurrentRowChanging(sender As Object, e As CurrentRowChangingEventArgs) Handles dgvBhukaBag.CurrentRowChanging
        For i As Integer = 0 To dgvBhukaBag.Rows.Count - 1
            If Not String.IsNullOrEmpty(dgvBhukaBag.Rows(i).Cells(7).Value.ToString()) Then
                dgvBhukaBag.Rows(i).Cells(0).Value = True
            End If
        Next
    End Sub

    Private Sub UpdateBhukaBagNo()
        If dgvBhukaBag.Rows.Count > 0 Then

            Try

                Dim Dparameters = New List(Of SqlParameter)()
                Dparameters.Clear()

                For i As Integer = 0 To dgvBhukaBag.RowCount - 1
                    If dgvBhukaBag.Rows(i).Cells(0).Value = True And dgvBhukaBag.Rows(i).Cells(8).Value IsNot Nothing Then
                        With Dparameters
                            .Add(dbManager.CreateParameter("@ActionType", "UpdateBhukaData", DbType.String))
                            .Add(dbManager.CreateParameter("@BagSrNo", CStr(cmbRBagNo.Text.Trim()), DbType.String))
                            .Add(dbManager.CreateParameter("@TId", Val(dgvBhukaBag.Rows(i).Cells(8).Value), DbType.Int16))
                        End With

                        dbManager.Update("SP_EditBags_Update", CommandType.StoredProcedure, Dparameters.ToArray())
                    End If
                    Dparameters.Clear()
                Next

                MessageBox.Show("Bhuka Bag Updated !!!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error:- " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not Validate_Fields() Then Exit Sub

        Try
            Me.UpdateBhukaBagNo()
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
    Private Sub CalculateTotal()
        Dim sBhukaTotal As Single = 0
        Dim sBhukaFineTotal As Single = 0

        For Each row As GridViewRowInfo In dgvBhukaBag.Rows
            If CBool(row.Cells()(0).Value) = True And Not String.IsNullOrEmpty(row.Cells(4).Value) Then
                sBhukaTotal += Single.Parse(row.Cells(4).Value)
                sBhukaFineTotal += Single.Parse(row.Cells(6).Value)
            End If
        Next

        lblBhukaTotal.Text = Format(sBhukaTotal, "0.00")
        lblFineTotal.Text = Format(sBhukaFineTotal, "0.00")
    End Sub
    Private Sub dgvBhukaBag_ValueChanged(sender As Object, e As EventArgs) Handles dgvBhukaBag.ValueChanged
        If dgvBhukaBag.CurrentColumn.Name = "colChkBox" Then
            dgvBhukaBag.EndEdit()
        End If

        Me.CalculateTotal()
    End Sub
    Private Sub dgvBhukaBag_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles dgvBhukaBag.CellEndEdit

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsExists() = False Then
            MessageBox.Show(String.Format("Cannot Delete Record.", Me.cmbRBagNo.Text))
            Me.cmbRBagNo.Focus()
            Exit Sub
        Else
            DeleteBhukaBagNo()
        End If
    End Sub
    Private Sub Clear_Form()
        Try

            '' For Header Field Start

            cmbEBagtype.SelectedIndex = 0
            cmbRBagNo.SelectedIndex = -1
            '' For Header Field End

            '' For Detail Field Start

            dgvBhukaBag.DataSource = Nothing

            '' For Detail Field End

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function CountCheckedRows() As Int16
        Dim iCount As Integer = 0

        For Each row As GridViewRowInfo In dgvBhukaBag.Rows
            If row.Cells(0).Value = True Then
                iCount += 1
            End If
        Next

        Return iCount

    End Function
    Private Function Validate_Fields() As Boolean
        Dim iCount As Int16 = 0

        Try
            If cmbRBagNo.SelectedIndex = -1 Then
                MessageBox.Show("Select To Bag !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbRBagNo.Focus()
                Return False
            End If

            iCount = CountCheckedRows()

            If Not iCount > 0 Then
                MessageBox.Show("Select Atleast One Row !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                dgvBhukaBag.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Shared Sub OnInfoMessage(sender As Object, args As SqlInfoMessageEventArgs)
        Dim err As SqlError
        For Each err In args.Errors
            MsgBox(err.Message)
        Next
    End Sub
    Private Function IsExists() As Boolean
        Dim iCnt As Int16 = 0

        Try

            Using cmd As New SqlCommand("SP_CheckBagNo_Select", Objcn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ActionType", "UpdateBhukaData")
                cmd.Parameters.AddWithValue("@BagNo", CStr(cmbRBagNo.Text.Trim()))
                cmd.Parameters.Add("@Exists", SqlDbType.Int)
                cmd.Parameters("@Exists").Direction = ParameterDirection.Output
                Objcn.Open()
                cmd.ExecuteNonQuery()
                Objcn.Close()

                iCnt = cmd.Parameters("@Exists").Value

            End Using

            If iCnt = 1 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "Chain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Private Sub DeleteBhukaBagNo()

        If dgvBhukaBag.Rows.Count > 0 Then

            Try

                Dim Dparameters = New List(Of SqlParameter)()
                Dparameters.Clear()

                For i As Integer = 0 To dgvBhukaBag.RowCount - 1
                    If dgvBhukaBag.Rows(i).Cells(0).Value = True And dgvBhukaBag.Rows(i).Cells(8).Value IsNot Nothing Then
                        With Dparameters
                            .Add(dbManager.CreateParameter("@ActionType", "DeleteBhukaData", DbType.String))
                            .Add(dbManager.CreateParameter("@BagNo", CStr(cmbRBagNo.Text.Trim()), DbType.String))
                            .Add(dbManager.CreateParameter("@TId", Val(dgvBhukaBag.Rows(i).Cells(8).Value), DbType.Int16))
                        End With

                        dbManager.Update("SP_EditBags_Delete", CommandType.StoredProcedure, Dparameters.ToArray())
                    End If
                    Dparameters.Clear()
                Next

                MessageBox.Show("Bhuka Bag Deleted !!!", "Chain", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error:- " & ex.Message)
            End Try

        End If
    End Sub
End Class