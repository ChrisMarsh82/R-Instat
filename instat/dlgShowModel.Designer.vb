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
Partial Class dlgShowModel
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
        Me.lblQuantValues = New System.Windows.Forms.Label()
        Me.lblProbValues = New System.Windows.Forms.Label()
        Me.rdoProbabilities = New System.Windows.Forms.RadioButton()
        Me.rdoQuantiles = New System.Windows.Forms.RadioButton()
        Me.cmdDistributionOptions = New System.Windows.Forms.Button()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoValues = New System.Windows.Forms.RadioButton()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrPnlGraphValues = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkEnterValues = New instat.ucrCheck()
        Me.ucrPnlDistributionType = New instat.UcrPanel()
        Me.ucrInputValuesOrProbabilities = New instat.ucrInputComboBox()
        Me.ucrDistributionAndParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrSelectorShowModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverProbabilitiesOrValues = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblQuantValues
        '
        Me.lblQuantValues.AutoSize = True
        Me.lblQuantValues.Location = New System.Drawing.Point(324, 70)
        Me.lblQuantValues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantValues.Name = "lblQuantValues"
        Me.lblQuantValues.Size = New System.Drawing.Size(53, 16)
        Me.lblQuantValues.TabIndex = 8
        Me.lblQuantValues.Text = "Values:"
        '
        'lblProbValues
        '
        Me.lblProbValues.AutoSize = True
        Me.lblProbValues.Location = New System.Drawing.Point(324, 70)
        Me.lblProbValues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProbValues.Name = "lblProbValues"
        Me.lblProbValues.Size = New System.Drawing.Size(86, 16)
        Me.lblProbValues.TabIndex = 4
        Me.lblProbValues.Text = "Probabilities:"
        '
        'rdoProbabilities
        '
        Me.rdoProbabilities.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoProbabilities.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProbabilities.FlatAppearance.BorderSize = 2
        Me.rdoProbabilities.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProbabilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoProbabilities.Location = New System.Drawing.Point(311, 18)
        Me.rdoProbabilities.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoProbabilities.Name = "rdoProbabilities"
        Me.rdoProbabilities.Size = New System.Drawing.Size(171, 33)
        Me.rdoProbabilities.TabIndex = 2
        Me.rdoProbabilities.TabStop = True
        Me.rdoProbabilities.Text = "Probabilities"
        Me.rdoProbabilities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoProbabilities.UseVisualStyleBackColor = True
        '
        'rdoQuantiles
        '
        Me.rdoQuantiles.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQuantiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatAppearance.BorderSize = 2
        Me.rdoQuantiles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQuantiles.Location = New System.Drawing.Point(140, 18)
        Me.rdoQuantiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoQuantiles.Name = "rdoQuantiles"
        Me.rdoQuantiles.Size = New System.Drawing.Size(171, 33)
        Me.rdoQuantiles.TabIndex = 1
        Me.rdoQuantiles.TabStop = True
        Me.rdoQuantiles.Text = "Quantiles"
        Me.rdoQuantiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQuantiles.UseVisualStyleBackColor = True
        '
        'cmdDistributionOptions
        '
        Me.cmdDistributionOptions.Location = New System.Drawing.Point(513, 305)
        Me.cmdDistributionOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDistributionOptions.Name = "cmdDistributionOptions"
        Me.cmdDistributionOptions.Size = New System.Drawing.Size(133, 31)
        Me.cmdDistributionOptions.TabIndex = 12
        Me.cmdDistributionOptions.Text = "Graphics Options"
        Me.cmdDistributionOptions.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.AutoSize = True
        Me.rdoGraph.Location = New System.Drawing.Point(33, 298)
        Me.rdoGraph.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(70, 20)
        Me.rdoGraph.TabIndex = 8
        Me.rdoGraph.TabStop = True
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoValues
        '
        Me.rdoValues.AutoSize = True
        Me.rdoValues.Location = New System.Drawing.Point(161, 298)
        Me.rdoValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoValues.Name = "rdoValues"
        Me.rdoValues.Size = New System.Drawing.Size(75, 20)
        Me.rdoValues.TabIndex = 9
        Me.rdoValues.TabStop = True
        Me.rdoValues.Text = "Values"
        Me.rdoValues.UseVisualStyleBackColor = True
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(12, 351)
        Me.ucrSaveNewColumn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(428, 30)
        Me.ucrSaveNewColumn.TabIndex = 11
        '
        'ucrPnlGraphValues
        '
        Me.ucrPnlGraphValues.Location = New System.Drawing.Point(12, 288)
        Me.ucrPnlGraphValues.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlGraphValues.Name = "ucrPnlGraphValues"
        Me.ucrPnlGraphValues.Size = New System.Drawing.Size(285, 38)
        Me.ucrPnlGraphValues.TabIndex = 7
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 351)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(371, 30)
        Me.ucrSaveGraph.TabIndex = 9
        '
        'ucrChkEnterValues
        '
        Me.ucrChkEnterValues.Checked = False
        Me.ucrChkEnterValues.Location = New System.Drawing.Point(12, 326)
        Me.ucrChkEnterValues.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkEnterValues.Name = "ucrChkEnterValues"
        Me.ucrChkEnterValues.Size = New System.Drawing.Size(299, 25)
        Me.ucrChkEnterValues.TabIndex = 10
        '
        'ucrPnlDistributionType
        '
        Me.ucrPnlDistributionType.Location = New System.Drawing.Point(127, 12)
        Me.ucrPnlDistributionType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlDistributionType.Name = "ucrPnlDistributionType"
        Me.ucrPnlDistributionType.Size = New System.Drawing.Size(364, 44)
        Me.ucrPnlDistributionType.TabIndex = 0
        '
        'ucrInputValuesOrProbabilities
        '
        Me.ucrInputValuesOrProbabilities.AddQuotesIfUnrecognised = True
        Me.ucrInputValuesOrProbabilities.GetSetSelectedIndex = -1
        Me.ucrInputValuesOrProbabilities.IsReadOnly = False
        Me.ucrInputValuesOrProbabilities.Location = New System.Drawing.Point(328, 91)
        Me.ucrInputValuesOrProbabilities.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputValuesOrProbabilities.Name = "ucrInputValuesOrProbabilities"
        Me.ucrInputValuesOrProbabilities.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputValuesOrProbabilities.TabIndex = 5
        '
        'ucrDistributionAndParameters
        '
        Me.ucrDistributionAndParameters.Location = New System.Drawing.Point(321, 124)
        Me.ucrDistributionAndParameters.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrDistributionAndParameters.Name = "ucrDistributionAndParameters"
        Me.ucrDistributionAndParameters.Size = New System.Drawing.Size(329, 181)
        Me.ucrDistributionAndParameters.TabIndex = 6
        '
        'ucrSelectorShowModel
        '
        Me.ucrSelectorShowModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorShowModel.bShowHiddenColumns = False
        Me.ucrSelectorShowModel.bUseCurrentFilter = True
        Me.ucrSelectorShowModel.Location = New System.Drawing.Point(12, 60)
        Me.ucrSelectorShowModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorShowModel.Name = "ucrSelectorShowModel"
        Me.ucrSelectorShowModel.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorShowModel.TabIndex = 3
        '
        'ucrReceiverProbabilitiesOrValues
        '
        Me.ucrReceiverProbabilitiesOrValues.frmParent = Me
        Me.ucrReceiverProbabilitiesOrValues.Location = New System.Drawing.Point(328, 91)
        Me.ucrReceiverProbabilitiesOrValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProbabilitiesOrValues.Name = "ucrReceiverProbabilitiesOrValues"
        Me.ucrReceiverProbabilitiesOrValues.Selector = Nothing
        Me.ucrReceiverProbabilitiesOrValues.Size = New System.Drawing.Size(183, 25)
        Me.ucrReceiverProbabilitiesOrValues.strNcFilePath = ""
        Me.ucrReceiverProbabilitiesOrValues.TabIndex = 2
        Me.ucrReceiverProbabilitiesOrValues.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 383)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 13
        '
        'dlgShowModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 459)
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.rdoValues)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlGraphValues)
        Me.Controls.Add(Me.cmdDistributionOptions)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkEnterValues)
        Me.Controls.Add(Me.rdoProbabilities)
        Me.Controls.Add(Me.rdoQuantiles)
        Me.Controls.Add(Me.ucrPnlDistributionType)
        Me.Controls.Add(Me.ucrInputValuesOrProbabilities)
        Me.Controls.Add(Me.ucrDistributionAndParameters)
        Me.Controls.Add(Me.lblProbValues)
        Me.Controls.Add(Me.lblQuantValues)
        Me.Controls.Add(Me.ucrSelectorShowModel)
        Me.Controls.Add(Me.ucrReceiverProbabilitiesOrValues)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgShowModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverProbabilitiesOrValues As ucrReceiverSingle
    Friend WithEvents ucrSelectorShowModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblQuantValues As Label
    Friend WithEvents lblProbValues As Label
    Friend WithEvents ucrDistributionAndParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrInputValuesOrProbabilities As ucrInputComboBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkEnterValues As ucrCheck
    Friend WithEvents rdoProbabilities As RadioButton
    Friend WithEvents rdoQuantiles As RadioButton
    Friend WithEvents ucrPnlDistributionType As UcrPanel
    Friend WithEvents cmdDistributionOptions As Button
    Friend WithEvents rdoValues As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlGraphValues As UcrPanel
    Friend WithEvents ucrSaveNewColumn As ucrSave
End Class
