﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditVBags
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
        Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.GCBoxMain = New System.Windows.Forms.GroupBox()
        Me.cmbRBagNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEBagtype = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblKarigarName = New System.Windows.Forms.Label()
        Me.GCBoxDetails = New System.Windows.Forms.GroupBox()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.lblFineTotal = New System.Windows.Forms.Label()
        Me.lblReceivePrTotal = New System.Windows.Forms.Label()
        Me.lblBhukaTotal = New System.Windows.Forms.Label()
        Me.lblCBhukaTotal = New System.Windows.Forms.Label()
        Me.dgvVacuumBag = New Telerik.WinControls.UI.RadGridView()
        Me.GCBoxMain.SuspendLayout()
        CType(Me.cmbRBagNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEBagtype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBoxDetails.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVacuumBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVacuumBag.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCBoxMain
        '
        Me.GCBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GCBoxMain.Controls.Add(Me.cmbRBagNo)
        Me.GCBoxMain.Controls.Add(Me.Label3)
        Me.GCBoxMain.Controls.Add(Me.cmbEBagtype)
        Me.GCBoxMain.Controls.Add(Me.lblKarigarName)
        Me.GCBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GCBoxMain.Location = New System.Drawing.Point(5, 8)
        Me.GCBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GCBoxMain.Name = "GCBoxMain"
        Me.GCBoxMain.Size = New System.Drawing.Size(727, 61)
        Me.GCBoxMain.TabIndex = 20
        Me.GCBoxMain.TabStop = False
        Me.GCBoxMain.Text = "Vacuum Bag Information"
        '
        'cmbRBagNo
        '
        Me.cmbRBagNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbRBagNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbRBagNo.Location = New System.Drawing.Point(572, 24)
        Me.cmbRBagNo.Name = "cmbRBagNo"
        '
        '
        '
        Me.cmbRBagNo.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 125, 20)
        Me.cmbRBagNo.RootElement.StretchVertically = True
        Me.cmbRBagNo.Size = New System.Drawing.Size(145, 20)
        Me.cmbRBagNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(507, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bag Sr No"
        '
        'cmbEBagtype
        '
        Me.cmbEBagtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbEBagtype.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbEBagtype.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbEBagtype.Location = New System.Drawing.Point(115, 27)
        Me.cmbEBagtype.Name = "cmbEBagtype"
        '
        '
        '
        Me.cmbEBagtype.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 125, 20)
        Me.cmbEBagtype.RootElement.StretchVertically = True
        Me.cmbEBagtype.Size = New System.Drawing.Size(145, 20)
        Me.cmbEBagtype.TabIndex = 0
        '
        'lblKarigarName
        '
        Me.lblKarigarName.AutoSize = True
        Me.lblKarigarName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKarigarName.Location = New System.Drawing.Point(14, 30)
        Me.lblKarigarName.Name = "lblKarigarName"
        Me.lblKarigarName.Size = New System.Drawing.Size(97, 14)
        Me.lblKarigarName.TabIndex = 1
        Me.lblKarigarName.Text = "Select Bag Type"
        '
        'GCBoxDetails
        '
        Me.GCBoxDetails.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GCBoxDetails.Controls.Add(Me.btnExit)
        Me.GCBoxDetails.Controls.Add(Me.btnCancel)
        Me.GCBoxDetails.Controls.Add(Me.btnUpdate)
        Me.GCBoxDetails.Controls.Add(Me.btnDelete)
        Me.GCBoxDetails.Controls.Add(Me.lblFineTotal)
        Me.GCBoxDetails.Controls.Add(Me.lblReceivePrTotal)
        Me.GCBoxDetails.Controls.Add(Me.lblBhukaTotal)
        Me.GCBoxDetails.Controls.Add(Me.lblCBhukaTotal)
        Me.GCBoxDetails.Controls.Add(Me.dgvVacuumBag)
        Me.GCBoxDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GCBoxDetails.Location = New System.Drawing.Point(5, 73)
        Me.GCBoxDetails.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GCBoxDetails.Name = "GCBoxDetails"
        Me.GCBoxDetails.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GCBoxDetails.Size = New System.Drawing.Size(727, 388)
        Me.GCBoxDetails.TabIndex = 27
        Me.GCBoxDetails.TabStop = False
        Me.GCBoxDetails.Text = "Vacuum Bag Details"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(433, 359)
        Me.btnExit.Name = "btnExit"
        '
        '
        '
        Me.btnExit.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 803
        Me.btnExit.Text = "E&xit"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(356, 359)
        Me.btnCancel.Name = "btnCancel"
        '
        '
        '
        Me.btnCancel.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 802
        Me.btnCancel.Text = "&Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(202, 359)
        Me.btnUpdate.Name = "btnUpdate"
        '
        '
        '
        Me.btnUpdate.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.btnUpdate.Size = New System.Drawing.Size(75, 25)
        Me.btnUpdate.TabIndex = 800
        Me.btnUpdate.Text = "&Update"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(279, 359)
        Me.btnDelete.Name = "btnDelete"
        '
        '
        '
        Me.btnDelete.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 801
        Me.btnDelete.Text = "&Delete"
        '
        'lblFineTotal
        '
        Me.lblFineTotal.AutoSize = True
        Me.lblFineTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFineTotal.Location = New System.Drawing.Point(611, 332)
        Me.lblFineTotal.Name = "lblFineTotal"
        Me.lblFineTotal.Size = New System.Drawing.Size(14, 14)
        Me.lblFineTotal.TabIndex = 37
        Me.lblFineTotal.Text = "0"
        '
        'lblReceivePrTotal
        '
        Me.lblReceivePrTotal.AutoSize = True
        Me.lblReceivePrTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivePrTotal.Location = New System.Drawing.Point(533, 331)
        Me.lblReceivePrTotal.Name = "lblReceivePrTotal"
        Me.lblReceivePrTotal.Size = New System.Drawing.Size(14, 14)
        Me.lblReceivePrTotal.TabIndex = 36
        Me.lblReceivePrTotal.Text = "0"
        Me.lblReceivePrTotal.Visible = False
        '
        'lblBhukaTotal
        '
        Me.lblBhukaTotal.AutoSize = True
        Me.lblBhukaTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBhukaTotal.Location = New System.Drawing.Point(455, 331)
        Me.lblBhukaTotal.Name = "lblBhukaTotal"
        Me.lblBhukaTotal.Size = New System.Drawing.Size(14, 14)
        Me.lblBhukaTotal.TabIndex = 35
        Me.lblBhukaTotal.Text = "0"
        '
        'lblCBhukaTotal
        '
        Me.lblCBhukaTotal.AutoSize = True
        Me.lblCBhukaTotal.Location = New System.Drawing.Point(365, 331)
        Me.lblCBhukaTotal.Name = "lblCBhukaTotal"
        Me.lblCBhukaTotal.Size = New System.Drawing.Size(38, 14)
        Me.lblCBhukaTotal.TabIndex = 34
        Me.lblCBhukaTotal.Text = "Total"
        '
        'dgvVacuumBag
        '
        Me.dgvVacuumBag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvVacuumBag.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvVacuumBag.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvVacuumBag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvVacuumBag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvVacuumBag.Location = New System.Drawing.Point(8, 34)
        '
        '
        '
        Me.dgvVacuumBag.MasterTemplate.AllowAddNewRow = False
        Me.dgvVacuumBag.MasterTemplate.AllowColumnReorder = False
        GridViewCheckBoxColumn2.AllowFiltering = False
        GridViewCheckBoxColumn2.AllowGroup = False
        GridViewCheckBoxColumn2.AllowResize = False
        GridViewCheckBoxColumn2.EnableExpressionEditor = False
        GridViewCheckBoxColumn2.EnableHeaderCheckBox = True
        GridViewCheckBoxColumn2.MinWidth = 20
        GridViewCheckBoxColumn2.Name = "colChkBox"
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "TransDt"
        GridViewTextBoxColumn9.HeaderText = "Trans. Dt"
        GridViewTextBoxColumn9.Name = "colTransDate"
        GridViewTextBoxColumn9.Width = 90
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "OperationName"
        GridViewTextBoxColumn10.HeaderText = "Operation"
        GridViewTextBoxColumn10.Name = "colOperation"
        GridViewTextBoxColumn10.Width = 150
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "LotNo"
        GridViewTextBoxColumn11.HeaderText = "Lot No."
        GridViewTextBoxColumn11.Name = "colLotNo"
        GridViewTextBoxColumn11.Width = 90
        GridViewTextBoxColumn12.EnableExpressionEditor = False
        GridViewTextBoxColumn12.FieldName = "BhukaWt"
        GridViewTextBoxColumn12.HeaderText = "Vacuum Wt."
        GridViewTextBoxColumn12.Name = "colVacuumWt"
        GridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn12.Width = 80
        GridViewTextBoxColumn13.EnableExpressionEditor = False
        GridViewTextBoxColumn13.FieldName = "ReceivePr"
        GridViewTextBoxColumn13.HeaderText = "Receive %"
        GridViewTextBoxColumn13.Name = "colReceivePr"
        GridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn13.Width = 80
        GridViewTextBoxColumn14.EnableExpressionEditor = False
        GridViewTextBoxColumn14.FieldName = "FineWt"
        GridViewTextBoxColumn14.HeaderText = "Fine Wt."
        GridViewTextBoxColumn14.Name = "colFineWt"
        GridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn14.Width = 80
        GridViewTextBoxColumn15.EnableExpressionEditor = False
        GridViewTextBoxColumn15.FieldName = "ScrapBagNo"
        GridViewTextBoxColumn15.HeaderText = "Bag No."
        GridViewTextBoxColumn15.Name = "colBagNo"
        GridViewTextBoxColumn15.Width = 100
        GridViewTextBoxColumn16.EnableExpressionEditor = False
        GridViewTextBoxColumn16.FieldName = "TransId"
        GridViewTextBoxColumn16.HeaderText = "Trans Id."
        GridViewTextBoxColumn16.IsVisible = False
        GridViewTextBoxColumn16.Name = "colTransId"
        Me.dgvVacuumBag.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCheckBoxColumn2, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16})
        Me.dgvVacuumBag.MasterTemplate.EnableGrouping = False
        Me.dgvVacuumBag.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvVacuumBag.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.dgvVacuumBag.Name = "dgvVacuumBag"
        Me.dgvVacuumBag.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.dgvVacuumBag.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.dgvVacuumBag.Size = New System.Drawing.Size(715, 290)
        Me.dgvVacuumBag.TabIndex = 30
        Me.dgvVacuumBag.ThemeName = "ControlDefault"
        '
        'frmEditVBags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 467)
        Me.Controls.Add(Me.GCBoxDetails)
        Me.Controls.Add(Me.GCBoxMain)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmEditVBags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Vacuum Bags"
        Me.GCBoxMain.ResumeLayout(False)
        Me.GCBoxMain.PerformLayout()
        CType(Me.cmbRBagNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEBagtype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBoxDetails.ResumeLayout(False)
        Me.GCBoxDetails.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVacuumBag.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVacuumBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCBoxMain As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblKarigarName As Label
    Friend WithEvents GCBoxDetails As GroupBox
    Friend WithEvents lblFineTotal As Label
    Friend WithEvents lblReceivePrTotal As Label
    Friend WithEvents lblBhukaTotal As Label
    Friend WithEvents lblCBhukaTotal As Label
    Private WithEvents cmbRBagNo As Telerik.WinControls.UI.RadDropDownList
    Private WithEvents cmbEBagtype As Telerik.WinControls.UI.RadDropDownList
    Private WithEvents btnExit As Telerik.WinControls.UI.RadButton
    Private WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Private WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Private WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Private WithEvents dgvVacuumBag As Telerik.WinControls.UI.RadGridView
End Class