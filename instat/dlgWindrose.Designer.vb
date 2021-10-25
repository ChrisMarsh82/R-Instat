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
Partial Class dlgWindrose
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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.lblNoOfColumns = New System.Windows.Forms.Label()
        Me.cmdWindroseOptions = New System.Windows.Forms.Button()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.lblGraphSubtitle = New System.Windows.Forms.Label()
        Me.lblGraphCaption = New System.Windows.Forms.Label()
        Me.ucrInputCaption = New instat.ucrInputTextBox()
        Me.ucrInputSubTitle = New instat.ucrInputTextBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudNoOfColumns = New instat.ucrNud()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrWindRoseSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(347, 55)
        Me.lblXVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(86, 16)
        Me.lblXVariable.TabIndex = 1
        Me.lblXVariable.Text = "Wind Speed:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(347, 114)
        Me.lblYVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(98, 16)
        Me.lblYVariable.TabIndex = 3
        Me.lblYVariable.Text = "Wind Direction:"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(347, 172)
        Me.lblFacet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(45, 16)
        Me.lblFacet.TabIndex = 5
        Me.lblFacet.Text = "Facet:"
        '
        'lblNoOfColumns
        '
        Me.lblNoOfColumns.AutoSize = True
        Me.lblNoOfColumns.Location = New System.Drawing.Point(345, 222)
        Me.lblNoOfColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoOfColumns.Name = "lblNoOfColumns"
        Me.lblNoOfColumns.Size = New System.Drawing.Size(128, 16)
        Me.lblNoOfColumns.TabIndex = 7
        Me.lblNoOfColumns.Text = "Number of Columns:"
        '
        'cmdWindroseOptions
        '
        Me.cmdWindroseOptions.Location = New System.Drawing.Point(13, 244)
        Me.cmdWindroseOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdWindroseOptions.Name = "cmdWindroseOptions"
        Me.cmdWindroseOptions.Size = New System.Drawing.Size(197, 28)
        Me.cmdWindroseOptions.TabIndex = 11
        Me.cmdWindroseOptions.Text = "Windrose Options"
        Me.cmdWindroseOptions.UseVisualStyleBackColor = True
        '
        'lblGraphTitle
        '
        Me.lblGraphTitle.AutoSize = True
        Me.lblGraphTitle.Location = New System.Drawing.Point(9, 288)
        Me.lblGraphTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraphTitle.Name = "lblGraphTitle"
        Me.lblGraphTitle.Size = New System.Drawing.Size(74, 16)
        Me.lblGraphTitle.TabIndex = 18
        Me.lblGraphTitle.Text = "Graph Title"
        '
        'lblGraphSubtitle
        '
        Me.lblGraphSubtitle.AutoSize = True
        Me.lblGraphSubtitle.Location = New System.Drawing.Point(9, 321)
        Me.lblGraphSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraphSubtitle.Name = "lblGraphSubtitle"
        Me.lblGraphSubtitle.Size = New System.Drawing.Size(101, 16)
        Me.lblGraphSubtitle.TabIndex = 18
        Me.lblGraphSubtitle.Text = "Graph Sub Title"
        '
        'lblGraphCaption
        '
        Me.lblGraphCaption.AutoSize = True
        Me.lblGraphCaption.Location = New System.Drawing.Point(9, 354)
        Me.lblGraphCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraphCaption.Name = "lblGraphCaption"
        Me.lblGraphCaption.Size = New System.Drawing.Size(94, 16)
        Me.lblGraphCaption.TabIndex = 18
        Me.lblGraphCaption.Text = "Graph Caption"
        '
        'ucrInputCaption
        '
        Me.ucrInputCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputCaption.IsMultiline = False
        Me.ucrInputCaption.IsReadOnly = False
        Me.ucrInputCaption.Location = New System.Drawing.Point(207, 353)
        Me.ucrInputCaption.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputCaption.Name = "ucrInputCaption"
        Me.ucrInputCaption.Size = New System.Drawing.Size(287, 26)
        Me.ucrInputCaption.TabIndex = 17
        '
        'ucrInputSubTitle
        '
        Me.ucrInputSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubTitle.IsMultiline = False
        Me.ucrInputSubTitle.IsReadOnly = False
        Me.ucrInputSubTitle.Location = New System.Drawing.Point(207, 320)
        Me.ucrInputSubTitle.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputSubTitle.Name = "ucrInputSubTitle"
        Me.ucrInputSubTitle.Size = New System.Drawing.Size(287, 26)
        Me.ucrInputSubTitle.TabIndex = 16
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(207, 283)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(287, 26)
        Me.ucrInputTitle.TabIndex = 15
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(347, 191)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 6
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 393)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(425, 30)
        Me.ucrSaveGraph.TabIndex = 9
        '
        'ucrNudNoOfColumns
        '
        Me.ucrNudNoOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfColumns.Location = New System.Drawing.Point(483, 219)
        Me.ucrNudNoOfColumns.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudNoOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfColumns.Name = "ucrNudNoOfColumns"
        Me.ucrNudNoOfColumns.Size = New System.Drawing.Size(61, 25)
        Me.ucrNudNoOfColumns.TabIndex = 8
        Me.ucrNudNoOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(347, 133)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 4
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(347, 74)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 2
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrWindRoseSelector
        '
        Me.ucrWindRoseSelector.bDropUnusedFilterLevels = False
        Me.ucrWindRoseSelector.bShowHiddenColumns = False
        Me.ucrWindRoseSelector.bUseCurrentFilter = True
        Me.ucrWindRoseSelector.Location = New System.Drawing.Point(13, 12)
        Me.ucrWindRoseSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrWindRoseSelector.Name = "ucrWindRoseSelector"
        Me.ucrWindRoseSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrWindRoseSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 430)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 10
        '
        'dlgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 501)
        Me.Controls.Add(Me.lblGraphCaption)
        Me.Controls.Add(Me.lblGraphSubtitle)
        Me.Controls.Add(Me.lblGraphTitle)
        Me.Controls.Add(Me.ucrInputCaption)
        Me.Controls.Add(Me.ucrInputSubTitle)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.cmdWindroseOptions)
        Me.Controls.Add(Me.ucrReceiverFacet)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblNoOfColumns)
        Me.Controls.Add(Me.ucrNudNoOfColumns)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrWindRoseSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrWindRoseSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblFacet As Label
    Friend WithEvents lblNoOfColumns As Label
    Friend WithEvents ucrNudNoOfColumns As ucrNud
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents cmdWindroseOptions As Button
    Friend WithEvents ucrInputCaption As ucrInputTextBox
    Friend WithEvents ucrInputSubTitle As ucrInputTextBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblGraphCaption As Label
    Friend WithEvents lblGraphSubtitle As Label
    Friend WithEvents lblGraphTitle As Label
End Class
