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
Partial Class dlgTwoVariableFitModel
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
        Me.lblResidualMsg = New System.Windows.Forms.Label()
        Me.lblDF = New System.Windows.Forms.Label()
        Me.txtResidualMsg = New System.Windows.Forms.TextBox()
        Me.txtdf = New System.Windows.Forms.TextBox()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.rdoTest = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lblFirstVariableType = New System.Windows.Forms.Label()
        Me.cmdExplanatoryFunction = New System.Windows.Forms.Button()
        Me.lblSecondVariableType = New System.Windows.Forms.Label()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrInputTest = New instat.ucrInputComboBox()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrSaveModels = New instat.ucrSave()
        Me.ucrChkConvertToVariate = New instat.ucrCheck()
        Me.ucrReceiverExplanatory = New instat.ucrReceiverSingle()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleReg = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlModelType = New instat.UcrPanel()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputConfidenceInterval = New instat.ucrInputComboBox()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.ucrInputNullHypothesis = New instat.ucrInputTextBox()
        Me.lblNullHypothesis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResidualMsg
        '
        Me.lblResidualMsg.AutoSize = True
        Me.lblResidualMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResidualMsg.Location = New System.Drawing.Point(7, 11)
        Me.lblResidualMsg.Name = "lblResidualMsg"
        Me.lblResidualMsg.Size = New System.Drawing.Size(94, 13)
        Me.lblResidualMsg.TabIndex = 0
        Me.lblResidualMsg.Tag = "Residual_Msg"
        '
        'lblDF
        '
        Me.lblDF.AutoSize = True
        Me.lblDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDF.Location = New System.Drawing.Point(7, 43)
        Me.lblDF.Name = "lblDF"
        Me.lblDF.Size = New System.Drawing.Size(100, 13)
        Me.lblDF.TabIndex = 1
        Me.lblDF.Tag = "Degrees_of_freedom"
        '
        'txtResidualMsg
        '
        Me.txtResidualMsg.Location = New System.Drawing.Point(118, 11)
        Me.txtResidualMsg.Name = "txtResidualMsg"
        Me.txtResidualMsg.Size = New System.Drawing.Size(149, 22)
        Me.txtResidualMsg.TabIndex = 2
        '
        'txtdf
        '
        Me.txtdf.Location = New System.Drawing.Point(118, 43)
        Me.txtdf.Name = "txtdf"
        Me.txtdf.Size = New System.Drawing.Size(58, 22)
        Me.txtdf.TabIndex = 12
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(433, 508)
        Me.cmdDisplayOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(175, 28)
        Me.cmdDisplayOptions.TabIndex = 16
        Me.cmdDisplayOptions.Tag = "Display_Options..."
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModelOptions.Location = New System.Drawing.Point(433, 474)
        Me.cmdModelOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(175, 28)
        Me.cmdModelOptions.TabIndex = 15
        Me.cmdModelOptions.Tag = "Model_Options..."
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelPreview.Location = New System.Drawing.Point(13, 478)
        Me.lblModelPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(100, 16)
        Me.lblModelPreview.TabIndex = 12
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'rdoTest
        '
        Me.rdoTest.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTest.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTest.FlatAppearance.BorderSize = 2
        Me.rdoTest.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTest.Location = New System.Drawing.Point(296, 14)
        Me.rdoTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoTest.Name = "rdoTest"
        Me.rdoTest.Size = New System.Drawing.Size(161, 34)
        Me.rdoTest.TabIndex = 2
        Me.rdoTest.Text = "Test"
        Me.rdoTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTest.UseVisualStyleBackColor = True
        '
        'rdoGeneralCase
        '
        Me.rdoGeneralCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneralCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatAppearance.BorderSize = 2
        Me.rdoGeneralCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneralCase.Location = New System.Drawing.Point(137, 14)
        Me.rdoGeneralCase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.Size = New System.Drawing.Size(161, 34)
        Me.rdoGeneralCase.TabIndex = 1
        Me.rdoGeneralCase.Text = "General Case"
        Me.rdoGeneralCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneralCase.UseVisualStyleBackColor = True
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(356, 185)
        Me.lblFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(136, 16)
        Me.lblFactor.TabIndex = 7
        Me.lblFactor.Text = "Explanatory Variable:"
        '
        'lblNumeric
        '
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeric.Location = New System.Drawing.Point(356, 105)
        Me.lblNumeric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(128, 16)
        Me.lblNumeric.TabIndex = 4
        Me.lblNumeric.Text = "Response Variable:"
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariable.Location = New System.Drawing.Point(356, 105)
        Me.lblFirstVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(90, 16)
        Me.lblFirstVariable.TabIndex = 21
        Me.lblFirstVariable.Text = "First Variable:"
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondVariable.Location = New System.Drawing.Point(356, 185)
        Me.lblSecondVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(109, 16)
        Me.lblSecondVariable.TabIndex = 22
        Me.lblSecondVariable.Text = "Second Variable"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(13, 308)
        Me.lblTest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(38, 16)
        Me.lblTest.TabIndex = 23
        Me.lblTest.Text = "Test:"
        '
        'lblFirstVariableType
        '
        Me.lblFirstVariableType.AutoSize = True
        Me.lblFirstVariableType.Location = New System.Drawing.Point(364, 153)
        Me.lblFirstVariableType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariableType.Name = "lblFirstVariableType"
        Me.lblFirstVariableType.Size = New System.Drawing.Size(0, 16)
        Me.lblFirstVariableType.TabIndex = 25
        '
        'cmdExplanatoryFunction
        '
        Me.cmdExplanatoryFunction.Location = New System.Drawing.Point(357, 229)
        Me.cmdExplanatoryFunction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExplanatoryFunction.Name = "cmdExplanatoryFunction"
        Me.cmdExplanatoryFunction.Size = New System.Drawing.Size(163, 28)
        Me.cmdExplanatoryFunction.TabIndex = 10
        Me.cmdExplanatoryFunction.Text = "Function..."
        Me.cmdExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'lblSecondVariableType
        '
        Me.lblSecondVariableType.AutoSize = True
        Me.lblSecondVariableType.Location = New System.Drawing.Point(363, 235)
        Me.lblSecondVariableType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondVariableType.Name = "lblSecondVariableType"
        Me.lblSecondVariableType.Size = New System.Drawing.Size(0, 16)
        Me.lblSecondVariableType.TabIndex = 26
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(13, 298)
        Me.ucrDistributionChoice.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(277, 33)
        Me.ucrDistributionChoice.TabIndex = 11
        '
        'ucrInputTest
        '
        Me.ucrInputTest.AddQuotesIfUnrecognised = True
        Me.ucrInputTest.GetSetSelectedIndex = -1
        Me.ucrInputTest.IsReadOnly = False
        Me.ucrInputTest.Location = New System.Drawing.Point(59, 304)
        Me.ucrInputTest.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputTest.Name = "ucrInputTest"
        Me.ucrInputTest.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputTest.TabIndex = 24
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.Location = New System.Drawing.Point(-4, 432)
        Me.ucrTryModelling.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(528, 36)
        Me.ucrTryModelling.TabIndex = 20
        '
        'ucrSaveModels
        '
        Me.ucrSaveModels.Location = New System.Drawing.Point(13, 511)
        Me.ucrSaveModels.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveModels.Name = "ucrSaveModels"
        Me.ucrSaveModels.Size = New System.Drawing.Size(412, 30)
        Me.ucrSaveModels.TabIndex = 14
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.Checked = False
        Me.ucrChkConvertToVariate.Location = New System.Drawing.Point(360, 150)
        Me.ucrChkConvertToVariate.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        Me.ucrChkConvertToVariate.Size = New System.Drawing.Size(213, 25)
        Me.ucrChkConvertToVariate.TabIndex = 6
        '
        'ucrReceiverExplanatory
        '
        Me.ucrReceiverExplanatory.frmParent = Me
        Me.ucrReceiverExplanatory.Location = New System.Drawing.Point(357, 201)
        Me.ucrReceiverExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExplanatory.Name = "ucrReceiverExplanatory"
        Me.ucrReceiverExplanatory.Selector = Nothing
        Me.ucrReceiverExplanatory.Size = New System.Drawing.Size(163, 25)
        Me.ucrReceiverExplanatory.strNcFilePath = ""
        Me.ucrReceiverExplanatory.TabIndex = 8
        Me.ucrReceiverExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(360, 121)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 5
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrSelectorSimpleReg
        '
        Me.ucrSelectorSimpleReg.bDropUnusedFilterLevels = False
        Me.ucrSelectorSimpleReg.bShowHiddenColumns = False
        Me.ucrSelectorSimpleReg.bUseCurrentFilter = True
        Me.ucrSelectorSimpleReg.Location = New System.Drawing.Point(13, 60)
        Me.ucrSelectorSimpleReg.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSimpleReg.Name = "ucrSelectorSimpleReg"
        Me.ucrSelectorSimpleReg.Size = New System.Drawing.Size(301, 229)
        Me.ucrSelectorSimpleReg.TabIndex = 3
        '
        'ucrPnlModelType
        '
        Me.ucrPnlModelType.Location = New System.Drawing.Point(124, 4)
        Me.ucrPnlModelType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        Me.ucrPnlModelType.Size = New System.Drawing.Size(356, 53)
        Me.ucrPnlModelType.TabIndex = 0
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(153, 475)
        Me.ucrModelPreview.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(272, 26)
        Me.ucrModelPreview.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 553)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(541, 66)
        Me.ucrBase.TabIndex = 17
        '
        'ucrInputConfidenceInterval
        '
        Me.ucrInputConfidenceInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputConfidenceInterval.GetSetSelectedIndex = -1
        Me.ucrInputConfidenceInterval.IsReadOnly = False
        Me.ucrInputConfidenceInterval.Location = New System.Drawing.Point(448, 287)
        Me.ucrInputConfidenceInterval.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputConfidenceInterval.Name = "ucrInputConfidenceInterval"
        Me.ucrInputConfidenceInterval.Size = New System.Drawing.Size(125, 26)
        Me.ucrInputConfidenceInterval.TabIndex = 86
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(317, 292)
        Me.lblConfidenceLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(115, 16)
        Me.lblConfidenceLevel.TabIndex = 87
        Me.lblConfidenceLevel.Text = "Confidence Level:"
        '
        'ucrInputNullHypothesis
        '
        Me.ucrInputNullHypothesis.AddQuotesIfUnrecognised = True
        Me.ucrInputNullHypothesis.IsMultiline = False
        Me.ucrInputNullHypothesis.IsReadOnly = False
        Me.ucrInputNullHypothesis.Location = New System.Drawing.Point(448, 322)
        Me.ucrInputNullHypothesis.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputNullHypothesis.Name = "ucrInputNullHypothesis"
        Me.ucrInputNullHypothesis.Size = New System.Drawing.Size(125, 27)
        Me.ucrInputNullHypothesis.TabIndex = 88
        '
        'lblNullHypothesis
        '
        Me.lblNullHypothesis.AutoSize = True
        Me.lblNullHypothesis.Location = New System.Drawing.Point(317, 326)
        Me.lblNullHypothesis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNullHypothesis.Name = "lblNullHypothesis"
        Me.lblNullHypothesis.Size = New System.Drawing.Size(105, 16)
        Me.lblNullHypothesis.TabIndex = 89
        Me.lblNullHypothesis.Text = "Null Hypothesis:"
        '
        'dlgTwoVariableFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 629)
        Me.Controls.Add(Me.lblNullHypothesis)
        Me.Controls.Add(Me.ucrInputNullHypothesis)
        Me.Controls.Add(Me.lblConfidenceLevel)
        Me.Controls.Add(Me.ucrInputConfidenceInterval)
        Me.Controls.Add(Me.lblSecondVariableType)
        Me.Controls.Add(Me.lblFirstVariableType)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.ucrInputTest)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.cmdExplanatoryFunction)
        Me.Controls.Add(Me.ucrSaveModels)
        Me.Controls.Add(Me.rdoTest)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumeric)
        Me.Controls.Add(Me.ucrReceiverExplanatory)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.ucrSelectorSimpleReg)
        Me.Controls.Add(Me.ucrPnlModelType)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.lblTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoVariableFitModel"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Simple_Regression"
        Me.Text = "Two Variable Fit Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents lblDF As Label
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents txtdf As TextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents ucrPnlModelType As UcrPanel
    Friend WithEvents rdoTest As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrChkConvertToVariate As ucrCheck
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblNumeric As Label
    Friend WithEvents ucrReceiverExplanatory As ucrReceiverSingle
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorSimpleReg As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveModels As ucrSave
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrInputTest As ucrInputComboBox
    Friend WithEvents lblTest As Label
    Friend WithEvents lblSecondVariableType As Label
    Friend WithEvents lblFirstVariableType As Label
    Friend WithEvents cmdExplanatoryFunction As Button
    Friend WithEvents ucrInputConfidenceInterval As ucrInputComboBox
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents ucrInputNullHypothesis As ucrInputTextBox
    Friend WithEvents lblNullHypothesis As Label
End Class