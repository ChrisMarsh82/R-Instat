﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSurvivalObject
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
        Me.components = New System.ComponentModel.Container()
        Me.lblEntryTime = New System.Windows.Forms.Label()
        Me.lblExitTime2 = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoInterval = New System.Windows.Forms.RadioButton()
        Me.rdoCounting = New System.Windows.Forms.RadioButton()
        Me.rdoMstate = New System.Windows.Forms.RadioButton()
        Me.rdoInterval2 = New System.Windows.Forms.RadioButton()
        Me.ttEventInterval = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrModifyEventLogical = New instat.ucrInputComboBox()
        Me.ucrModifyEventNumeric = New instat.ucrInputTextBox()
        Me.ucrModifyEventFactor = New instat.ucrFactor()
        Me.ucrInputOrigin = New instat.ucrInputTextBox()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrSaveObject = New instat.ucrSave()
        Me.ucrReceiverEvent = New instat.ucrReceiverSingle()
        Me.ucrReceiverExit = New instat.ucrReceiverSingle()
        Me.ucrReceiverEntry = New instat.ucrReceiverSingle()
        Me.ucrSelectorFitObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkModifyEvent = New instat.ucrCheck()
        Me.lblModifyEvent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEntryTime
        '
        Me.lblEntryTime.Location = New System.Drawing.Point(371, 74)
        Me.lblEntryTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEntryTime.Name = "lblEntryTime"
        Me.lblEntryTime.Size = New System.Drawing.Size(111, 18)
        Me.lblEntryTime.TabIndex = 8
        Me.lblEntryTime.Text = "Entry Time:"
        '
        'lblExitTime2
        '
        Me.lblExitTime2.Location = New System.Drawing.Point(371, 132)
        Me.lblExitTime2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExitTime2.Name = "lblExitTime2"
        Me.lblExitTime2.Size = New System.Drawing.Size(111, 18)
        Me.lblExitTime2.TabIndex = 10
        Me.lblExitTime2.Text = "Exit Time:"
        '
        'lblEvent
        '
        Me.lblEvent.Location = New System.Drawing.Point(371, 190)
        Me.lblEvent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(111, 18)
        Me.lblEvent.TabIndex = 12
        Me.lblEvent.Text = "Event:"
        '
        'lblOrigin
        '
        Me.lblOrigin.Location = New System.Drawing.Point(376, 308)
        Me.lblOrigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(55, 23)
        Me.lblOrigin.TabIndex = 19
        Me.lblOrigin.Text = "Origin:"
        '
        'rdoRight
        '
        Me.rdoRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRight.FlatAppearance.BorderSize = 2
        Me.rdoRight.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRight.Location = New System.Drawing.Point(55, 17)
        Me.rdoRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(95, 33)
        Me.rdoRight.TabIndex = 1
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Right"
        Me.rdoRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLeft.FlatAppearance.BorderSize = 2
        Me.rdoLeft.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeft.Location = New System.Drawing.Point(147, 17)
        Me.rdoLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(95, 33)
        Me.rdoLeft.TabIndex = 2
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoInterval
        '
        Me.rdoInterval.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInterval.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval.FlatAppearance.BorderSize = 2
        Me.rdoInterval.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInterval.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoInterval.Location = New System.Drawing.Point(331, 17)
        Me.rdoInterval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoInterval.Name = "rdoInterval"
        Me.rdoInterval.Size = New System.Drawing.Size(95, 33)
        Me.rdoInterval.TabIndex = 4
        Me.rdoInterval.TabStop = True
        Me.rdoInterval.Text = "Interval"
        Me.rdoInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInterval.UseVisualStyleBackColor = True
        '
        'rdoCounting
        '
        Me.rdoCounting.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCounting.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCounting.FlatAppearance.BorderSize = 2
        Me.rdoCounting.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCounting.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCounting.Location = New System.Drawing.Point(239, 17)
        Me.rdoCounting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCounting.Name = "rdoCounting"
        Me.rdoCounting.Size = New System.Drawing.Size(95, 33)
        Me.rdoCounting.TabIndex = 3
        Me.rdoCounting.TabStop = True
        Me.rdoCounting.Text = "Counting Process"
        Me.rdoCounting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCounting.UseVisualStyleBackColor = True
        '
        'rdoMstate
        '
        Me.rdoMstate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMstate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMstate.FlatAppearance.BorderSize = 2
        Me.rdoMstate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMstate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMstate.Location = New System.Drawing.Point(515, 17)
        Me.rdoMstate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMstate.Name = "rdoMstate"
        Me.rdoMstate.Size = New System.Drawing.Size(95, 33)
        Me.rdoMstate.TabIndex = 6
        Me.rdoMstate.TabStop = True
        Me.rdoMstate.Text = "Multistate"
        Me.rdoMstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMstate.UseVisualStyleBackColor = True
        '
        'rdoInterval2
        '
        Me.rdoInterval2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInterval2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval2.FlatAppearance.BorderSize = 2
        Me.rdoInterval2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInterval2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInterval2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoInterval2.Location = New System.Drawing.Point(423, 17)
        Me.rdoInterval2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoInterval2.Name = "rdoInterval2"
        Me.rdoInterval2.Size = New System.Drawing.Size(95, 33)
        Me.rdoInterval2.TabIndex = 5
        Me.rdoInterval2.TabStop = True
        Me.rdoInterval2.Text = "Interval2"
        Me.rdoInterval2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInterval2.UseVisualStyleBackColor = True
        '
        'ucrModifyEventLogical
        '
        Me.ucrModifyEventLogical.AddQuotesIfUnrecognised = True
        Me.ucrModifyEventLogical.GetSetSelectedIndex = -1
        Me.ucrModifyEventLogical.IsReadOnly = False
        Me.ucrModifyEventLogical.Location = New System.Drawing.Point(371, 265)
        Me.ucrModifyEventLogical.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrModifyEventLogical.Name = "ucrModifyEventLogical"
        Me.ucrModifyEventLogical.Size = New System.Drawing.Size(160, 26)
        Me.ucrModifyEventLogical.TabIndex = 16
        '
        'ucrModifyEventNumeric
        '
        Me.ucrModifyEventNumeric.AddQuotesIfUnrecognised = True
        Me.ucrModifyEventNumeric.IsMultiline = False
        Me.ucrModifyEventNumeric.IsReadOnly = False
        Me.ucrModifyEventNumeric.Location = New System.Drawing.Point(371, 265)
        Me.ucrModifyEventNumeric.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrModifyEventNumeric.Name = "ucrModifyEventNumeric"
        Me.ucrModifyEventNumeric.Size = New System.Drawing.Size(160, 32)
        Me.ucrModifyEventNumeric.TabIndex = 17
        '
        'ucrModifyEventFactor
        '
        Me.ucrModifyEventFactor.AutoSize = True
        Me.ucrModifyEventFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrModifyEventFactor.clsReceiver = Nothing
        Me.ucrModifyEventFactor.Location = New System.Drawing.Point(567, 239)
        Me.ucrModifyEventFactor.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrModifyEventFactor.Name = "ucrModifyEventFactor"
        Me.ucrModifyEventFactor.shtCurrSheet = Nothing
        Me.ucrModifyEventFactor.Size = New System.Drawing.Size(281, 166)
        Me.ucrModifyEventFactor.TabIndex = 18
        Me.ucrModifyEventFactor.ucrChkLevels = Nothing
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.IsMultiline = False
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(437, 304)
        Me.ucrInputOrigin.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(105, 26)
        Me.ucrInputOrigin.TabIndex = 20
        '
        'ucrPnlType
        '
        Me.ucrPnlType.Location = New System.Drawing.Point(45, 12)
        Me.ucrPnlType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlType.Name = "ucrPnlType"
        Me.ucrPnlType.Size = New System.Drawing.Size(583, 44)
        Me.ucrPnlType.TabIndex = 0
        '
        'ucrSaveObject
        '
        Me.ucrSaveObject.Location = New System.Drawing.Point(13, 304)
        Me.ucrSaveObject.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveObject.Name = "ucrSaveObject"
        Me.ucrSaveObject.Size = New System.Drawing.Size(355, 30)
        Me.ucrSaveObject.TabIndex = 21
        '
        'ucrReceiverEvent
        '
        Me.ucrReceiverEvent.frmParent = Me
        Me.ucrReceiverEvent.Location = New System.Drawing.Point(371, 209)
        Me.ucrReceiverEvent.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvent.Name = "ucrReceiverEvent"
        Me.ucrReceiverEvent.Selector = Nothing
        Me.ucrReceiverEvent.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverEvent.strNcFilePath = ""
        Me.ucrReceiverEvent.TabIndex = 13
        Me.ucrReceiverEvent.ucrSelector = Nothing
        '
        'ucrReceiverExit
        '
        Me.ucrReceiverExit.frmParent = Me
        Me.ucrReceiverExit.Location = New System.Drawing.Point(371, 151)
        Me.ucrReceiverExit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExit.Name = "ucrReceiverExit"
        Me.ucrReceiverExit.Selector = Nothing
        Me.ucrReceiverExit.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverExit.strNcFilePath = ""
        Me.ucrReceiverExit.TabIndex = 11
        Me.ucrReceiverExit.ucrSelector = Nothing
        '
        'ucrReceiverEntry
        '
        Me.ucrReceiverEntry.frmParent = Me
        Me.ucrReceiverEntry.Location = New System.Drawing.Point(371, 94)
        Me.ucrReceiverEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEntry.Name = "ucrReceiverEntry"
        Me.ucrReceiverEntry.Selector = Nothing
        Me.ucrReceiverEntry.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverEntry.strNcFilePath = ""
        Me.ucrReceiverEntry.TabIndex = 9
        Me.ucrReceiverEntry.ucrSelector = Nothing
        '
        'ucrSelectorFitObject
        '
        Me.ucrSelectorFitObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorFitObject.bShowHiddenColumns = False
        Me.ucrSelectorFitObject.bUseCurrentFilter = True
        Me.ucrSelectorFitObject.Location = New System.Drawing.Point(12, 60)
        Me.ucrSelectorFitObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFitObject.Name = "ucrSelectorFitObject"
        Me.ucrSelectorFitObject.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorFitObject.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 341)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 22
        '
        'ucrChkModifyEvent
        '
        Me.ucrChkModifyEvent.Checked = False
        Me.ucrChkModifyEvent.Location = New System.Drawing.Point(539, 210)
        Me.ucrChkModifyEvent.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkModifyEvent.Name = "ucrChkModifyEvent"
        Me.ucrChkModifyEvent.Size = New System.Drawing.Size(252, 25)
        Me.ucrChkModifyEvent.TabIndex = 14
        '
        'lblModifyEvent
        '
        Me.lblModifyEvent.Location = New System.Drawing.Point(371, 246)
        Me.lblModifyEvent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModifyEvent.Name = "lblModifyEvent"
        Me.lblModifyEvent.Size = New System.Drawing.Size(203, 16)
        Me.lblModifyEvent.TabIndex = 23
        Me.lblModifyEvent.Text = "Event Occurs When Value is:"
        '
        'dlgSurvivalObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 412)
        Me.Controls.Add(Me.ucrModifyEventLogical)
        Me.Controls.Add(Me.ucrModifyEventNumeric)
        Me.Controls.Add(Me.ucrModifyEventFactor)
        Me.Controls.Add(Me.ucrInputOrigin)
        Me.Controls.Add(Me.rdoMstate)
        Me.Controls.Add(Me.rdoInterval2)
        Me.Controls.Add(Me.rdoInterval)
        Me.Controls.Add(Me.rdoCounting)
        Me.Controls.Add(Me.rdoLeft)
        Me.Controls.Add(Me.rdoRight)
        Me.Controls.Add(Me.ucrPnlType)
        Me.Controls.Add(Me.ucrSaveObject)
        Me.Controls.Add(Me.lblOrigin)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblExitTime2)
        Me.Controls.Add(Me.ucrReceiverEvent)
        Me.Controls.Add(Me.lblEntryTime)
        Me.Controls.Add(Me.ucrReceiverExit)
        Me.Controls.Add(Me.ucrReceiverEntry)
        Me.Controls.Add(Me.ucrSelectorFitObject)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkModifyEvent)
        Me.Controls.Add(Me.lblModifyEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSurvivalObject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Survival Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverExit As ucrReceiverSingle
    Friend WithEvents ucrReceiverEntry As ucrReceiverSingle
    Friend WithEvents ucrSelectorFitObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverEvent As ucrReceiverSingle
    Friend WithEvents ucrSaveObject As ucrSave
    Friend WithEvents lblOrigin As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents lblExitTime2 As Label
    Friend WithEvents lblEntryTime As Label
    Friend WithEvents rdoMstate As RadioButton
    Friend WithEvents rdoInterval2 As RadioButton
    Friend WithEvents rdoInterval As RadioButton
    Friend WithEvents rdoCounting As RadioButton
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents ucrInputOrigin As ucrInputTextBox
    Friend WithEvents ucrChkModifyEvent As ucrCheck
    Friend WithEvents ucrModifyEventNumeric As ucrInputTextBox
    Friend WithEvents ucrModifyEventFactor As ucrFactor
    Friend WithEvents ucrModifyEventLogical As ucrInputComboBox
    Friend WithEvents ttEventInterval As ToolTip
    Friend WithEvents lblModifyEvent As Label
End Class