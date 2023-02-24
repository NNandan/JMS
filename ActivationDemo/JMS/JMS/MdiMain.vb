﻿Imports System.Windows.Forms
Imports JMS.Common_Cls
Public Class frmMain
    Private Sub LabourMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabourMasterToolStripMenuItem.Click
        Try
            Dim ObjLabour As New frmKarigarMaster
            ObjLabour.MdiParent = Me
            ObjLabour.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AccountMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountMasterToolStripMenuItem.Click
        Try
            Dim ObjAccount As New frmAccountMaster
            ObjAccount.MdiParent = Me
            ObjAccount.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CategoryMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryMasterToolStripMenuItem.Click
        Try
            Dim ObjCategory As New frmCategoryMaster
            ObjCategory.MdiParent = Me
            ObjCategory.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub OperationMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperationMasterToolStripMenuItem.Click
        Try
            Dim ObjOperation As New frmOperationMaster
            ObjOperation.MdiParent = Me
            ObjOperation.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ItemMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMasterToolStripMenuItem.Click
        Try
            Dim ObjItem As New frmItemMaster
            ObjItem.MdiParent = Me
            ObjItem.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MeltingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeltingToolStripMenuItem.Click
        Try
            Dim ObjMelting As New frmMelting
            ObjMelting.MdiParent = Me
            ObjMelting.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub FamilyMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamilyMasterToolStripMenuItem.Click
        Try
            Dim ObjFamily As New frmFamilyMaster
            ObjFamily.MdiParent = Me
            ObjFamily.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotNoToolStripMenuItem.Click
        Try
            Dim ObjLotNo As New frmLotNo
            ObjLotNo.MdiParent = Me
            ObjLotNo.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Try
            Dim ObjMainChart As New frmMainChart
            ObjMainChart.MdiParent = Me
            ObjMainChart.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotTransferToolStripMenuItem.Click
        Try
            Dim ObjILotTransfer As New frmILotTransfer
            ObjILotTransfer.MdiParent = Me
            ObjILotTransfer.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub UsedLotTransferedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsedLotTransferedToolStripMenuItem.Click
        Try
            Dim ObjRLotTransfer As New frmRLotTransfer
            ObjRLotTransfer.MdiParent = Me
            ObjRLotTransfer.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CreateBhukaBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateBhukaBagsToolStripMenuItem.Click
        Try
            Dim ObjbukaBag As New frmBhukaBag
            ObjbukaBag.MdiParent = Me
            ObjbukaBag.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LabIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabIssueToolStripMenuItem.Click
        Try
            Dim ObjLabIssue As New frmLabIssue
            ObjLabIssue.MdiParent = Me
            ObjLabIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LabMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabMasterToolStripMenuItem.Click
        Try
            Dim ObjLabMaster As New frmLabMaster
            ObjLabMaster.MdiParent = Me
            ObjLabMaster.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each ctl As Control In Me.Controls
            Try
                Dim Mdi As System.Windows.Forms.Control = CType(ctl, MdiClient)
                Mdi.BackColor = System.Drawing.Color.White
            Catch a As Exception
            End Try
        Next

        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height

        Left = Top = 0
    End Sub
    Private Sub User_Grant()
        'If User_Level = 2 Then
        '    Mnu_Mast.Enabled = False
        '    Mnu_Util_HouseKeeping.Enabled = False
        'End If
    End Sub
    Private Sub LotFailBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotFailBagToolStripMenuItem.Click
        Try
            Dim ObjLotFail As New frmLotFailBag
            ObjLotFail.MdiParent = Me
            ObjLotFail.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub UserMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMasterToolStripMenuItem.Click
        Try
            Dim ObjUserMaster As New frmUserMaster
            ObjUserMaster.MdiParent = Me
            ObjUserMaster.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub VaccumeBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaccumeBagsToolStripMenuItem.Click
        Try
            Dim ObjVaccumeBag As New frmVaccumBag
            ObjVaccumeBag.MdiParent = Me
            ObjVaccumeBag.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub DepartmentReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentReceiptToolStripMenuItem.Click
        Try
            Dim ObjInterDeptReceipt As New frmInterDeptReceipt
            ObjInterDeptReceipt.MdiParent = Me
            ObjInterDeptReceipt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub DepartmentIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentIssueToolStripMenuItem.Click
        Try
            Dim ObjInterDeptIssue As New frmInterDeptIssue
            ObjInterDeptIssue.MdiParent = Me
            ObjInterDeptIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub SampleBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleBagsToolStripMenuItem.Click
        Try
            Dim ObjSampleBag As New frmSampleBag
            ObjSampleBag.MdiParent = Me
            ObjSampleBag.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ReportByBagNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportByBagNumberToolStripMenuItem.Click
        Try
            Dim ObjRptBhukaBagByNumber As New frmBhukaBagByNumber
            ObjRptBhukaBagByNumber.MdiParent = Me
            ObjRptBhukaBagByNumber.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotAdditionReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotAdditionReceiptToolStripMenuItem.Click
        Try
            Dim ObjLotAdditionReceive As New frmLotAdditionReceive
            ObjLotAdditionReceive.MdiParent = Me
            ObjLotAdditionReceive.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotAdditionIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotAdditionIssueToolStripMenuItem.Click
        Try
            Dim ObjLotAdditionIssue As New frmLotAdditionIssue
            ObjLotAdditionIssue.MdiParent = Me
            ObjLotAdditionIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotAdditionCreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotAdditionCreateToolStripMenuItem.Click
        Try
            Dim ObjNewLotAddition As New frmLotAdditionNew
            ObjNewLotAddition.MdiParent = Me
            ObjNewLotAddition.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Try
            Dim ObjMetalUsedReport As New frmMetalUsedReport
            ObjMetalUsedReport.MdiParent = Me
            ObjMetalUsedReport.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotTransferReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotTransferReportToolStripMenuItem.Click
        Try
            Dim ObjRptLotTransfer As New frmRptLotTransfer
            ObjRptLotTransfer.MdiParent = Me
            ObjRptLotTransfer.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub OfficeIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeIssueToolStripMenuItem.Click
        Try
            Dim ObjRptOfficeIssue As New frmRptIssueDept
            ObjRptOfficeIssue.MdiParent = Me
            ObjRptOfficeIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub OfficeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeToolStripMenuItem.Click
        Try
            Dim ObjRptOfficeReceive As New frmRptReceiveDept
            ObjRptOfficeReceive.MdiParent = Me
            ObjRptOfficeReceive.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotFailReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotFailReportToolStripMenuItem.Click
        Try
            Dim ObjRptLotFail As New frmRptLotFail
            ObjRptLotFail.MdiParent = Me
            ObjRptLotFail.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub SampleReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim ObjRptSample As New frmSamplesRpt
            ObjRptSample.MdiParent = Me
            ObjRptSample.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoreToolStripMenuItem.Click
        Try
            Dim ObjCoreAdditionIssue As New frmCoreAdditionIssue
            ObjCoreAdditionIssue.MdiParent = Me
            ObjCoreAdditionIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CoreAdditionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoreAdditionToolStripMenuItem1.Click
        Try
            Dim ObjCoreAdditionReceive As New frmCoreAdditionReceive
            ObjCoreAdditionReceive.MdiParent = Me
            ObjCoreAdditionReceive.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CoreAdditionRemovalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CoreAdditionRemovalToolStripMenuItem.Click
        Try
            Dim ObjCoreAdditionRemoval As New frmCoreAdditionRemoval
            ObjCoreAdditionRemoval.MdiParent = Me
            ObjCoreAdditionRemoval.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub HelpMenu_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub WIPLotNoWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIPLotNoWiseToolStripMenuItem.Click
        Try
            Dim ObjWIPLotNoWise As New frmWIPLotNoWise
            ObjWIPLotNoWise.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub PartyMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyMasterToolStripMenuItem.Click
        Try
            Dim ObjPartyMaster As New frmPartyMaster
            ObjPartyMaster.MdiParent = Me
            ObjPartyMaster.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MeltingStockReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim ObjMeltingStockRpt As New frmMeltingStockRpt
            ObjMeltingStockRpt.MdiParent = Me
            ObjMeltingStockRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        'Try
        '    Dim ObjSerialKey As New frmSerialKey
        '    ObjSerialKey.MdiParent = Me
        '    ObjSerialKey.Show()
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub
    Private Sub TransactionStockReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim ObjTransactionStockRpt As New frmTransactionStockRpt
            ObjTransactionStockRpt.MdiParent = Me
            ObjTransactionStockRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ChangeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserToolStripMenuItem.Click
        Try
            'close all child forms
            Dim frm As Form
            For Each frm In MdiChildren
                frm.Close()
            Next

            Me.Dispose()
            frmLogin.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub VaccumBagByNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaccumBagByNumberToolStripMenuItem.Click
        Try
            Dim ObjTransactionStockRpt As New frmVaccumBagByNumber
            ObjTransactionStockRpt.MdiParent = Me
            ObjTransactionStockRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub StockSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockSummaryToolStripMenuItem.Click
        Try
            Dim ObjStockSummary As New frmStockSummary
            ObjStockSummary.MdiParent = Me
            ObjStockSummary.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub StockIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockIssueToolStripMenuItem.Click
        Try
            Dim ObjStockIssue As New frmStockIssue
            ObjStockIssue.MdiParent = Me
            ObjStockIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MetalUsedByBagNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetalUsedByBagNumberToolStripMenuItem.Click
        Try
            Dim ObjMetalUsedInBag As New frmMetalUsedInBag
            ObjMetalUsedInBag.MdiParent = Me
            ObjMetalUsedInBag.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotAdditionFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotAdditionFinalToolStripMenuItem.Click
        Try
            Dim ObjLotAdditionFinal As New frmLotAdditionFinal
            ObjLotAdditionFinal.MdiParent = Me
            ObjLotAdditionFinal.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub LotAdditionReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LotAdditionReportToolStripMenuItem1.Click
        Try
            Dim ObjfrmLotAdditionRpt As New frmLotAdditionRpt
            ObjfrmLotAdditionRpt.MdiParent = Me
            ObjfrmLotAdditionRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AllBhukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllBhukaToolStripMenuItem.Click
        Try
            Dim ObjAllBhukaBagReport As New frmAllBhukaBagRpt
            ObjAllBhukaBagReport.MdiParent = Me
            ObjAllBhukaBagReport.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub WIPLotsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIPLotsToolStripMenuItem.Click
        'Try
        '    Dim ObjStockSummaryRuntime As New frmStockSummary
        '    ObjStockSummaryRuntime.MdiParent = Me
        '    ObjStockSummaryRuntime.Show()
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub
    Public Sub Childfrm_Load(ByVal sender As Object, ByVal e As System.EventArgs)

        Try
            Dim Cl_Frm As Form = DirectCast(sender, Form)
            Dim Frmname As String = ""
            '--------------------------------------------------------------------------
            Frmname = Replace(Cl_Frm.Name, "_Frm", "")
            Frmname = Replace(Frmname, "_", " ")

            '--------------------------------------------------------------------------
            Dim Childformexists As Boolean = False
            Dim btnSomething As New ToolStripButton
            Dim m As New System.Windows.Forms.Padding
            '--------------------------------------------------------------------------
            m.All = 1
            With btnSomething
                .Text = Frmname
                .Tag = Cl_Frm.Name
                .Name = Val(Cl_Frm.Tag)
                .ForeColor = Color.Cyan
                .DisplayStyle = ToolStripItemDisplayStyle.Text
                .Margin = m
            End With

        Catch ex As Exception

        End Try

    End Sub
    Private Sub frmMain_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        Try
            For Each ChildForm As Form In Me.MdiChildren
                AddHandler ChildForm.FormClosed, AddressOf Me.Childfrm_Closed
                AddHandler ChildForm.Load, AddressOf Me.Childfrm_Load
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Childfrm_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Try
                'If Me.TlStrp_menuHistoryutility.Items.Count <= 5 Then Exit Sub

                'Dim Cl_Frm As Form = DirectCast(sender, Form)
                'For Each TlStrpBtn As ToolStripButton In Me.TlStrp_menuHistoryutility.Items
                '    If Cl_Frm.Name = TlStrpBtn.Tag Then
                '        Me.TlStrp_menuHistoryutility.Items.Remove(TlStrpBtn)
                '        Exit Sub
                '    End If
                'Next
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Wish To Exit?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub AccountOpeningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountOpeningToolStripMenuItem.Click
        Try
            Dim ObjAccountOpening As New frmAccountOpening
            ObjAccountOpening.MdiParent = Me
            ObjAccountOpening.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub EditBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBagsToolStripMenuItem.Click
        Try
            Dim ObjEditBags As New frmEditBags
            ObjEditBags.MdiParent = Me
            ObjEditBags.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LossReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LossReportToolStripMenuItem.Click
        Try
            Dim ObjRptKarigarwiseLoss As New frmRptKarigarwiseLoss
            ObjRptKarigarwiseLoss.MdiParent = Me
            ObjRptKarigarwiseLoss.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LotAdditionOpStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotAdditionOpStockToolStripMenuItem.Click
        Try
            Dim ObjRptLotAdditionOpStock As New frmRptLotAdditionOpStock
            ObjRptLotAdditionOpStock.MdiParent = Me
            ObjRptLotAdditionOpStock.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LossReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LossReportToolStripMenuItem1.Click
        Try
            Dim ObjLotHistory As New frmLotHistory
            ObjLotHistory.MdiParent = Me
            ObjLotHistory.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub NewSamplesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSamplesReportToolStripMenuItem.Click
        Try
            Dim ObjNewSamplesReport As New frmSamplesRpt
            ObjNewSamplesReport.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TouchConversionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TouchConversionReportToolStripMenuItem.Click
        Try
            Dim ObjTouchConversionReport As New frmTouchConversionRpt
            ObjTouchConversionReport.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ScrapReceiveReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScrapReceiveReportToolStripMenuItem.Click
        Try
            Dim objScrapReceiveReport As New frmScrapReceiveRpt
            objScrapReceiveReport.MdiParent = Me
            objScrapReceiveReport.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CarbonReceiveReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarbonReceiveReportToolStripMenuItem.Click
        Try
            Dim objCarbonReceiveReport As New frmCarbonReceiveRpt
            objCarbonReceiveReport.MdiParent = Me
            objCarbonReceiveReport.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub NewLabIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLabIssueToolStripMenuItem.Click
        Try
            Dim ObjLabIssue As New frmLabIssue
            ObjLabIssue.MdiParent = Me
            ObjLabIssue.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EditLabIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLabIssueToolStripMenuItem.Click
        Try
            Dim ObjEditELabIssue As New frmListLabIssue
            ObjEditELabIssue.MdiParent = Me
            ObjEditELabIssue.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub StockReceiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReceiveToolStripMenuItem.Click
        Try
            Dim ObjStockReceive As New frmStockReceive
            ObjStockReceive.MdiParent = Me
            ObjStockReceive.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MeltingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeltingReportToolStripMenuItem.Click
        Try
            Dim ObjMeltingRpt As New frmMeltingRpt
            ObjMeltingRpt.MdiParent = Me
            ObjMeltingRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ExtraScrapReceiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraScrapReceiveToolStripMenuItem.Click
        Try
            Dim ObjScrapReceive As New frmScrapReceive
            ObjScrapReceive.MdiParent = Me
            ObjScrapReceive.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub StockAdditionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockAdditionReportToolStripMenuItem.Click
        Try
            Dim ObjRptStockAddition As New frmStockAdditionRpt
            ObjRptStockAddition.MdiParent = Me
            ObjRptStockAddition.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim ObjRptCoreAddition As New frmCoreAdditionRpt
            ObjRptCoreAddition.MdiParent = Me
            ObjRptCoreAddition.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub BalancePendingInBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalancePendingInBagsToolStripMenuItem.Click
        Try
            Dim ObjPendingVoucherRpt As New frmPendingBags
            ObjPendingVoucherRpt.MdiParent = Me
            ObjPendingVoucherRpt.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub BalancePendingInVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalancePendingInVoucherToolStripMenuItem.Click
        Try
            Dim ObjPendingVoucher As New frmPendingVoucher
            ObjPendingVoucher.MdiParent = Me
            ObjPendingVoucher.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EditScrapBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditScrapBagsToolStripMenuItem.Click
        Try
            Dim ObjEditBBags As New frmEditBBags
            ObjEditBBags.MdiParent = Me
            ObjEditBBags.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EditLotFailBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLotFailBagToolStripMenuItem.Click
        Try
            Dim ObjEditLBags As New frmEditLBags
            ObjEditLBags.MdiParent = Me
            ObjEditLBags.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EditVacuumBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVacuumBagsToolStripMenuItem.Click
        Try
            Dim ObjEditVBags As New frmEditVBags
            ObjEditVBags.MdiParent = Me
            ObjEditVBags.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EditSampleBagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSampleBagsToolStripMenuItem.Click
        Try
            Dim ObjEditSBags As New frmEditSBags
            ObjEditSBags.MdiParent = Me
            ObjEditSBags.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class