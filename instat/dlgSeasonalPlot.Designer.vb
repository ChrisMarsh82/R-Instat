<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSeasonalPlot
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
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.ucrInputN = New instat.ucrInputTextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrChkMovingAverage = New instat.ucrCheck()
        Me.grpSmoothing = New System.Windows.Forms.GroupBox()
        Me.ucrNudSpan = New instat.ucrNud()
        Me.lblSpan = New System.Windows.Forms.Label()
        Me.ucrNudDf = New instat.ucrNud()
        Me.lblHarmonics = New System.Windows.Forms.Label()
        Me.lblDf = New System.Windows.Forms.Label()
        Me.ucrNudHarmonics = New instat.ucrNud()
        Me.ucrInputSmoothing = New instat.ucrInputComboBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.ucrNudPeriod = New instat.ucrNud()
        Me.lblReferenceSummary = New System.Windows.Forms.Label()
        Me.lblSeasonality = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblEstimates = New System.Windows.Forms.Label()
        Me.lblEstimatesSummary = New System.Windows.Forms.Label()
        Me.ucrInputEstimatesSummary = New instat.ucrInputTextBox()
        Me.ucrInputEstimatesThreshold = New instat.ucrInputTextBox()
        Me.ucrInputReferenceThreshold = New instat.ucrInputTextBox()
        Me.ucrInputReferenceSummary = New instat.ucrInputComboBox()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkRemoveMissing = New instat.ucrCheck()
        Me.ucrReceiverEstimates = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonality = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverReference = New instat.ucrReceiverSingle()
        Me.ucrSelectorSeasonalityComparisons = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpValues.SuspendLayout()
        Me.grpSmoothing.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.ucrInputN)
        Me.grpValues.Controls.Add(Me.lblN)
        Me.grpValues.Controls.Add(Me.ucrChkPoints)
        Me.grpValues.Controls.Add(Me.ucrChkMovingAverage)
        Me.grpValues.Location = New System.Drawing.Point(16, 379)
        Me.grpValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpValues.Size = New System.Drawing.Size(324, 87)
        Me.grpValues.TabIndex = 16
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Display Values As"
        '
        'ucrInputN
        '
        Me.ucrInputN.AddQuotesIfUnrecognised = True
        Me.ucrInputN.IsMultiline = False
        Me.ucrInputN.IsReadOnly = False
        Me.ucrInputN.Location = New System.Drawing.Point(199, 55)
        Me.ucrInputN.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputN.Name = "ucrInputN"
        Me.ucrInputN.Size = New System.Drawing.Size(63, 26)
        Me.ucrInputN.TabIndex = 23
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(173, 58)
        Me.lblN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(18, 16)
        Me.lblN.TabIndex = 21
        Me.lblN.Text = "n:"
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(11, 23)
        Me.ucrChkPoints.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(207, 25)
        Me.ucrChkPoints.TabIndex = 8
        '
        'ucrChkMovingAverage
        '
        Me.ucrChkMovingAverage.Checked = False
        Me.ucrChkMovingAverage.Location = New System.Drawing.Point(11, 55)
        Me.ucrChkMovingAverage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkMovingAverage.Name = "ucrChkMovingAverage"
        Me.ucrChkMovingAverage.Size = New System.Drawing.Size(161, 25)
        Me.ucrChkMovingAverage.TabIndex = 7
        '
        'grpSmoothing
        '
        Me.grpSmoothing.Controls.Add(Me.ucrNudSpan)
        Me.grpSmoothing.Controls.Add(Me.lblSpan)
        Me.grpSmoothing.Controls.Add(Me.ucrNudDf)
        Me.grpSmoothing.Controls.Add(Me.lblHarmonics)
        Me.grpSmoothing.Controls.Add(Me.lblDf)
        Me.grpSmoothing.Controls.Add(Me.ucrNudHarmonics)
        Me.grpSmoothing.Controls.Add(Me.ucrInputSmoothing)
        Me.grpSmoothing.Controls.Add(Me.lblPeriod)
        Me.grpSmoothing.Controls.Add(Me.ucrNudPeriod)
        Me.grpSmoothing.Location = New System.Drawing.Point(16, 272)
        Me.grpSmoothing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSmoothing.Name = "grpSmoothing"
        Me.grpSmoothing.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSmoothing.Size = New System.Drawing.Size(340, 92)
        Me.grpSmoothing.TabIndex = 17
        Me.grpSmoothing.TabStop = False
        Me.grpSmoothing.Text = "Smoothing Curves"
        '
        'ucrNudSpan
        '
        Me.ucrNudSpan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSpan.Location = New System.Drawing.Point(60, 60)
        Me.ucrNudSpan.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudSpan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSpan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Name = "ucrNudSpan"
        Me.ucrNudSpan.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudSpan.TabIndex = 20
        Me.ucrNudSpan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSpan
        '
        Me.lblSpan.AutoSize = True
        Me.lblSpan.Location = New System.Drawing.Point(9, 64)
        Me.lblSpan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpan.Name = "lblSpan"
        Me.lblSpan.Size = New System.Drawing.Size(43, 16)
        Me.lblSpan.TabIndex = 23
        Me.lblSpan.Text = "Span:"
        '
        'ucrNudDf
        '
        Me.ucrNudDf.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDf.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDf.Location = New System.Drawing.Point(147, 60)
        Me.ucrNudDf.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudDf.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDf.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDf.Name = "ucrNudDf"
        Me.ucrNudDf.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudDf.TabIndex = 21
        Me.ucrNudDf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHarmonics
        '
        Me.lblHarmonics.AutoSize = True
        Me.lblHarmonics.Location = New System.Drawing.Point(8, 64)
        Me.lblHarmonics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHarmonics.Name = "lblHarmonics"
        Me.lblHarmonics.Size = New System.Drawing.Size(76, 16)
        Me.lblHarmonics.TabIndex = 19
        Me.lblHarmonics.Text = "Harmonics:"
        '
        'lblDf
        '
        Me.lblDf.AutoSize = True
        Me.lblDf.Location = New System.Drawing.Point(8, 63)
        Me.lblDf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDf.Name = "lblDf"
        Me.lblDf.Size = New System.Drawing.Size(131, 16)
        Me.lblDf.TabIndex = 24
        Me.lblDf.Text = "Degrees of freedom:"
        '
        'ucrNudHarmonics
        '
        Me.ucrNudHarmonics.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHarmonics.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHarmonics.Location = New System.Drawing.Point(129, 60)
        Me.ucrNudHarmonics.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudHarmonics.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHarmonics.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHarmonics.Name = "ucrNudHarmonics"
        Me.ucrNudHarmonics.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudHarmonics.TabIndex = 1
        Me.ucrNudHarmonics.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSmoothing
        '
        Me.ucrInputSmoothing.AddQuotesIfUnrecognised = True
        Me.ucrInputSmoothing.GetSetSelectedIndex = -1
        Me.ucrInputSmoothing.IsReadOnly = False
        Me.ucrInputSmoothing.Location = New System.Drawing.Point(9, 25)
        Me.ucrInputSmoothing.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputSmoothing.Name = "ucrInputSmoothing"
        Me.ucrInputSmoothing.Size = New System.Drawing.Size(159, 26)
        Me.ucrInputSmoothing.TabIndex = 0
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(201, 64)
        Me.lblPeriod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(51, 16)
        Me.lblPeriod.TabIndex = 18
        Me.lblPeriod.Text = "Period:"
        '
        'ucrNudPeriod
        '
        Me.ucrNudPeriod.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPeriod.Location = New System.Drawing.Point(264, 60)
        Me.ucrNudPeriod.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudPeriod.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPeriod.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPeriod.Name = "ucrNudPeriod"
        Me.ucrNudPeriod.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudPeriod.TabIndex = 2
        Me.ucrNudPeriod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblReferenceSummary
        '
        Me.lblReferenceSummary.AutoSize = True
        Me.lblReferenceSummary.Location = New System.Drawing.Point(367, 90)
        Me.lblReferenceSummary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReferenceSummary.Name = "lblReferenceSummary"
        Me.lblReferenceSummary.Size = New System.Drawing.Size(68, 16)
        Me.lblReferenceSummary.TabIndex = 3
        Me.lblReferenceSummary.Text = "Summary:"
        '
        'lblSeasonality
        '
        Me.lblSeasonality.AutoSize = True
        Me.lblSeasonality.Location = New System.Drawing.Point(367, 268)
        Me.lblSeasonality.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeasonality.Name = "lblSeasonality"
        Me.lblSeasonality.Size = New System.Drawing.Size(82, 16)
        Me.lblSeasonality.TabIndex = 11
        Me.lblSeasonality.Text = "Seasonality:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(367, 325)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(52, 16)
        Me.lblStation.TabIndex = 13
        Me.lblStation.Text = "Station:"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(367, 33)
        Me.lblReference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(119, 16)
        Me.lblReference.TabIndex = 1
        Me.lblReference.Text = "Reference Values:"
        '
        'lblEstimates
        '
        Me.lblEstimates.AutoSize = True
        Me.lblEstimates.Location = New System.Drawing.Point(367, 148)
        Me.lblEstimates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(70, 16)
        Me.lblEstimates.TabIndex = 6
        Me.lblEstimates.Text = "Estimates:"
        '
        'lblEstimatesSummary
        '
        Me.lblEstimatesSummary.AutoSize = True
        Me.lblEstimatesSummary.Location = New System.Drawing.Point(367, 203)
        Me.lblEstimatesSummary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstimatesSummary.Name = "lblEstimatesSummary"
        Me.lblEstimatesSummary.Size = New System.Drawing.Size(68, 16)
        Me.lblEstimatesSummary.TabIndex = 20
        Me.lblEstimatesSummary.Text = "Summary:"
        '
        'ucrInputEstimatesSummary
        '
        Me.ucrInputEstimatesSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputEstimatesSummary.IsMultiline = False
        Me.ucrInputEstimatesSummary.IsReadOnly = False
        Me.ucrInputEstimatesSummary.Location = New System.Drawing.Point(367, 223)
        Me.ucrInputEstimatesSummary.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputEstimatesSummary.Name = "ucrInputEstimatesSummary"
        Me.ucrInputEstimatesSummary.Size = New System.Drawing.Size(119, 26)
        Me.ucrInputEstimatesSummary.TabIndex = 21
        '
        'ucrInputEstimatesThreshold
        '
        Me.ucrInputEstimatesThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputEstimatesThreshold.IsMultiline = False
        Me.ucrInputEstimatesThreshold.IsReadOnly = False
        Me.ucrInputEstimatesThreshold.Location = New System.Drawing.Point(497, 223)
        Me.ucrInputEstimatesThreshold.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputEstimatesThreshold.Name = "ucrInputEstimatesThreshold"
        Me.ucrInputEstimatesThreshold.Size = New System.Drawing.Size(53, 26)
        Me.ucrInputEstimatesThreshold.TabIndex = 10
        '
        'ucrInputReferenceThreshold
        '
        Me.ucrInputReferenceThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputReferenceThreshold.IsMultiline = False
        Me.ucrInputReferenceThreshold.IsReadOnly = False
        Me.ucrInputReferenceThreshold.Location = New System.Drawing.Point(497, 110)
        Me.ucrInputReferenceThreshold.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputReferenceThreshold.Name = "ucrInputReferenceThreshold"
        Me.ucrInputReferenceThreshold.Size = New System.Drawing.Size(53, 26)
        Me.ucrInputReferenceThreshold.TabIndex = 5
        '
        'ucrInputReferenceSummary
        '
        Me.ucrInputReferenceSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputReferenceSummary.GetSetSelectedIndex = -1
        Me.ucrInputReferenceSummary.IsReadOnly = False
        Me.ucrInputReferenceSummary.Location = New System.Drawing.Point(367, 110)
        Me.ucrInputReferenceSummary.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputReferenceSummary.Name = "ucrInputReferenceSummary"
        Me.ucrInputReferenceSummary.Size = New System.Drawing.Size(119, 26)
        Me.ucrInputReferenceSummary.TabIndex = 4
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(16, 529)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(427, 30)
        Me.ucrSaveGraph.TabIndex = 18
        '
        'ucrChkRemoveMissing
        '
        Me.ucrChkRemoveMissing.Checked = False
        Me.ucrChkRemoveMissing.Location = New System.Drawing.Point(16, 487)
        Me.ucrChkRemoveMissing.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkRemoveMissing.Name = "ucrChkRemoveMissing"
        Me.ucrChkRemoveMissing.Size = New System.Drawing.Size(487, 25)
        Me.ucrChkRemoveMissing.TabIndex = 15
        '
        'ucrReceiverEstimates
        '
        Me.ucrReceiverEstimates.frmParent = Me
        Me.ucrReceiverEstimates.Location = New System.Drawing.Point(367, 167)
        Me.ucrReceiverEstimates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimates.Name = "ucrReceiverEstimates"
        Me.ucrReceiverEstimates.Selector = Nothing
        Me.ucrReceiverEstimates.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverEstimates.strNcFilePath = ""
        Me.ucrReceiverEstimates.TabIndex = 7
        Me.ucrReceiverEstimates.ucrSelector = Nothing
        '
        'ucrReceiverSeasonality
        '
        Me.ucrReceiverSeasonality.frmParent = Me
        Me.ucrReceiverSeasonality.Location = New System.Drawing.Point(367, 288)
        Me.ucrReceiverSeasonality.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonality.Name = "ucrReceiverSeasonality"
        Me.ucrReceiverSeasonality.Selector = Nothing
        Me.ucrReceiverSeasonality.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverSeasonality.strNcFilePath = ""
        Me.ucrReceiverSeasonality.TabIndex = 12
        Me.ucrReceiverSeasonality.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(367, 345)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 14
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverReference
        '
        Me.ucrReceiverReference.frmParent = Me
        Me.ucrReceiverReference.Location = New System.Drawing.Point(367, 53)
        Me.ucrReceiverReference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReference.Name = "ucrReceiverReference"
        Me.ucrReceiverReference.Selector = Nothing
        Me.ucrReceiverReference.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverReference.strNcFilePath = ""
        Me.ucrReceiverReference.TabIndex = 2
        Me.ucrReceiverReference.ucrSelector = Nothing
        '
        'ucrSelectorSeasonalityComparisons
        '
        Me.ucrSelectorSeasonalityComparisons.bDropUnusedFilterLevels = False
        Me.ucrSelectorSeasonalityComparisons.bShowHiddenColumns = False
        Me.ucrSelectorSeasonalityComparisons.bUseCurrentFilter = True
        Me.ucrSelectorSeasonalityComparisons.Location = New System.Drawing.Point(16, 34)
        Me.ucrSelectorSeasonalityComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSeasonalityComparisons.Name = "ucrSelectorSeasonalityComparisons"
        Me.ucrSelectorSeasonalityComparisons.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorSeasonalityComparisons.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 576)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 19
        '
        'dlgSeasonalPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 642)
        Me.Controls.Add(Me.ucrInputEstimatesSummary)
        Me.Controls.Add(Me.lblEstimatesSummary)
        Me.Controls.Add(Me.lblEstimates)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblSeasonality)
        Me.Controls.Add(Me.lblReferenceSummary)
        Me.Controls.Add(Me.ucrInputEstimatesThreshold)
        Me.Controls.Add(Me.ucrInputReferenceThreshold)
        Me.Controls.Add(Me.ucrInputReferenceSummary)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.grpSmoothing)
        Me.Controls.Add(Me.grpValues)
        Me.Controls.Add(Me.ucrChkRemoveMissing)
        Me.Controls.Add(Me.ucrReceiverEstimates)
        Me.Controls.Add(Me.ucrReceiverSeasonality)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverReference)
        Me.Controls.Add(Me.ucrSelectorSeasonalityComparisons)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSeasonalPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seasonal Comparisons"
        Me.grpValues.ResumeLayout(False)
        Me.grpValues.PerformLayout()
        Me.grpSmoothing.ResumeLayout(False)
        Me.grpSmoothing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorSeasonalityComparisons As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReference As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpSmoothing As GroupBox
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrChkMovingAverage As ucrCheck
    Friend WithEvents ucrChkRemoveMissing As ucrCheck
    Friend WithEvents ucrReceiverEstimates As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonality As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrNudPeriod As ucrNud
    Friend WithEvents ucrNudHarmonics As ucrNud
    Friend WithEvents ucrInputSmoothing As ucrInputComboBox
    Friend WithEvents ucrInputEstimatesThreshold As ucrInputTextBox
    Friend WithEvents ucrInputReferenceThreshold As ucrInputTextBox
    Friend WithEvents ucrInputReferenceSummary As ucrInputComboBox
    Friend WithEvents lblEstimates As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblSeasonality As Label
    Friend WithEvents lblReferenceSummary As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblHarmonics As Label
    Friend WithEvents ucrInputN As ucrInputTextBox
    Friend WithEvents lblN As Label
    Friend WithEvents ucrNudSpan As ucrNud
    Friend WithEvents ucrNudDf As ucrNud
    Friend WithEvents lblDf As Label
    Friend WithEvents lblSpan As Label
    Friend WithEvents lblEstimatesSummary As Label
    Friend WithEvents ucrInputEstimatesSummary As ucrInputTextBox
End Class
