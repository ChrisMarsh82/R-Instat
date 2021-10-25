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
Partial Class dlgRemoveUnusedLabels
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
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSelectedVariable = New instat.ucrReceiverSingle()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 327)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 65)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.bDropUnusedFilterLevels = False
        Me.ucrDataFrame.bUseCurrentFilter = True
        Me.ucrDataFrame.Location = New System.Drawing.Point(3, 2)
        Me.ucrDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(169, 50)
        Me.ucrDataFrame.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 73)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(289, 180)
        Me.ucrAddRemove.TabIndex = 2
        '
        'ucrSelectedVariable
        '
        Me.ucrSelectedVariable.frmParent = Me
        Me.ucrSelectedVariable.Location = New System.Drawing.Point(312, 127)
        Me.ucrSelectedVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectedVariable.Name = "ucrSelectedVariable"
        Me.ucrSelectedVariable.Selector = Nothing
        Me.ucrSelectedVariable.Size = New System.Drawing.Size(141, 32)
        Me.ucrSelectedVariable.strNcFilePath = ""
        Me.ucrSelectedVariable.TabIndex = 3
        Me.ucrSelectedVariable.ucrSelector = Nothing
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(321, 105)
        Me.lblSelectedVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(112, 16)
        Me.lblSelectedVariable.TabIndex = 4
        Me.lblSelectedVariable.Tag = "selected_variable"
        Me.lblSelectedVariable.Text = "selected variable"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(17, 252)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(274, 16)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "An order,level,count control to be added later"
        '
        'dlgRemoveUnusedLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 394)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrSelectedVariable)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRemoveUnusedLabels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Remove_unused_labels"
        Me.Text = "Remove Unused Labels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSelectedVariable As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents lblInfo As Label
End Class
