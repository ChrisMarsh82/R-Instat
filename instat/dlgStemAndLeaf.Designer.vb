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
Partial Class dlgStemAndLeaf
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
        Me.ucrReceiverStemAndLeaf = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrStemLeafSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrReceiverStemAndLeaf
        '
        Me.ucrReceiverStemAndLeaf.frmParent = Me
        Me.ucrReceiverStemAndLeaf.Location = New System.Drawing.Point(341, 74)
        Me.ucrReceiverStemAndLeaf.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStemAndLeaf.Name = "ucrReceiverStemAndLeaf"
        Me.ucrReceiverStemAndLeaf.Selector = Nothing
        Me.ucrReceiverStemAndLeaf.Size = New System.Drawing.Size(160, 32)
        Me.ucrReceiverStemAndLeaf.strNcFilePath = ""
        Me.ucrReceiverStemAndLeaf.TabIndex = 2
        Me.ucrReceiverStemAndLeaf.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 247)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 3
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(341, 55)
        Me.lblSelectedVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(119, 16)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable:"
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'ucrStemLeafSelector
        '
        Me.ucrStemLeafSelector.bDropUnusedFilterLevels = False
        Me.ucrStemLeafSelector.bShowHiddenColumns = False
        Me.ucrStemLeafSelector.bUseCurrentFilter = True
        Me.ucrStemLeafSelector.Location = New System.Drawing.Point(13, 12)
        Me.ucrStemLeafSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrStemLeafSelector.Name = "ucrStemLeafSelector"
        Me.ucrStemLeafSelector.Size = New System.Drawing.Size(323, 231)
        Me.ucrStemLeafSelector.TabIndex = 0
        '
        'dlgStemAndLeaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 320)
        Me.Controls.Add(Me.ucrStemLeafSelector)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverStemAndLeaf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStemAndLeaf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stem_and_Leaf"
        Me.Text = "Stem and Leaf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverStemAndLeaf As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrStemLeafSelector As ucrSelectorByDataFrameAddRemove
End Class