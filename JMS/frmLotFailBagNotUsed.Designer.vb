﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotFailBagNotUsed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.dgvLotFailBagNo = New Telerik.WinControls.UI.RadGridView()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        CType(Me.dgvLotFailBagNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLotFailBagNo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLotFailBagNo
        '
        Me.dgvLotFailBagNo.BackColor = System.Drawing.SystemColors.Control
        Me.dgvLotFailBagNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvLotFailBagNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvLotFailBagNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvLotFailBagNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvLotFailBagNo.Location = New System.Drawing.Point(3, 2)
        '
        '
        '
        Me.dgvLotFailBagNo.MasterTemplate.AllowAddNewRow = False
        Me.dgvLotFailBagNo.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "UsedBagDt"
        GridViewTextBoxColumn1.HeaderText = "Trans. Dt"
        GridViewTextBoxColumn1.Name = "colTransDt"
        GridViewTextBoxColumn1.Width = 82
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "BagSrNo"
        GridViewTextBoxColumn2.HeaderText = "Bag Sr No"
        GridViewTextBoxColumn2.Name = "colItemName"
        GridViewTextBoxColumn2.Width = 280
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "ReceiveWt"
        GridViewTextBoxColumn3.HeaderText = "Receive Wt."
        GridViewTextBoxColumn3.Name = "colReceiveWt"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn3.Width = 93
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "ReportPr"
        GridViewTextBoxColumn4.HeaderText = "Receive %"
        GridViewTextBoxColumn4.Name = "colReceivePr"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn4.Width = 105
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "FineWt"
        GridViewTextBoxColumn5.HeaderText = "Fine Wt."
        GridViewTextBoxColumn5.Name = "colFineWt"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 93
        Me.dgvLotFailBagNo.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.dgvLotFailBagNo.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvLotFailBagNo.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvLotFailBagNo.Name = "dgvLotFailBagNo"
        Me.dgvLotFailBagNo.ReadOnly = True
        Me.dgvLotFailBagNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvLotFailBagNo.Size = New System.Drawing.Size(773, 408)
        Me.dgvLotFailBagNo.TabIndex = 7
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPrint.Location = New System.Drawing.Point(292, 419)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 27)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(380, 419)
        Me.btnExit.Name = "btnExit"
        '
        '
        '
        Me.btnExit.RootElement.ControlBounds = New System.Drawing.Rectangle(380, 419, 110, 24)
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 799
        Me.btnExit.Text = "E&xit"
        '
        'frmLotFailBagNotUsed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(780, 451)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgvLotFailBagNo)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmLotFailBagNotUsed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LotFail Bag Not Used"
        CType(Me.dgvLotFailBagNo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLotFailBagNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLotFailBagNo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Private WithEvents btnExit As Telerik.WinControls.UI.RadButton
End Class
