' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSeasonalSummaryRain
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
        Me.ucrBase = New instat.ucrButtons()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkSumLabel = New System.Windows.Forms.CheckBox()
        Me.chkLongestDrySpellName = New System.Windows.Forms.CheckBox()
        Me.chkReplace = New System.Windows.Forms.CheckBox()
        Me.chkCountLabel = New System.Windows.Forms.CheckBox()
        Me.chkStrictThreshold = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.lblMeanLabel = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.nudNosofMonth = New System.Windows.Forms.NumericUpDown()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonths = New System.Windows.Forms.Label()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.nudStartMonth = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.txtSpellLengthName = New System.Windows.Forms.TextBox()
        Me.txtLongDrySpellName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLongDrySpellLabel = New System.Windows.Forms.Label()
        Me.lblSpelllengthName = New System.Windows.Forms.Label()
        Me.grpSummaries.SuspendLayout()
        CType(Me.nudNosofMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(131, 427)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 39)
        Me.ucrBase.TabIndex = 0
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(451, 361)
        Me.chkRemoveNA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(102, 21)
        Me.chkRemoveNA.TabIndex = 1
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox1"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkSumLabel
        '
        Me.chkSumLabel.AutoSize = True
        Me.chkSumLabel.Location = New System.Drawing.Point(8, 20)
        Me.chkSumLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSumLabel.Name = "chkSumLabel"
        Me.chkSumLabel.Size = New System.Drawing.Size(102, 21)
        Me.chkSumLabel.TabIndex = 2
        Me.chkSumLabel.Tag = "Totals"
        Me.chkSumLabel.Text = "CheckBox2"
        Me.chkSumLabel.UseVisualStyleBackColor = True
        '
        'chkLongestDrySpellName
        '
        Me.chkLongestDrySpellName.AutoSize = True
        Me.chkLongestDrySpellName.Location = New System.Drawing.Point(216, 361)
        Me.chkLongestDrySpellName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkLongestDrySpellName.Name = "chkLongestDrySpellName"
        Me.chkLongestDrySpellName.Size = New System.Drawing.Size(102, 21)
        Me.chkLongestDrySpellName.TabIndex = 3
        Me.chkLongestDrySpellName.Tag = "Longest_Dry_Spell_Name"
        Me.chkLongestDrySpellName.Text = "CheckBox3"
        Me.chkLongestDrySpellName.UseVisualStyleBackColor = True
        '
        'chkReplace
        '
        Me.chkReplace.AutoSize = True
        Me.chkReplace.Location = New System.Drawing.Point(665, 361)
        Me.chkReplace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkReplace.Name = "chkReplace"
        Me.chkReplace.Size = New System.Drawing.Size(102, 21)
        Me.chkReplace.TabIndex = 4
        Me.chkReplace.Tag = "Replace"
        Me.chkReplace.Text = "CheckBox4"
        Me.chkReplace.UseVisualStyleBackColor = True
        '
        'chkCountLabel
        '
        Me.chkCountLabel.AutoSize = True
        Me.chkCountLabel.Location = New System.Drawing.Point(144, 20)
        Me.chkCountLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCountLabel.Name = "chkCountLabel"
        Me.chkCountLabel.Size = New System.Drawing.Size(102, 21)
        Me.chkCountLabel.TabIndex = 5
        Me.chkCountLabel.Tag = "Counts"
        Me.chkCountLabel.Text = "CheckBox5"
        Me.chkCountLabel.UseVisualStyleBackColor = True
        '
        'chkStrictThreshold
        '
        Me.chkStrictThreshold.AutoSize = True
        Me.chkStrictThreshold.Location = New System.Drawing.Point(24, 361)
        Me.chkStrictThreshold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkStrictThreshold.Name = "chkStrictThreshold"
        Me.chkStrictThreshold.Size = New System.Drawing.Size(102, 21)
        Me.chkStrictThreshold.TabIndex = 6
        Me.chkStrictThreshold.Tag = "Strict_Threshold"
        Me.chkStrictThreshold.Text = "CheckBox6"
        Me.chkStrictThreshold.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(8, 60)
        Me.chkMean.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(102, 21)
        Me.chkMean.TabIndex = 7
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "CheckBox7"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(23, 23)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox8.TabIndex = 8
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(237, 23)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(23, 71)
        Me.chk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(109, 21)
        Me.chk.TabIndex = 10
        Me.chk.Text = "CheckBox10"
        Me.chk.UseVisualStyleBackColor = True
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.lblMeanLabel)
        Me.grpSummaries.Controls.Add(Me.lblCount)
        Me.grpSummaries.Controls.Add(Me.lblTotals)
        Me.grpSummaries.Controls.Add(Me.lblStartMonth)
        Me.grpSummaries.Controls.Add(Me.nudNosofMonth)
        Me.grpSummaries.Controls.Add(Me.txtTotal)
        Me.grpSummaries.Controls.Add(Me.txtCount)
        Me.grpSummaries.Controls.Add(Me.lblNumberofMonths)
        Me.grpSummaries.Controls.Add(Me.txtMean)
        Me.grpSummaries.Controls.Add(Me.chkMean)
        Me.grpSummaries.Controls.Add(Me.chkCountLabel)
        Me.grpSummaries.Controls.Add(Me.nudStartMonth)
        Me.grpSummaries.Controls.Add(Me.chkSumLabel)
        Me.grpSummaries.Location = New System.Drawing.Point(16, 32)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSummaries.Size = New System.Drawing.Size(661, 165)
        Me.grpSummaries.TabIndex = 11
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Tag = "Summaries"
        Me.grpSummaries.Text = "Summaries"
        '
        'lblMeanLabel
        '
        Me.lblMeanLabel.AutoSize = True
        Me.lblMeanLabel.Location = New System.Drawing.Point(309, 130)
        Me.lblMeanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanLabel.Name = "lblMeanLabel"
        Me.lblMeanLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblMeanLabel.TabIndex = 23
        Me.lblMeanLabel.Tag = "Mean_Label"
        Me.lblMeanLabel.Text = "Label5"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(309, 76)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(49, 16)
        Me.lblCount.TabIndex = 22
        Me.lblCount.Tag = "Count_Label"
        Me.lblCount.Text = "Label4"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(309, 25)
        Me.lblTotals.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(49, 16)
        Me.lblTotals.TabIndex = 21
        Me.lblTotals.Tag = "Total_Label"
        Me.lblTotals.Text = "Label3"
        '
        'lblStartMonth
        '
        Me.lblStartMonth.AutoSize = True
        Me.lblStartMonth.Location = New System.Drawing.Point(8, 106)
        Me.lblStartMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartMonth.Name = "lblStartMonth"
        Me.lblStartMonth.Size = New System.Drawing.Size(49, 16)
        Me.lblStartMonth.TabIndex = 14
        Me.lblStartMonth.Tag = "Start_Month"
        Me.lblStartMonth.Text = "Label2"
        '
        'nudNosofMonth
        '
        Me.nudNosofMonth.Location = New System.Drawing.Point(157, 135)
        Me.nudNosofMonth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudNosofMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudNosofMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNosofMonth.Name = "nudNosofMonth"
        Me.nudNosofMonth.Size = New System.Drawing.Size(73, 22)
        Me.nudNosofMonth.TabIndex = 11
        Me.nudNosofMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(401, 23)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(251, 22)
        Me.txtTotal.TabIndex = 16
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(401, 76)
        Me.txtCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(251, 22)
        Me.txtCount.TabIndex = 19
        '
        'lblNumberofMonths
        '
        Me.lblNumberofMonths.AutoSize = True
        Me.lblNumberofMonths.Location = New System.Drawing.Point(8, 130)
        Me.lblNumberofMonths.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberofMonths.Name = "lblNumberofMonths"
        Me.lblNumberofMonths.Size = New System.Drawing.Size(49, 16)
        Me.lblNumberofMonths.TabIndex = 13
        Me.lblNumberofMonths.Tag = "Nos._of_Months"
        Me.lblNumberofMonths.Text = "Label1"
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(401, 126)
        Me.txtMean.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(251, 22)
        Me.txtMean.TabIndex = 20
        '
        'nudStartMonth
        '
        Me.nudStartMonth.Location = New System.Drawing.Point(157, 103)
        Me.nudStartMonth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudStartMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudStartMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartMonth.Name = "nudStartMonth"
        Me.nudStartMonth.Size = New System.Drawing.Size(73, 22)
        Me.nudStartMonth.TabIndex = 12
        Me.nudStartMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblThreshold)
        Me.GroupBox2.Controls.Add(Me.nudThreshold)
        Me.GroupBox2.Controls.Add(Me.chk)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 236)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(361, 101)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Threshold"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(189, 71)
        Me.lblThreshold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(49, 16)
        Me.lblThreshold.TabIndex = 25
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label3"
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(273, 68)
        Me.nudThreshold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(72, 22)
        Me.nudThreshold.TabIndex = 24
        Me.nudThreshold.Tag = ""
        Me.nudThreshold.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'txtSpellLengthName
        '
        Me.txtSpellLengthName.Location = New System.Drawing.Point(173, 288)
        Me.txtSpellLengthName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpellLengthName.Name = "txtSpellLengthName"
        Me.txtSpellLengthName.Size = New System.Drawing.Size(132, 22)
        Me.txtSpellLengthName.TabIndex = 17
        '
        'txtLongDrySpellName
        '
        Me.txtLongDrySpellName.Location = New System.Drawing.Point(173, 256)
        Me.txtLongDrySpellName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLongDrySpellName.Name = "txtLongDrySpellName"
        Me.txtLongDrySpellName.Size = New System.Drawing.Size(132, 22)
        Me.txtLongDrySpellName.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Data list not implemented"
        '
        'lblLongDrySpellLabel
        '
        Me.lblLongDrySpellLabel.AutoSize = True
        Me.lblLongDrySpellLabel.Location = New System.Drawing.Point(49, 256)
        Me.lblLongDrySpellLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongDrySpellLabel.Name = "lblLongDrySpellLabel"
        Me.lblLongDrySpellLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblLongDrySpellLabel.TabIndex = 25
        Me.lblLongDrySpellLabel.Tag = "Long_Dry_Spell_Label"
        Me.lblLongDrySpellLabel.Text = "Label7"
        '
        'lblSpelllengthName
        '
        Me.lblSpelllengthName.AutoSize = True
        Me.lblSpelllengthName.Location = New System.Drawing.Point(49, 292)
        Me.lblSpelllengthName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpelllengthName.Name = "lblSpelllengthName"
        Me.lblSpelllengthName.Size = New System.Drawing.Size(49, 16)
        Me.lblSpelllengthName.TabIndex = 26
        Me.lblSpelllengthName.Tag = "Spell_Name"
        Me.lblSpelllengthName.Text = "Label8"
        '
        'dlgSeasonalSummaryRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 469)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLongDrySpellLabel)
        Me.Controls.Add(Me.lblSpelllengthName)
        Me.Controls.Add(Me.txtSpellLengthName)
        Me.Controls.Add(Me.txtLongDrySpellName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkStrictThreshold)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkReplace)
        Me.Controls.Add(Me.chkLongestDrySpellName)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSeasonalSummaryRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Seasonal_Summary_Rain"
        Me.Text = "dlgSeasonalSummaryRain"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        CType(Me.nudNosofMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkSumLabel As CheckBox
    Friend WithEvents chkLongestDrySpellName As CheckBox
    Friend WithEvents chkReplace As CheckBox
    Friend WithEvents chkCountLabel As CheckBox
    Friend WithEvents chkStrictThreshold As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents chk As CheckBox
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents lblMeanLabel As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudNosofMonth As NumericUpDown
    Friend WithEvents nudStartMonth As NumericUpDown
    Friend WithEvents lblNumberofMonths As Label
    Friend WithEvents lblStartMonth As Label
    Friend WithEvents txtSpellLengthName As TextBox
    Friend WithEvents txtLongDrySpellName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLongDrySpellLabel As Label
    Friend WithEvents lblSpelllengthName As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents nudThreshold As NumericUpDown
End Class
