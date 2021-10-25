﻿' R- Instat
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
Partial Class dlgFlatFrequencyTable
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
        Me.lblRowVariable = New System.Windows.Forms.Label()
        Me.lblColumnVariable = New System.Windows.Forms.Label()
        Me.ucrChkAddMargins = New instat.ucrCheck()
        Me.ucrColumnVariable = New instat.ucrReceiverMultiple()
        Me.ucrRowVariable = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblRowVariable
        '
        Me.lblRowVariable.AutoSize = True
        Me.lblRowVariable.Location = New System.Drawing.Point(352, 185)
        Me.lblRowVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowVariable.Name = "lblRowVariable"
        Me.lblRowVariable.Size = New System.Drawing.Size(107, 16)
        Me.lblRowVariable.TabIndex = 1
        Me.lblRowVariable.Text = "Row Variable(s):"
        '
        'lblColumnVariable
        '
        Me.lblColumnVariable.AutoSize = True
        Me.lblColumnVariable.Location = New System.Drawing.Point(352, 53)
        Me.lblColumnVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnVariable.Name = "lblColumnVariable"
        Me.lblColumnVariable.Size = New System.Drawing.Size(174, 16)
        Me.lblColumnVariable.TabIndex = 3
        Me.lblColumnVariable.Text = "Column Variable(s) (Factor):"
        '
        'ucrChkAddMargins
        '
        Me.ucrChkAddMargins.Checked = False
        Me.ucrChkAddMargins.Location = New System.Drawing.Point(13, 294)
        Me.ucrChkAddMargins.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkAddMargins.Name = "ucrChkAddMargins"
        Me.ucrChkAddMargins.Size = New System.Drawing.Size(133, 25)
        Me.ucrChkAddMargins.TabIndex = 5
        '
        'ucrColumnVariable
        '
        Me.ucrColumnVariable.frmParent = Me
        Me.ucrColumnVariable.Location = New System.Drawing.Point(352, 71)
        Me.ucrColumnVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnVariable.Name = "ucrColumnVariable"
        Me.ucrColumnVariable.Selector = Nothing
        Me.ucrColumnVariable.Size = New System.Drawing.Size(160, 105)
        Me.ucrColumnVariable.strNcFilePath = ""
        Me.ucrColumnVariable.TabIndex = 4
        Me.ucrColumnVariable.ucrSelector = Nothing
        '
        'ucrRowVariable
        '
        Me.ucrRowVariable.frmParent = Me
        Me.ucrRowVariable.Location = New System.Drawing.Point(352, 203)
        Me.ucrRowVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRowVariable.Name = "ucrRowVariable"
        Me.ucrRowVariable.Selector = Nothing
        Me.ucrRowVariable.Size = New System.Drawing.Size(160, 105)
        Me.ucrRowVariable.strNcFilePath = ""
        Me.ucrRowVariable.TabIndex = 2
        Me.ucrRowVariable.ucrSelector = Nothing
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 325)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(537, 64)
        Me.ucrBase.TabIndex = 6
        '
        'dlgFlatFrequencyTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 397)
        Me.Controls.Add(Me.ucrChkAddMargins)
        Me.Controls.Add(Me.lblColumnVariable)
        Me.Controls.Add(Me.lblRowVariable)
        Me.Controls.Add(Me.ucrColumnVariable)
        Me.Controls.Add(Me.ucrRowVariable)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFlatFrequencyTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flat Frequency Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrRowVariable As ucrReceiverMultiple
    Friend WithEvents ucrColumnVariable As ucrReceiverMultiple
    Friend WithEvents lblRowVariable As Label
    Friend WithEvents lblColumnVariable As Label
    Friend WithEvents ucrChkAddMargins As ucrCheck
End Class
