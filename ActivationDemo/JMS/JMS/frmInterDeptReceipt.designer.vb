﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInterDeptReceipt
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
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TbReceipt = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GBoxDetails = New System.Windows.Forms.GroupBox()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        Me.lblTotalFineWt = New System.Windows.Forms.Label()
        Me.lblTotalGrossPr = New System.Windows.Forms.Label()
        Me.lblTotalGrossWt = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.dgvReceipt = New Telerik.WinControls.UI.RadGridView()
        Me.GBoxMain = New System.Windows.Forms.GroupBox()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbVoucherNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtFrKarigar = New Telerik.WinControls.UI.RadTextBox()
        Me.cmbTLabour = New Telerik.WinControls.UI.RadDropDownList()
        Me.cmbtDepartment = New Telerik.WinControls.UI.RadDropDownList()
        Me.cmbfDepartment = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TransDt = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstReceipt = New System.Windows.Forms.ListView()
        Me.CReceiptId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CReceiptDt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CfDeptId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CfDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CtDeptId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CtDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CReceiptNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CCreatedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.TbReceipt.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GBoxDetails.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReceipt.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxMain.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVoucherNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrKarigar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbfDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbReceipt
        '
        Me.TbReceipt.Controls.Add(Me.TabPage1)
        Me.TbReceipt.Controls.Add(Me.TabPage2)
        Me.TbReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbReceipt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TbReceipt.Location = New System.Drawing.Point(0, 0)
        Me.TbReceipt.Margin = New System.Windows.Forms.Padding(5)
        Me.TbReceipt.Name = "TbReceipt"
        Me.TbReceipt.SelectedIndex = 0
        Me.TbReceipt.Size = New System.Drawing.Size(734, 536)
        Me.TbReceipt.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GBoxDetails)
        Me.TabPage1.Controls.Add(Me.GBoxMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Size = New System.Drawing.Size(726, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information"
        '
        'GBoxDetails
        '
        Me.GBoxDetails.Controls.Add(Me.btnDelete)
        Me.GBoxDetails.Controls.Add(Me.btnExit)
        Me.GBoxDetails.Controls.Add(Me.lblTotalFineWt)
        Me.GBoxDetails.Controls.Add(Me.lblTotalGrossPr)
        Me.GBoxDetails.Controls.Add(Me.lblTotalGrossWt)
        Me.GBoxDetails.Controls.Add(Me.lblTotal)
        Me.GBoxDetails.Controls.Add(Me.btnCancel)
        Me.GBoxDetails.Controls.Add(Me.btnSave)
        Me.GBoxDetails.Controls.Add(Me.dgvReceipt)
        Me.GBoxDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxDetails.Location = New System.Drawing.Point(9, 122)
        Me.GBoxDetails.Name = "GBoxDetails"
        Me.GBoxDetails.Size = New System.Drawing.Size(709, 380)
        Me.GBoxDetails.TabIndex = 23
        Me.GBoxDetails.TabStop = False
        Me.GBoxDetails.Text = "Receipt Details"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(400, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 799
        Me.btnExit.Text = "E&xit"
        '
        'lblTotalFineWt
        '
        Me.lblTotalFineWt.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFineWt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFineWt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalFineWt.Location = New System.Drawing.Point(630, 321)
        Me.lblTotalFineWt.Name = "lblTotalFineWt"
        Me.lblTotalFineWt.Size = New System.Drawing.Size(60, 12)
        Me.lblTotalFineWt.TabIndex = 790
        Me.lblTotalFineWt.Text = "0"
        Me.lblTotalFineWt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGrossPr
        '
        Me.lblTotalGrossPr.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalGrossPr.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrossPr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalGrossPr.Location = New System.Drawing.Point(549, 321)
        Me.lblTotalGrossPr.Name = "lblTotalGrossPr"
        Me.lblTotalGrossPr.Size = New System.Drawing.Size(60, 12)
        Me.lblTotalGrossPr.TabIndex = 783
        Me.lblTotalGrossPr.Text = "0"
        Me.lblTotalGrossPr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGrossWt
        '
        Me.lblTotalGrossWt.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalGrossWt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrossWt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalGrossWt.Location = New System.Drawing.Point(468, 321)
        Me.lblTotalGrossWt.Name = "lblTotalGrossWt"
        Me.lblTotalGrossWt.Size = New System.Drawing.Size(60, 12)
        Me.lblTotalGrossWt.TabIndex = 781
        Me.lblTotalGrossWt.Text = "0"
        Me.lblTotalGrossWt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(419, 321)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 14)
        Me.lblTotal.TabIndex = 51
        Me.lblTotal.Text = "Total"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(324, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(172, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'dgvReceipt
        '
        Me.dgvReceipt.BackColor = System.Drawing.Color.White
        Me.dgvReceipt.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvReceipt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvReceipt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvReceipt.Location = New System.Drawing.Point(7, 23)
        '
        '
        '
        Me.dgvReceipt.MasterTemplate.AllowAddNewRow = False
        Me.dgvReceipt.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Sr."
        GridViewTextBoxColumn1.Name = "colSrNo"
        GridViewTextBoxColumn1.Width = 42
        GridViewTextBoxColumn2.AllowGroup = False
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "IssueId"
        GridViewTextBoxColumn2.HeaderText = "Voucher No"
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "colIssueId"
        GridViewTextBoxColumn2.Width = 106
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "ItemId"
        GridViewTextBoxColumn3.HeaderText = "Item Id"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "colItemId"
        GridViewTextBoxColumn3.Width = 317
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "ItemName"
        GridViewTextBoxColumn4.HeaderText = "Item Name"
        GridViewTextBoxColumn4.Name = "colItemName"
        GridViewTextBoxColumn4.Width = 400
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "IssueWt"
        GridViewTextBoxColumn5.FormatString = "{0:F2}"
        GridViewTextBoxColumn5.HeaderText = "Receive Wt."
        GridViewTextBoxColumn5.Name = "colReceiveWt"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 85
        GridViewTextBoxColumn6.DataType = GetType(Decimal)
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "IssuePr"
        GridViewTextBoxColumn6.FormatString = "{0:F2}"
        GridViewTextBoxColumn6.HeaderText = "Receive %"
        GridViewTextBoxColumn6.Name = "colReceivePr"
        GridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn6.Width = 85
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "FineWt"
        GridViewTextBoxColumn7.FormatString = "{0:F2}"
        GridViewTextBoxColumn7.HeaderText = "Fine Wt."
        GridViewTextBoxColumn7.Name = "colFineWt"
        GridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn7.Width = 85
        Me.dgvReceipt.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.dgvReceipt.MasterTemplate.EnableGrouping = False
        Me.dgvReceipt.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvReceipt.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvReceipt.Name = "dgvReceipt"
        Me.dgvReceipt.ReadOnly = True
        Me.dgvReceipt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvReceipt.Size = New System.Drawing.Size(696, 291)
        Me.dgvReceipt.TabIndex = 0
        '
        'GBoxMain
        '
        Me.GBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBoxMain.Controls.Add(Me.txtId)
        Me.GBoxMain.Controls.Add(Me.Label5)
        Me.GBoxMain.Controls.Add(Me.cmbVoucherNo)
        Me.GBoxMain.Controls.Add(Me.txtFrKarigar)
        Me.GBoxMain.Controls.Add(Me.cmbTLabour)
        Me.GBoxMain.Controls.Add(Me.cmbtDepartment)
        Me.GBoxMain.Controls.Add(Me.cmbfDepartment)
        Me.GBoxMain.Controls.Add(Me.Label2)
        Me.GBoxMain.Controls.Add(Me.Label4)
        Me.GBoxMain.Controls.Add(Me.Label1)
        Me.GBoxMain.Controls.Add(Me.Label7)
        Me.GBoxMain.Controls.Add(Me.TransDt)
        Me.GBoxMain.Controls.Add(Me.Label26)
        Me.GBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxMain.Location = New System.Drawing.Point(9, 4)
        Me.GBoxMain.Margin = New System.Windows.Forms.Padding(5)
        Me.GBoxMain.Name = "GBoxMain"
        Me.GBoxMain.Padding = New System.Windows.Forms.Padding(5)
        Me.GBoxMain.Size = New System.Drawing.Size(709, 110)
        Me.GBoxMain.TabIndex = 21
        Me.GBoxMain.TabStop = False
        Me.GBoxMain.Text = "Receipt Information"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(199, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(12, 20)
        Me.txtId.TabIndex = 44
        Me.txtId.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(17, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Select Voucher"
        '
        'cmbVoucherNo
        '
        Me.cmbVoucherNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbVoucherNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbVoucherNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbVoucherNo.Location = New System.Drawing.Point(112, 56)
        Me.cmbVoucherNo.Name = "cmbVoucherNo"
        Me.cmbVoucherNo.Size = New System.Drawing.Size(85, 20)
        Me.cmbVoucherNo.TabIndex = 1
        '
        'txtFrKarigar
        '
        Me.txtFrKarigar.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtFrKarigar.Location = New System.Drawing.Point(576, 30)
        Me.txtFrKarigar.Name = "txtFrKarigar"
        Me.txtFrKarigar.ReadOnly = True
        Me.txtFrKarigar.Size = New System.Drawing.Size(125, 20)
        Me.txtFrKarigar.TabIndex = 4
        Me.txtFrKarigar.TabStop = False
        '
        'cmbTLabour
        '
        Me.cmbTLabour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTLabour.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbTLabour.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbTLabour.Location = New System.Drawing.Point(576, 59)
        Me.cmbTLabour.Name = "cmbTLabour"
        Me.cmbTLabour.Size = New System.Drawing.Size(125, 20)
        Me.cmbTLabour.TabIndex = 5
        '
        'cmbtDepartment
        '
        Me.cmbtDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbtDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbtDepartment.Location = New System.Drawing.Point(326, 56)
        Me.cmbtDepartment.Name = "cmbtDepartment"
        Me.cmbtDepartment.Size = New System.Drawing.Size(125, 20)
        Me.cmbtDepartment.TabIndex = 3
        '
        'cmbfDepartment
        '
        Me.cmbfDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbfDepartment.Location = New System.Drawing.Point(326, 27)
        Me.cmbfDepartment.Name = "cmbfDepartment"
        Me.cmbfDepartment.Size = New System.Drawing.Size(125, 20)
        Me.cmbfDepartment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(495, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "By Employee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(495, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fr. Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(265, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "To. Dept"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(270, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fr. Dept"
        '
        'TransDt
        '
        Me.TransDt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TransDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TransDt.Location = New System.Drawing.Point(112, 27)
        Me.TransDt.Name = "TransDt"
        Me.TransDt.Size = New System.Drawing.Size(85, 22)
        Me.TransDt.TabIndex = 0
        Me.TransDt.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(43, 30)
        Me.Label26.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 14)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Receipt Dt"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstReceipt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(726, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstReceipt
        '
        Me.lstReceipt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CReceiptId, Me.CReceiptDt, Me.CfDeptId, Me.CfDepartment, Me.CtDeptId, Me.CtDepartment, Me.CReceiptNo, Me.CCreatedBy})
        Me.lstReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstReceipt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FullRowSelect = True
        Me.lstReceipt.GridLines = True
        Me.lstReceipt.Location = New System.Drawing.Point(0, 0)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(726, 509)
        Me.lstReceipt.TabIndex = 0
        Me.lstReceipt.UseCompatibleStateImageBehavior = False
        Me.lstReceipt.View = System.Windows.Forms.View.Details
        '
        'CReceiptId
        '
        Me.CReceiptId.Text = "Receipt No"
        Me.CReceiptId.Width = 80
        '
        'CReceiptDt
        '
        Me.CReceiptDt.Text = "Receipt Dt"
        Me.CReceiptDt.Width = 80
        '
        'CfDeptId
        '
        Me.CfDeptId.Text = "Dept Id"
        Me.CfDeptId.Width = 0
        '
        'CfDepartment
        '
        Me.CfDepartment.Text = "Fr Dept."
        Me.CfDepartment.Width = 125
        '
        'CtDeptId
        '
        Me.CtDeptId.Width = 0
        '
        'CtDepartment
        '
        Me.CtDepartment.Text = "To Dept."
        Me.CtDepartment.Width = 125
        '
        'CReceiptNo
        '
        Me.CReceiptNo.Text = "Voucher No"
        Me.CReceiptNo.Width = 110
        '
        'CCreatedBy
        '
        Me.CCreatedBy.Text = "Created By"
        Me.CCreatedBy.Width = 203
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(248, 350)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 800
        Me.btnDelete.Text = "&Delete"
        '
        'frmInterDeptReceipt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(734, 536)
        Me.Controls.Add(Me.TbReceipt)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInterDeptReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inter Dept. Receipt Voucer"
        Me.TbReceipt.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GBoxDetails.ResumeLayout(False)
        Me.GBoxDetails.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReceipt.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxMain.ResumeLayout(False)
        Me.GBoxMain.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVoucherNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFrKarigar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTLabour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbfDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbReceipt As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstReceipt As ListView
    Friend WithEvents GBoxMain As GroupBox
    Friend WithEvents TransDt As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents CReceiptId As ColumnHeader
    Friend WithEvents CReceiptDt As ColumnHeader
    Friend WithEvents CfDeptId As ColumnHeader
    Friend WithEvents CfDepartment As ColumnHeader
    Friend WithEvents CReceiptNo As ColumnHeader
    Friend WithEvents CCreatedBy As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CtDeptId As ColumnHeader
    Friend WithEvents CtDepartment As ColumnHeader
    Friend WithEvents cmbfDepartment As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cmbtDepartment As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cmbTLabour As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents GBoxDetails As GroupBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents dgvReceipt As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtFrKarigar As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalGrossWt As Label
    Friend WithEvents lblTotalGrossPr As Label
    Friend WithEvents lblTotalFineWt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbVoucherNo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
End Class