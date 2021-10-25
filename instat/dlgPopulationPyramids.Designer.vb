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
Partial Class dlgPopulationPyramids
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
        Me.ucrPopulationPyramidselector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrXVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrYVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSavePopulationPyramid = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 300)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPopulationPyramidselector
        '
        Me.ucrPopulationPyramidselector.bDropUnusedFilterLevels = False
        Me.ucrPopulationPyramidselector.bShowHiddenColumns = False
        Me.ucrPopulationPyramidselector.bUseCurrentFilter = True
        Me.ucrPopulationPyramidselector.Location = New System.Drawing.Point(13, 12)
        Me.ucrPopulationPyramidselector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrPopulationPyramidselector.Name = "ucrPopulationPyramidselector"
        Me.ucrPopulationPyramidselector.Size = New System.Drawing.Size(280, 222)
        Me.ucrPopulationPyramidselector.TabIndex = 1
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(340, 31)
        Me.lblXVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(70, 16)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Text = "X Variable"
        '
        'ucrXVariableReceiver
        '
        Me.ucrXVariableReceiver.frmParent = Me
        Me.ucrXVariableReceiver.Location = New System.Drawing.Point(344, 52)
        Me.ucrXVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrXVariableReceiver.Name = "ucrXVariableReceiver"
        Me.ucrXVariableReceiver.Selector = Nothing
        Me.ucrXVariableReceiver.Size = New System.Drawing.Size(160, 25)
        Me.ucrXVariableReceiver.strNcFilePath = ""
        Me.ucrXVariableReceiver.TabIndex = 3
        Me.ucrXVariableReceiver.ucrSelector = Nothing
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(340, 94)
        Me.lblYVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(71, 16)
        Me.lblYVariable.TabIndex = 2
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrYVariableReceiver
        '
        Me.ucrYVariableReceiver.frmParent = Me
        Me.ucrYVariableReceiver.Location = New System.Drawing.Point(344, 113)
        Me.ucrYVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYVariableReceiver.Name = "ucrYVariableReceiver"
        Me.ucrYVariableReceiver.Selector = Nothing
        Me.ucrYVariableReceiver.Size = New System.Drawing.Size(160, 25)
        Me.ucrYVariableReceiver.strNcFilePath = ""
        Me.ucrYVariableReceiver.TabIndex = 3
        Me.ucrYVariableReceiver.ucrSelector = Nothing
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(340, 154)
        Me.lblSecondFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(96, 16)
        Me.lblSecondFactor.TabIndex = 2
        Me.lblSecondFactor.Text = "Second Factor"
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(344, 175)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(160, 25)
        Me.ucrSecondFactorReceiver.strNcFilePath = ""
        Me.ucrSecondFactorReceiver.TabIndex = 3
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrSavePopulationPyramid
        '
        Me.ucrSavePopulationPyramid.Location = New System.Drawing.Point(13, 257)
        Me.ucrSavePopulationPyramid.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrSavePopulationPyramid.Name = "ucrSavePopulationPyramid"
        Me.ucrSavePopulationPyramid.Size = New System.Drawing.Size(353, 25)
        Me.ucrSavePopulationPyramid.TabIndex = 4
        '
        'dlgPopulationPyramids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 367)
        Me.Controls.Add(Me.ucrSavePopulationPyramid)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.ucrYVariableReceiver)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrXVariableReceiver)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrPopulationPyramidselector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPopulationPyramids"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Population Pyramids"
        Me.Text = "Population Pyramids"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPopulationPyramidselector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrXVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrYVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrSavePopulationPyramid As ucrSaveGraph
End Class
