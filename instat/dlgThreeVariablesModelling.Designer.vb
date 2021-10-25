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
Partial Class dlgThreeVariableModelling
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
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelOperator = New System.Windows.Forms.Label()
        Me.cmdFirstExplanatoryFunction = New System.Windows.Forms.Button()
        Me.cmdSecondExplanatoryFunction = New System.Windows.Forms.Button()
        Me.cmdResponseFunction = New System.Windows.Forms.Button()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrReceiverSecondExplanatory = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrChkConvertToNumeric = New instat.ucrCheck()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrInputModelOperator = New instat.ucrInputComboBox()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrSelectorThreeVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(336, 90)
        Me.lblFirstExplanatoryVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Size = New System.Drawing.Size(161, 16)
        Me.lblFirstExplanatoryVariable.TabIndex = 4
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable"
        Me.lblFirstExplanatoryVariable.Text = "First Explanatory Variable"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(336, 31)
        Me.lblResponse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(128, 16)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable:"
        '
        'lblSecondExplanatoryVariable
        '
        Me.lblSecondExplanatoryVariable.AutoSize = True
        Me.lblSecondExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondExplanatoryVariable.Location = New System.Drawing.Point(336, 192)
        Me.lblSecondExplanatoryVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Size = New System.Drawing.Size(183, 16)
        Me.lblSecondExplanatoryVariable.TabIndex = 8
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable"
        Me.lblSecondExplanatoryVariable.Text = "Second Explanatory Variable"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(476, 271)
        Me.cmdDisplayOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(163, 28)
        Me.cmdDisplayOptions.TabIndex = 16
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(9, 334)
        Me.lblModelPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(100, 16)
        Me.lblModelPreview.TabIndex = 10
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(305, 271)
        Me.cmdModelOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(163, 28)
        Me.cmdModelOptions.TabIndex = 13
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelOperator
        '
        Me.lblModelOperator.AutoSize = True
        Me.lblModelOperator.Location = New System.Drawing.Point(336, 154)
        Me.lblModelOperator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelOperator.Name = "lblModelOperator"
        Me.lblModelOperator.Size = New System.Drawing.Size(105, 16)
        Me.lblModelOperator.TabIndex = 21
        Me.lblModelOperator.Text = "Model Operator:"
        '
        'cmdFirstExplanatoryFunction
        '
        Me.cmdFirstExplanatoryFunction.Location = New System.Drawing.Point(511, 106)
        Me.cmdFirstExplanatoryFunction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFirstExplanatoryFunction.Name = "cmdFirstExplanatoryFunction"
        Me.cmdFirstExplanatoryFunction.Size = New System.Drawing.Size(89, 25)
        Me.cmdFirstExplanatoryFunction.TabIndex = 31
        Me.cmdFirstExplanatoryFunction.Text = "Function..."
        Me.cmdFirstExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'cmdSecondExplanatoryFunction
        '
        Me.cmdSecondExplanatoryFunction.Location = New System.Drawing.Point(509, 208)
        Me.cmdSecondExplanatoryFunction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSecondExplanatoryFunction.Name = "cmdSecondExplanatoryFunction"
        Me.cmdSecondExplanatoryFunction.Size = New System.Drawing.Size(89, 25)
        Me.cmdSecondExplanatoryFunction.TabIndex = 32
        Me.cmdSecondExplanatoryFunction.Text = "Function..."
        Me.cmdSecondExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'cmdResponseFunction
        '
        Me.cmdResponseFunction.Location = New System.Drawing.Point(509, 47)
        Me.cmdResponseFunction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdResponseFunction.Name = "cmdResponseFunction"
        Me.cmdResponseFunction.Size = New System.Drawing.Size(89, 25)
        Me.cmdResponseFunction.TabIndex = 33
        Me.cmdResponseFunction.Text = "Function..."
        Me.cmdResponseFunction.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(13, 367)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(417, 30)
        Me.ucrSaveModel.TabIndex = 30
        '
        'ucrReceiverSecondExplanatory
        '
        Me.ucrReceiverSecondExplanatory.frmParent = Me
        Me.ucrReceiverSecondExplanatory.Location = New System.Drawing.Point(339, 208)
        Me.ucrReceiverSecondExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondExplanatory.Name = "ucrReceiverSecondExplanatory"
        Me.ucrReceiverSecondExplanatory.Selector = Nothing
        Me.ucrReceiverSecondExplanatory.Size = New System.Drawing.Size(161, 25)
        Me.ucrReceiverSecondExplanatory.strNcFilePath = ""
        Me.ucrReceiverSecondExplanatory.TabIndex = 28
        Me.ucrReceiverSecondExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverFirstExplanatory
        '
        Me.ucrReceiverFirstExplanatory.frmParent = Me
        Me.ucrReceiverFirstExplanatory.Location = New System.Drawing.Point(340, 106)
        Me.ucrReceiverFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstExplanatory.Name = "ucrReceiverFirstExplanatory"
        Me.ucrReceiverFirstExplanatory.Selector = Nothing
        Me.ucrReceiverFirstExplanatory.Size = New System.Drawing.Size(161, 25)
        Me.ucrReceiverFirstExplanatory.strNcFilePath = ""
        Me.ucrReceiverFirstExplanatory.TabIndex = 26
        Me.ucrReceiverFirstExplanatory.ucrSelector = Nothing
        '
        'ucrChkConvertToNumeric
        '
        Me.ucrChkConvertToNumeric.Checked = False
        Me.ucrChkConvertToNumeric.Location = New System.Drawing.Point(512, 47)
        Me.ucrChkConvertToNumeric.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkConvertToNumeric.Name = "ucrChkConvertToNumeric"
        Me.ucrChkConvertToNumeric.Size = New System.Drawing.Size(207, 25)
        Me.ucrChkConvertToNumeric.TabIndex = 25
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(340, 47)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(161, 25)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 23
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrInputModelOperator
        '
        Me.ucrInputModelOperator.AddQuotesIfUnrecognised = True
        Me.ucrInputModelOperator.GetSetSelectedIndex = -1
        Me.ucrInputModelOperator.IsReadOnly = False
        Me.ucrInputModelOperator.Location = New System.Drawing.Point(512, 154)
        Me.ucrInputModelOperator.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputModelOperator.Name = "ucrInputModelOperator"
        Me.ucrInputModelOperator.Size = New System.Drawing.Size(52, 26)
        Me.ucrInputModelOperator.TabIndex = 20
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(211, 324)
        Me.ucrModelPreview.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(428, 26)
        Me.ucrModelPreview.TabIndex = 11
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(13, 268)
        Me.ucrDistributionChoice.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(300, 53)
        Me.ucrDistributionChoice.TabIndex = 12
        '
        'ucrSelectorThreeVariableModelling
        '
        Me.ucrSelectorThreeVariableModelling.bDropUnusedFilterLevels = False
        Me.ucrSelectorThreeVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableModelling.bUseCurrentFilter = True
        Me.ucrSelectorThreeVariableModelling.Location = New System.Drawing.Point(13, 11)
        Me.ucrSelectorThreeVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableModelling.Name = "ucrSelectorThreeVariableModelling"
        Me.ucrSelectorThreeVariableModelling.Size = New System.Drawing.Size(285, 228)
        Me.ucrSelectorThreeVariableModelling.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 404)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(539, 66)
        Me.ucrBase.TabIndex = 17
        '
        'dlgThreeVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 476)
        Me.Controls.Add(Me.cmdResponseFunction)
        Me.Controls.Add(Me.cmdSecondExplanatoryFunction)
        Me.Controls.Add(Me.cmdFirstExplanatoryFunction)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrReceiverSecondExplanatory)
        Me.Controls.Add(Me.ucrReceiverFirstExplanatory)
        Me.Controls.Add(Me.ucrChkConvertToNumeric)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.lblModelOperator)
        Me.Controls.Add(Me.ucrInputModelOperator)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrSelectorThreeVariableModelling)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Three_Variable_Modelling"
        Me.Text = "Three Variable Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrSelectorThreeVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrInputModelOperator As ucrInputComboBox
    Friend WithEvents lblModelOperator As Label
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents ucrChkConvertToNumeric As ucrCheck
    Friend WithEvents ucrReceiverFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondExplanatory As ucrReceiverSingle
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents cmdSecondExplanatoryFunction As Button
    Friend WithEvents cmdFirstExplanatoryFunction As Button
    Friend WithEvents cmdResponseFunction As Button
End Class
