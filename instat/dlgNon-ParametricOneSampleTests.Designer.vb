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
Partial Class dlgNon_ParametricOneSampleTests
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
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.nudMedian = New System.Windows.Forms.NumericUpDown()
        Me.nudConfidenceInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.lblConfidenceInterval = New System.Windows.Forms.Label()
        Me.grpTypeOfTest = New System.Windows.Forms.GroupBox()
        Me.rdoLessThan = New System.Windows.Forms.RadioButton()
        Me.rdoGreaterThan = New System.Windows.Forms.RadioButton()
        Me.rdoTwoSided = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorNPOneSample = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudMedian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTypeOfTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(361, 102)
        Me.lblDataColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(83, 16)
        Me.lblDataColumn.TabIndex = 3
        Me.lblDataColumn.Tag = "Data_column"
        Me.lblDataColumn.Text = "Data column"
        '
        'nudMedian
        '
        Me.nudMedian.Location = New System.Drawing.Point(383, 219)
        Me.nudMedian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMedian.Name = "nudMedian"
        Me.nudMedian.Size = New System.Drawing.Size(91, 22)
        Me.nudMedian.TabIndex = 4
        '
        'nudConfidenceInterval
        '
        Me.nudConfidenceInterval.Location = New System.Drawing.Point(383, 252)
        Me.nudConfidenceInterval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudConfidenceInterval.Name = "nudConfidenceInterval"
        Me.nudConfidenceInterval.Size = New System.Drawing.Size(91, 22)
        Me.nudConfidenceInterval.TabIndex = 5
        Me.nudConfidenceInterval.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.Location = New System.Drawing.Point(209, 224)
        Me.lblMedian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(149, 16)
        Me.lblMedian.TabIndex = 6
        Me.lblMedian.Tag = "Assumed_median_value"
        Me.lblMedian.Text = "Assumed median value"
        '
        'lblConfidenceInterval
        '
        Me.lblConfidenceInterval.AutoSize = True
        Me.lblConfidenceInterval.Location = New System.Drawing.Point(229, 256)
        Me.lblConfidenceInterval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfidenceInterval.Name = "lblConfidenceInterval"
        Me.lblConfidenceInterval.Size = New System.Drawing.Size(122, 16)
        Me.lblConfidenceInterval.TabIndex = 7
        Me.lblConfidenceInterval.Tag = "Confidence_interval"
        Me.lblConfidenceInterval.Text = "Confidence interval"
        '
        'grpTypeOfTest
        '
        Me.grpTypeOfTest.Controls.Add(Me.rdoLessThan)
        Me.grpTypeOfTest.Controls.Add(Me.rdoGreaterThan)
        Me.grpTypeOfTest.Controls.Add(Me.rdoTwoSided)
        Me.grpTypeOfTest.Location = New System.Drawing.Point(3, 309)
        Me.grpTypeOfTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTypeOfTest.Name = "grpTypeOfTest"
        Me.grpTypeOfTest.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTypeOfTest.Size = New System.Drawing.Size(540, 53)
        Me.grpTypeOfTest.TabIndex = 8
        Me.grpTypeOfTest.TabStop = False
        Me.grpTypeOfTest.Tag = "Type_of_test"
        Me.grpTypeOfTest.Text = "Type of test"
        '
        'rdoLessThan
        '
        Me.rdoLessThan.AutoSize = True
        Me.rdoLessThan.Location = New System.Drawing.Point(351, 22)
        Me.rdoLessThan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLessThan.Name = "rdoLessThan"
        Me.rdoLessThan.Size = New System.Drawing.Size(90, 20)
        Me.rdoLessThan.TabIndex = 2
        Me.rdoLessThan.TabStop = True
        Me.rdoLessThan.Tag = "Less_than"
        Me.rdoLessThan.Text = "Less than"
        Me.rdoLessThan.UseVisualStyleBackColor = True
        '
        'rdoGreaterThan
        '
        Me.rdoGreaterThan.AutoSize = True
        Me.rdoGreaterThan.Location = New System.Drawing.Point(165, 22)
        Me.rdoGreaterThan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoGreaterThan.Name = "rdoGreaterThan"
        Me.rdoGreaterThan.Size = New System.Drawing.Size(106, 20)
        Me.rdoGreaterThan.TabIndex = 1
        Me.rdoGreaterThan.TabStop = True
        Me.rdoGreaterThan.Tag = "Greater_than"
        Me.rdoGreaterThan.Text = "Greater than"
        Me.rdoGreaterThan.UseVisualStyleBackColor = True
        '
        'rdoTwoSided
        '
        Me.rdoTwoSided.AutoSize = True
        Me.rdoTwoSided.Location = New System.Drawing.Point(15, 22)
        Me.rdoTwoSided.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoTwoSided.Name = "rdoTwoSided"
        Me.rdoTwoSided.Size = New System.Drawing.Size(96, 20)
        Me.rdoTwoSided.TabIndex = 0
        Me.rdoTwoSided.TabStop = True
        Me.rdoTwoSided.Tag = "Two_sided"
        Me.rdoTwoSided.Text = "Two sided"
        Me.rdoTwoSided.UseVisualStyleBackColor = True
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.frmParent = Me
        Me.ucrReceiverDataColumn.Location = New System.Drawing.Point(353, 119)
        Me.ucrReceiverDataColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.Size = New System.Drawing.Size(141, 32)
        Me.ucrReceiverDataColumn.strNcFilePath = ""
        Me.ucrReceiverDataColumn.TabIndex = 2
        Me.ucrReceiverDataColumn.ucrSelector = Nothing
        '
        'ucrSelectorNPOneSample
        '
        Me.ucrSelectorNPOneSample.bDropUnusedFilterLevels = False
        Me.ucrSelectorNPOneSample.bShowHiddenColumns = False
        Me.ucrSelectorNPOneSample.bUseCurrentFilter = True
        Me.ucrSelectorNPOneSample.Location = New System.Drawing.Point(3, 2)
        Me.ucrSelectorNPOneSample.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorNPOneSample.Name = "ucrSelectorNPOneSample"
        Me.ucrSelectorNPOneSample.Size = New System.Drawing.Size(323, 220)
        Me.ucrSelectorNPOneSample.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 383)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 69)
        Me.ucrBase.TabIndex = 0
        '
        'dlgNon_ParametricOneSampleTests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 454)
        Me.Controls.Add(Me.grpTypeOfTest)
        Me.Controls.Add(Me.lblConfidenceInterval)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.nudConfidenceInterval)
        Me.Controls.Add(Me.nudMedian)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrSelectorNPOneSample)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNon_ParametricOneSampleTests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Non-Parametric_One_Sample_Tests"
        Me.Text = "Non_Parametric One Sample Tests"
        CType(Me.nudMedian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTypeOfTest.ResumeLayout(False)
        Me.grpTypeOfTest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorNPOneSample As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents nudMedian As NumericUpDown
    Friend WithEvents nudConfidenceInterval As NumericUpDown
    Friend WithEvents lblMedian As Label
    Friend WithEvents lblConfidenceInterval As Label
    Friend WithEvents grpTypeOfTest As GroupBox
    Friend WithEvents rdoLessThan As RadioButton
    Friend WithEvents rdoGreaterThan As RadioButton
    Friend WithEvents rdoTwoSided As RadioButton
End Class
