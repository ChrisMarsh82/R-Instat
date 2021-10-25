<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareSummary
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSatellite = New System.Windows.Forms.Label()
        Me.rdoContinuous = New System.Windows.Forms.RadioButton()
        Me.rdoCategorical = New System.Windows.Forms.RadioButton()
        Me.rdoBinary = New System.Windows.Forms.RadioButton()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkIgnoreMissing = New instat.ucrCheck()
        Me.ucrPnlObservationType = New instat.UcrPanel()
        Me.ucrReceiverMultipleFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSatellite = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorVerificationSummary = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(387, 94)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(71, 16)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Observed:"
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(387, 212)
        Me.lblFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(56, 16)
        Me.lblFactors.TabIndex = 9
        Me.lblFactors.Text = "Factors:"
        '
        'lblSatellite
        '
        Me.lblSatellite.AutoSize = True
        Me.lblSatellite.Location = New System.Drawing.Point(387, 155)
        Me.lblSatellite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSatellite.Name = "lblSatellite"
        Me.lblSatellite.Size = New System.Drawing.Size(71, 16)
        Me.lblSatellite.TabIndex = 7
        Me.lblSatellite.Text = "Estimated:"
        '
        'rdoContinuous
        '
        Me.rdoContinuous.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoContinuous.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoContinuous.FlatAppearance.BorderSize = 2
        Me.rdoContinuous.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoContinuous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoContinuous.Location = New System.Drawing.Point(89, 15)
        Me.rdoContinuous.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoContinuous.Name = "rdoContinuous"
        Me.rdoContinuous.Size = New System.Drawing.Size(131, 33)
        Me.rdoContinuous.TabIndex = 1
        Me.rdoContinuous.TabStop = True
        Me.rdoContinuous.Text = "Continuous"
        Me.rdoContinuous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoContinuous.UseVisualStyleBackColor = True
        '
        'rdoCategorical
        '
        Me.rdoCategorical.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCategorical.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCategorical.FlatAppearance.BorderSize = 2
        Me.rdoCategorical.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCategorical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCategorical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCategorical.Location = New System.Drawing.Point(345, 15)
        Me.rdoCategorical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCategorical.Name = "rdoCategorical"
        Me.rdoCategorical.Size = New System.Drawing.Size(131, 33)
        Me.rdoCategorical.TabIndex = 3
        Me.rdoCategorical.TabStop = True
        Me.rdoCategorical.Text = "Categorical"
        Me.rdoCategorical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCategorical.UseVisualStyleBackColor = True
        '
        'rdoBinary
        '
        Me.rdoBinary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBinary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinary.FlatAppearance.BorderSize = 2
        Me.rdoBinary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBinary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBinary.Location = New System.Drawing.Point(217, 15)
        Me.rdoBinary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoBinary.Name = "rdoBinary"
        Me.rdoBinary.Size = New System.Drawing.Size(131, 33)
        Me.rdoBinary.TabIndex = 2
        Me.rdoBinary.TabStop = True
        Me.rdoBinary.Text = "Binary"
        Me.rdoBinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBinary.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(387, 358)
        Me.cmdSummaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(160, 28)
        Me.cmdSummaries.TabIndex = 14
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(13, 346)
        Me.ucrChkPrintOutput.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(364, 25)
        Me.ucrChkPrintOutput.TabIndex = 12
        '
        'ucrChkIgnoreMissing
        '
        Me.ucrChkIgnoreMissing.Checked = False
        Me.ucrChkIgnoreMissing.Location = New System.Drawing.Point(13, 378)
        Me.ucrChkIgnoreMissing.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkIgnoreMissing.Name = "ucrChkIgnoreMissing"
        Me.ucrChkIgnoreMissing.Size = New System.Drawing.Size(365, 25)
        Me.ucrChkIgnoreMissing.TabIndex = 13
        '
        'ucrPnlObservationType
        '
        Me.ucrPnlObservationType.Location = New System.Drawing.Point(84, 5)
        Me.ucrPnlObservationType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlObservationType.Name = "ucrPnlObservationType"
        Me.ucrPnlObservationType.Size = New System.Drawing.Size(400, 62)
        Me.ucrPnlObservationType.TabIndex = 0
        '
        'ucrReceiverMultipleFactors
        '
        Me.ucrReceiverMultipleFactors.frmParent = Me
        Me.ucrReceiverMultipleFactors.Location = New System.Drawing.Point(387, 231)
        Me.ucrReceiverMultipleFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFactors.Name = "ucrReceiverMultipleFactors"
        Me.ucrReceiverMultipleFactors.Selector = Nothing
        Me.ucrReceiverMultipleFactors.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverMultipleFactors.strNcFilePath = ""
        Me.ucrReceiverMultipleFactors.TabIndex = 10
        Me.ucrReceiverMultipleFactors.ucrSelector = Nothing
        '
        'ucrReceiverSatellite
        '
        Me.ucrReceiverSatellite.frmParent = Me
        Me.ucrReceiverSatellite.Location = New System.Drawing.Point(387, 175)
        Me.ucrReceiverSatellite.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSatellite.Name = "ucrReceiverSatellite"
        Me.ucrReceiverSatellite.Selector = Nothing
        Me.ucrReceiverSatellite.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverSatellite.strNcFilePath = ""
        Me.ucrReceiverSatellite.TabIndex = 8
        Me.ucrReceiverSatellite.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(387, 114)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorVerificationSummary
        '
        Me.ucrSelectorVerificationSummary.bDropUnusedFilterLevels = False
        Me.ucrSelectorVerificationSummary.bShowHiddenColumns = False
        Me.ucrSelectorVerificationSummary.bUseCurrentFilter = True
        Me.ucrSelectorVerificationSummary.Location = New System.Drawing.Point(13, 70)
        Me.ucrSelectorVerificationSummary.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVerificationSummary.Name = "ucrSelectorVerificationSummary"
        Me.ucrSelectorVerificationSummary.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorVerificationSummary.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 415)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 15
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(13, 314)
        Me.ucrChkStoreResults.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(364, 25)
        Me.ucrChkStoreResults.TabIndex = 11
        '
        'dlgCompareSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 490)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.ucrChkPrintOutput)
        Me.Controls.Add(Me.ucrChkIgnoreMissing)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.rdoBinary)
        Me.Controls.Add(Me.rdoCategorical)
        Me.Controls.Add(Me.rdoContinuous)
        Me.Controls.Add(Me.ucrPnlObservationType)
        Me.Controls.Add(Me.lblSatellite)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMultipleFactors)
        Me.Controls.Add(Me.ucrReceiverSatellite)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorVerificationSummary)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dlgCompareSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verification Summaries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVerificationSummary As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleFactors As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSatellite As ucrReceiverSingle
    Friend WithEvents lblSatellite As Label
    Friend WithEvents lblFactors As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrPnlObservationType As UcrPanel
    Friend WithEvents rdoBinary As RadioButton
    Friend WithEvents rdoCategorical As RadioButton
    Friend WithEvents rdoContinuous As RadioButton
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkIgnoreMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
End Class
