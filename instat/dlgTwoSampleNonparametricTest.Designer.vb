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
Partial Class dlgTwoSampleNonparametricTest
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
        Me.ucrTwoSampleSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLayoutOfData = New System.Windows.Forms.GroupBox()
        Me.rdotwoColinSamedataframe = New System.Windows.Forms.RadioButton()
        Me.rdoTwoColinSeparateDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoDataColandFactorCol = New System.Windows.Forms.RadioButton()
        Me.rdoSignTest = New System.Windows.Forms.RadioButton()
        Me.rdoWilcoxon = New System.Windows.Forms.RadioButton()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.grpTypeOfTest = New System.Windows.Forms.GroupBox()
        Me.rdoOneSidedy2 = New System.Windows.Forms.RadioButton()
        Me.rdoOnesidedy1 = New System.Windows.Forms.RadioButton()
        Me.rdoTwoSided = New System.Windows.Forms.RadioButton()
        Me.grpLayoutOfData.SuspendLayout()
        Me.grpTypeOfTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 449)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 65)
        Me.ucrBase.TabIndex = 0
        '
        'ucrTwoSampleSelector
        '
        Me.ucrTwoSampleSelector.bDropUnusedFilterLevels = False
        Me.ucrTwoSampleSelector.bShowHiddenColumns = False
        Me.ucrTwoSampleSelector.bUseCurrentFilter = True
        Me.ucrTwoSampleSelector.Location = New System.Drawing.Point(11, 132)
        Me.ucrTwoSampleSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTwoSampleSelector.Name = "ucrTwoSampleSelector"
        Me.ucrTwoSampleSelector.Size = New System.Drawing.Size(323, 220)
        Me.ucrTwoSampleSelector.TabIndex = 1
        '
        'grpLayoutOfData
        '
        Me.grpLayoutOfData.Controls.Add(Me.rdotwoColinSamedataframe)
        Me.grpLayoutOfData.Controls.Add(Me.rdoTwoColinSeparateDataFrame)
        Me.grpLayoutOfData.Controls.Add(Me.rdoDataColandFactorCol)
        Me.grpLayoutOfData.Location = New System.Drawing.Point(17, 6)
        Me.grpLayoutOfData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLayoutOfData.Name = "grpLayoutOfData"
        Me.grpLayoutOfData.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLayoutOfData.Size = New System.Drawing.Size(571, 123)
        Me.grpLayoutOfData.TabIndex = 2
        Me.grpLayoutOfData.TabStop = False
        Me.grpLayoutOfData.Tag = "Layout_Of_Data"
        Me.grpLayoutOfData.Text = "Layout Of Data"
        '
        'rdotwoColinSamedataframe
        '
        Me.rdotwoColinSamedataframe.AutoSize = True
        Me.rdotwoColinSamedataframe.Location = New System.Drawing.Point(9, 81)
        Me.rdotwoColinSamedataframe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdotwoColinSamedataframe.Name = "rdotwoColinSamedataframe"
        Me.rdotwoColinSamedataframe.Size = New System.Drawing.Size(240, 20)
        Me.rdotwoColinSamedataframe.TabIndex = 0
        Me.rdotwoColinSamedataframe.TabStop = True
        Me.rdotwoColinSamedataframe.Tag = "Two_Columns_in_Same_Data_Frame"
        Me.rdotwoColinSamedataframe.Text = "Two Columns in Same Data Frame"
        Me.rdotwoColinSamedataframe.UseVisualStyleBackColor = True
        '
        'rdoTwoColinSeparateDataFrame
        '
        Me.rdoTwoColinSeparateDataFrame.AutoSize = True
        Me.rdoTwoColinSeparateDataFrame.Location = New System.Drawing.Point(9, 53)
        Me.rdoTwoColinSeparateDataFrame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoTwoColinSeparateDataFrame.Name = "rdoTwoColinSeparateDataFrame"
        Me.rdoTwoColinSeparateDataFrame.Size = New System.Drawing.Size(267, 20)
        Me.rdoTwoColinSeparateDataFrame.TabIndex = 0
        Me.rdoTwoColinSeparateDataFrame.TabStop = True
        Me.rdoTwoColinSeparateDataFrame.Tag = "Two_Columns_in_Separate_Data_Frames"
        Me.rdoTwoColinSeparateDataFrame.Text = "Two Columns in Separate Data Frames"
        Me.rdoTwoColinSeparateDataFrame.UseVisualStyleBackColor = True
        '
        'rdoDataColandFactorCol
        '
        Me.rdoDataColandFactorCol.AutoSize = True
        Me.rdoDataColandFactorCol.Location = New System.Drawing.Point(9, 25)
        Me.rdoDataColandFactorCol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDataColandFactorCol.Name = "rdoDataColandFactorCol"
        Me.rdoDataColandFactorCol.Size = New System.Drawing.Size(225, 20)
        Me.rdoDataColandFactorCol.TabIndex = 0
        Me.rdoDataColandFactorCol.TabStop = True
        Me.rdoDataColandFactorCol.Tag = "Data_Column_and_Factor_Column"
        Me.rdoDataColandFactorCol.Text = "Data Column and Factor Column"
        Me.rdoDataColandFactorCol.UseVisualStyleBackColor = True
        '
        'rdoSignTest
        '
        Me.rdoSignTest.AutoSize = True
        Me.rdoSignTest.Location = New System.Drawing.Point(313, 153)
        Me.rdoSignTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSignTest.Name = "rdoSignTest"
        Me.rdoSignTest.Size = New System.Drawing.Size(90, 20)
        Me.rdoSignTest.TabIndex = 3
        Me.rdoSignTest.TabStop = True
        Me.rdoSignTest.Tag = "Sign_Test"
        Me.rdoSignTest.Text = "Sign Test"
        Me.rdoSignTest.UseVisualStyleBackColor = True
        '
        'rdoWilcoxon
        '
        Me.rdoWilcoxon.AutoSize = True
        Me.rdoWilcoxon.Location = New System.Drawing.Point(463, 153)
        Me.rdoWilcoxon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoWilcoxon.Name = "rdoWilcoxon"
        Me.rdoWilcoxon.Size = New System.Drawing.Size(88, 20)
        Me.rdoWilcoxon.TabIndex = 3
        Me.rdoWilcoxon.TabStop = True
        Me.rdoWilcoxon.Tag = "Wilcoxon"
        Me.rdoWilcoxon.Text = "Wilcoxon"
        Me.rdoWilcoxon.UseVisualStyleBackColor = True
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(341, 192)
        Me.lblVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(59, 16)
        Me.lblVariable.TabIndex = 4
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(345, 213)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(141, 32)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 5
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(341, 258)
        Me.lblFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(46, 16)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(345, 279)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(141, 32)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 5
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'grpTypeOfTest
        '
        Me.grpTypeOfTest.Controls.Add(Me.rdoOneSidedy2)
        Me.grpTypeOfTest.Controls.Add(Me.rdoOnesidedy1)
        Me.grpTypeOfTest.Controls.Add(Me.rdoTwoSided)
        Me.grpTypeOfTest.Location = New System.Drawing.Point(17, 361)
        Me.grpTypeOfTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTypeOfTest.Name = "grpTypeOfTest"
        Me.grpTypeOfTest.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTypeOfTest.Size = New System.Drawing.Size(571, 81)
        Me.grpTypeOfTest.TabIndex = 6
        Me.grpTypeOfTest.TabStop = False
        Me.grpTypeOfTest.Tag = "Type_of_Test"
        Me.grpTypeOfTest.Text = "Type of Test"
        '
        'rdoOneSidedy2
        '
        Me.rdoOneSidedy2.AutoSize = True
        Me.rdoOneSidedy2.Location = New System.Drawing.Point(296, 25)
        Me.rdoOneSidedy2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoOneSidedy2.Name = "rdoOneSidedy2"
        Me.rdoOneSidedy2.Size = New System.Drawing.Size(144, 20)
        Me.rdoOneSidedy2.TabIndex = 0
        Me.rdoOneSidedy2.TabStop = True
        Me.rdoOneSidedy2.Tag = "One_Sided _y1y2"
        Me.rdoOneSidedy2.Text = "One-Sided (y1>y2)"
        Me.rdoOneSidedy2.UseVisualStyleBackColor = True
        '
        'rdoOnesidedy1
        '
        Me.rdoOnesidedy1.AutoSize = True
        Me.rdoOnesidedy1.Location = New System.Drawing.Point(119, 25)
        Me.rdoOnesidedy1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoOnesidedy1.Name = "rdoOnesidedy1"
        Me.rdoOnesidedy1.Size = New System.Drawing.Size(144, 20)
        Me.rdoOnesidedy1.TabIndex = 0
        Me.rdoOnesidedy1.TabStop = True
        Me.rdoOnesidedy1.Tag = "One_Sided _y1_y2)"
        Me.rdoOnesidedy1.Text = "One-Sided (y1<y2)"
        Me.rdoOnesidedy1.UseVisualStyleBackColor = True
        '
        'rdoTwoSided
        '
        Me.rdoTwoSided.AutoSize = True
        Me.rdoTwoSided.Location = New System.Drawing.Point(9, 25)
        Me.rdoTwoSided.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoTwoSided.Name = "rdoTwoSided"
        Me.rdoTwoSided.Size = New System.Drawing.Size(99, 20)
        Me.rdoTwoSided.TabIndex = 0
        Me.rdoTwoSided.TabStop = True
        Me.rdoTwoSided.Tag = "Two_Sided"
        Me.rdoTwoSided.Text = "Two-Sided"
        Me.rdoTwoSided.UseVisualStyleBackColor = True
        '
        'dlgTwoSampleNonparametricTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 515)
        Me.Controls.Add(Me.grpTypeOfTest)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.rdoWilcoxon)
        Me.Controls.Add(Me.rdoSignTest)
        Me.Controls.Add(Me.grpLayoutOfData)
        Me.Controls.Add(Me.ucrTwoSampleSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoSampleNonparametricTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Two_Sample_Non_parametric_Tests"
        Me.Text = "Two Sample Non parametric Tests"
        Me.grpLayoutOfData.ResumeLayout(False)
        Me.grpLayoutOfData.PerformLayout()
        Me.grpTypeOfTest.ResumeLayout(False)
        Me.grpTypeOfTest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrTwoSampleSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLayoutOfData As GroupBox
    Friend WithEvents rdotwoColinSamedataframe As RadioButton
    Friend WithEvents rdoTwoColinSeparateDataFrame As RadioButton
    Friend WithEvents rdoDataColandFactorCol As RadioButton
    Friend WithEvents rdoSignTest As RadioButton
    Friend WithEvents rdoWilcoxon As RadioButton
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents grpTypeOfTest As GroupBox
    Friend WithEvents rdoOneSidedy2 As RadioButton
    Friend WithEvents rdoOnesidedy1 As RadioButton
    Friend WithEvents rdoTwoSided As RadioButton
End Class
