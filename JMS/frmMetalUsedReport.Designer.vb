﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMetalUsedReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.dgvMeltingBagList = New Telerik.WinControls.UI.RadGridView()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        CType(Me.dgvMeltingBagList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMeltingBagList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMeltingBagList
        '
        Me.dgvMeltingBagList.BackColor = System.Drawing.SystemColors.Control
        Me.dgvMeltingBagList.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvMeltingBagList.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvMeltingBagList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvMeltingBagList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvMeltingBagList.Location = New System.Drawing.Point(3, 3)
        '
        '
        '
        Me.dgvMeltingBagList.MasterTemplate.AllowAddNewRow = False
        Me.dgvMeltingBagList.MasterTemplate.AllowColumnReorder = False
        Me.dgvMeltingBagList.MasterTemplate.AllowDeleteRow = False
        Me.dgvMeltingBagList.MasterTemplate.AllowEditRow = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "SlipBagNo"
        GridViewTextBoxColumn1.HeaderText = "Voucher No."
        GridViewTextBoxColumn1.Name = "colVoucherNo"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "ItemName"
        GridViewTextBoxColumn2.HeaderText = "Item Name"
        GridViewTextBoxColumn2.Name = "colItemName"
        GridViewTextBoxColumn2.Width = 130
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Used In"
        GridViewTextBoxColumn3.HeaderText = "Used In"
        GridViewTextBoxColumn3.Name = "colUsedIn"
        GridViewTextBoxColumn3.Width = 89
        GridViewDecimalColumn1.AllowFiltering = False
        GridViewDecimalColumn1.AllowGroup = False
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "LotNo"
        GridViewDecimalColumn1.FormatString = "{0:F2}"
        GridViewDecimalColumn1.HeaderText = "Lot No."
        GridViewDecimalColumn1.Name = "colUsedInLotNo"
        GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewDecimalColumn1.Width = 100
        GridViewTextBoxColumn4.AllowFiltering = False
        GridViewTextBoxColumn4.AllowGroup = False
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "IssueWt"
        GridViewTextBoxColumn4.FormatString = "{0:F2}"
        GridViewTextBoxColumn4.HeaderText = "Issue Wt."
        GridViewTextBoxColumn4.Name = "colIssueWt"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn4.Width = 90
        GridViewDecimalColumn2.AllowFiltering = False
        GridViewDecimalColumn2.AllowGroup = False
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "IssuePr"
        GridViewDecimalColumn2.FormatString = "{0:F2}"
        GridViewDecimalColumn2.HeaderText = "Issue [%]"
        GridViewDecimalColumn2.Name = "colIssuePr"
        GridViewDecimalColumn2.Width = 90
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "FineWt"
        GridViewTextBoxColumn5.HeaderText = "Fine Wt."
        GridViewTextBoxColumn5.Name = "colFineWt"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 90
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "PartyName"
        GridViewTextBoxColumn6.HeaderText = "Party Name"
        GridViewTextBoxColumn6.Name = "colPartyName"
        GridViewTextBoxColumn6.Width = 120
        Me.dgvMeltingBagList.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDecimalColumn1, GridViewTextBoxColumn4, GridViewDecimalColumn2, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
        Me.dgvMeltingBagList.MasterTemplate.EnableGrouping = False
        Me.dgvMeltingBagList.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvMeltingBagList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvMeltingBagList.Name = "dgvMeltingBagList"
        Me.dgvMeltingBagList.ReadOnly = True
        Me.dgvMeltingBagList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvMeltingBagList.Size = New System.Drawing.Size(804, 403)
        Me.dgvMeltingBagList.TabIndex = 16
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Location = New System.Drawing.Point(330, 412)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "&Print"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(408, 412)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        '
        'frmMetalUsedReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(810, 440)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgvMeltingBagList)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMetalUsedReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metal Used By Voucher Number"
        CType(Me.dgvMeltingBagList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMeltingBagList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMeltingBagList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
End Class
