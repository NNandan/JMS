﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBhukaBagByNumber
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
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.dgvBhukaBagList = New Telerik.WinControls.UI.RadGridView()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        CType(Me.dgvBhukaBagList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBhukaBagList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBhukaBagList
        '
        Me.dgvBhukaBagList.BackColor = System.Drawing.SystemColors.Control
        Me.dgvBhukaBagList.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvBhukaBagList.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvBhukaBagList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvBhukaBagList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvBhukaBagList.Location = New System.Drawing.Point(5, 30)
        '
        '
        '
        Me.dgvBhukaBagList.MasterTemplate.AllowAddNewRow = False
        Me.dgvBhukaBagList.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "LotNo"
        GridViewTextBoxColumn6.HeaderText = "Lot No"
        GridViewTextBoxColumn6.Name = "colLotNumber"
        GridViewTextBoxColumn6.Width = 122
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "OperationName"
        GridViewTextBoxColumn7.HeaderText = "Operation Name"
        GridViewTextBoxColumn7.Name = "colOperationName"
        GridViewTextBoxColumn7.Width = 250
        GridViewTextBoxColumn8.AllowFiltering = False
        GridViewTextBoxColumn8.AllowGroup = False
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "BhukaWt"
        GridViewTextBoxColumn8.FormatString = "{0:F2}"
        GridViewTextBoxColumn8.HeaderText = "Scrap Wt."
        GridViewTextBoxColumn8.Name = "colBhukaWt"
        GridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn8.Width = 95
        GridViewTextBoxColumn9.AllowFiltering = False
        GridViewTextBoxColumn9.AllowGroup = False
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "ReceivePr"
        GridViewTextBoxColumn9.FormatString = "{0:F2}"
        GridViewTextBoxColumn9.HeaderText = "Receive %"
        GridViewTextBoxColumn9.Name = "colReceivePr"
        GridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn9.Width = 71
        GridViewTextBoxColumn10.AllowFiltering = False
        GridViewTextBoxColumn10.AllowGroup = False
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "FineWt"
        GridViewTextBoxColumn10.FormatString = "{0:F2}"
        GridViewTextBoxColumn10.HeaderText = "Fine Wt."
        GridViewTextBoxColumn10.Name = "colFineWt"
        GridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn10.Width = 73
        Me.dgvBhukaBagList.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.dgvBhukaBagList.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvBhukaBagList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.dgvBhukaBagList.Name = "dgvBhukaBagList"
        Me.dgvBhukaBagList.ReadOnly = True
        Me.dgvBhukaBagList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvBhukaBagList.Size = New System.Drawing.Size(795, 525)
        Me.dgvBhukaBagList.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(316, 4)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(163, 19)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Scrap Bag By Number"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Location = New System.Drawing.Point(322, 561)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&Print"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(399, 561)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        '
        'frmBhukaBagByNumber
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(804, 589)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.dgvBhukaBagList)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBhukaBagByNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBhukaBagList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBhukaBagList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBhukaBagList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
End Class