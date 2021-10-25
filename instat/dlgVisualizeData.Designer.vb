<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgVisualizeData
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
        Me.rdoVisDat = New System.Windows.Forms.RadioButton()
        Me.rdoVisMiss = New System.Windows.Forms.RadioButton()
        Me.rdoVisGuess = New System.Windows.Forms.RadioButton()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.lblMillionDataPoints = New System.Windows.Forms.Label()
        Me.lblPaltte = New System.Windows.Forms.Label()
        Me.lblSampling = New System.Windows.Forms.Label()
        Me.ucrNudAdjustSize = New instat.ucrNud()
        Me.ucrChkAdjustSize = New instat.ucrCheck()
        Me.ucrNudSamplingFunction = New instat.ucrNud()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.ucrChkSortVariables = New instat.ucrCheck()
        Me.ucrInputComboboxPalette = New instat.ucrInputComboBox()
        Me.ucrReceiverVisualizeData = New instat.ucrReceiverMultiple()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlVisualizeData = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSelectorVisualizeData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoVisDat
        '
        Me.rdoVisDat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisDat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatAppearance.BorderSize = 2
        Me.rdoVisDat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisDat.Location = New System.Drawing.Point(80, 14)
        Me.rdoVisDat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoVisDat.Name = "rdoVisDat"
        Me.rdoVisDat.Size = New System.Drawing.Size(133, 34)
        Me.rdoVisDat.TabIndex = 1
        Me.rdoVisDat.TabStop = True
        Me.rdoVisDat.Text = "Data"
        Me.rdoVisDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisDat.UseVisualStyleBackColor = True
        '
        'rdoVisMiss
        '
        Me.rdoVisMiss.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisMiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatAppearance.BorderSize = 2
        Me.rdoVisMiss.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisMiss.Location = New System.Drawing.Point(208, 14)
        Me.rdoVisMiss.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoVisMiss.Name = "rdoVisMiss"
        Me.rdoVisMiss.Size = New System.Drawing.Size(133, 34)
        Me.rdoVisMiss.TabIndex = 2
        Me.rdoVisMiss.TabStop = True
        Me.rdoVisMiss.Text = "Missing"
        Me.rdoVisMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisMiss.UseVisualStyleBackColor = True
        '
        'rdoVisGuess
        '
        Me.rdoVisGuess.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisGuess.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatAppearance.BorderSize = 2
        Me.rdoVisGuess.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisGuess.Location = New System.Drawing.Point(336, 14)
        Me.rdoVisGuess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoVisGuess.Name = "rdoVisGuess"
        Me.rdoVisGuess.Size = New System.Drawing.Size(133, 34)
        Me.rdoVisGuess.TabIndex = 3
        Me.rdoVisGuess.TabStop = True
        Me.rdoVisGuess.Text = "Guess"
        Me.rdoVisGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisGuess.UseVisualStyleBackColor = True
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(347, 85)
        Me.rdoWholeDataFrame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(104, 20)
        Me.rdoWholeDataFrame.TabIndex = 6
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(347, 113)
        Me.rdoSelectedColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(232, 30)
        Me.rdoSelectedColumn.TabIndex = 7
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(9, 364)
        Me.lblMaximumSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(97, 16)
        Me.lblMaximumSize.TabIndex = 14
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'lblMillionDataPoints
        '
        Me.lblMillionDataPoints.AutoSize = True
        Me.lblMillionDataPoints.Location = New System.Drawing.Point(216, 364)
        Me.lblMillionDataPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMillionDataPoints.Name = "lblMillionDataPoints"
        Me.lblMillionDataPoints.Size = New System.Drawing.Size(118, 16)
        Me.lblMillionDataPoints.TabIndex = 16
        Me.lblMillionDataPoints.Text = "Million Data Points"
        '
        'lblPaltte
        '
        Me.lblPaltte.AutoSize = True
        Me.lblPaltte.Location = New System.Drawing.Point(9, 331)
        Me.lblPaltte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaltte.Name = "lblPaltte"
        Me.lblPaltte.Size = New System.Drawing.Size(53, 16)
        Me.lblPaltte.TabIndex = 12
        Me.lblPaltte.Text = "Palette:"
        '
        'lblSampling
        '
        Me.lblSampling.AutoSize = True
        Me.lblSampling.Location = New System.Drawing.Point(255, 300)
        Me.lblSampling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSampling.Name = "lblSampling"
        Me.lblSampling.Size = New System.Drawing.Size(119, 16)
        Me.lblSampling.TabIndex = 9
        Me.lblSampling.Text = "Sampling Fraction:"
        '
        'ucrNudAdjustSize
        '
        Me.ucrNudAdjustSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAdjustSize.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAdjustSize.Location = New System.Drawing.Point(208, 400)
        Me.ucrNudAdjustSize.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudAdjustSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAdjustSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAdjustSize.Name = "ucrNudAdjustSize"
        Me.ucrNudAdjustSize.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudAdjustSize.TabIndex = 20
        Me.ucrNudAdjustSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkAdjustSize
        '
        Me.ucrChkAdjustSize.Checked = False
        Me.ucrChkAdjustSize.Location = New System.Drawing.Point(13, 400)
        Me.ucrChkAdjustSize.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkAdjustSize.Name = "ucrChkAdjustSize"
        Me.ucrChkAdjustSize.Size = New System.Drawing.Size(173, 25)
        Me.ucrChkAdjustSize.TabIndex = 19
        '
        'ucrNudSamplingFunction
        '
        Me.ucrNudSamplingFunction.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSamplingFunction.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Location = New System.Drawing.Point(440, 298)
        Me.ucrNudSamplingFunction.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudSamplingFunction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSamplingFunction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Name = "ucrNudSamplingFunction"
        Me.ucrNudSamplingFunction.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudSamplingFunction.TabIndex = 10
        Me.ucrNudSamplingFunction.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(145, 361)
        Me.ucrNudMaximumSize.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudMaximumSize.TabIndex = 15
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSortVariables
        '
        Me.ucrChkSortVariables.Checked = False
        Me.ucrChkSortVariables.Location = New System.Drawing.Point(13, 298)
        Me.ucrChkSortVariables.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkSortVariables.Name = "ucrChkSortVariables"
        Me.ucrChkSortVariables.Size = New System.Drawing.Size(193, 25)
        Me.ucrChkSortVariables.TabIndex = 11
        '
        'ucrInputComboboxPalette
        '
        Me.ucrInputComboboxPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputComboboxPalette.GetSetSelectedIndex = -1
        Me.ucrInputComboboxPalette.IsReadOnly = False
        Me.ucrInputComboboxPalette.Location = New System.Drawing.Point(73, 327)
        Me.ucrInputComboboxPalette.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputComboboxPalette.Name = "ucrInputComboboxPalette"
        Me.ucrInputComboboxPalette.Size = New System.Drawing.Size(113, 26)
        Me.ucrInputComboboxPalette.TabIndex = 13
        '
        'ucrReceiverVisualizeData
        '
        Me.ucrReceiverVisualizeData.frmParent = Me
        Me.ucrReceiverVisualizeData.Location = New System.Drawing.Point(347, 146)
        Me.ucrReceiverVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVisualizeData.Name = "ucrReceiverVisualizeData"
        Me.ucrReceiverVisualizeData.Selector = Nothing
        Me.ucrReceiverVisualizeData.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverVisualizeData.strNcFilePath = ""
        Me.ucrReceiverVisualizeData.TabIndex = 8
        Me.ucrReceiverVisualizeData.ucrSelector = Nothing
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(344, 85)
        Me.ucrPnlSelectData.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(189, 60)
        Me.ucrPnlSelectData.TabIndex = 5
        '
        'ucrPnlVisualizeData
        '
        Me.ucrPnlVisualizeData.Location = New System.Drawing.Point(59, 1)
        Me.ucrPnlVisualizeData.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlVisualizeData.Name = "ucrPnlVisualizeData"
        Me.ucrPnlVisualizeData.Size = New System.Drawing.Size(432, 57)
        Me.ucrPnlVisualizeData.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 434)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(425, 30)
        Me.ucrSaveGraph.TabIndex = 17
        '
        'ucrSelectorVisualizeData
        '
        Me.ucrSelectorVisualizeData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVisualizeData.bShowHiddenColumns = False
        Me.ucrSelectorVisualizeData.bUseCurrentFilter = True
        Me.ucrSelectorVisualizeData.Location = New System.Drawing.Point(13, 62)
        Me.ucrSelectorVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVisualizeData.Name = "ucrSelectorVisualizeData"
        Me.ucrSelectorVisualizeData.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorVisualizeData.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 474)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 18
        '
        'dlgVisualizeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 544)
        Me.Controls.Add(Me.ucrNudAdjustSize)
        Me.Controls.Add(Me.ucrChkAdjustSize)
        Me.Controls.Add(Me.lblSampling)
        Me.Controls.Add(Me.ucrNudSamplingFunction)
        Me.Controls.Add(Me.ucrNudMaximumSize)
        Me.Controls.Add(Me.lblPaltte)
        Me.Controls.Add(Me.ucrChkSortVariables)
        Me.Controls.Add(Me.lblMillionDataPoints)
        Me.Controls.Add(Me.lblMaximumSize)
        Me.Controls.Add(Me.ucrInputComboboxPalette)
        Me.Controls.Add(Me.ucrReceiverVisualizeData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.rdoVisGuess)
        Me.Controls.Add(Me.rdoVisMiss)
        Me.Controls.Add(Me.rdoVisDat)
        Me.Controls.Add(Me.ucrPnlVisualizeData)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrSelectorVisualizeData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgVisualizeData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualise Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVisualizeData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrPnlVisualizeData As UcrPanel
    Friend WithEvents rdoVisDat As RadioButton
    Friend WithEvents rdoVisMiss As RadioButton
    Friend WithEvents rdoVisGuess As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrReceiverVisualizeData As ucrReceiverMultiple
    Friend WithEvents ucrInputComboboxPalette As ucrInputComboBox
    Friend WithEvents lblMillionDataPoints As Label
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents ucrChkSortVariables As ucrCheck
    Friend WithEvents lblPaltte As Label
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents lblSampling As Label
    Friend WithEvents ucrNudSamplingFunction As ucrNud
    Friend WithEvents ucrNudAdjustSize As ucrNud
    Friend WithEvents ucrChkAdjustSize As ucrCheck
End Class