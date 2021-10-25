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
Partial Class dlgRecodeNumericIntoQuantiles
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
        Me.lblNumberOfQuantiles = New System.Windows.Forms.Label()
        Me.lblQuantileAlgorithm = New System.Windows.Forms.Label()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrNudQuantileAlgorithm = New instat.ucrNud()
        Me.ucrNudNumberOfQuantiles = New instat.ucrNud()
        Me.ucrReceiverNumeric = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRecodeNumeric = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblNumberOfQuantiles
        '
        Me.lblNumberOfQuantiles.AutoSize = True
        Me.lblNumberOfQuantiles.Location = New System.Drawing.Point(325, 116)
        Me.lblNumberOfQuantiles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberOfQuantiles.Name = "lblNumberOfQuantiles"
        Me.lblNumberOfQuantiles.Size = New System.Drawing.Size(132, 16)
        Me.lblNumberOfQuantiles.TabIndex = 3
        Me.lblNumberOfQuantiles.Tag = ""
        Me.lblNumberOfQuantiles.Text = "Number of Quantiles:"
        '
        'lblQuantileAlgorithm
        '
        Me.lblQuantileAlgorithm.AutoSize = True
        Me.lblQuantileAlgorithm.Location = New System.Drawing.Point(325, 146)
        Me.lblQuantileAlgorithm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantileAlgorithm.Name = "lblQuantileAlgorithm"
        Me.lblQuantileAlgorithm.Size = New System.Drawing.Size(119, 16)
        Me.lblQuantileAlgorithm.TabIndex = 5
        Me.lblQuantileAlgorithm.Tag = ""
        Me.lblQuantileAlgorithm.Text = "Quantile Algorithm:"
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(325, 55)
        Me.lblSelectedVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(119, 16)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable:"
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(13, 245)
        Me.ucrNewColumnName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(337, 30)
        Me.ucrNewColumnName.TabIndex = 7
        '
        'ucrNudQuantileAlgorithm
        '
        Me.ucrNudQuantileAlgorithm.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Location = New System.Drawing.Point(467, 144)
        Me.ucrNudQuantileAlgorithm.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudQuantileAlgorithm.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Name = "ucrNudQuantileAlgorithm"
        Me.ucrNudQuantileAlgorithm.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudQuantileAlgorithm.TabIndex = 6
        Me.ucrNudQuantileAlgorithm.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberOfQuantiles
        '
        Me.ucrNudNumberOfQuantiles.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Location = New System.Drawing.Point(467, 112)
        Me.ucrNudNumberOfQuantiles.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudNumberOfQuantiles.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Name = "ucrNudNumberOfQuantiles"
        Me.ucrNudNumberOfQuantiles.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudNumberOfQuantiles.TabIndex = 4
        Me.ucrNudNumberOfQuantiles.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverNumeric
        '
        Me.ucrReceiverNumeric.frmParent = Me
        Me.ucrReceiverNumeric.Location = New System.Drawing.Point(327, 74)
        Me.ucrReceiverNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumeric.Name = "ucrReceiverNumeric"
        Me.ucrReceiverNumeric.Selector = Nothing
        Me.ucrReceiverNumeric.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverNumeric.strNcFilePath = ""
        Me.ucrReceiverNumeric.TabIndex = 2
        Me.ucrReceiverNumeric.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 282)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelectorRecodeNumeric
        '
        Me.ucrSelectorRecodeNumeric.bDropUnusedFilterLevels = False
        Me.ucrSelectorRecodeNumeric.bShowHiddenColumns = False
        Me.ucrSelectorRecodeNumeric.bUseCurrentFilter = True
        Me.ucrSelectorRecodeNumeric.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorRecodeNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRecodeNumeric.Name = "ucrSelectorRecodeNumeric"
        Me.ucrSelectorRecodeNumeric.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorRecodeNumeric.TabIndex = 0
        '
        'dlgRecodeNumericIntoQuantiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 352)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.ucrNudQuantileAlgorithm)
        Me.Controls.Add(Me.lblQuantileAlgorithm)
        Me.Controls.Add(Me.ucrNudNumberOfQuantiles)
        Me.Controls.Add(Me.lblNumberOfQuantiles)
        Me.Controls.Add(Me.ucrReceiverNumeric)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRecodeNumeric)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumericIntoQuantiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recode Numeric into Quantiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRecodeNumeric As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverNumeric As ucrReceiverSingle
    Friend WithEvents lblNumberOfQuantiles As Label
    Friend WithEvents ucrNudQuantileAlgorithm As ucrNud
    Friend WithEvents lblQuantileAlgorithm As Label
    Friend WithEvents ucrNudNumberOfQuantiles As ucrNud
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents lblSelectedVariable As Label
End Class
