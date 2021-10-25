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
Partial Class dlgGeneralANOVA
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
        Me.rdoAnalysis = New System.Windows.Forms.RadioButton()
        Me.rdoReplicates = New System.Windows.Forms.RadioButton()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblTreatmentFactor = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.cmdGeneralANOVAOptions = New System.Windows.Forms.Button()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatmentStructure = New instat.ucrReceiverSingle()
        Me.ucrReceiverLayout = New instat.ucrReceiverSingle()
        Me.ucrSelectorGeneralANOVA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoAnalysis
        '
        Me.rdoAnalysis.AutoSize = True
        Me.rdoAnalysis.Location = New System.Drawing.Point(61, 12)
        Me.rdoAnalysis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAnalysis.Name = "rdoAnalysis"
        Me.rdoAnalysis.Size = New System.Drawing.Size(84, 20)
        Me.rdoAnalysis.TabIndex = 1
        Me.rdoAnalysis.TabStop = True
        Me.rdoAnalysis.Tag = "Analysis"
        Me.rdoAnalysis.Text = "Analysis"
        Me.rdoAnalysis.UseVisualStyleBackColor = True
        '
        'rdoReplicates
        '
        Me.rdoReplicates.AutoSize = True
        Me.rdoReplicates.Location = New System.Drawing.Point(340, 12)
        Me.rdoReplicates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoReplicates.Name = "rdoReplicates"
        Me.rdoReplicates.Size = New System.Drawing.Size(98, 20)
        Me.rdoReplicates.TabIndex = 2
        Me.rdoReplicates.TabStop = True
        Me.rdoReplicates.Tag = "Replicates"
        Me.rdoReplicates.Text = "Replicates"
        Me.rdoReplicates.UseVisualStyleBackColor = True
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(340, 85)
        Me.lblYVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(69, 16)
        Me.lblYVariable.TabIndex = 7
        Me.lblYVariable.Tag = "Y_variable"
        Me.lblYVariable.Text = "Y variable"
        '
        'lblTreatmentFactor
        '
        Me.lblTreatmentFactor.AutoSize = True
        Me.lblTreatmentFactor.Location = New System.Drawing.Point(340, 137)
        Me.lblTreatmentFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTreatmentFactor.Name = "lblTreatmentFactor"
        Me.lblTreatmentFactor.Size = New System.Drawing.Size(122, 16)
        Me.lblTreatmentFactor.TabIndex = 8
        Me.lblTreatmentFactor.Tag = "Treatment_structure"
        Me.lblTreatmentFactor.Text = "Treatment structure"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(340, 190)
        Me.lblLayout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(48, 16)
        Me.lblLayout.TabIndex = 9
        Me.lblLayout.Tag = "Layout"
        Me.lblLayout.Text = "Layout"
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(13, 314)
        Me.chkSaveModel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(123, 30)
        Me.chkSaveModel.TabIndex = 10
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'cmdGeneralANOVAOptions
        '
        Me.cmdGeneralANOVAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGeneralANOVAOptions.Location = New System.Drawing.Point(13, 274)
        Me.cmdGeneralANOVAOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGeneralANOVAOptions.Name = "cmdGeneralANOVAOptions"
        Me.cmdGeneralANOVAOptions.Size = New System.Drawing.Size(193, 28)
        Me.cmdGeneralANOVAOptions.TabIndex = 12
        Me.cmdGeneralANOVAOptions.Tag = "General_ANOVA_Options..."
        Me.cmdGeneralANOVAOptions.Text = "General ANOVA Options..."
        Me.cmdGeneralANOVAOptions.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(135, 315)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(199, 28)
        Me.ucrModelName.TabIndex = 11
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.frmParent = Me
        Me.ucrReceiverYVariable.Location = New System.Drawing.Point(340, 105)
        Me.ucrReceiverYVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverYVariable.strNcFilePath = ""
        Me.ucrReceiverYVariable.TabIndex = 6
        Me.ucrReceiverYVariable.ucrSelector = Nothing
        '
        'ucrReceiverTreatmentStructure
        '
        Me.ucrReceiverTreatmentStructure.frmParent = Me
        Me.ucrReceiverTreatmentStructure.Location = New System.Drawing.Point(340, 156)
        Me.ucrReceiverTreatmentStructure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTreatmentStructure.Name = "ucrReceiverTreatmentStructure"
        Me.ucrReceiverTreatmentStructure.Selector = Nothing
        Me.ucrReceiverTreatmentStructure.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverTreatmentStructure.strNcFilePath = ""
        Me.ucrReceiverTreatmentStructure.TabIndex = 5
        Me.ucrReceiverTreatmentStructure.ucrSelector = Nothing
        '
        'ucrReceiverLayout
        '
        Me.ucrReceiverLayout.frmParent = Me
        Me.ucrReceiverLayout.Location = New System.Drawing.Point(340, 208)
        Me.ucrReceiverLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        Me.ucrReceiverLayout.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverLayout.strNcFilePath = ""
        Me.ucrReceiverLayout.TabIndex = 4
        Me.ucrReceiverLayout.ucrSelector = Nothing
        '
        'ucrSelectorGeneralANOVA
        '
        Me.ucrSelectorGeneralANOVA.bDropUnusedFilterLevels = False
        Me.ucrSelectorGeneralANOVA.bShowHiddenColumns = False
        Me.ucrSelectorGeneralANOVA.bUseCurrentFilter = True
        Me.ucrSelectorGeneralANOVA.Location = New System.Drawing.Point(13, 38)
        Me.ucrSelectorGeneralANOVA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGeneralANOVA.Name = "ucrSelectorGeneralANOVA"
        Me.ucrSelectorGeneralANOVA.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorGeneralANOVA.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 352)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'dlgGeneralANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 419)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.cmdGeneralANOVAOptions)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.lblTreatmentFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrReceiverTreatmentStructure)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrSelectorGeneralANOVA)
        Me.Controls.Add(Me.rdoReplicates)
        Me.Controls.Add(Me.rdoAnalysis)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGeneralANOVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General_ANOVA"
        Me.Text = "General ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoAnalysis As RadioButton
    Friend WithEvents rdoReplicates As RadioButton
    Friend WithEvents ucrSelectorGeneralANOVA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLayout As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatmentStructure As ucrReceiverSingle
    Friend WithEvents ucrReceiverYVariable As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblTreatmentFactor As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents cmdGeneralANOVAOptions As Button
End Class
