﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLotFailBag
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
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.tbLotFail = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.GCBoxMain = New System.Windows.Forms.GroupBox()
        Me.txtMaxNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblMaxNo = New System.Windows.Forms.Label()
        Me.txtCTransId = New Telerik.WinControls.UI.RadTextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtItemName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCLotFailPr = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCLotFailWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.txtLabour = New Telerik.WinControls.UI.RadTextBox()
        Me.txtOperation = New Telerik.WinControls.UI.RadTextBox()
        Me.TransDt = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.cmbCLotNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKarigarName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GRBoxDetails = New System.Windows.Forms.GroupBox()
        Me.btnREdit = New Telerik.WinControls.UI.RadButton()
        Me.btnRExit = New Telerik.WinControls.UI.RadButton()
        Me.btnRCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnRSave = New Telerik.WinControls.UI.RadButton()
        Me.dgvRLotFail = New Telerik.WinControls.UI.RadGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GRBoxMain = New System.Windows.Forms.GroupBox()
        Me.cmbRBagNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtRBagName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblRBagSrNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRGrossLoss = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRCarbon = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRTotalWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRSample = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRReceiveWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRWtOnScale = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRLotFailPr = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRLotFailWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRTransId = New Telerik.WinControls.UI.RadTextBox()
        Me.RTransDt = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLotNo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnUSave = New Telerik.WinControls.UI.RadButton()
        Me.btnUEdit = New Telerik.WinControls.UI.RadButton()
        Me.btnUExit = New Telerik.WinControls.UI.RadButton()
        Me.btnUCancel = New Telerik.WinControls.UI.RadButton()
        Me.GUBoxMain = New System.Windows.Forms.GroupBox()
        Me.cmbUpdBagNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtUBagSrNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblUBagSrNo = New System.Windows.Forms.Label()
        Me.RadCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.txtUcarbonReceive = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUWtOnScale = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUIssueFineWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUIssueWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUIssuePr = New Telerik.WinControls.UI.RadTextBox()
        Me.txtULossFine = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUGrossLoss = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUreceiveFineWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUreceiveWt = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUReceivePr = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtUTransId = New Telerik.WinControls.UI.RadTextBox()
        Me.UTransDt = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblUBagType = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvFinalUpdate = New Telerik.WinControls.UI.RadGridView()
        Me.tbLotFail.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBoxMain.SuspendLayout()
        CType(Me.txtMaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCTransId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCLotFailPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCLotFailWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLabour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GRBoxDetails.SuspendLayout()
        CType(Me.btnREdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRLotFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRLotFail.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBoxMain.SuspendLayout()
        CType(Me.cmbRBagNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRBagNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRBagNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRBagName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRGrossLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRCarbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRTotalWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRReceiveWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRWtOnScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRLotFailPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRLotFailWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRTransId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTransDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.btnUSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GUBoxMain.SuspendLayout()
        CType(Me.cmbUpdBagNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUpdBagNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUpdBagNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUBagSrNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel1.PanelContainer.SuspendLayout()
        CType(Me.txtUcarbonReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUWtOnScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUIssueFineWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUIssueWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUIssuePr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtULossFine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUGrossLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUreceiveFineWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUreceiveWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUReceivePr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUTransId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UTransDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvFinalUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalUpdate.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLotFail
        '
        Me.tbLotFail.Controls.Add(Me.TabPage1)
        Me.tbLotFail.Controls.Add(Me.TabPage2)
        Me.tbLotFail.Controls.Add(Me.TabPage3)
        Me.tbLotFail.Controls.Add(Me.TabPage4)
        Me.tbLotFail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLotFail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLotFail.Location = New System.Drawing.Point(0, 0)
        Me.tbLotFail.Name = "tbLotFail"
        Me.tbLotFail.SelectedIndex = 0
        Me.tbLotFail.Size = New System.Drawing.Size(714, 511)
        Me.tbLotFail.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnExit)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.GCBoxMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(706, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create LotFail  Bag"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(278, 261)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "&Delete"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(430, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(354, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(202, 261)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "&Save"
        '
        'GCBoxMain
        '
        Me.GCBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GCBoxMain.Controls.Add(Me.txtMaxNo)
        Me.GCBoxMain.Controls.Add(Me.lblMaxNo)
        Me.GCBoxMain.Controls.Add(Me.txtCTransId)
        Me.GCBoxMain.Controls.Add(Me.lblItemName)
        Me.GCBoxMain.Controls.Add(Me.txtItemName)
        Me.GCBoxMain.Controls.Add(Me.txtCLotFailPr)
        Me.GCBoxMain.Controls.Add(Me.txtCLotFailWt)
        Me.GCBoxMain.Controls.Add(Me.txtRemarks)
        Me.GCBoxMain.Controls.Add(Me.txtLabour)
        Me.GCBoxMain.Controls.Add(Me.txtOperation)
        Me.GCBoxMain.Controls.Add(Me.TransDt)
        Me.GCBoxMain.Controls.Add(Me.cmbCLotNo)
        Me.GCBoxMain.Controls.Add(Me.Label4)
        Me.GCBoxMain.Controls.Add(Me.Label7)
        Me.GCBoxMain.Controls.Add(Me.Label6)
        Me.GCBoxMain.Controls.Add(Me.Label3)
        Me.GCBoxMain.Controls.Add(Me.Label2)
        Me.GCBoxMain.Controls.Add(Me.Label1)
        Me.GCBoxMain.Controls.Add(Me.lblKarigarName)
        Me.GCBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GCBoxMain.Location = New System.Drawing.Point(5, 9)
        Me.GCBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GCBoxMain.Name = "GCBoxMain"
        Me.GCBoxMain.Size = New System.Drawing.Size(694, 175)
        Me.GCBoxMain.TabIndex = 18
        Me.GCBoxMain.TabStop = False
        Me.GCBoxMain.Text = "Lot Fail Information"
        '
        'txtMaxNo
        '
        Me.txtMaxNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMaxNo.Location = New System.Drawing.Point(256, 25)
        Me.txtMaxNo.Name = "txtMaxNo"
        Me.txtMaxNo.ReadOnly = True
        Me.txtMaxNo.Size = New System.Drawing.Size(65, 20)
        Me.txtMaxNo.TabIndex = 45
        Me.txtMaxNo.Visible = False
        '
        'lblMaxNo
        '
        Me.lblMaxNo.AutoSize = True
        Me.lblMaxNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxNo.Location = New System.Drawing.Point(207, 28)
        Me.lblMaxNo.Name = "lblMaxNo"
        Me.lblMaxNo.Size = New System.Drawing.Size(46, 14)
        Me.lblMaxNo.TabIndex = 44
        Me.lblMaxNo.Text = "Bag No"
        Me.lblMaxNo.Visible = False
        '
        'txtCTransId
        '
        Me.txtCTransId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCTransId.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCTransId.Location = New System.Drawing.Point(323, 25)
        Me.txtCTransId.Name = "txtCTransId"
        Me.txtCTransId.ReadOnly = True
        '
        '
        '
        Me.txtCTransId.RootElement.ControlBounds = New System.Drawing.Rectangle(323, 25, 100, 20)
        Me.txtCTransId.RootElement.StretchVertically = True
        Me.txtCTransId.Size = New System.Drawing.Size(10, 20)
        Me.txtCTransId.TabIndex = 43
        Me.txtCTransId.Visible = False
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblItemName.Location = New System.Drawing.Point(485, 54)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(68, 14)
        Me.lblItemName.TabIndex = 21
        Me.lblItemName.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtItemName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtItemName.Location = New System.Drawing.Point(556, 51)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        '
        '
        '
        Me.txtItemName.RootElement.ControlBounds = New System.Drawing.Rectangle(556, 51, 100, 20)
        Me.txtItemName.RootElement.StretchVertically = True
        Me.txtItemName.Size = New System.Drawing.Size(133, 20)
        Me.txtItemName.TabIndex = 20
        '
        'txtCLotFailPr
        '
        Me.txtCLotFailPr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCLotFailPr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCLotFailPr.Location = New System.Drawing.Point(556, 105)
        Me.txtCLotFailPr.Name = "txtCLotFailPr"
        Me.txtCLotFailPr.ReadOnly = True
        '
        '
        '
        Me.txtCLotFailPr.RootElement.ControlBounds = New System.Drawing.Rectangle(556, 105, 100, 20)
        Me.txtCLotFailPr.RootElement.StretchVertically = True
        Me.txtCLotFailPr.Size = New System.Drawing.Size(100, 20)
        Me.txtCLotFailPr.TabIndex = 6
        Me.txtCLotFailPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCLotFailWt
        '
        Me.txtCLotFailWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCLotFailWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCLotFailWt.Location = New System.Drawing.Point(556, 78)
        Me.txtCLotFailWt.Name = "txtCLotFailWt"
        Me.txtCLotFailWt.ReadOnly = True
        '
        '
        '
        Me.txtCLotFailWt.RootElement.ControlBounds = New System.Drawing.Rectangle(556, 78, 100, 20)
        Me.txtCLotFailWt.RootElement.StretchVertically = True
        Me.txtCLotFailWt.Size = New System.Drawing.Size(100, 20)
        Me.txtCLotFailWt.TabIndex = 4
        Me.txtCLotFailWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(105, 105)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.ControlBounds = New System.Drawing.Rectangle(105, 105, 100, 20)
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(217, 64)
        Me.txtRemarks.TabIndex = 7
        '
        'txtLabour
        '
        Me.txtLabour.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtLabour.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtLabour.Location = New System.Drawing.Point(105, 78)
        Me.txtLabour.Name = "txtLabour"
        Me.txtLabour.ReadOnly = True
        '
        '
        '
        Me.txtLabour.RootElement.ControlBounds = New System.Drawing.Rectangle(105, 78, 100, 20)
        Me.txtLabour.RootElement.StretchVertically = True
        Me.txtLabour.Size = New System.Drawing.Size(217, 20)
        Me.txtLabour.TabIndex = 5
        '
        'txtOperation
        '
        Me.txtOperation.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOperation.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOperation.Location = New System.Drawing.Point(105, 51)
        Me.txtOperation.Name = "txtOperation"
        Me.txtOperation.ReadOnly = True
        '
        '
        '
        Me.txtOperation.RootElement.ControlBounds = New System.Drawing.Rectangle(105, 51, 100, 20)
        Me.txtOperation.RootElement.StretchVertically = True
        Me.txtOperation.Size = New System.Drawing.Size(217, 20)
        Me.txtOperation.TabIndex = 3
        '
        'TransDt
        '
        Me.TransDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TransDt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TransDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TransDt.Location = New System.Drawing.Point(105, 25)
        Me.TransDt.Name = "TransDt"
        '
        '
        '
        Me.TransDt.RootElement.ControlBounds = New System.Drawing.Rectangle(105, 25, 164, 20)
        Me.TransDt.RootElement.StretchVertically = True
        Me.TransDt.Size = New System.Drawing.Size(100, 20)
        Me.TransDt.TabIndex = 0
        Me.TransDt.TabStop = False
        Me.TransDt.Text = "01/03/2021"
        Me.TransDt.Value = New Date(2021, 3, 1, 13, 31, 38, 765)
        '
        'cmbCLotNo
        '
        Me.cmbCLotNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCLotNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbCLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbCLotNo.Location = New System.Drawing.Point(556, 25)
        Me.cmbCLotNo.Name = "cmbCLotNo"
        '
        '
        '
        Me.cmbCLotNo.RootElement.ControlBounds = New System.Drawing.Rectangle(556, 25, 125, 20)
        Me.cmbCLotNo.RootElement.StretchVertically = True
        Me.cmbCLotNo.Size = New System.Drawing.Size(100, 20)
        Me.cmbCLotNo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(491, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Lot Fail %"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(483, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Lot Fail Wt."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(49, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(59, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Karigar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(508, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lot No"
        '
        'lblKarigarName
        '
        Me.lblKarigarName.AutoSize = True
        Me.lblKarigarName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKarigarName.Location = New System.Drawing.Point(39, 28)
        Me.lblKarigarName.Name = "lblKarigarName"
        Me.lblKarigarName.Size = New System.Drawing.Size(62, 14)
        Me.lblKarigarName.TabIndex = 1
        Me.lblKarigarName.Text = "LotFail Dt."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GRBoxDetails)
        Me.TabPage2.Controls.Add(Me.GRBoxMain)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(706, 484)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receive LotFail Bag"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GRBoxDetails
        '
        Me.GRBoxDetails.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRBoxDetails.Controls.Add(Me.btnREdit)
        Me.GRBoxDetails.Controls.Add(Me.btnRExit)
        Me.GRBoxDetails.Controls.Add(Me.btnRCancel)
        Me.GRBoxDetails.Controls.Add(Me.btnRSave)
        Me.GRBoxDetails.Controls.Add(Me.dgvRLotFail)
        Me.GRBoxDetails.Controls.Add(Me.Label16)
        Me.GRBoxDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GRBoxDetails.Location = New System.Drawing.Point(5, 197)
        Me.GRBoxDetails.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GRBoxDetails.Name = "GRBoxDetails"
        Me.GRBoxDetails.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GRBoxDetails.Size = New System.Drawing.Size(691, 285)
        Me.GRBoxDetails.TabIndex = 26
        Me.GRBoxDetails.TabStop = False
        Me.GRBoxDetails.Text = "Bags Details"
        '
        'btnREdit
        '
        Me.btnREdit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnREdit.Location = New System.Drawing.Point(272, 253)
        Me.btnREdit.Name = "btnREdit"
        Me.btnREdit.Size = New System.Drawing.Size(75, 25)
        Me.btnREdit.TabIndex = 807
        Me.btnREdit.Text = "&Edit"
        '
        'btnRExit
        '
        Me.btnRExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnRExit.Location = New System.Drawing.Point(428, 253)
        Me.btnRExit.Name = "btnRExit"
        '
        '
        '
        Me.btnRExit.RootElement.ControlBounds = New System.Drawing.Rectangle(428, 253, 110, 24)
        Me.btnRExit.Size = New System.Drawing.Size(75, 25)
        Me.btnRExit.TabIndex = 76
        Me.btnRExit.Text = "E&xit"
        '
        'btnRCancel
        '
        Me.btnRCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnRCancel.Location = New System.Drawing.Point(350, 253)
        Me.btnRCancel.Name = "btnRCancel"
        '
        '
        '
        Me.btnRCancel.RootElement.ControlBounds = New System.Drawing.Rectangle(350, 253, 110, 24)
        Me.btnRCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnRCancel.TabIndex = 75
        Me.btnRCancel.Text = "&Cancel"
        '
        'btnRSave
        '
        Me.btnRSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRSave.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnRSave.Location = New System.Drawing.Point(194, 253)
        Me.btnRSave.Name = "btnRSave"
        '
        '
        '
        Me.btnRSave.RootElement.ControlBounds = New System.Drawing.Rectangle(194, 253, 110, 24)
        Me.btnRSave.Size = New System.Drawing.Size(75, 25)
        Me.btnRSave.TabIndex = 74
        Me.btnRSave.Text = "&Save"
        '
        'dgvRLotFail
        '
        Me.dgvRLotFail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRLotFail.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvRLotFail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvRLotFail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvRLotFail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvRLotFail.Location = New System.Drawing.Point(7, 25)
        '
        '
        '
        Me.dgvRLotFail.MasterTemplate.AllowAddNewRow = False
        Me.dgvRLotFail.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "LotFailId"
        GridViewTextBoxColumn1.HeaderText = "LotFail Id."
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "colLotFailId"
        GridViewDateTimeColumn1.EnableExpressionEditor = False
        GridViewDateTimeColumn1.FieldName = "LotFailBagNo"
        GridViewDateTimeColumn1.HeaderText = "LotFail Bag"
        GridViewDateTimeColumn1.Name = "colLotFailBag"
        GridViewDateTimeColumn1.Width = 83
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "LotNo"
        GridViewTextBoxColumn2.HeaderText = "Lot No."
        GridViewTextBoxColumn2.Name = "colLotNo"
        GridViewTextBoxColumn2.Width = 80
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "OperationId"
        GridViewTextBoxColumn3.HeaderText = "Operation Id."
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "colOperationId"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn3.Width = 100
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "OperationName"
        GridViewTextBoxColumn4.HeaderText = "Operation Name"
        GridViewTextBoxColumn4.Name = "colOperationName"
        GridViewTextBoxColumn4.Width = 120
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "LotFailWt"
        GridViewTextBoxColumn5.HeaderText = "LotFail Wt."
        GridViewTextBoxColumn5.Name = "colLotFailWt"
        GridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 80
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "LotFailPr"
        GridViewTextBoxColumn6.HeaderText = "LotFail  [%]"
        GridViewTextBoxColumn6.Name = "colLotFailPr"
        GridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn6.Width = 80
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "FineWt"
        GridViewTextBoxColumn7.HeaderText = "Fine Wt."
        GridViewTextBoxColumn7.Name = "colFineWt"
        GridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn7.Width = 80
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "Remark"
        GridViewTextBoxColumn8.HeaderText = "Remark"
        GridViewTextBoxColumn8.Name = "colRemark"
        GridViewTextBoxColumn8.Width = 160
        Me.dgvRLotFail.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewDateTimeColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8})
        Me.dgvRLotFail.MasterTemplate.EnableGrouping = False
        Me.dgvRLotFail.MasterTemplate.ShowRowHeaderColumn = False
        SortDescriptor1.PropertyName = "colLotFailWt"
        Me.dgvRLotFail.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.dgvRLotFail.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvRLotFail.Name = "dgvRLotFail"
        Me.dgvRLotFail.ReadOnly = True
        Me.dgvRLotFail.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.dgvRLotFail.RootElement.ControlBounds = New System.Drawing.Rectangle(7, 25, 240, 150)
        Me.dgvRLotFail.Size = New System.Drawing.Size(678, 220)
        Me.dgvRLotFail.TabIndex = 73
        Me.dgvRLotFail.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 21)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 15)
        Me.Label16.TabIndex = 12
        '
        'GRBoxMain
        '
        Me.GRBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRBoxMain.Controls.Add(Me.cmbRBagNo)
        Me.GRBoxMain.Controls.Add(Me.txtRBagName)
        Me.GRBoxMain.Controls.Add(Me.lblRBagSrNo)
        Me.GRBoxMain.Controls.Add(Me.Label12)
        Me.GRBoxMain.Controls.Add(Me.txtRGrossLoss)
        Me.GRBoxMain.Controls.Add(Me.txtRCarbon)
        Me.GRBoxMain.Controls.Add(Me.txtRTotalWt)
        Me.GRBoxMain.Controls.Add(Me.txtRSample)
        Me.GRBoxMain.Controls.Add(Me.txtRReceiveWt)
        Me.GRBoxMain.Controls.Add(Me.txtRWtOnScale)
        Me.GRBoxMain.Controls.Add(Me.txtRLotFailPr)
        Me.GRBoxMain.Controls.Add(Me.txtRLotFailWt)
        Me.GRBoxMain.Controls.Add(Me.txtRTransId)
        Me.GRBoxMain.Controls.Add(Me.RTransDt)
        Me.GRBoxMain.Controls.Add(Me.Label10)
        Me.GRBoxMain.Controls.Add(Me.Label9)
        Me.GRBoxMain.Controls.Add(Me.Label8)
        Me.GRBoxMain.Controls.Add(Me.Label5)
        Me.GRBoxMain.Controls.Add(Me.Label11)
        Me.GRBoxMain.Controls.Add(Me.Label13)
        Me.GRBoxMain.Controls.Add(Me.Label14)
        Me.GRBoxMain.Controls.Add(Me.lblLotNo)
        Me.GRBoxMain.Controls.Add(Me.Label15)
        Me.GRBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GRBoxMain.Location = New System.Drawing.Point(5, 9)
        Me.GRBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GRBoxMain.Name = "GRBoxMain"
        Me.GRBoxMain.Size = New System.Drawing.Size(691, 183)
        Me.GRBoxMain.TabIndex = 19
        Me.GRBoxMain.TabStop = False
        Me.GRBoxMain.Text = "Receive LotFail Bag"
        '
        'cmbRBagNo
        '
        Me.cmbRBagNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'cmbRBagNo.NestedRadGridView
        '
        Me.cmbRBagNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRBagNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRBagNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbRBagNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cmbRBagNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cmbRBagNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cmbRBagNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cmbRBagNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cmbRBagNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cmbRBagNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.cmbRBagNo.EditorControl.Name = "NestedRadGridView"
        Me.cmbRBagNo.EditorControl.ReadOnly = True
        Me.cmbRBagNo.EditorControl.ShowGroupPanel = False
        Me.cmbRBagNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cmbRBagNo.EditorControl.TabIndex = 0
        Me.cmbRBagNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbRBagNo.Location = New System.Drawing.Point(109, 51)
        Me.cmbRBagNo.Name = "cmbRBagNo"
        Me.cmbRBagNo.Size = New System.Drawing.Size(147, 20)
        Me.cmbRBagNo.TabIndex = 50
        Me.cmbRBagNo.TabStop = False
        '
        'txtRBagName
        '
        Me.txtRBagName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRBagName.Location = New System.Drawing.Point(109, 77)
        Me.txtRBagName.Name = "txtRBagName"
        Me.txtRBagName.ReadOnly = True
        Me.txtRBagName.Size = New System.Drawing.Size(147, 20)
        Me.txtRBagName.TabIndex = 49
        '
        'lblRBagSrNo
        '
        Me.lblRBagSrNo.AutoSize = True
        Me.lblRBagSrNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblRBagSrNo.Location = New System.Drawing.Point(47, 54)
        Me.lblRBagSrNo.Name = "lblRBagSrNo"
        Me.lblRBagSrNo.Size = New System.Drawing.Size(59, 14)
        Me.lblRBagSrNo.TabIndex = 48
        Me.lblRBagSrNo.Text = "Bag Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(536, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 14)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Wt. On Scale"
        '
        'txtRGrossLoss
        '
        Me.txtRGrossLoss.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRGrossLoss.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRGrossLoss.Location = New System.Drawing.Point(619, 155)
        Me.txtRGrossLoss.Name = "txtRGrossLoss"
        Me.txtRGrossLoss.ReadOnly = True
        '
        '
        '
        Me.txtRGrossLoss.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 155, 100, 20)
        Me.txtRGrossLoss.RootElement.StretchVertically = True
        Me.txtRGrossLoss.Size = New System.Drawing.Size(60, 20)
        Me.txtRGrossLoss.TabIndex = 45
        Me.txtRGrossLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRCarbon
        '
        Me.txtRCarbon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRCarbon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRCarbon.Location = New System.Drawing.Point(619, 129)
        Me.txtRCarbon.Name = "txtRCarbon"
        '
        '
        '
        Me.txtRCarbon.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 129, 100, 20)
        Me.txtRCarbon.RootElement.StretchVertically = True
        Me.txtRCarbon.Size = New System.Drawing.Size(60, 20)
        Me.txtRCarbon.TabIndex = 44
        Me.txtRCarbon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRTotalWt
        '
        Me.txtRTotalWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRTotalWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRTotalWt.Location = New System.Drawing.Point(619, 103)
        Me.txtRTotalWt.Name = "txtRTotalWt"
        Me.txtRTotalWt.ReadOnly = True
        '
        '
        '
        Me.txtRTotalWt.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 103, 100, 20)
        Me.txtRTotalWt.RootElement.StretchVertically = True
        Me.txtRTotalWt.Size = New System.Drawing.Size(60, 20)
        Me.txtRTotalWt.TabIndex = 43
        Me.txtRTotalWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRSample
        '
        Me.txtRSample.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRSample.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRSample.Location = New System.Drawing.Point(619, 77)
        Me.txtRSample.Name = "txtRSample"
        '
        '
        '
        Me.txtRSample.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 77, 100, 20)
        Me.txtRSample.RootElement.StretchVertically = True
        Me.txtRSample.Size = New System.Drawing.Size(60, 20)
        Me.txtRSample.TabIndex = 42
        Me.txtRSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRReceiveWt
        '
        Me.txtRReceiveWt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRReceiveWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRReceiveWt.Location = New System.Drawing.Point(619, 51)
        Me.txtRReceiveWt.Name = "txtRReceiveWt"
        '
        '
        '
        Me.txtRReceiveWt.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 51, 100, 20)
        Me.txtRReceiveWt.RootElement.StretchVertically = True
        Me.txtRReceiveWt.Size = New System.Drawing.Size(60, 20)
        Me.txtRReceiveWt.TabIndex = 40
        Me.txtRReceiveWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRWtOnScale
        '
        Me.txtRWtOnScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRWtOnScale.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRWtOnScale.Location = New System.Drawing.Point(619, 25)
        Me.txtRWtOnScale.Name = "txtRWtOnScale"
        '
        '
        '
        Me.txtRWtOnScale.RootElement.ControlBounds = New System.Drawing.Rectangle(619, 25, 100, 20)
        Me.txtRWtOnScale.RootElement.StretchVertically = True
        Me.txtRWtOnScale.Size = New System.Drawing.Size(60, 20)
        Me.txtRWtOnScale.TabIndex = 39
        Me.txtRWtOnScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRLotFailPr
        '
        Me.txtRLotFailPr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRLotFailPr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRLotFailPr.Location = New System.Drawing.Point(109, 129)
        Me.txtRLotFailPr.Name = "txtRLotFailPr"
        Me.txtRLotFailPr.ReadOnly = True
        '
        '
        '
        Me.txtRLotFailPr.RootElement.ControlBounds = New System.Drawing.Rectangle(109, 129, 100, 20)
        Me.txtRLotFailPr.RootElement.StretchVertically = True
        Me.txtRLotFailPr.Size = New System.Drawing.Size(85, 20)
        Me.txtRLotFailPr.TabIndex = 37
        Me.txtRLotFailPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRLotFailWt
        '
        Me.txtRLotFailWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRLotFailWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRLotFailWt.Location = New System.Drawing.Point(109, 103)
        Me.txtRLotFailWt.Name = "txtRLotFailWt"
        Me.txtRLotFailWt.ReadOnly = True
        '
        '
        '
        Me.txtRLotFailWt.RootElement.ControlBounds = New System.Drawing.Rectangle(109, 103, 100, 20)
        Me.txtRLotFailWt.RootElement.StretchVertically = True
        Me.txtRLotFailWt.Size = New System.Drawing.Size(85, 20)
        Me.txtRLotFailWt.TabIndex = 36
        Me.txtRLotFailWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRTransId
        '
        Me.txtRTransId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRTransId.Location = New System.Drawing.Point(213, 25)
        Me.txtRTransId.Name = "txtRTransId"
        '
        '
        '
        Me.txtRTransId.RootElement.ControlBounds = New System.Drawing.Rectangle(213, 25, 100, 20)
        Me.txtRTransId.RootElement.StretchVertically = True
        Me.txtRTransId.Size = New System.Drawing.Size(10, 20)
        Me.txtRTransId.TabIndex = 34
        Me.txtRTransId.Visible = False
        '
        'RTransDt
        '
        Me.RTransDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RTransDt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RTransDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RTransDt.Location = New System.Drawing.Point(109, 25)
        Me.RTransDt.Name = "RTransDt"
        '
        '
        '
        Me.RTransDt.RootElement.ControlBounds = New System.Drawing.Rectangle(109, 25, 164, 20)
        Me.RTransDt.RootElement.StretchVertically = True
        Me.RTransDt.Size = New System.Drawing.Size(100, 20)
        Me.RTransDt.TabIndex = 33
        Me.RTransDt.TabStop = False
        Me.RTransDt.Text = "01/03/2021"
        Me.RTransDt.Value = New Date(2021, 3, 1, 14, 56, 36, 761)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(553, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Gross Loss"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(518, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Carbon Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(528, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 14)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Received"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(517, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Sample Received"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(528, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 14)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Lagdi Received"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(55, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 14)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Issue %"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(46, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 14)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Issue Wt."
        '
        'lblLotNo
        '
        Me.lblLotNo.AutoSize = True
        Me.lblLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblLotNo.Location = New System.Drawing.Point(44, 80)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(62, 14)
        Me.lblLotNo.TabIndex = 3
        Me.lblLotNo.Text = "Bag Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 14)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Transfer Dt."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnUSave)
        Me.TabPage3.Controls.Add(Me.btnUEdit)
        Me.TabPage3.Controls.Add(Me.btnUExit)
        Me.TabPage3.Controls.Add(Me.btnUCancel)
        Me.TabPage3.Controls.Add(Me.GUBoxMain)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(706, 484)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update LotFail  Bag"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnUSave
        '
        Me.btnUSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUSave.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUSave.Location = New System.Drawing.Point(199, 445)
        Me.btnUSave.Name = "btnUSave"
        Me.btnUSave.Size = New System.Drawing.Size(75, 25)
        Me.btnUSave.TabIndex = 808
        Me.btnUSave.Text = "&Save"
        '
        'btnUEdit
        '
        Me.btnUEdit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUEdit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUEdit.Location = New System.Drawing.Point(276, 445)
        Me.btnUEdit.Name = "btnUEdit"
        Me.btnUEdit.Size = New System.Drawing.Size(75, 25)
        Me.btnUEdit.TabIndex = 807
        Me.btnUEdit.Text = "&Edit"
        '
        'btnUExit
        '
        Me.btnUExit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUExit.Location = New System.Drawing.Point(430, 445)
        Me.btnUExit.Name = "btnUExit"
        '
        '
        '
        Me.btnUExit.RootElement.ControlBounds = New System.Drawing.Rectangle(430, 445, 110, 24)
        Me.btnUExit.Size = New System.Drawing.Size(75, 25)
        Me.btnUExit.TabIndex = 77
        Me.btnUExit.Text = "E&xit"
        '
        'btnUCancel
        '
        Me.btnUCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnUCancel.Location = New System.Drawing.Point(353, 445)
        Me.btnUCancel.Name = "btnUCancel"
        '
        '
        '
        Me.btnUCancel.RootElement.ControlBounds = New System.Drawing.Rectangle(353, 445, 110, 24)
        Me.btnUCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnUCancel.TabIndex = 23
        Me.btnUCancel.Text = "&Cancel"
        '
        'GUBoxMain
        '
        Me.GUBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GUBoxMain.Controls.Add(Me.cmbUpdBagNo)
        Me.GUBoxMain.Controls.Add(Me.txtUBagSrNo)
        Me.GUBoxMain.Controls.Add(Me.lblUBagSrNo)
        Me.GUBoxMain.Controls.Add(Me.RadCollapsiblePanel1)
        Me.GUBoxMain.Controls.Add(Me.txtUTransId)
        Me.GUBoxMain.Controls.Add(Me.UTransDt)
        Me.GUBoxMain.Controls.Add(Me.lblUBagType)
        Me.GUBoxMain.Controls.Add(Me.Label29)
        Me.GUBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GUBoxMain.Location = New System.Drawing.Point(8, 9)
        Me.GUBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GUBoxMain.Name = "GUBoxMain"
        Me.GUBoxMain.Size = New System.Drawing.Size(690, 333)
        Me.GUBoxMain.TabIndex = 21
        Me.GUBoxMain.TabStop = False
        Me.GUBoxMain.Text = "Update LotFail Bag"
        '
        'cmbUpdBagNo
        '
        Me.cmbUpdBagNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'cmbUpdBagNo.NestedRadGridView
        '
        Me.cmbUpdBagNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUpdBagNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUpdBagNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbUpdBagNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cmbUpdBagNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.cmbUpdBagNo.EditorControl.Name = "NestedRadGridView"
        Me.cmbUpdBagNo.EditorControl.ReadOnly = True
        Me.cmbUpdBagNo.EditorControl.ShowGroupPanel = False
        Me.cmbUpdBagNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cmbUpdBagNo.EditorControl.TabIndex = 0
        Me.cmbUpdBagNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmbUpdBagNo.Location = New System.Drawing.Point(120, 50)
        Me.cmbUpdBagNo.Name = "cmbUpdBagNo"
        Me.cmbUpdBagNo.Size = New System.Drawing.Size(145, 20)
        Me.cmbUpdBagNo.TabIndex = 52
        Me.cmbUpdBagNo.TabStop = False
        '
        'txtUBagSrNo
        '
        Me.txtUBagSrNo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUBagSrNo.Location = New System.Drawing.Point(120, 75)
        Me.txtUBagSrNo.Name = "txtUBagSrNo"
        Me.txtUBagSrNo.ReadOnly = True
        Me.txtUBagSrNo.Size = New System.Drawing.Size(145, 20)
        Me.txtUBagSrNo.TabIndex = 51
        '
        'lblUBagSrNo
        '
        Me.lblUBagSrNo.AutoSize = True
        Me.lblUBagSrNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUBagSrNo.Location = New System.Drawing.Point(56, 53)
        Me.lblUBagSrNo.Name = "lblUBagSrNo"
        Me.lblUBagSrNo.Size = New System.Drawing.Size(61, 14)
        Me.lblUBagSrNo.TabIndex = 44
        Me.lblUBagSrNo.Text = "Bag Sr No"
        '
        'RadCollapsiblePanel1
        '
        Me.RadCollapsiblePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadCollapsiblePanel1.Location = New System.Drawing.Point(24, 131)
        Me.RadCollapsiblePanel1.Name = "RadCollapsiblePanel1"
        '
        'RadCollapsiblePanel1.PanelContainer
        '
        Me.RadCollapsiblePanel1.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUcarbonReceive)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUWtOnScale)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUIssueFineWt)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUIssueWt)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUIssuePr)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtULossFine)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUGrossLoss)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUreceiveFineWt)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUreceiveWt)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.txtUReceivePr)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel11)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel10)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel9)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel8)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel7)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel6)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel5)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel4)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel3)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadLabel2)
        Me.RadCollapsiblePanel1.PanelContainer.Size = New System.Drawing.Size(633, 157)
        '
        '
        '
        Me.RadCollapsiblePanel1.RootElement.ControlBounds = New System.Drawing.Rectangle(24, 131, 150, 200)
        Me.RadCollapsiblePanel1.ShowHeaderLine = False
        Me.RadCollapsiblePanel1.Size = New System.Drawing.Size(635, 185)
        Me.RadCollapsiblePanel1.TabIndex = 43
        '
        'txtUcarbonReceive
        '
        Me.txtUcarbonReceive.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUcarbonReceive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUcarbonReceive.Location = New System.Drawing.Point(565, 118)
        Me.txtUcarbonReceive.Name = "txtUcarbonReceive"
        Me.txtUcarbonReceive.ReadOnly = True
        '
        '
        '
        Me.txtUcarbonReceive.RootElement.ControlBounds = New System.Drawing.Rectangle(565, 118, 100, 20)
        Me.txtUcarbonReceive.RootElement.StretchVertically = True
        Me.txtUcarbonReceive.Size = New System.Drawing.Size(60, 20)
        Me.txtUcarbonReceive.TabIndex = 19
        Me.txtUcarbonReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUWtOnScale
        '
        Me.txtUWtOnScale.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUWtOnScale.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUWtOnScale.Location = New System.Drawing.Point(565, 93)
        Me.txtUWtOnScale.Name = "txtUWtOnScale"
        Me.txtUWtOnScale.ReadOnly = True
        '
        '
        '
        Me.txtUWtOnScale.RootElement.ControlBounds = New System.Drawing.Rectangle(565, 93, 100, 20)
        Me.txtUWtOnScale.RootElement.StretchVertically = True
        Me.txtUWtOnScale.Size = New System.Drawing.Size(60, 20)
        Me.txtUWtOnScale.TabIndex = 18
        Me.txtUWtOnScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUIssueFineWt
        '
        Me.txtUIssueFineWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUIssueFineWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUIssueFineWt.Location = New System.Drawing.Point(565, 68)
        Me.txtUIssueFineWt.Name = "txtUIssueFineWt"
        Me.txtUIssueFineWt.ReadOnly = True
        '
        '
        '
        Me.txtUIssueFineWt.RootElement.ControlBounds = New System.Drawing.Rectangle(565, 68, 100, 20)
        Me.txtUIssueFineWt.RootElement.StretchVertically = True
        Me.txtUIssueFineWt.Size = New System.Drawing.Size(60, 20)
        Me.txtUIssueFineWt.TabIndex = 17
        Me.txtUIssueFineWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUIssueWt
        '
        Me.txtUIssueWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUIssueWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUIssueWt.Location = New System.Drawing.Point(565, 43)
        Me.txtUIssueWt.Name = "txtUIssueWt"
        Me.txtUIssueWt.ReadOnly = True
        '
        '
        '
        Me.txtUIssueWt.RootElement.ControlBounds = New System.Drawing.Rectangle(565, 43, 100, 20)
        Me.txtUIssueWt.RootElement.StretchVertically = True
        Me.txtUIssueWt.Size = New System.Drawing.Size(60, 20)
        Me.txtUIssueWt.TabIndex = 16
        Me.txtUIssueWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUIssuePr
        '
        Me.txtUIssuePr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUIssuePr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUIssuePr.Location = New System.Drawing.Point(565, 18)
        Me.txtUIssuePr.Name = "txtUIssuePr"
        Me.txtUIssuePr.ReadOnly = True
        '
        '
        '
        Me.txtUIssuePr.RootElement.ControlBounds = New System.Drawing.Rectangle(565, 18, 100, 20)
        Me.txtUIssuePr.RootElement.StretchVertically = True
        Me.txtUIssuePr.Size = New System.Drawing.Size(60, 20)
        Me.txtUIssuePr.TabIndex = 15
        Me.txtUIssuePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtULossFine
        '
        Me.txtULossFine.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtULossFine.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtULossFine.Location = New System.Drawing.Point(117, 118)
        Me.txtULossFine.Name = "txtULossFine"
        Me.txtULossFine.ReadOnly = True
        '
        '
        '
        Me.txtULossFine.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 118, 100, 20)
        Me.txtULossFine.RootElement.StretchVertically = True
        Me.txtULossFine.Size = New System.Drawing.Size(60, 20)
        Me.txtULossFine.TabIndex = 14
        Me.txtULossFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUGrossLoss
        '
        Me.txtUGrossLoss.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUGrossLoss.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUGrossLoss.Location = New System.Drawing.Point(117, 93)
        Me.txtUGrossLoss.Name = "txtUGrossLoss"
        Me.txtUGrossLoss.ReadOnly = True
        '
        '
        '
        Me.txtUGrossLoss.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 93, 100, 20)
        Me.txtUGrossLoss.RootElement.StretchVertically = True
        Me.txtUGrossLoss.Size = New System.Drawing.Size(60, 20)
        Me.txtUGrossLoss.TabIndex = 13
        Me.txtUGrossLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUreceiveFineWt
        '
        Me.txtUreceiveFineWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUreceiveFineWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUreceiveFineWt.Location = New System.Drawing.Point(117, 68)
        Me.txtUreceiveFineWt.Name = "txtUreceiveFineWt"
        Me.txtUreceiveFineWt.ReadOnly = True
        '
        '
        '
        Me.txtUreceiveFineWt.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 68, 100, 20)
        Me.txtUreceiveFineWt.RootElement.StretchVertically = True
        Me.txtUreceiveFineWt.Size = New System.Drawing.Size(60, 20)
        Me.txtUreceiveFineWt.TabIndex = 12
        Me.txtUreceiveFineWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUreceiveWt
        '
        Me.txtUreceiveWt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUreceiveWt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUreceiveWt.Location = New System.Drawing.Point(117, 43)
        Me.txtUreceiveWt.Name = "txtUreceiveWt"
        Me.txtUreceiveWt.ReadOnly = True
        '
        '
        '
        Me.txtUreceiveWt.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 43, 100, 20)
        Me.txtUreceiveWt.RootElement.StretchVertically = True
        Me.txtUreceiveWt.Size = New System.Drawing.Size(60, 20)
        Me.txtUreceiveWt.TabIndex = 11
        Me.txtUreceiveWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUReceivePr
        '
        Me.txtUReceivePr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUReceivePr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUReceivePr.Location = New System.Drawing.Point(117, 18)
        Me.txtUReceivePr.Name = "txtUReceivePr"
        '
        '
        '
        Me.txtUReceivePr.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 18, 100, 20)
        Me.txtUReceivePr.RootElement.StretchVertically = True
        Me.txtUReceivePr.Size = New System.Drawing.Size(60, 20)
        Me.txtUReceivePr.TabIndex = 10
        Me.txtUReceivePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel11
        '
        Me.RadLabel11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel11.Location = New System.Drawing.Point(470, 119)
        Me.RadLabel11.Name = "RadLabel11"
        '
        '
        '
        Me.RadLabel11.RootElement.ControlBounds = New System.Drawing.Rectangle(470, 119, 100, 18)
        Me.RadLabel11.Size = New System.Drawing.Size(91, 18)
        Me.RadLabel11.TabIndex = 9
        Me.RadLabel11.Text = "Carbon Receive"
        '
        'RadLabel10
        '
        Me.RadLabel10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel10.Location = New System.Drawing.Point(484, 94)
        Me.RadLabel10.Name = "RadLabel10"
        '
        '
        '
        Me.RadLabel10.RootElement.ControlBounds = New System.Drawing.Rectangle(484, 94, 100, 18)
        Me.RadLabel10.Size = New System.Drawing.Size(77, 18)
        Me.RadLabel10.TabIndex = 8
        Me.RadLabel10.Text = "Wt. On Scale"
        '
        'RadLabel9
        '
        Me.RadLabel9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel9.Location = New System.Drawing.Point(472, 70)
        Me.RadLabel9.Name = "RadLabel9"
        '
        '
        '
        Me.RadLabel9.RootElement.ControlBounds = New System.Drawing.Rectangle(472, 70, 100, 18)
        Me.RadLabel9.Size = New System.Drawing.Size(89, 18)
        Me.RadLabel9.TabIndex = 7
        Me.RadLabel9.Text = "Issue  Fine Wt."
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel8.Location = New System.Drawing.Point(503, 44)
        Me.RadLabel8.Name = "RadLabel8"
        '
        '
        '
        Me.RadLabel8.RootElement.ControlBounds = New System.Drawing.Rectangle(503, 44, 100, 18)
        Me.RadLabel8.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel8.TabIndex = 6
        Me.RadLabel8.Text = "Issue Wt."
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel7.Location = New System.Drawing.Point(510, 20)
        Me.RadLabel7.Name = "RadLabel7"
        '
        '
        '
        Me.RadLabel7.RootElement.ControlBounds = New System.Drawing.Rectangle(510, 20, 100, 18)
        Me.RadLabel7.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel7.TabIndex = 5
        Me.RadLabel7.Text = "Issue %"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel6.Location = New System.Drawing.Point(55, 119)
        Me.RadLabel6.Name = "RadLabel6"
        '
        '
        '
        Me.RadLabel6.RootElement.ControlBounds = New System.Drawing.Rectangle(55, 119, 100, 18)
        Me.RadLabel6.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel6.TabIndex = 4
        Me.RadLabel6.Text = "Loss Fine"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel5.Location = New System.Drawing.Point(47, 95)
        Me.RadLabel5.Name = "RadLabel5"
        '
        '
        '
        Me.RadLabel5.RootElement.ControlBounds = New System.Drawing.Rectangle(47, 95, 100, 18)
        Me.RadLabel5.Size = New System.Drawing.Size(65, 18)
        Me.RadLabel5.TabIndex = 3
        Me.RadLabel5.Text = "Gross Loss"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel4.Location = New System.Drawing.Point(14, 70)
        Me.RadLabel4.Name = "RadLabel4"
        '
        '
        '
        Me.RadLabel4.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 70, 100, 18)
        Me.RadLabel4.Size = New System.Drawing.Size(98, 18)
        Me.RadLabel4.TabIndex = 2
        Me.RadLabel4.Text = "Receive Fine Wt."
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(41, 44)
        Me.RadLabel3.Name = "RadLabel3"
        '
        '
        '
        Me.RadLabel3.RootElement.ControlBounds = New System.Drawing.Rectangle(41, 44, 100, 18)
        Me.RadLabel3.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel3.TabIndex = 1
        Me.RadLabel3.Text = "Receive Wt."
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(48, 19)
        Me.RadLabel2.Name = "RadLabel2"
        '
        '
        '
        Me.RadLabel2.RootElement.ControlBounds = New System.Drawing.Rectangle(48, 19, 100, 18)
        Me.RadLabel2.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = "Receive %"
        '
        'txtUTransId
        '
        Me.txtUTransId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUTransId.Location = New System.Drawing.Point(222, 25)
        Me.txtUTransId.Name = "txtUTransId"
        '
        '
        '
        Me.txtUTransId.RootElement.ControlBounds = New System.Drawing.Rectangle(214, 25, 100, 20)
        Me.txtUTransId.RootElement.StretchVertically = True
        Me.txtUTransId.Size = New System.Drawing.Size(10, 20)
        Me.txtUTransId.TabIndex = 42
        Me.txtUTransId.Visible = False
        '
        'UTransDt
        '
        Me.UTransDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UTransDt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.UTransDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.UTransDt.Location = New System.Drawing.Point(120, 25)
        Me.UTransDt.Name = "UTransDt"
        '
        '
        '
        Me.UTransDt.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 25, 164, 20)
        Me.UTransDt.RootElement.StretchVertically = True
        Me.UTransDt.Size = New System.Drawing.Size(100, 20)
        Me.UTransDt.TabIndex = 41
        Me.UTransDt.TabStop = False
        Me.UTransDt.Text = "01/03/2021"
        Me.UTransDt.Value = New Date(2021, 3, 1, 16, 27, 25, 218)
        '
        'lblUBagType
        '
        Me.lblUBagType.AutoSize = True
        Me.lblUBagType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUBagType.Location = New System.Drawing.Point(58, 78)
        Me.lblUBagType.Name = "lblUBagType"
        Me.lblUBagType.Size = New System.Drawing.Size(59, 14)
        Me.lblUBagType.TabIndex = 3
        Me.lblUBagType.Text = "Bag Type"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(44, 28)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 14)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Transfer Dt."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvFinalUpdate)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(706, 484)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Edit Data"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvFinalUpdate
        '
        Me.dgvFinalUpdate.BackColor = System.Drawing.Color.Transparent
        Me.dgvFinalUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvFinalUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvFinalUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvFinalUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvFinalUpdate.Location = New System.Drawing.Point(2, 2)
        '
        '
        '
        Me.dgvFinalUpdate.MasterTemplate.AllowAddNewRow = False
        Me.dgvFinalUpdate.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "UsedBagId"
        GridViewTextBoxColumn9.HeaderText = "UsedBag Id."
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "colUsedBagId"
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "BagName"
        GridViewTextBoxColumn10.HeaderText = "Bag Name"
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "colBagName"
        GridViewTextBoxColumn10.Width = 100
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "BagSrNo"
        GridViewTextBoxColumn11.HeaderText = "Bag Sr No"
        GridViewTextBoxColumn11.Name = "colBagSrNo"
        GridViewTextBoxColumn11.Width = 120
        GridViewTextBoxColumn12.EnableExpressionEditor = False
        GridViewTextBoxColumn12.FieldName = "ReceiveWt"
        GridViewTextBoxColumn12.HeaderText = "Receive Wt."
        GridViewTextBoxColumn12.Name = "colReceiveWt"
        GridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn12.Width = 90
        GridViewTextBoxColumn13.EnableExpressionEditor = False
        GridViewTextBoxColumn13.FieldName = "TFSampleWt"
        GridViewTextBoxColumn13.HeaderText = "TF Sample Wt."
        GridViewTextBoxColumn13.Name = "colTFSampleWt"
        GridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn13.Width = 90
        GridViewTextBoxColumn14.EnableExpressionEditor = False
        GridViewTextBoxColumn14.FieldName = "WtOnScale"
        GridViewTextBoxColumn14.HeaderText = "Wt On Scale"
        GridViewTextBoxColumn14.Name = "colWtOnScale"
        GridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn14.Width = 90
        GridViewTextBoxColumn15.EnableExpressionEditor = False
        GridViewTextBoxColumn15.FieldName = "CarbonReceive"
        GridViewTextBoxColumn15.HeaderText = "Carbon Receive"
        GridViewTextBoxColumn15.Name = "colCarbonReceive"
        GridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn15.Width = 110
        GridViewTextBoxColumn16.EnableExpressionEditor = False
        GridViewTextBoxColumn16.FieldName = "ReportPr"
        GridViewTextBoxColumn16.HeaderText = "Report [%]"
        GridViewTextBoxColumn16.Name = "colReportPr"
        GridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn16.Width = 90
        Me.dgvFinalUpdate.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16})
        Me.dgvFinalUpdate.MasterTemplate.EnableGrouping = False
        Me.dgvFinalUpdate.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvFinalUpdate.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.dgvFinalUpdate.Name = "dgvFinalUpdate"
        Me.dgvFinalUpdate.ReadOnly = True
        Me.dgvFinalUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvFinalUpdate.Size = New System.Drawing.Size(702, 480)
        Me.dgvFinalUpdate.TabIndex = 0
        '
        'frmLotFailBag
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(714, 511)
        Me.Controls.Add(Me.tbLotFail)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(105, 25)
        Me.MaximizeBox = False
        Me.Name = "frmLotFailBag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LotFail Bags"
        Me.tbLotFail.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBoxMain.ResumeLayout(False)
        Me.GCBoxMain.PerformLayout()
        CType(Me.txtMaxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCTransId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCLotFailPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCLotFailWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLabour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GRBoxDetails.ResumeLayout(False)
        Me.GRBoxDetails.PerformLayout()
        CType(Me.btnREdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRLotFail.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRLotFail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBoxMain.ResumeLayout(False)
        Me.GRBoxMain.PerformLayout()
        CType(Me.cmbRBagNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRBagNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRBagNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRBagName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRGrossLoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRCarbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRTotalWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRReceiveWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRWtOnScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRLotFailPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRLotFailWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRTransId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTransDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.btnUSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GUBoxMain.ResumeLayout(False)
        Me.GUBoxMain.PerformLayout()
        CType(Me.cmbUpdBagNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUpdBagNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUpdBagNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUBagSrNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCollapsiblePanel1.PanelContainer.ResumeLayout(False)
        Me.RadCollapsiblePanel1.PanelContainer.PerformLayout()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUcarbonReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUWtOnScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUIssueFineWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUIssueWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUIssuePr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtULossFine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUGrossLoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUreceiveFineWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUreceiveWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUReceivePr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUTransId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UTransDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvFinalUpdate.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinalUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbLotFail As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GCBoxMain As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKarigarName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GRBoxMain As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblLotNo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GRBoxDetails As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GUBoxMain As GroupBox
    Friend WithEvents lblUBagType As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRBagSrNo As Label
    Friend WithEvents lblUBagSrNo As Label
    Friend WithEvents lblItemName As Label
    Private WithEvents cmbCLotNo As Telerik.WinControls.UI.RadDropDownList
    Private WithEvents TransDt As Telerik.WinControls.UI.RadDateTimePicker
    Private WithEvents txtCLotFailPr As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtCLotFailWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtLabour As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtOperation As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRTransId As Telerik.WinControls.UI.RadTextBox
    Private WithEvents RTransDt As Telerik.WinControls.UI.RadDateTimePicker
    Private WithEvents txtRLotFailPr As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRLotFailWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRReceiveWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRWtOnScale As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRSample As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRCarbon As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRTotalWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtRGrossLoss As Telerik.WinControls.UI.RadTextBox
    Private WithEvents dgvRLotFail As Telerik.WinControls.UI.RadGridView
    Private WithEvents btnRCancel As Telerik.WinControls.UI.RadButton
    Private WithEvents btnRSave As Telerik.WinControls.UI.RadButton
    Private WithEvents txtUTransId As Telerik.WinControls.UI.RadTextBox
    Private WithEvents UTransDt As Telerik.WinControls.UI.RadDateTimePicker
    Private WithEvents RadCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
    Private WithEvents txtUcarbonReceive As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUWtOnScale As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUIssueFineWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUIssueWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUIssuePr As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtULossFine As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUGrossLoss As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUreceiveFineWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUreceiveWt As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtUReceivePr As Telerik.WinControls.UI.RadTextBox
    Private WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Private WithEvents btnUCancel As Telerik.WinControls.UI.RadButton
    Private WithEvents btnRExit As Telerik.WinControls.UI.RadButton
    Private WithEvents btnUExit As Telerik.WinControls.UI.RadButton
    Private WithEvents txtItemName As Telerik.WinControls.UI.RadTextBox
    Private WithEvents txtCTransId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmbRBagNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtRBagName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtUBagSrNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmbUpdBagNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnREdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnUEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvFinalUpdate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnUSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtMaxNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblMaxNo As Label
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
End Class
