﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDeptIssue
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
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.dgvWipLotNo = New Telerik.WinControls.UI.RadGridView()
        Me.lblCBhukaTotal = New System.Windows.Forms.Label()
        Me.lblReceiveFw = New System.Windows.Forms.Label()
        Me.lblReceivePr = New System.Windows.Forms.Label()
        Me.lblReceiveWt = New System.Windows.Forms.Label()
        CType(Me.dgvWipLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWipLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWipLotNo
        '
        Me.dgvWipLotNo.BackColor = System.Drawing.SystemColors.Control
        Me.dgvWipLotNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvWipLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvWipLotNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvWipLotNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvWipLotNo.Location = New System.Drawing.Point(2, 1)
        '
        '
        '
        Me.dgvWipLotNo.MasterTemplate.AllowAddNewRow = False
        Me.dgvWipLotNo.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "TransactionDt"
        GridViewTextBoxColumn1.HeaderText = "Trans. Dt"
        GridViewTextBoxColumn1.Name = "colTransDt"
        GridViewTextBoxColumn1.Width = 70
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "VoucherNo"
        GridViewTextBoxColumn2.HeaderText = "Voucher No"
        GridViewTextBoxColumn2.Name = "colVoucherNo"
        GridViewTextBoxColumn2.Width = 105
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "ItemName"
        GridViewTextBoxColumn3.HeaderText = "Item Name"
        GridViewTextBoxColumn3.Name = "colItemName"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn3.Width = 240
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "IssueWt"
        GridViewTextBoxColumn4.HeaderText = "Issue Wt."
        GridViewTextBoxColumn4.Name = "colIssueWt"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn4.Width = 80
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "IssuePr"
        GridViewTextBoxColumn5.HeaderText = "Issue %"
        GridViewTextBoxColumn5.Name = "colIssuePr"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 90
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "FineWt"
        GridViewTextBoxColumn6.HeaderText = "Fine Wt."
        GridViewTextBoxColumn6.Name = "colFineWt"
        GridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn6.Width = 80
        Me.dgvWipLotNo.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
        Me.dgvWipLotNo.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvWipLotNo.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvWipLotNo.Name = "dgvWipLotNo"
        Me.dgvWipLotNo.ReadOnly = True
        Me.dgvWipLotNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvWipLotNo.Size = New System.Drawing.Size(664, 389)
        Me.dgvWipLotNo.TabIndex = 9
        '
        'lblCBhukaTotal
        '
        Me.lblCBhukaTotal.AutoSize = True
        Me.lblCBhukaTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCBhukaTotal.Location = New System.Drawing.Point(403, 396)
        Me.lblCBhukaTotal.Name = "lblCBhukaTotal"
        Me.lblCBhukaTotal.Size = New System.Drawing.Size(38, 14)
        Me.lblCBhukaTotal.TabIndex = 51
        Me.lblCBhukaTotal.Text = "Total"
        '
        'lblReceiveFw
        '
        Me.lblReceiveFw.AutoSize = True
        Me.lblReceiveFw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblReceiveFw.Location = New System.Drawing.Point(641, 397)
        Me.lblReceiveFw.Name = "lblReceiveFw"
        Me.lblReceiveFw.Size = New System.Drawing.Size(14, 14)
        Me.lblReceiveFw.TabIndex = 50
        Me.lblReceiveFw.Text = "0"
        '
        'lblReceivePr
        '
        Me.lblReceivePr.AutoSize = True
        Me.lblReceivePr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblReceivePr.Location = New System.Drawing.Point(572, 397)
        Me.lblReceivePr.Name = "lblReceivePr"
        Me.lblReceivePr.Size = New System.Drawing.Size(14, 14)
        Me.lblReceivePr.TabIndex = 49
        Me.lblReceivePr.Text = "0"
        Me.lblReceivePr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReceiveWt
        '
        Me.lblReceiveWt.AutoSize = True
        Me.lblReceiveWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblReceiveWt.Location = New System.Drawing.Point(503, 397)
        Me.lblReceiveWt.Name = "lblReceiveWt"
        Me.lblReceiveWt.Size = New System.Drawing.Size(14, 14)
        Me.lblReceiveWt.TabIndex = 48
        Me.lblReceiveWt.Text = "0"
        '
        'frmStockDeptIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 417)
        Me.Controls.Add(Me.lblCBhukaTotal)
        Me.Controls.Add(Me.lblReceiveFw)
        Me.Controls.Add(Me.lblReceivePr)
        Me.Controls.Add(Me.lblReceiveWt)
        Me.Controls.Add(Me.dgvWipLotNo)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmStockDeptIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dept Issue"
        CType(Me.dgvWipLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWipLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvWipLotNo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblCBhukaTotal As Label
    Friend WithEvents lblReceiveFw As Label
    Friend WithEvents lblReceivePr As Label
    Friend WithEvents lblReceiveWt As Label
End Class
