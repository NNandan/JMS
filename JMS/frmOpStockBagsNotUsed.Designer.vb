﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpStockBagsNotUsed
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
        Dim GridViewTextBoxColumn118 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn119 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn120 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn121 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn122 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn123 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn124 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn125 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn126 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition14 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TabOpStock = New System.Windows.Forms.TabControl()
        Me.TabStock = New System.Windows.Forms.TabPage()
        Me.GBoxMain = New System.Windows.Forms.GroupBox()
        Me.txtReportPr = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBagNo = New Telerik.WinControls.UI.RadTextBox()
        Me.TransDt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtReceiveWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtIssuePr = New Telerik.WinControls.UI.RadTextBox()
        Me.txtIssueWt = New Telerik.WinControls.UI.RadTextBox()
        Me.cmbItem = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtSrNo = New Telerik.WinControls.UI.RadTextBox()
        Me.dgvUsedBags = New Telerik.WinControls.UI.RadGridView()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.TabOpStock.SuspendLayout()
        Me.TabStock.SuspendLayout()
        Me.GBoxMain.SuspendLayout()
        CType(Me.txtReportPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBagNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiveWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssuePr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssueWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsedBags, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsedBags.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabOpStock
        '
        Me.TabOpStock.Controls.Add(Me.TabStock)
        Me.TabOpStock.Location = New System.Drawing.Point(1, 2)
        Me.TabOpStock.Name = "TabOpStock"
        Me.TabOpStock.SelectedIndex = 0
        Me.TabOpStock.Size = New System.Drawing.Size(674, 462)
        Me.TabOpStock.TabIndex = 3
        '
        'TabStock
        '
        Me.TabStock.Controls.Add(Me.GBoxMain)
        Me.TabStock.Location = New System.Drawing.Point(4, 22)
        Me.TabStock.Name = "TabStock"
        Me.TabStock.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStock.Size = New System.Drawing.Size(666, 436)
        Me.TabStock.TabIndex = 0
        Me.TabStock.Text = "Used Bags"
        Me.TabStock.UseVisualStyleBackColor = True
        '
        'GBoxMain
        '
        Me.GBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBoxMain.Controls.Add(Me.txtReportPr)
        Me.GBoxMain.Controls.Add(Me.Label1)
        Me.GBoxMain.Controls.Add(Me.txtBagNo)
        Me.GBoxMain.Controls.Add(Me.TransDt)
        Me.GBoxMain.Controls.Add(Me.txtReceiveWt)
        Me.GBoxMain.Controls.Add(Me.txtIssuePr)
        Me.GBoxMain.Controls.Add(Me.txtIssueWt)
        Me.GBoxMain.Controls.Add(Me.cmbItem)
        Me.GBoxMain.Controls.Add(Me.txtSrNo)
        Me.GBoxMain.Controls.Add(Me.dgvUsedBags)
        Me.GBoxMain.Controls.Add(Me.btnDelete)
        Me.GBoxMain.Controls.Add(Me.btnCancel)
        Me.GBoxMain.Controls.Add(Me.btnSave)
        Me.GBoxMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GBoxMain.Location = New System.Drawing.Point(4, 3)
        Me.GBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GBoxMain.Name = "GBoxMain"
        Me.GBoxMain.Padding = New System.Windows.Forms.Padding(4)
        Me.GBoxMain.Size = New System.Drawing.Size(658, 428)
        Me.GBoxMain.TabIndex = 19
        Me.GBoxMain.TabStop = False
        Me.GBoxMain.Text = "Bags Not Created Details"
        '
        'txtReportPr
        '
        Me.txtReportPr.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtReportPr.Location = New System.Drawing.Point(586, 33)
        Me.txtReportPr.Name = "txtReportPr"
        Me.txtReportPr.Size = New System.Drawing.Size(70, 20)
        Me.txtReportPr.TabIndex = 6
        Me.txtReportPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(419, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 16)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Press  ( F12 )  to delete selected row"
        '
        'txtBagNo
        '
        Me.txtBagNo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtBagNo.Location = New System.Drawing.Point(112, 33)
        Me.txtBagNo.Name = "txtBagNo"
        Me.txtBagNo.Size = New System.Drawing.Size(75, 20)
        Me.txtBagNo.TabIndex = 1
        '
        'TransDt
        '
        Me.TransDt.BackColor = System.Drawing.Color.LemonChiffon
        Me.TransDt.Location = New System.Drawing.Point(39, 33)
        Me.TransDt.Mask = "00/00/0000"
        Me.TransDt.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.TransDt.Name = "TransDt"
        Me.TransDt.Size = New System.Drawing.Size(72, 20)
        Me.TransDt.TabIndex = 0
        Me.TransDt.TabStop = False
        Me.TransDt.Text = "__/__/____"
        '
        'txtReceiveWt
        '
        Me.txtReceiveWt.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtReceiveWt.Location = New System.Drawing.Point(508, 33)
        Me.txtReceiveWt.Name = "txtReceiveWt"
        Me.txtReceiveWt.Size = New System.Drawing.Size(77, 20)
        Me.txtReceiveWt.TabIndex = 5
        Me.txtReceiveWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIssuePr
        '
        Me.txtIssuePr.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtIssuePr.Location = New System.Drawing.Point(430, 33)
        Me.txtIssuePr.Name = "txtIssuePr"
        Me.txtIssuePr.Size = New System.Drawing.Size(77, 20)
        Me.txtIssuePr.TabIndex = 4
        Me.txtIssuePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIssueWt
        '
        Me.txtIssueWt.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtIssueWt.Location = New System.Drawing.Point(352, 33)
        Me.txtIssueWt.Name = "txtIssueWt"
        Me.txtIssueWt.Size = New System.Drawing.Size(77, 20)
        Me.txtIssueWt.TabIndex = 3
        Me.txtIssueWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbItem
        '
        Me.cmbItem.BackColor = System.Drawing.Color.LemonChiffon
        Me.cmbItem.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbItem.Location = New System.Drawing.Point(188, 33)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(163, 20)
        Me.cmbItem.TabIndex = 2
        '
        'txtSrNo
        '
        Me.txtSrNo.Location = New System.Drawing.Point(3, 33)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.ReadOnly = True
        Me.txtSrNo.Size = New System.Drawing.Size(35, 20)
        Me.txtSrNo.TabIndex = 0
        Me.txtSrNo.TabStop = False
        '
        'dgvUsedBags
        '
        Me.dgvUsedBags.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvUsedBags.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvUsedBags.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvUsedBags.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvUsedBags.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvUsedBags.Location = New System.Drawing.Point(2, 54)
        '
        '
        '
        Me.dgvUsedBags.MasterTemplate.AllowAddNewRow = False
        Me.dgvUsedBags.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn118.EnableExpressionEditor = False
        GridViewTextBoxColumn118.HeaderText = "Sr. "
        GridViewTextBoxColumn118.Name = "colSrNo"
        GridViewTextBoxColumn118.Width = 35
        GridViewTextBoxColumn119.EnableExpressionEditor = False
        GridViewTextBoxColumn119.HeaderText = "Trans. Dt"
        GridViewTextBoxColumn119.Name = "colTransDt"
        GridViewTextBoxColumn119.Width = 75
        GridViewTextBoxColumn120.EnableExpressionEditor = False
        GridViewTextBoxColumn120.HeaderText = "Bag No."
        GridViewTextBoxColumn120.Name = "colBagNo"
        GridViewTextBoxColumn120.Width = 76
        GridViewTextBoxColumn121.EnableExpressionEditor = False
        GridViewTextBoxColumn121.HeaderText = "Item Id"
        GridViewTextBoxColumn121.IsVisible = False
        GridViewTextBoxColumn121.Name = "colItemId"
        GridViewTextBoxColumn121.Width = 40
        GridViewTextBoxColumn122.EnableExpressionEditor = False
        GridViewTextBoxColumn122.HeaderText = "Item Name"
        GridViewTextBoxColumn122.Name = "colItemName"
        GridViewTextBoxColumn122.Width = 165
        GridViewTextBoxColumn123.EnableExpressionEditor = False
        GridViewTextBoxColumn123.HeaderText = "Issue Wt."
        GridViewTextBoxColumn123.Name = "colIssueWt"
        GridViewTextBoxColumn123.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn123.Width = 79
        GridViewTextBoxColumn124.EnableExpressionEditor = False
        GridViewTextBoxColumn124.HeaderText = "Issue %"
        GridViewTextBoxColumn124.Name = "colIssuePr"
        GridViewTextBoxColumn124.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn124.Width = 80
        GridViewTextBoxColumn125.EnableExpressionEditor = False
        GridViewTextBoxColumn125.HeaderText = "Receive Wt."
        GridViewTextBoxColumn125.Name = "colReceiveWt"
        GridViewTextBoxColumn125.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn125.Width = 79
        GridViewTextBoxColumn126.EnableExpressionEditor = False
        GridViewTextBoxColumn126.HeaderText = "Report %"
        GridViewTextBoxColumn126.Name = "colReportPr"
        GridViewTextBoxColumn126.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn126.Width = 70
        Me.dgvUsedBags.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn118, GridViewTextBoxColumn119, GridViewTextBoxColumn120, GridViewTextBoxColumn121, GridViewTextBoxColumn122, GridViewTextBoxColumn123, GridViewTextBoxColumn124, GridViewTextBoxColumn125, GridViewTextBoxColumn126})
        Me.dgvUsedBags.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvUsedBags.MasterTemplate.ViewDefinition = TableViewDefinition14
        Me.dgvUsedBags.Name = "dgvUsedBags"
        Me.dgvUsedBags.ReadOnly = True
        Me.dgvUsedBags.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvUsedBags.ShowGroupPanel = False
        Me.dgvUsedBags.Size = New System.Drawing.Size(654, 340)
        Me.dgvUsedBags.TabIndex = 8
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(291, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(368, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(214, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'frmOpStockBagsNotUsed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(675, 467)
        Me.Controls.Add(Me.TabOpStock)
        Me.KeyPreview = True
        Me.Name = "frmOpStockBagsNotUsed"
        Me.Text = "frmOpStockBagsNotUsed"
        Me.TabOpStock.ResumeLayout(False)
        Me.TabStock.ResumeLayout(False)
        Me.GBoxMain.ResumeLayout(False)
        Me.GBoxMain.PerformLayout()
        CType(Me.txtReportPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBagNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiveWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssuePr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssueWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsedBags.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsedBags, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabOpStock As TabControl
    Friend WithEvents TabStock As TabPage
    Friend WithEvents GBoxMain As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBagNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TransDt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtReceiveWt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtIssuePr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtIssueWt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmbItem As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtSrNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dgvUsedBags As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtReportPr As Telerik.WinControls.UI.RadTextBox
End Class