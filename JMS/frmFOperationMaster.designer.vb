﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFOperationMaster
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.dgvOperationList = New Telerik.WinControls.UI.RadGridView()
        Me.GBoxMain = New System.Windows.Forms.GroupBox()
        Me.GBoxWd = New System.Windows.Forms.GroupBox()
        Me.RbReceive = New System.Windows.Forms.RadioButton()
        Me.RbIssue = New System.Windows.Forms.RadioButton()
        Me.txtMaxLossWt = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOperationType = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtOperationName = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOperationList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOperationList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxMain.SuspendLayout()
        Me.GBoxWd.SuspendLayout()
        CType(Me.txtMaxLossWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperationType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperationName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(724, 532)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GBoxMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage1.Size = New System.Drawing.Size(716, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.dgvOperationList)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 347)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation  Details"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(439, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 801
        Me.btnExit.Text = "E&xit"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCancel.Location = New System.Drawing.Point(361, 314)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(205, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(283, 314)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        '
        'dgvOperationList
        '
        Me.dgvOperationList.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOperationList.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvOperationList.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dgvOperationList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvOperationList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvOperationList.Location = New System.Drawing.Point(6, 30)
        '
        '
        '
        Me.dgvOperationList.MasterTemplate.AllowAddNewRow = False
        Me.dgvOperationList.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "OperationId"
        GridViewTextBoxColumn1.HeaderText = "Operation Id"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "ColOperationId"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "OperationName"
        GridViewTextBoxColumn2.HeaderText = "Operation Name"
        GridViewTextBoxColumn2.Name = "ColOperationName"
        GridViewTextBoxColumn2.Width = 205
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "OperationTypeId"
        GridViewTextBoxColumn3.HeaderText = "OperationType Id"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "ColOperationTypeId"
        GridViewTextBoxColumn3.Width = 108
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "OperationType"
        GridViewTextBoxColumn4.HeaderText = "Operation Type"
        GridViewTextBoxColumn4.Name = "ColOperationType"
        GridViewTextBoxColumn4.Width = 180
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "MaxValueAllowed"
        GridViewTextBoxColumn5.HeaderText = "Max Value Allowed"
        GridViewTextBoxColumn5.Name = "ColMaxValueAllowed"
        GridViewTextBoxColumn5.ReadOnly = True
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 140
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "WorkDoneAllowed"
        GridViewTextBoxColumn6.HeaderText = "Work Done"
        GridViewTextBoxColumn6.Name = "ColWorkDoneAllowed"
        GridViewTextBoxColumn6.Width = 100
        Me.dgvOperationList.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
        Me.dgvOperationList.MasterTemplate.EnableGrouping = False
        Me.dgvOperationList.MasterTemplate.ShowRowHeaderColumn = False
        Me.dgvOperationList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvOperationList.Name = "dgvOperationList"
        Me.dgvOperationList.ReadOnly = True
        Me.dgvOperationList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvOperationList.Size = New System.Drawing.Size(686, 275)
        Me.dgvOperationList.TabIndex = 23
        '
        'GBoxMain
        '
        Me.GBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBoxMain.Controls.Add(Me.GBoxWd)
        Me.GBoxMain.Controls.Add(Me.txtMaxLossWt)
        Me.GBoxMain.Controls.Add(Me.Label1)
        Me.GBoxMain.Controls.Add(Me.cmbOperationType)
        Me.GBoxMain.Controls.Add(Me.txtOperationName)
        Me.GBoxMain.Controls.Add(Me.Label2)
        Me.GBoxMain.Controls.Add(Me.Label28)
        Me.GBoxMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxMain.Location = New System.Drawing.Point(8, 11)
        Me.GBoxMain.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.GBoxMain.Name = "GBoxMain"
        Me.GBoxMain.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GBoxMain.Size = New System.Drawing.Size(699, 134)
        Me.GBoxMain.TabIndex = 18
        Me.GBoxMain.TabStop = False
        Me.GBoxMain.Text = "Operation Information"
        '
        'GBoxWd
        '
        Me.GBoxWd.Controls.Add(Me.RbReceive)
        Me.GBoxWd.Controls.Add(Me.RbIssue)
        Me.GBoxWd.Location = New System.Drawing.Point(518, 33)
        Me.GBoxWd.Name = "GBoxWd"
        Me.GBoxWd.Size = New System.Drawing.Size(173, 71)
        Me.GBoxWd.TabIndex = 815
        Me.GBoxWd.TabStop = False
        Me.GBoxWd.Text = "Work Done Allowed"
        '
        'RbReceive
        '
        Me.RbReceive.AutoSize = True
        Me.RbReceive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RbReceive.Location = New System.Drawing.Point(72, 47)
        Me.RbReceive.Name = "RbReceive"
        Me.RbReceive.Size = New System.Drawing.Size(67, 18)
        Me.RbReceive.TabIndex = 1
        Me.RbReceive.TabStop = True
        Me.RbReceive.Text = "Receive"
        Me.RbReceive.UseVisualStyleBackColor = True
        '
        'RbIssue
        '
        Me.RbIssue.AutoSize = True
        Me.RbIssue.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.RbIssue.Location = New System.Drawing.Point(72, 22)
        Me.RbIssue.Name = "RbIssue"
        Me.RbIssue.Size = New System.Drawing.Size(53, 18)
        Me.RbIssue.TabIndex = 0
        Me.RbIssue.TabStop = True
        Me.RbIssue.Text = "Issue"
        Me.RbIssue.UseVisualStyleBackColor = True
        '
        'txtMaxLossWt
        '
        Me.txtMaxLossWt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaxLossWt.Location = New System.Drawing.Point(178, 95)
        Me.txtMaxLossWt.Name = "txtMaxLossWt"
        Me.txtMaxLossWt.Size = New System.Drawing.Size(56, 20)
        Me.txtMaxLossWt.TabIndex = 814
        Me.txtMaxLossWt.TabStop = False
        Me.txtMaxLossWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 14)
        Me.Label1.TabIndex = 813
        Me.Label1.Text = "Max Allowed Value in %"
        '
        'cmbOperationType
        '
        Me.cmbOperationType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbOperationType.Location = New System.Drawing.Point(178, 64)
        Me.cmbOperationType.Name = "cmbOperationType"
        Me.cmbOperationType.Size = New System.Drawing.Size(165, 20)
        Me.cmbOperationType.TabIndex = 2
        '
        'txtOperationName
        '
        Me.txtOperationName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOperationName.Location = New System.Drawing.Point(178, 33)
        Me.txtOperationName.Name = "txtOperationName"
        Me.txtOperationName.Size = New System.Drawing.Size(290, 20)
        Me.txtOperationName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(81, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operation Type"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label28.Location = New System.Drawing.Point(79, 36)
        Me.Label28.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 14)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Operation Name"
        '
        'frmFaOperationMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(724, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFaOperationMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operation Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOperationList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOperationList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxMain.ResumeLayout(False)
        Me.GBoxMain.PerformLayout()
        Me.GBoxWd.ResumeLayout(False)
        Me.GBoxWd.PerformLayout()
        CType(Me.txtMaxLossWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperationType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperationName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GBoxMain As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOperationName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmbOperationType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dgvOperationList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtMaxLossWt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBoxWd As GroupBox
    Friend WithEvents RbReceive As RadioButton
    Friend WithEvents RbIssue As RadioButton
End Class
