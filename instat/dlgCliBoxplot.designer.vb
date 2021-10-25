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
Partial Class dlgCliBoxplot
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkVarwidth = New System.Windows.Forms.CheckBox()
        Me.chkAdd = New System.Windows.Forms.CheckBox()
        Me.chkNotch = New System.Windows.Forms.CheckBox()
        Me.chkOutline = New System.Windows.Forms.CheckBox()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.chkFactorLevel = New System.Windows.Forms.CheckBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.nudRange = New System.Windows.Forms.NumericUpDown()
        Me.nudWhisklty = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblWhiskLineType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblDataPeriodLabel = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.lblAT = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblpars = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputDataPeriod = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputXLabel = New instat.ucrInputTextBox()
        Me.ucrInputWidth = New instat.ucrInputTextBox()
        Me.ucrInputYLabel = New instat.ucrInputTextBox()
        Me.ucrInputFactorLab = New instat.ucrInputTextBox()
        Me.ucrInputColour = New instat.ucrInputTextBox()
        Me.ucrInputLog = New instat.ucrInputTextBox()
        Me.ucrInputAt = New instat.ucrInputTextBox()
        Me.ucrInputBorder = New instat.ucrInputTextBox()
        Me.ucrInputPars = New instat.ucrInputTextBox()
        Me.grpOptions.SuspendLayout()
        CType(Me.nudRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'chkVarwidth
        '
        Me.chkVarwidth.AutoSize = True
        Me.chkVarwidth.Location = New System.Drawing.Point(8, 52)
        Me.chkVarwidth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkVarwidth.Name = "chkVarwidth"
        Me.chkVarwidth.Size = New System.Drawing.Size(122, 21)
        Me.chkVarwidth.TabIndex = 3
        Me.chkVarwidth.Tag = "Variable_Width"
        Me.chkVarwidth.Text = "Variable Width"
        Me.chkVarwidth.UseVisualStyleBackColor = True
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Location = New System.Drawing.Point(8, 23)
        Me.chkAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(59, 21)
        Me.chkAdd.TabIndex = 4
        Me.chkAdd.Tag = "add"
        Me.chkAdd.Text = "Add"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'chkNotch
        '
        Me.chkNotch.AutoSize = True
        Me.chkNotch.Location = New System.Drawing.Point(8, 80)
        Me.chkNotch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNotch.Name = "chkNotch"
        Me.chkNotch.Size = New System.Drawing.Size(69, 21)
        Me.chkNotch.TabIndex = 5
        Me.chkNotch.Tag = "Notch"
        Me.chkNotch.Text = "Notch"
        Me.chkNotch.UseVisualStyleBackColor = True
        '
        'chkOutline
        '
        Me.chkOutline.AutoSize = True
        Me.chkOutline.Location = New System.Drawing.Point(8, 108)
        Me.chkOutline.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkOutline.Name = "chkOutline"
        Me.chkOutline.Size = New System.Drawing.Size(75, 21)
        Me.chkOutline.TabIndex = 6
        Me.chkOutline.Tag = "Outline"
        Me.chkOutline.Text = "Outline"
        Me.chkOutline.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(81, 23)
        Me.chkPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(57, 21)
        Me.chkPlot.TabIndex = 7
        Me.chkPlot.Tag = "Plot"
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'chkFactorLevel
        '
        Me.chkFactorLevel.AutoSize = True
        Me.chkFactorLevel.Location = New System.Drawing.Point(176, 80)
        Me.chkFactorLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkFactorLevel.Name = "chkFactorLevel"
        Me.chkFactorLevel.Size = New System.Drawing.Size(108, 21)
        Me.chkFactorLevel.TabIndex = 8
        Me.chkFactorLevel.Tag = "Factor_Level"
        Me.chkFactorLevel.Text = "Factor Level"
        Me.chkFactorLevel.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkMonthAbbreviations)
        Me.grpOptions.Controls.Add(Me.chkHorizontal)
        Me.grpOptions.Controls.Add(Me.chkFactorLevel)
        Me.grpOptions.Controls.Add(Me.chkVarwidth)
        Me.grpOptions.Controls.Add(Me.chkAdd)
        Me.grpOptions.Controls.Add(Me.chkNotch)
        Me.grpOptions.Controls.Add(Me.chkOutline)
        Me.grpOptions.Controls.Add(Me.chkPlot)
        Me.grpOptions.Location = New System.Drawing.Point(341, 182)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Size = New System.Drawing.Size(335, 143)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(176, 23)
        Me.chkMonthAbbreviations.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(156, 21)
        Me.chkMonthAbbreviations.TabIndex = 10
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "Month Abbreviations"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(176, 52)
        Me.chkHorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(94, 21)
        Me.chkHorizontal.TabIndex = 9
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "Horizontal"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'nudRange
        '
        Me.nudRange.Location = New System.Drawing.Point(599, 336)
        Me.nudRange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudRange.Name = "nudRange"
        Me.nudRange.Size = New System.Drawing.Size(77, 22)
        Me.nudRange.TabIndex = 11
        '
        'nudWhisklty
        '
        Me.nudWhisklty.Location = New System.Drawing.Point(176, 330)
        Me.nudWhisklty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudWhisklty.Name = "nudWhisklty"
        Me.nudWhisklty.Size = New System.Drawing.Size(77, 22)
        Me.nudWhisklty.TabIndex = 12
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(363, 332)
        Me.nudThreshold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(77, 22)
        Me.nudThreshold.TabIndex = 13
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(473, 341)
        Me.lblRange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(49, 16)
        Me.lblRange.TabIndex = 14
        Me.lblRange.Tag = "Range"
        Me.lblRange.Text = "Range"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(283, 338)
        Me.lblThreshold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(69, 16)
        Me.lblThreshold.TabIndex = 15
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(40, 335)
        Me.lblWhiskLineType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(108, 16)
        Me.lblWhiskLineType.TabIndex = 16
        Me.lblWhiskLineType.Tag = "Whisk_line_type"
        Me.lblWhiskLineType.Text = "Whisk Line Type"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(40, 53)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(34, 16)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(40, 85)
        Me.lblVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(59, 16)
        Me.lblVariable.TabIndex = 15
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(40, 117)
        Me.lblYLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(54, 16)
        Me.lblYLabel.TabIndex = 16
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(43, 149)
        Me.lblXLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(53, 16)
        Me.lblXLabel.TabIndex = 17
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X Label"
        '
        'lblDataPeriodLabel
        '
        Me.lblDataPeriodLabel.AutoSize = True
        Me.lblDataPeriodLabel.Location = New System.Drawing.Point(33, 182)
        Me.lblDataPeriodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataPeriodLabel.Name = "lblDataPeriodLabel"
        Me.lblDataPeriodLabel.Size = New System.Drawing.Size(117, 16)
        Me.lblDataPeriodLabel.TabIndex = 18
        Me.lblDataPeriodLabel.Tag = "Data_Period_Label"
        Me.lblDataPeriodLabel.Text = "Data Period Label"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(40, 214)
        Me.lblFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(46, 16)
        Me.lblFactor.TabIndex = 19
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(40, 247)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(42, 16)
        Me.lblWidth.TabIndex = 20
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Width"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(40, 282)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(47, 16)
        Me.lblColour.TabIndex = 21
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Colour"
        '
        'lblBorder
        '
        Me.lblBorder.AutoSize = True
        Me.lblBorder.Location = New System.Drawing.Point(321, 117)
        Me.lblBorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(49, 16)
        Me.lblBorder.TabIndex = 22
        Me.lblBorder.Tag = "Border"
        Me.lblBorder.Text = "Border"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.Location = New System.Drawing.Point(321, 85)
        Me.lblAT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(26, 16)
        Me.lblAT.TabIndex = 23
        Me.lblAT.Tag = "AT"
        Me.lblAT.Text = "AT"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(321, 53)
        Me.lblLog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(31, 16)
        Me.lblLog.TabIndex = 24
        Me.lblLog.Tag = "Log"
        Me.lblLog.Text = "Log"
        '
        'lblpars
        '
        Me.lblpars.AutoSize = True
        Me.lblpars.Location = New System.Drawing.Point(321, 149)
        Me.lblpars.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpars.Name = "lblpars"
        Me.lblpars.Size = New System.Drawing.Size(36, 16)
        Me.lblpars.TabIndex = 25
        Me.lblpars.Tag = "pars"
        Me.lblpars.Text = "Pars"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(44, 364)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 76)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(171, 44)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputTitle.TabIndex = 27
        '
        'ucrInputDataPeriod
        '
        Me.ucrInputDataPeriod.AddQuotesIfUnrecognised = True
        Me.ucrInputDataPeriod.IsMultiline = False
        Me.ucrInputDataPeriod.IsReadOnly = False
        Me.ucrInputDataPeriod.Location = New System.Drawing.Point(171, 172)
        Me.ucrInputDataPeriod.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputDataPeriod.Name = "ucrInputDataPeriod"
        Me.ucrInputDataPeriod.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputDataPeriod.TabIndex = 27
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.AddQuotesIfUnrecognised = True
        Me.ucrInputVariable.IsMultiline = False
        Me.ucrInputVariable.IsReadOnly = False
        Me.ucrInputVariable.Location = New System.Drawing.Point(171, 75)
        Me.ucrInputVariable.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputVariable.TabIndex = 27
        '
        'ucrInputXLabel
        '
        Me.ucrInputXLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputXLabel.IsMultiline = False
        Me.ucrInputXLabel.IsReadOnly = False
        Me.ucrInputXLabel.Location = New System.Drawing.Point(171, 139)
        Me.ucrInputXLabel.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputXLabel.Name = "ucrInputXLabel"
        Me.ucrInputXLabel.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputXLabel.TabIndex = 27
        '
        'ucrInputWidth
        '
        Me.ucrInputWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputWidth.IsMultiline = False
        Me.ucrInputWidth.IsReadOnly = False
        Me.ucrInputWidth.Location = New System.Drawing.Point(171, 238)
        Me.ucrInputWidth.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputWidth.Name = "ucrInputWidth"
        Me.ucrInputWidth.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputWidth.TabIndex = 28
        '
        'ucrInputYLabel
        '
        Me.ucrInputYLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputYLabel.IsMultiline = False
        Me.ucrInputYLabel.IsReadOnly = False
        Me.ucrInputYLabel.Location = New System.Drawing.Point(171, 107)
        Me.ucrInputYLabel.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputYLabel.Name = "ucrInputYLabel"
        Me.ucrInputYLabel.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputYLabel.TabIndex = 29
        '
        'ucrInputFactorLab
        '
        Me.ucrInputFactorLab.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorLab.IsMultiline = False
        Me.ucrInputFactorLab.IsReadOnly = False
        Me.ucrInputFactorLab.Location = New System.Drawing.Point(171, 204)
        Me.ucrInputFactorLab.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputFactorLab.Name = "ucrInputFactorLab"
        Me.ucrInputFactorLab.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputFactorLab.TabIndex = 30
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.IsMultiline = False
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(171, 272)
        Me.ucrInputColour.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(143, 26)
        Me.ucrInputColour.TabIndex = 31
        '
        'ucrInputLog
        '
        Me.ucrInputLog.AddQuotesIfUnrecognised = True
        Me.ucrInputLog.IsMultiline = False
        Me.ucrInputLog.IsReadOnly = False
        Me.ucrInputLog.Location = New System.Drawing.Point(376, 43)
        Me.ucrInputLog.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputLog.Name = "ucrInputLog"
        Me.ucrInputLog.Size = New System.Drawing.Size(121, 26)
        Me.ucrInputLog.TabIndex = 32
        '
        'ucrInputAt
        '
        Me.ucrInputAt.AddQuotesIfUnrecognised = True
        Me.ucrInputAt.IsMultiline = False
        Me.ucrInputAt.IsReadOnly = False
        Me.ucrInputAt.Location = New System.Drawing.Point(376, 78)
        Me.ucrInputAt.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputAt.Name = "ucrInputAt"
        Me.ucrInputAt.Size = New System.Drawing.Size(121, 26)
        Me.ucrInputAt.TabIndex = 33
        '
        'ucrInputBorder
        '
        Me.ucrInputBorder.AddQuotesIfUnrecognised = True
        Me.ucrInputBorder.IsMultiline = False
        Me.ucrInputBorder.IsReadOnly = False
        Me.ucrInputBorder.Location = New System.Drawing.Point(376, 106)
        Me.ucrInputBorder.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputBorder.Name = "ucrInputBorder"
        Me.ucrInputBorder.Size = New System.Drawing.Size(121, 26)
        Me.ucrInputBorder.TabIndex = 34
        '
        'ucrInputPars
        '
        Me.ucrInputPars.AddQuotesIfUnrecognised = True
        Me.ucrInputPars.IsMultiline = False
        Me.ucrInputPars.IsReadOnly = False
        Me.ucrInputPars.Location = New System.Drawing.Point(376, 138)
        Me.ucrInputPars.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputPars.Name = "ucrInputPars"
        Me.ucrInputPars.Size = New System.Drawing.Size(121, 26)
        Me.ucrInputPars.TabIndex = 35
        '
        'dlgCliBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 442)
        Me.Controls.Add(Me.ucrInputPars)
        Me.Controls.Add(Me.ucrInputBorder)
        Me.Controls.Add(Me.ucrInputAt)
        Me.Controls.Add(Me.ucrInputLog)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrInputFactorLab)
        Me.Controls.Add(Me.ucrInputYLabel)
        Me.Controls.Add(Me.ucrInputWidth)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputXLabel)
        Me.Controls.Add(Me.ucrInputDataPeriod)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.lblpars)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblAT)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblDataPeriodLabel)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblWhiskLineType)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.nudRange)
        Me.Controls.Add(Me.nudWhisklty)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCliBoxplot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliboxplot"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.nudRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents chkVarwidth As CheckBox
    Friend WithEvents chkAdd As CheckBox
    Friend WithEvents chkNotch As CheckBox
    Friend WithEvents chkOutline As CheckBox
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents chkFactorLevel As CheckBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkHorizontal As CheckBox
    Friend WithEvents nudRange As NumericUpDown
    Friend WithEvents nudWhisklty As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents lblRange As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblWhiskLineType As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblDataPeriodLabel As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblBorder As Label
    Friend WithEvents lblAT As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents lblpars As Label
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputDataPeriod As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputXLabel As ucrInputTextBox
    Friend WithEvents ucrInputWidth As ucrInputTextBox
    Friend WithEvents ucrInputYLabel As ucrInputTextBox
    Friend WithEvents ucrInputFactorLab As ucrInputTextBox
    Friend WithEvents ucrInputColour As ucrInputTextBox
    Friend WithEvents ucrInputLog As ucrInputTextBox
    Friend WithEvents ucrInputAt As ucrInputTextBox
    Friend WithEvents ucrInputBorder As ucrInputTextBox
    Friend WithEvents ucrInputPars As ucrInputTextBox
End Class
