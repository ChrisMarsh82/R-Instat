<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgConditionalQuantilePlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrConditionalQuantilePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverObservations = New instat.ucrReceiverSingle()
        Me.lblObservations = New System.Windows.Forms.Label()
        Me.lblPredictions = New System.Windows.Forms.Label()
        Me.ucrReceiverPredictions = New instat.ucrReceiverSingle()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrNudBin = New instat.ucrNud()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.lblTypes = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleFacet = New instat.ucrReceiverMultiple()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrNudColumns = New instat.ucrNud()
        Me.ttConditionalQuatilePlot = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColNumber = New System.Windows.Forms.Label()
        Me.lblLegendPositions = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.rdoQuantiles = New System.Windows.Forms.RadioButton()
        Me.rdoEvaluation = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverMultiplePred = New instat.ucrReceiverMultiple()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrReceiverType = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleObs = New instat.ucrReceiverMultiple()
        Me.lblVarObserved = New System.Windows.Forms.Label()
        Me.lblStatistics = New System.Windows.Forms.Label()
        Me.lblVarPredicted = New System.Windows.Forms.Label()
        Me.ucrReceiverStatistics = New instat.ucrReceiverSingle()
        Me.ucrNudMinNumPoints = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 538)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrConditionalQuantilePlotSelector
        '
        Me.ucrConditionalQuantilePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrConditionalQuantilePlotSelector.bShowHiddenColumns = False
        Me.ucrConditionalQuantilePlotSelector.bUseCurrentFilter = True
        Me.ucrConditionalQuantilePlotSelector.Location = New System.Drawing.Point(12, 53)
        Me.ucrConditionalQuantilePlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrConditionalQuantilePlotSelector.Name = "ucrConditionalQuantilePlotSelector"
        Me.ucrConditionalQuantilePlotSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrConditionalQuantilePlotSelector.TabIndex = 3
        '
        'ucrReceiverObservations
        '
        Me.ucrReceiverObservations.frmParent = Me
        Me.ucrReceiverObservations.Location = New System.Drawing.Point(376, 96)
        Me.ucrReceiverObservations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObservations.Name = "ucrReceiverObservations"
        Me.ucrReceiverObservations.Selector = Nothing
        Me.ucrReceiverObservations.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverObservations.strNcFilePath = ""
        Me.ucrReceiverObservations.TabIndex = 5
        Me.ucrReceiverObservations.ucrSelector = Nothing
        '
        'lblObservations
        '
        Me.lblObservations.AutoSize = True
        Me.lblObservations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservations.Location = New System.Drawing.Point(379, 74)
        Me.lblObservations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservations.Name = "lblObservations"
        Me.lblObservations.Size = New System.Drawing.Size(91, 16)
        Me.lblObservations.TabIndex = 4
        Me.lblObservations.Text = "Observations:"
        '
        'lblPredictions
        '
        Me.lblPredictions.AutoSize = True
        Me.lblPredictions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPredictions.Location = New System.Drawing.Point(379, 135)
        Me.lblPredictions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPredictions.Name = "lblPredictions"
        Me.lblPredictions.Size = New System.Drawing.Size(78, 16)
        Me.lblPredictions.TabIndex = 6
        Me.lblPredictions.Text = "Predictions:"
        '
        'ucrReceiverPredictions
        '
        Me.ucrReceiverPredictions.frmParent = Me
        Me.ucrReceiverPredictions.Location = New System.Drawing.Point(376, 159)
        Me.ucrReceiverPredictions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPredictions.Name = "ucrReceiverPredictions"
        Me.ucrReceiverPredictions.Selector = Nothing
        Me.ucrReceiverPredictions.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverPredictions.strNcFilePath = ""
        Me.ucrReceiverPredictions.TabIndex = 7
        Me.ucrReceiverPredictions.ucrSelector = Nothing
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Enabled = False
        Me.cmdPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotOptions.Location = New System.Drawing.Point(12, 282)
        Me.cmdPlotOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(197, 28)
        Me.cmdPlotOptions.TabIndex = 66
        Me.cmdPlotOptions.Text = "Conditional Quantile Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrNudBin
        '
        Me.ucrNudBin.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBin.Location = New System.Drawing.Point(220, 326)
        Me.ucrNudBin.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudBin.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBin.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Name = "ucrNudBin"
        Me.ucrNudBin.Size = New System.Drawing.Size(53, 25)
        Me.ucrNudBin.TabIndex = 68
        Me.ucrNudBin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(12, 508)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(427, 27)
        Me.ucrSavePlot.TabIndex = 72
        '
        'lblTypes
        '
        Me.lblTypes.AutoSize = True
        Me.lblTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTypes.Location = New System.Drawing.Point(379, 197)
        Me.lblTypes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypes.Name = "lblTypes"
        Me.lblTypes.Size = New System.Drawing.Size(125, 16)
        Me.lblTypes.TabIndex = 8
        Me.lblTypes.Text = "Facet By (Optional):"
        '
        'ucrReceiverMultipleFacet
        '
        Me.ucrReceiverMultipleFacet.frmParent = Me
        Me.ucrReceiverMultipleFacet.Location = New System.Drawing.Point(376, 222)
        Me.ucrReceiverMultipleFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFacet.Name = "ucrReceiverMultipleFacet"
        Me.ucrReceiverMultipleFacet.Selector = Nothing
        Me.ucrReceiverMultipleFacet.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverMultipleFacet.strNcFilePath = ""
        Me.ucrReceiverMultipleFacet.TabIndex = 9
        Me.ucrReceiverMultipleFacet.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(220, 390)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(119, 26)
        Me.ucrInputLegendPosition.TabIndex = 75
        '
        'ucrNudColumns
        '
        Me.ucrNudColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumns.Location = New System.Drawing.Point(420, 391)
        Me.ucrNudColumns.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Name = "ucrNudColumns"
        Me.ucrNudColumns.Size = New System.Drawing.Size(53, 25)
        Me.ucrNudColumns.TabIndex = 76
        Me.ucrNudColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ttConditionalQuatilePlot
        '
        Me.ttConditionalQuatilePlot.AutoPopDelay = 10000
        Me.ttConditionalQuatilePlot.InitialDelay = 500
        Me.ttConditionalQuatilePlot.ReshowDelay = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 330)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Histogram Bins:"
        '
        'lblColNumber
        '
        Me.lblColNumber.AutoSize = True
        Me.lblColNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColNumber.Location = New System.Drawing.Point(12, 361)
        Me.lblColNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColNumber.Name = "lblColNumber"
        Me.lblColNumber.Size = New System.Drawing.Size(169, 16)
        Me.lblColNumber.TabIndex = 80
        Me.lblColNumber.Text = "Minimum Number of Points:"
        '
        'lblLegendPositions
        '
        Me.lblLegendPositions.AutoSize = True
        Me.lblLegendPositions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLegendPositions.Location = New System.Drawing.Point(12, 395)
        Me.lblLegendPositions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegendPositions.Name = "lblLegendPositions"
        Me.lblLegendPositions.Size = New System.Drawing.Size(108, 16)
        Me.lblLegendPositions.TabIndex = 81
        Me.lblLegendPositions.Text = "Legend Position:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(344, 395)
        Me.lblColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(71, 16)
        Me.lblColumns.TabIndex = 82
        Me.lblColumns.Text = "Column(s):"
        '
        'rdoQuantiles
        '
        Me.rdoQuantiles.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQuantiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoQuantiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatAppearance.BorderSize = 2
        Me.rdoQuantiles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQuantiles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQuantiles.Location = New System.Drawing.Point(103, 6)
        Me.rdoQuantiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoQuantiles.Name = "rdoQuantiles"
        Me.rdoQuantiles.Size = New System.Drawing.Size(180, 33)
        Me.rdoQuantiles.TabIndex = 1
        Me.rdoQuantiles.Text = "Quantiles"
        Me.rdoQuantiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQuantiles.UseVisualStyleBackColor = True
        '
        'rdoEvaluation
        '
        Me.rdoEvaluation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEvaluation.Enabled = False
        Me.rdoEvaluation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEvaluation.FlatAppearance.BorderSize = 2
        Me.rdoEvaluation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEvaluation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEvaluation.Location = New System.Drawing.Point(280, 6)
        Me.rdoEvaluation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoEvaluation.Name = "rdoEvaluation"
        Me.rdoEvaluation.Size = New System.Drawing.Size(180, 33)
        Me.rdoEvaluation.TabIndex = 2
        Me.rdoEvaluation.Text = "Evaluation"
        Me.rdoEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEvaluation.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(96, 4)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(371, 43)
        Me.ucrPnlOptions.TabIndex = 85
        '
        'ucrReceiverMultiplePred
        '
        Me.ucrReceiverMultiplePred.frmParent = Me
        Me.ucrReceiverMultiplePred.Location = New System.Drawing.Point(376, 380)
        Me.ucrReceiverMultiplePred.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePred.Name = "ucrReceiverMultiplePred"
        Me.ucrReceiverMultiplePred.Selector = Nothing
        Me.ucrReceiverMultiplePred.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverMultiplePred.strNcFilePath = ""
        Me.ucrReceiverMultiplePred.TabIndex = 11
        Me.ucrReceiverMultiplePred.ucrSelector = Nothing
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(17, 363)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(43, 16)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "Type:"
        '
        'ucrReceiverType
        '
        Me.ucrReceiverType.frmParent = Me
        Me.ucrReceiverType.Location = New System.Drawing.Point(65, 361)
        Me.ucrReceiverType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverType.Name = "ucrReceiverType"
        Me.ucrReceiverType.Selector = Nothing
        Me.ucrReceiverType.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverType.strNcFilePath = ""
        Me.ucrReceiverType.TabIndex = 13
        Me.ucrReceiverType.ucrSelector = Nothing
        '
        'ucrReceiverMultipleObs
        '
        Me.ucrReceiverMultipleObs.frmParent = Me
        Me.ucrReceiverMultipleObs.Location = New System.Drawing.Point(376, 222)
        Me.ucrReceiverMultipleObs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleObs.Name = "ucrReceiverMultipleObs"
        Me.ucrReceiverMultipleObs.Selector = Nothing
        Me.ucrReceiverMultipleObs.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverMultipleObs.strNcFilePath = ""
        Me.ucrReceiverMultipleObs.TabIndex = 9
        Me.ucrReceiverMultipleObs.ucrSelector = Nothing
        '
        'lblVarObserved
        '
        Me.lblVarObserved.AutoSize = True
        Me.lblVarObserved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVarObserved.Location = New System.Drawing.Point(379, 197)
        Me.lblVarObserved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVarObserved.Name = "lblVarObserved"
        Me.lblVarObserved.Size = New System.Drawing.Size(167, 16)
        Me.lblVarObserved.TabIndex = 8
        Me.lblVarObserved.Text = "Other Observed Variables:"
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = True
        Me.lblStatistics.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatistics.Location = New System.Drawing.Point(15, 420)
        Me.lblStatistics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(64, 16)
        Me.lblStatistics.TabIndex = 14
        Me.lblStatistics.Text = "Statistics:"
        '
        'lblVarPredicted
        '
        Me.lblVarPredicted.AutoSize = True
        Me.lblVarPredicted.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVarPredicted.Location = New System.Drawing.Point(379, 354)
        Me.lblVarPredicted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVarPredicted.Name = "lblVarPredicted"
        Me.lblVarPredicted.Size = New System.Drawing.Size(165, 16)
        Me.lblVarPredicted.TabIndex = 10
        Me.lblVarPredicted.Text = "Other Predicted Variables:"
        '
        'ucrReceiverStatistics
        '
        Me.ucrReceiverStatistics.frmParent = Me
        Me.ucrReceiverStatistics.Location = New System.Drawing.Point(85, 417)
        Me.ucrReceiverStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStatistics.Name = "ucrReceiverStatistics"
        Me.ucrReceiverStatistics.Selector = Nothing
        Me.ucrReceiverStatistics.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStatistics.strNcFilePath = ""
        Me.ucrReceiverStatistics.TabIndex = 15
        Me.ucrReceiverStatistics.ucrSelector = Nothing
        '
        'ucrNudMinNumPoints
        '
        Me.ucrNudMinNumPoints.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinNumPoints.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinNumPoints.Location = New System.Drawing.Point(220, 358)
        Me.ucrNudMinNumPoints.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudMinNumPoints.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinNumPoints.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinNumPoints.Name = "ucrNudMinNumPoints"
        Me.ucrNudMinNumPoints.Size = New System.Drawing.Size(53, 25)
        Me.ucrNudMinNumPoints.TabIndex = 86
        Me.ucrNudMinNumPoints.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgConditionalQuantilePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 604)
        Me.Controls.Add(Me.ucrNudMinNumPoints)
        Me.Controls.Add(Me.ucrReceiverStatistics)
        Me.Controls.Add(Me.lblVarPredicted)
        Me.Controls.Add(Me.lblStatistics)
        Me.Controls.Add(Me.lblVarObserved)
        Me.Controls.Add(Me.ucrReceiverMultipleObs)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrReceiverType)
        Me.Controls.Add(Me.ucrReceiverMultiplePred)
        Me.Controls.Add(Me.rdoQuantiles)
        Me.Controls.Add(Me.rdoEvaluation)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.lblLegendPositions)
        Me.Controls.Add(Me.lblColNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrNudColumns)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrReceiverMultipleFacet)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrNudBin)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.lblPredictions)
        Me.Controls.Add(Me.ucrReceiverPredictions)
        Me.Controls.Add(Me.lblTypes)
        Me.Controls.Add(Me.ucrReceiverObservations)
        Me.Controls.Add(Me.lblObservations)
        Me.Controls.Add(Me.ucrConditionalQuantilePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConditionalQuantilePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conditional Quantile Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrConditionalQuantilePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverObservations As ucrReceiverSingle
    Friend WithEvents lblObservations As Label
    Friend WithEvents lblPredictions As Label
    Friend WithEvents ucrReceiverPredictions As ucrReceiverSingle
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrNudBin As ucrNud
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents lblTypes As Label
    Friend WithEvents ucrReceiverMultipleFacet As ucrReceiverMultiple
    Friend WithEvents ucrNudColumns As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ttConditionalQuatilePlot As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLegendPositions As Label
    Friend WithEvents lblColNumber As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents rdoQuantiles As RadioButton
    Friend WithEvents rdoEvaluation As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblType As Label
    Friend WithEvents ucrReceiverType As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultiplePred As ucrReceiverMultiple
    Friend WithEvents lblVarObserved As Label
    Friend WithEvents ucrReceiverMultipleObs As ucrReceiverMultiple
    Friend WithEvents lblStatistics As Label
    Friend WithEvents lblVarPredicted As Label
    Friend WithEvents ucrReceiverStatistics As ucrReceiverSingle
    Friend WithEvents ucrNudMinNumPoints As ucrNud
End Class
