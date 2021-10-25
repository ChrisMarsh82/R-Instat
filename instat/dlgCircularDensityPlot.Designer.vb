<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircularDensityPlot
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.rdoScatterPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoRosePlot = New System.Windows.Forms.RadioButton()
        Me.lblKernel = New System.Windows.Forms.Label()
        Me.lblBandWidth = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblBins = New System.Windows.Forms.Label()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputComboKernel = New instat.ucrInputComboBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrSaveDensity = New instat.ucrSave()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputBins = New instat.ucrInputTextBox()
        Me.ucrInputBandWidth = New instat.ucrInputTextBox()
        Me.ucrNudShrink = New instat.ucrNud()
        Me.lblShrink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(316, 277)
        Me.lblUnits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(41, 16)
        Me.lblUnits.TabIndex = 30
        Me.lblUnits.Text = "Units:"
        '
        'rdoScatterPlot
        '
        Me.rdoScatterPlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoScatterPlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScatterPlot.FlatAppearance.BorderSize = 2
        Me.rdoScatterPlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScatterPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoScatterPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoScatterPlot.Location = New System.Drawing.Point(355, 2)
        Me.rdoScatterPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoScatterPlot.Name = "rdoScatterPlot"
        Me.rdoScatterPlot.Size = New System.Drawing.Size(147, 58)
        Me.rdoScatterPlot.TabIndex = 28
        Me.rdoScatterPlot.TabStop = True
        Me.rdoScatterPlot.Tag = "ScatterOPlot"
        Me.rdoScatterPlot.Text = "Scatter Plot"
        Me.rdoScatterPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoScatterPlot.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDensity.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatAppearance.BorderSize = 2
        Me.rdoDensity.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(55, 2)
        Me.rdoDensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(135, 58)
        Me.rdoDensity.TabIndex = 27
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Tag = "Density"
        Me.rdoDensity.Text = "Density Plot"
        Me.rdoDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoRosePlot
        '
        Me.rdoRosePlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRosePlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRosePlot.FlatAppearance.BorderSize = 2
        Me.rdoRosePlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRosePlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRosePlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRosePlot.Location = New System.Drawing.Point(189, 2)
        Me.rdoRosePlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRosePlot.Name = "rdoRosePlot"
        Me.rdoRosePlot.Size = New System.Drawing.Size(165, 58)
        Me.rdoRosePlot.TabIndex = 26
        Me.rdoRosePlot.TabStop = True
        Me.rdoRosePlot.Tag = "RosePlot"
        Me.rdoRosePlot.Text = "Histogram (Rose Plot)"
        Me.rdoRosePlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRosePlot.UseVisualStyleBackColor = True
        '
        'lblKernel
        '
        Me.lblKernel.AutoSize = True
        Me.lblKernel.Location = New System.Drawing.Point(316, 244)
        Me.lblKernel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKernel.Name = "lblKernel"
        Me.lblKernel.Size = New System.Drawing.Size(52, 16)
        Me.lblKernel.TabIndex = 24
        Me.lblKernel.Text = "Kernel :"
        '
        'lblBandWidth
        '
        Me.lblBandWidth.AutoSize = True
        Me.lblBandWidth.Location = New System.Drawing.Point(316, 304)
        Me.lblBandWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBandWidth.Name = "lblBandWidth"
        Me.lblBandWidth.Size = New System.Drawing.Size(76, 16)
        Me.lblBandWidth.TabIndex = 22
        Me.lblBandWidth.Text = "Bandwidth: "
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(380, 87)
        Me.lblVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(62, 16)
        Me.lblVariable.TabIndex = 18
        Me.lblVariable.Text = "Variable:"
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(316, 304)
        Me.lblBins.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(75, 16)
        Me.lblBins.TabIndex = 33
        Me.lblBins.Text = "No of Bins: "
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.GetSetSelectedIndex = -1
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(423, 267)
        Me.ucrInputUnits.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(124, 26)
        Me.ucrInputUnits.TabIndex = 29
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(48, -2)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(464, 70)
        Me.ucrPnlOptions.TabIndex = 25
        '
        'ucrInputComboKernel
        '
        Me.ucrInputComboKernel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboKernel.GetSetSelectedIndex = -1
        Me.ucrInputComboKernel.IsReadOnly = False
        Me.ucrInputComboKernel.Location = New System.Drawing.Point(423, 234)
        Me.ucrInputComboKernel.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputComboKernel.Name = "ucrInputComboKernel"
        Me.ucrInputComboKernel.Size = New System.Drawing.Size(124, 26)
        Me.ucrInputComboKernel.TabIndex = 23
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(7, 316)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(227, 25)
        Me.ucrChkOmitMissing.TabIndex = 20
        '
        'ucrSaveDensity
        '
        Me.ucrSaveDensity.Location = New System.Drawing.Point(7, 366)
        Me.ucrSaveDensity.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveDensity.Name = "ucrSaveDensity"
        Me.ucrSaveDensity.Size = New System.Drawing.Size(411, 26)
        Me.ucrSaveDensity.TabIndex = 19
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(385, 105)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 17
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(13, 74)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorDataFrame.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 401)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.IsMultiline = False
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(452, 302)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(93, 26)
        Me.ucrInputBins.TabIndex = 32
        '
        'ucrInputBandWidth
        '
        Me.ucrInputBandWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputBandWidth.IsMultiline = False
        Me.ucrInputBandWidth.IsReadOnly = False
        Me.ucrInputBandWidth.Location = New System.Drawing.Point(471, 302)
        Me.ucrInputBandWidth.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputBandWidth.Name = "ucrInputBandWidth"
        Me.ucrInputBandWidth.Size = New System.Drawing.Size(75, 26)
        Me.ucrInputBandWidth.TabIndex = 21
        '
        'ucrNudShrink
        '
        Me.ucrNudShrink.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShrink.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShrink.Location = New System.Drawing.Point(480, 335)
        Me.ucrNudShrink.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudShrink.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShrink.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShrink.Name = "ucrNudShrink"
        Me.ucrNudShrink.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudShrink.TabIndex = 34
        Me.ucrNudShrink.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblShrink
        '
        Me.lblShrink.AutoSize = True
        Me.lblShrink.Location = New System.Drawing.Point(316, 343)
        Me.lblShrink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShrink.Name = "lblShrink"
        Me.lblShrink.Size = New System.Drawing.Size(51, 16)
        Me.lblShrink.TabIndex = 35
        Me.lblShrink.Text = "Shrink: "
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 480)
        Me.Controls.Add(Me.lblShrink)
        Me.Controls.Add(Me.ucrNudShrink)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.ucrInputUnits)
        Me.Controls.Add(Me.rdoScatterPlot)
        Me.Controls.Add(Me.rdoDensity)
        Me.Controls.Add(Me.rdoRosePlot)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblKernel)
        Me.Controls.Add(Me.ucrInputComboKernel)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSaveDensity)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.lblBandWidth)
        Me.Controls.Add(Me.ucrInputBins)
        Me.Controls.Add(Me.ucrInputBandWidth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularDensityPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circular Plots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblUnits As Label
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents rdoScatterPlot As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoRosePlot As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblKernel As Label
    Friend WithEvents ucrInputComboKernel As ucrInputComboBox
    Friend WithEvents lblBandWidth As Label
    Friend WithEvents ucrInputBandWidth As ucrInputTextBox
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrSaveDensity As ucrSave
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputBins As ucrInputTextBox
    Friend WithEvents lblBins As Label
    Friend WithEvents lblShrink As Label
    Friend WithEvents ucrNudShrink As ucrNud
End Class
