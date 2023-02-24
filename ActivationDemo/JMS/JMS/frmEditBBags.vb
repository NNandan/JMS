﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports DataAccessHandler
Imports Telerik.WinControls.UI
Public Class frmEditBBags
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private mFr_State As FormState

    Dim strSQL As String = Nothing

    Dim dbManager As New SqlHelper(ConfigurationManager.ConnectionStrings("ConString").ToString())

    Dim Objcn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConString").ToString())
    Private Sub frmEditSBags_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.fillBagType()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)

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
        If Convert.ToInt32(cmbRBagNo.SelectedIndex) > 0 Then
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

    'Private Sub fillAllBhukaBag()

    '    If cmbEBagtype.SelectedIndex > 0 Then

    '        Dim parameters = New List(Of SqlParameter)()
    '        parameters.Clear()

    '        parameters.Add(dbManager.CreateParameter("@ActionType", "GetAllBhukaBag", DbType.String))
    '        parameters.Add(dbManager.CreateParameter("@BId", Val(cmbEBagtype.SelectedValue), DbType.Int16))

    '        Dim dr As SqlDataReader = dbManager.GetDataReader("SP_EditBags_Select", CommandType.StoredProcedure, Objcn, parameters.ToArray())

    '        If dr.HasRows = False Then
    '            MessageBox.Show("No Data Exists !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    '            Exit Sub
    '        End If

    '        cmbRBagNo.Items.Clear()
    '        cmbRBagNo.ResetText()

    '        Try
    '            While dr.Read
    '                If Not IsDBNull(dr.Item("BhukaBagNo")) Then
    '                    cmbRBagNo.Items.Add(dr.Item("BhukaBagNo"))
    '                End If
    '            End While

    '        Catch ex As Exception
    '            MessageBox.Show("Error:- " & ex.Message)
    '        Finally
    '            dr.Close()
    '            Objcn.Close()
    '        End Try
    '    End If
    'End Sub
    Private Sub fillAllBhukaBag()
        Dim i As Int16

        Dim connection As SqlConnection = Nothing

        Dim parameters = New List(Of SqlParameter)()
        parameters.Clear()

        With parameters
            .Add(dbManager.CreateParameter("@ActionType", "GetAllBhukaBag", DbType.String))
            .Add(dbManager.CreateParameter("@BId", Val(cmbEBagtype.SelectedValue), DbType.Int16))
        End With

        Dim dr = dbManager.GetDataReader("SP_EditBags_Select", CommandType.StoredProcedure, parameters.ToArray(), connection)
        Dim dt As DataTable = New DataTable()

        dt.Load(dr)

        Try
            cmbRBagNo.DataSource = Nothing
            cmbRBagNo.Items.Clear()

            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "---Select---"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbRBagNo.DataSource = dt
            cmbRBagNo.DisplayMember = "BhukaBagNo"
            cmbRBagNo.ValueMember = "TransId"
            cmbRBagNo.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MessageBox.Show("Error:- " & ex.Message)
        Finally
            dr.Close()
            dbManager.CloseConnection(connection)
        End Try
    End Sub

    Private Sub dgvBhukaBag_CurrentRowChanging(sender As Object, e As CurrentRowChangingEventArgs) Handles dgvBhukaBag.CurrentRowChanging
        If e.NewRow IsNot Nothing Then
            e.NewRow.Cells(0).Value = True
            e.NewRow.Cells(0).ReadOnly = True
        Else
            e.NewRow.Cells(0).Value = False
        End If

        'If e.CurrentRow IsNot Nothing Then
        '    e.CurrentRow.Cells("IsActive").Value = False
        'End If
    End Sub
End Class