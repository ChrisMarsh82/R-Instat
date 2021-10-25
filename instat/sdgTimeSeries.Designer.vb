<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTimeSeries
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
        Me.grpComparisonSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkKge = New instat.ucrCheck()
        Me.ucrChkRmse = New instat.ucrCheck()
        Me.ucrChkMae = New instat.ucrCheck()
        Me.ucrChkMe = New instat.ucrCheck()
        Me.ucrChkRSd = New instat.ucrCheck()
        Me.ucrChkPBias = New instat.ucrCheck()
        Me.ucrChkCor = New instat.ucrCheck()
        Me.ucrChkN = New instat.ucrCheck()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblPositionReference = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrInputPositionReference = New instat.ucrInputComboBox()
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.ucrInputSeparator = New instat.ucrInputTextBox()
        Me.ucrInputFontSize = New instat.ucrInputTextBox()
        Me.rdoIndividual = New System.Windows.Forms.RadioButton()
        Me.rdoComparison = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSummaries = New instat.UcrPanel()
        Me.ucrInputPositionEstimates = New instat.ucrInputComboBox()
        Me.lblPositionEstimates = New System.Windows.Forms.Label()
        Me.grpIndividualSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkSlopeIndividual = New instat.ucrCheck()
        Me.ucrChkSdIndividual = New instat.ucrCheck()
        Me.ucrChkMeanIndividual = New instat.ucrCheck()
        Me.ucrChkNIndividual = New instat.ucrCheck()
        Me.grpComparisonSummaries.SuspendLayout()
        Me.grpIndividualSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpComparisonSummaries
        '
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkKge)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkRmse)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkMae)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkMe)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkRSd)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkPBias)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkCor)
        Me.grpComparisonSummaries.Controls.Add(Me.ucrChkN)
        Me.grpComparisonSummaries.Location = New System.Drawing.Point(19, 81)
        Me.grpComparisonSummaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpComparisonSummaries.Name = "grpComparisonSummaries"
        Me.grpComparisonSummaries.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpComparisonSummaries.Size = New System.Drawing.Size(392, 117)
        Me.grpComparisonSummaries.TabIndex = 0
        Me.grpComparisonSummaries.TabStop = False
        Me.grpComparisonSummaries.Text = "Comparison Summaries"
        '
        'ucrChkKge
        '
        Me.ucrChkKge.Checked = False
        Me.ucrChkKge.Location = New System.Drawing.Point(299, 75)
        Me.ucrChkKge.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkKge.Name = "ucrChkKge"
        Me.ucrChkKge.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkKge.TabIndex = 10
        '
        'ucrChkRmse
        '
        Me.ucrChkRmse.Checked = False
        Me.ucrChkRmse.Location = New System.Drawing.Point(204, 75)
        Me.ucrChkRmse.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkRmse.Name = "ucrChkRmse"
        Me.ucrChkRmse.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkRmse.TabIndex = 9
        '
        'ucrChkMae
        '
        Me.ucrChkMae.Checked = False
        Me.ucrChkMae.Location = New System.Drawing.Point(109, 75)
        Me.ucrChkMae.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkMae.Name = "ucrChkMae"
        Me.ucrChkMae.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkMae.TabIndex = 8
        '
        'ucrChkMe
        '
        Me.ucrChkMe.Checked = False
        Me.ucrChkMe.Location = New System.Drawing.Point(15, 75)
        Me.ucrChkMe.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkMe.Name = "ucrChkMe"
        Me.ucrChkMe.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkMe.TabIndex = 7
        '
        'ucrChkRSd
        '
        Me.ucrChkRSd.Checked = False
        Me.ucrChkRSd.Location = New System.Drawing.Point(299, 36)
        Me.ucrChkRSd.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkRSd.Name = "ucrChkRSd"
        Me.ucrChkRSd.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkRSd.TabIndex = 6
        '
        'ucrChkPBias
        '
        Me.ucrChkPBias.Checked = False
        Me.ucrChkPBias.Location = New System.Drawing.Point(204, 36)
        Me.ucrChkPBias.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkPBias.Name = "ucrChkPBias"
        Me.ucrChkPBias.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkPBias.TabIndex = 2
        '
        'ucrChkCor
        '
        Me.ucrChkCor.Checked = False
        Me.ucrChkCor.Location = New System.Drawing.Point(109, 36)
        Me.ucrChkCor.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkCor.Name = "ucrChkCor"
        Me.ucrChkCor.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkCor.TabIndex = 1
        '
        'ucrChkN
        '
        Me.ucrChkN.Checked = False
        Me.ucrChkN.Location = New System.Drawing.Point(15, 36)
        Me.ucrChkN.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkN.Name = "ucrChkN"
        Me.ucrChkN.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkN.TabIndex = 0
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(15, 218)
        Me.lblSeparator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(71, 16)
        Me.lblSeparator.TabIndex = 2
        Me.lblSeparator.Text = "Separator:"
        '
        'lblPositionReference
        '
        Me.lblPositionReference.AutoSize = True
        Me.lblPositionReference.Location = New System.Drawing.Point(15, 292)
        Me.lblPositionReference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionReference.Name = "lblPositionReference"
        Me.lblPositionReference.Size = New System.Drawing.Size(59, 16)
        Me.lblPositionReference.TabIndex = 3
        Me.lblPositionReference.Text = "Position:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(15, 255)
        Me.lblFontSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(66, 16)
        Me.lblFontSize.TabIndex = 4
        Me.lblFontSize.Text = "Font Size:"
        '
        'ucrInputPositionReference
        '
        Me.ucrInputPositionReference.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionReference.GetSetSelectedIndex = -1
        Me.ucrInputPositionReference.IsReadOnly = False
        Me.ucrInputPositionReference.Location = New System.Drawing.Point(165, 287)
        Me.ucrInputPositionReference.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputPositionReference.Name = "ucrInputPositionReference"
        Me.ucrInputPositionReference.Size = New System.Drawing.Size(133, 26)
        Me.ucrInputPositionReference.TabIndex = 5
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(116, 384)
        Me.ucrButtonsSummaries.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(200, 38)
        Me.ucrButtonsSummaries.TabIndex = 7
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsMultiline = False
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(165, 213)
        Me.ucrInputSeparator.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(53, 26)
        Me.ucrInputSeparator.TabIndex = 8
        '
        'ucrInputFontSize
        '
        Me.ucrInputFontSize.AddQuotesIfUnrecognised = True
        Me.ucrInputFontSize.IsMultiline = False
        Me.ucrInputFontSize.IsReadOnly = False
        Me.ucrInputFontSize.Location = New System.Drawing.Point(165, 250)
        Me.ucrInputFontSize.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(53, 26)
        Me.ucrInputFontSize.TabIndex = 9
        '
        'rdoIndividual
        '
        Me.rdoIndividual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIndividual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatAppearance.BorderSize = 2
        Me.rdoIndividual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIndividual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIndividual.Location = New System.Drawing.Point(215, 17)
        Me.rdoIndividual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoIndividual.Name = "rdoIndividual"
        Me.rdoIndividual.Size = New System.Drawing.Size(147, 33)
        Me.rdoIndividual.TabIndex = 12
        Me.rdoIndividual.TabStop = True
        Me.rdoIndividual.Text = "Individual"
        Me.rdoIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIndividual.UseVisualStyleBackColor = True
        '
        'rdoComparison
        '
        Me.rdoComparison.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoComparison.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoComparison.FlatAppearance.BorderSize = 2
        Me.rdoComparison.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoComparison.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoComparison.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoComparison.Location = New System.Drawing.Point(71, 17)
        Me.rdoComparison.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoComparison.Name = "rdoComparison"
        Me.rdoComparison.Size = New System.Drawing.Size(147, 33)
        Me.rdoComparison.TabIndex = 11
        Me.rdoComparison.TabStop = True
        Me.rdoComparison.Text = "Comparison"
        Me.rdoComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoComparison.UseVisualStyleBackColor = True
        '
        'ucrPnlSummaries
        '
        Me.ucrPnlSummaries.Location = New System.Drawing.Point(53, 14)
        Me.ucrPnlSummaries.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlSummaries.Name = "ucrPnlSummaries"
        Me.ucrPnlSummaries.Size = New System.Drawing.Size(325, 43)
        Me.ucrPnlSummaries.TabIndex = 10
        '
        'ucrInputPositionEstimates
        '
        Me.ucrInputPositionEstimates.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionEstimates.GetSetSelectedIndex = -1
        Me.ucrInputPositionEstimates.IsReadOnly = False
        Me.ucrInputPositionEstimates.Location = New System.Drawing.Point(165, 324)
        Me.ucrInputPositionEstimates.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputPositionEstimates.Name = "ucrInputPositionEstimates"
        Me.ucrInputPositionEstimates.Size = New System.Drawing.Size(133, 26)
        Me.ucrInputPositionEstimates.TabIndex = 14
        '
        'lblPositionEstimates
        '
        Me.lblPositionEstimates.AutoSize = True
        Me.lblPositionEstimates.Location = New System.Drawing.Point(15, 329)
        Me.lblPositionEstimates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionEstimates.Name = "lblPositionEstimates"
        Me.lblPositionEstimates.Size = New System.Drawing.Size(128, 16)
        Me.lblPositionEstimates.TabIndex = 13
        Me.lblPositionEstimates.Text = "Position - Estimates:"
        '
        'grpIndividualSummaries
        '
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkSlopeIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkSdIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkMeanIndividual)
        Me.grpIndividualSummaries.Controls.Add(Me.ucrChkNIndividual)
        Me.grpIndividualSummaries.Location = New System.Drawing.Point(19, 81)
        Me.grpIndividualSummaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIndividualSummaries.Name = "grpIndividualSummaries"
        Me.grpIndividualSummaries.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIndividualSummaries.Size = New System.Drawing.Size(392, 75)
        Me.grpIndividualSummaries.TabIndex = 11
        Me.grpIndividualSummaries.TabStop = False
        Me.grpIndividualSummaries.Text = "Individual Summaries"
        '
        'ucrChkSlopeIndividual
        '
        Me.ucrChkSlopeIndividual.Checked = False
        Me.ucrChkSlopeIndividual.Location = New System.Drawing.Point(299, 36)
        Me.ucrChkSlopeIndividual.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkSlopeIndividual.Name = "ucrChkSlopeIndividual"
        Me.ucrChkSlopeIndividual.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkSlopeIndividual.TabIndex = 6
        '
        'ucrChkSdIndividual
        '
        Me.ucrChkSdIndividual.Checked = False
        Me.ucrChkSdIndividual.Location = New System.Drawing.Point(204, 36)
        Me.ucrChkSdIndividual.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkSdIndividual.Name = "ucrChkSdIndividual"
        Me.ucrChkSdIndividual.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkSdIndividual.TabIndex = 2
        '
        'ucrChkMeanIndividual
        '
        Me.ucrChkMeanIndividual.Checked = False
        Me.ucrChkMeanIndividual.Location = New System.Drawing.Point(109, 36)
        Me.ucrChkMeanIndividual.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkMeanIndividual.Name = "ucrChkMeanIndividual"
        Me.ucrChkMeanIndividual.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkMeanIndividual.TabIndex = 1
        '
        'ucrChkNIndividual
        '
        Me.ucrChkNIndividual.Checked = False
        Me.ucrChkNIndividual.Location = New System.Drawing.Point(15, 36)
        Me.ucrChkNIndividual.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkNIndividual.Name = "ucrChkNIndividual"
        Me.ucrChkNIndividual.Size = New System.Drawing.Size(80, 25)
        Me.ucrChkNIndividual.TabIndex = 0
        '
        'sdgTimeSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 422)
        Me.Controls.Add(Me.grpIndividualSummaries)
        Me.Controls.Add(Me.ucrInputPositionEstimates)
        Me.Controls.Add(Me.lblPositionEstimates)
        Me.Controls.Add(Me.rdoIndividual)
        Me.Controls.Add(Me.rdoComparison)
        Me.Controls.Add(Me.ucrPnlSummaries)
        Me.Controls.Add(Me.ucrInputFontSize)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.ucrInputPositionReference)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblPositionReference)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.grpComparisonSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTimeSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Annotations"
        Me.grpComparisonSummaries.ResumeLayout(False)
        Me.grpIndividualSummaries.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpComparisonSummaries As GroupBox
    Friend WithEvents ucrChkPBias As ucrCheck
    Friend WithEvents ucrChkCor As ucrCheck
    Friend WithEvents ucrChkN As ucrCheck
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblPositionReference As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrInputPositionReference As ucrInputComboBox
    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents ucrChkKge As ucrCheck
    Friend WithEvents ucrChkRmse As ucrCheck
    Friend WithEvents ucrChkMae As ucrCheck
    Friend WithEvents ucrChkMe As ucrCheck
    Friend WithEvents ucrChkRSd As ucrCheck
    Friend WithEvents ucrInputSeparator As ucrInputTextBox
    Friend WithEvents ucrInputFontSize As ucrInputTextBox
    Friend WithEvents rdoIndividual As RadioButton
    Friend WithEvents rdoComparison As RadioButton
    Friend WithEvents ucrPnlSummaries As UcrPanel
    Friend WithEvents ucrInputPositionEstimates As ucrInputComboBox
    Friend WithEvents lblPositionEstimates As Label
    Friend WithEvents grpIndividualSummaries As GroupBox
    Friend WithEvents ucrChkSlopeIndividual As ucrCheck
    Friend WithEvents ucrChkSdIndividual As ucrCheck
    Friend WithEvents ucrChkMeanIndividual As ucrCheck
    Friend WithEvents ucrChkNIndividual As ucrCheck
End Class
