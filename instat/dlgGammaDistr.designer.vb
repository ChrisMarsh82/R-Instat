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
Partial Class dlgGammaDistr
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.grpColumns = New System.Windows.Forms.GroupBox()
        Me.rdoMultipleColumns = New System.Windows.Forms.RadioButton()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.lblSelectedColumn = New System.Windows.Forms.Label()
        Me.grpEstimationMethods = New System.Windows.Forms.GroupBox()
        Me.cboMethodOfMoments = New System.Windows.Forms.ComboBox()
        Me.cboMaximumLikelihood = New System.Windows.Forms.ComboBox()
        Me.lblSaveEstimates = New System.Windows.Forms.Label()
        Me.chkMethodOfMoments = New System.Windows.Forms.CheckBox()
        Me.chkMaximumLikelihood = New System.Windows.Forms.CheckBox()
        Me.chkRestrictValues = New System.Windows.Forms.CheckBox()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.txtBetween = New System.Windows.Forms.TextBox()
        Me.txtAnd = New System.Windows.Forms.TextBox()
        Me.chkProbabilityPlot = New System.Windows.Forms.CheckBox()
        Me.grpColumns.SuspendLayout()
        Me.grpEstimationMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 363)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 66)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(16, 54)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(271, 156)
        Me.ucrAddRemove.TabIndex = 1
        '
        'grpColumns
        '
        Me.grpColumns.Controls.Add(Me.rdoMultipleColumns)
        Me.grpColumns.Controls.Add(Me.rdoSingleColumn)
        Me.grpColumns.Location = New System.Drawing.Point(16, -1)
        Me.grpColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpColumns.Name = "grpColumns"
        Me.grpColumns.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpColumns.Size = New System.Drawing.Size(523, 48)
        Me.grpColumns.TabIndex = 2
        Me.grpColumns.TabStop = False
        '
        'rdoMultipleColumns
        '
        Me.rdoMultipleColumns.AutoSize = True
        Me.rdoMultipleColumns.Location = New System.Drawing.Point(279, 16)
        Me.rdoMultipleColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMultipleColumns.Name = "rdoMultipleColumns"
        Me.rdoMultipleColumns.Size = New System.Drawing.Size(132, 20)
        Me.rdoMultipleColumns.TabIndex = 1
        Me.rdoMultipleColumns.TabStop = True
        Me.rdoMultipleColumns.Tag = "Multiple_columns"
        Me.rdoMultipleColumns.Text = "Multiple columns"
        Me.rdoMultipleColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.AutoSize = True
        Me.rdoSingleColumn.Location = New System.Drawing.Point(8, 16)
        Me.rdoSingleColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(117, 20)
        Me.rdoSingleColumn.TabIndex = 0
        Me.rdoSingleColumn.TabStop = True
        Me.rdoSingleColumn.Tag = "Single_column"
        Me.rdoSingleColumn.Text = "Single column"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(295, 74)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(141, 32)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 3
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'lblSelectedColumn
        '
        Me.lblSelectedColumn.AutoSize = True
        Me.lblSelectedColumn.Location = New System.Drawing.Point(295, 54)
        Me.lblSelectedColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Size = New System.Drawing.Size(108, 16)
        Me.lblSelectedColumn.TabIndex = 4
        Me.lblSelectedColumn.Tag = "Selected_column"
        Me.lblSelectedColumn.Text = "Selected column"
        '
        'grpEstimationMethods
        '
        Me.grpEstimationMethods.Controls.Add(Me.cboMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.cboMaximumLikelihood)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveEstimates)
        Me.grpEstimationMethods.Controls.Add(Me.chkMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.chkMaximumLikelihood)
        Me.grpEstimationMethods.Location = New System.Drawing.Point(24, 218)
        Me.grpEstimationMethods.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEstimationMethods.Name = "grpEstimationMethods"
        Me.grpEstimationMethods.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEstimationMethods.Size = New System.Drawing.Size(321, 112)
        Me.grpEstimationMethods.TabIndex = 5
        Me.grpEstimationMethods.TabStop = False
        Me.grpEstimationMethods.Tag = "Estimation_methods"
        Me.grpEstimationMethods.Text = "Estimation methods"
        '
        'cboMethodOfMoments
        '
        Me.cboMethodOfMoments.FormattingEnabled = True
        Me.cboMethodOfMoments.Location = New System.Drawing.Point(196, 80)
        Me.cboMethodOfMoments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMethodOfMoments.Name = "cboMethodOfMoments"
        Me.cboMethodOfMoments.Size = New System.Drawing.Size(111, 24)
        Me.cboMethodOfMoments.TabIndex = 4
        '
        'cboMaximumLikelihood
        '
        Me.cboMaximumLikelihood.FormattingEnabled = True
        Me.cboMaximumLikelihood.Location = New System.Drawing.Point(196, 39)
        Me.cboMaximumLikelihood.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMaximumLikelihood.Name = "cboMaximumLikelihood"
        Me.cboMaximumLikelihood.Size = New System.Drawing.Size(111, 24)
        Me.cboMaximumLikelihood.TabIndex = 3
        '
        'lblSaveEstimates
        '
        Me.lblSaveEstimates.AutoSize = True
        Me.lblSaveEstimates.Location = New System.Drawing.Point(192, 20)
        Me.lblSaveEstimates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaveEstimates.Name = "lblSaveEstimates"
        Me.lblSaveEstimates.Size = New System.Drawing.Size(114, 16)
        Me.lblSaveEstimates.TabIndex = 2
        Me.lblSaveEstimates.Tag = "Save_estimates_in"
        Me.lblSaveEstimates.Text = "Save estimates in"
        '
        'chkMethodOfMoments
        '
        Me.chkMethodOfMoments.AutoSize = True
        Me.chkMethodOfMoments.Location = New System.Drawing.Point(8, 80)
        Me.chkMethodOfMoments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMethodOfMoments.Name = "chkMethodOfMoments"
        Me.chkMethodOfMoments.Size = New System.Drawing.Size(151, 21)
        Me.chkMethodOfMoments.TabIndex = 1
        Me.chkMethodOfMoments.Tag = "Method_of_moments"
        Me.chkMethodOfMoments.Text = "Method of moments"
        Me.chkMethodOfMoments.UseVisualStyleBackColor = True
        '
        'chkMaximumLikelihood
        '
        Me.chkMaximumLikelihood.AutoSize = True
        Me.chkMaximumLikelihood.Location = New System.Drawing.Point(8, 39)
        Me.chkMaximumLikelihood.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMaximumLikelihood.Name = "chkMaximumLikelihood"
        Me.chkMaximumLikelihood.Size = New System.Drawing.Size(152, 21)
        Me.chkMaximumLikelihood.TabIndex = 0
        Me.chkMaximumLikelihood.Tag = "Maximum_likelihood_"
        Me.chkMaximumLikelihood.Text = "Maximum likelihood"
        Me.chkMaximumLikelihood.UseVisualStyleBackColor = True
        '
        'chkRestrictValues
        '
        Me.chkRestrictValues.AutoSize = True
        Me.chkRestrictValues.Location = New System.Drawing.Point(332, 128)
        Me.chkRestrictValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRestrictValues.Name = "chkRestrictValues"
        Me.chkRestrictValues.Size = New System.Drawing.Size(152, 21)
        Me.chkRestrictValues.TabIndex = 6
        Me.chkRestrictValues.Tag = "Restrict_data_values"
        Me.chkRestrictValues.Text = "Restrict data values"
        Me.chkRestrictValues.UseVisualStyleBackColor = True
        '
        'lblBetween
        '
        Me.lblBetween.AutoSize = True
        Me.lblBetween.Location = New System.Drawing.Point(345, 162)
        Me.lblBetween.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Size = New System.Drawing.Size(59, 16)
        Me.lblBetween.TabIndex = 7
        Me.lblBetween.Tag = "between"
        Me.lblBetween.Text = "between"
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(469, 162)
        Me.lblAnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(31, 16)
        Me.lblAnd.TabIndex = 8
        Me.lblAnd.Tag = "and"
        Me.lblAnd.Text = "and"
        '
        'txtBetween
        '
        Me.txtBetween.Location = New System.Drawing.Point(417, 159)
        Me.txtBetween.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBetween.Name = "txtBetween"
        Me.txtBetween.Size = New System.Drawing.Size(43, 22)
        Me.txtBetween.TabIndex = 9
        '
        'txtAnd
        '
        Me.txtAnd.Location = New System.Drawing.Point(511, 158)
        Me.txtAnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAnd.Name = "txtAnd"
        Me.txtAnd.Size = New System.Drawing.Size(45, 22)
        Me.txtAnd.TabIndex = 10
        '
        'chkProbabilityPlot
        '
        Me.chkProbabilityPlot.AutoSize = True
        Me.chkProbabilityPlot.Location = New System.Drawing.Point(372, 238)
        Me.chkProbabilityPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProbabilityPlot.Name = "chkProbabilityPlot"
        Me.chkProbabilityPlot.Size = New System.Drawing.Size(123, 21)
        Me.chkProbabilityPlot.TabIndex = 11
        Me.chkProbabilityPlot.Tag = "Probability_plot"
        Me.chkProbabilityPlot.Text = "Probability plot"
        Me.chkProbabilityPlot.UseVisualStyleBackColor = True
        '
        'dlgGammaDistr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 432)
        Me.Controls.Add(Me.chkProbabilityPlot)
        Me.Controls.Add(Me.txtAnd)
        Me.Controls.Add(Me.txtBetween)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.chkRestrictValues)
        Me.Controls.Add(Me.grpEstimationMethods)
        Me.Controls.Add(Me.lblSelectedColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.grpColumns)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGammaDistr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_a_Gamma_distribution"
        Me.Text = "Fit a Gamma Distribution"
        Me.grpColumns.ResumeLayout(False)
        Me.grpColumns.PerformLayout()
        Me.grpEstimationMethods.ResumeLayout(False)
        Me.grpEstimationMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents grpColumns As GroupBox
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblSelectedColumn As Label
    Friend WithEvents rdoMultipleColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents grpEstimationMethods As GroupBox
    Friend WithEvents lblSaveEstimates As Label
    Friend WithEvents chkMethodOfMoments As CheckBox
    Friend WithEvents chkMaximumLikelihood As CheckBox
    Friend WithEvents cboMethodOfMoments As ComboBox
    Friend WithEvents cboMaximumLikelihood As ComboBox
    Friend WithEvents chkRestrictValues As CheckBox
    Friend WithEvents lblBetween As Label
    Friend WithEvents lblAnd As Label
    Friend WithEvents txtBetween As TextBox
    Friend WithEvents txtAnd As TextBox
    Friend WithEvents chkProbabilityPlot As CheckBox
End Class
