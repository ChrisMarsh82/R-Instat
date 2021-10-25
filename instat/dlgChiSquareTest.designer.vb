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
Partial Class dlgChiSquareTest
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
        Me.lblLayoutOfData = New System.Windows.Forms.Label()
        Me.cboLayoutOfData = New System.Windows.Forms.ComboBox()
        Me.chkContinuityCorrection = New System.Windows.Forms.CheckBox()
        Me.chkSaveValues = New System.Windows.Forms.CheckBox()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverChiSquare = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblLayoutOfData
        '
        Me.lblLayoutOfData.AutoSize = True
        Me.lblLayoutOfData.Location = New System.Drawing.Point(17, 225)
        Me.lblLayoutOfData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLayoutOfData.Name = "lblLayoutOfData"
        Me.lblLayoutOfData.Size = New System.Drawing.Size(92, 16)
        Me.lblLayoutOfData.TabIndex = 0
        Me.lblLayoutOfData.Tag = "Layout_of_data"
        Me.lblLayoutOfData.Text = "Layout of data"
        '
        'cboLayoutOfData
        '
        Me.cboLayoutOfData.FormattingEnabled = True
        Me.cboLayoutOfData.Items.AddRange(New Object() {"Multiple Data Columns", "Data Column and Two Factors", "Column of TABLE Counts"})
        Me.cboLayoutOfData.Location = New System.Drawing.Point(21, 257)
        Me.cboLayoutOfData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboLayoutOfData.Name = "cboLayoutOfData"
        Me.cboLayoutOfData.Size = New System.Drawing.Size(160, 24)
        Me.cboLayoutOfData.TabIndex = 1
        '
        'chkContinuityCorrection
        '
        Me.chkContinuityCorrection.AutoSize = True
        Me.chkContinuityCorrection.Location = New System.Drawing.Point(299, 220)
        Me.chkContinuityCorrection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkContinuityCorrection.Name = "chkContinuityCorrection"
        Me.chkContinuityCorrection.Size = New System.Drawing.Size(153, 21)
        Me.chkContinuityCorrection.TabIndex = 4
        Me.chkContinuityCorrection.Tag = "Continuity_correction"
        Me.chkContinuityCorrection.Text = "Continuity correction"
        Me.chkContinuityCorrection.UseVisualStyleBackColor = True
        '
        'chkSaveValues
        '
        Me.chkSaveValues.AutoSize = True
        Me.chkSaveValues.Location = New System.Drawing.Point(299, 292)
        Me.chkSaveValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSaveValues.Name = "chkSaveValues"
        Me.chkSaveValues.Size = New System.Drawing.Size(109, 21)
        Me.chkSaveValues.TabIndex = 5
        Me.chkSaveValues.Tag = "Save_values"
        Me.chkSaveValues.Text = "Save values"
        Me.chkSaveValues.UseVisualStyleBackColor = True
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(295, 11)
        Me.lblDataColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(92, 16)
        Me.lblDataColumns.TabIndex = 6
        Me.lblDataColumns.Tag = "Data_Columns"
        Me.lblDataColumns.Text = "Data Columns"
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(21, 16)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(269, 166)
        Me.ucrAddRemove.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 334)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 66)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverChiSquare
        '
        Me.ucrReceiverChiSquare.frmParent = Me
        Me.ucrReceiverChiSquare.Location = New System.Drawing.Point(299, 37)
        Me.ucrReceiverChiSquare.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChiSquare.Name = "ucrReceiverChiSquare"
        Me.ucrReceiverChiSquare.Selector = Nothing
        Me.ucrReceiverChiSquare.Size = New System.Drawing.Size(163, 162)
        Me.ucrReceiverChiSquare.strNcFilePath = ""
        Me.ucrReceiverChiSquare.TabIndex = 2
        Me.ucrReceiverChiSquare.ucrSelector = Nothing
        '
        'dlgChiSquareTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 400)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.chkSaveValues)
        Me.Controls.Add(Me.chkContinuityCorrection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverChiSquare)
        Me.Controls.Add(Me.cboLayoutOfData)
        Me.Controls.Add(Me.lblLayoutOfData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChiSquareTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Chi_square_Test"
        Me.Text = "Chi-Square Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLayoutOfData As Label
    Friend WithEvents cboLayoutOfData As ComboBox
    Friend WithEvents ucrReceiverChiSquare As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkContinuityCorrection As CheckBox
    Friend WithEvents chkSaveValues As CheckBox
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
End Class
