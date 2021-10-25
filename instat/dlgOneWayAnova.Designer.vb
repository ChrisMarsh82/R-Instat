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
Partial Class dlgOneWayANOVA
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
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFittedModel = New System.Windows.Forms.Label()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.ucrAddRemoveDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactor = New instat.ucrReceiverSingle()
        Me.ucrYVariate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(336, 38)
        Me.lblYVariate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(66, 16)
        Me.lblYVariate.TabIndex = 1
        Me.lblYVariate.Tag = "Y Variate:"
        Me.lblYVariate.Text = "Y Variate:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(339, 103)
        Me.lblFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(49, 16)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.Location = New System.Drawing.Point(443, 247)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(104, 31)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFittedModel
        '
        Me.lblFittedModel.AutoSize = True
        Me.lblFittedModel.Enabled = False
        Me.lblFittedModel.Location = New System.Drawing.Point(13, 255)
        Me.lblFittedModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFittedModel.Name = "lblFittedModel"
        Me.lblFittedModel.Size = New System.Drawing.Size(85, 16)
        Me.lblFittedModel.TabIndex = 6
        Me.lblFittedModel.Tag = "Fitted_Model:"
        Me.lblFittedModel.Text = "Fitted Model:"
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox1.Enabled = False
        Me.UcrInputTextBox1.IsMultiline = False
        Me.UcrInputTextBox1.IsReadOnly = False
        Me.UcrInputTextBox1.Location = New System.Drawing.Point(109, 251)
        Me.UcrInputTextBox1.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        Me.UcrInputTextBox1.Size = New System.Drawing.Size(183, 26)
        Me.UcrInputTextBox1.TabIndex = 7
        '
        'ucrAddRemoveDataFrame
        '
        Me.ucrAddRemoveDataFrame.bDropUnusedFilterLevels = False
        Me.ucrAddRemoveDataFrame.bShowHiddenColumns = False
        Me.ucrAddRemoveDataFrame.bUseCurrentFilter = True
        Me.ucrAddRemoveDataFrame.Location = New System.Drawing.Point(13, 12)
        Me.ucrAddRemoveDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemoveDataFrame.Name = "ucrAddRemoveDataFrame"
        Me.ucrAddRemoveDataFrame.Size = New System.Drawing.Size(323, 230)
        Me.ucrAddRemoveDataFrame.TabIndex = 0
        '
        'ucrFactor
        '
        Me.ucrFactor.frmParent = Me
        Me.ucrFactor.Location = New System.Drawing.Point(336, 122)
        Me.ucrFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactor.Name = "ucrFactor"
        Me.ucrFactor.Selector = Nothing
        Me.ucrFactor.Size = New System.Drawing.Size(160, 25)
        Me.ucrFactor.strNcFilePath = ""
        Me.ucrFactor.TabIndex = 4
        Me.ucrFactor.ucrSelector = Nothing
        '
        'ucrYVariate
        '
        Me.ucrYVariate.frmParent = Me
        Me.ucrYVariate.Location = New System.Drawing.Point(336, 57)
        Me.ucrYVariate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYVariate.Name = "ucrYVariate"
        Me.ucrYVariate.Selector = Nothing
        Me.ucrYVariate.Size = New System.Drawing.Size(160, 25)
        Me.ucrYVariate.strNcFilePath = ""
        Me.ucrYVariate.TabIndex = 2
        Me.ucrYVariate.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 284)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 8
        '
        'dlgOneWayANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 359)
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblFittedModel)
        Me.Controls.Add(Me.ucrAddRemoveDataFrame)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrFactor)
        Me.Controls.Add(Me.ucrYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayANOVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "One_Way_ANOVA"
        Me.Text = "One Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrYVariate As ucrReceiverSingle
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrAddRemoveDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactor As ucrReceiverSingle
    Friend WithEvents lblFittedModel As Label
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
End Class
