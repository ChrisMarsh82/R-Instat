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
Partial Class dlgExpand
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverExpand = New instat.ucrReceiverMultiple()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.cboMatchingColumn = New System.Windows.Forms.ComboBox()
        Me.cboWithColumn = New System.Windows.Forms.ComboBox()
        Me.lblWithColumn = New System.Windows.Forms.Label()
        Me.rdoMatchingColumn = New System.Windows.Forms.RadioButton()
        Me.rdoMatchingValues = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(17, 279)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 70)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(16, 15)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(271, 156)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverExpand
        '
        Me.ucrReceiverExpand.frmParent = Me
        Me.ucrReceiverExpand.Location = New System.Drawing.Point(324, 34)
        Me.ucrReceiverExpand.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExpand.Name = "ucrReceiverExpand"
        Me.ucrReceiverExpand.Selector = Nothing
        Me.ucrReceiverExpand.Size = New System.Drawing.Size(161, 116)
        Me.ucrReceiverExpand.strNcFilePath = ""
        Me.ucrReceiverExpand.TabIndex = 2
        Me.ucrReceiverExpand.ucrSelector = Nothing
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(387, 15)
        Me.lblInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(29, 16)
        Me.lblInto.TabIndex = 3
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'cboMatchingColumn
        '
        Me.cboMatchingColumn.FormattingEnabled = True
        Me.cboMatchingColumn.Location = New System.Drawing.Point(16, 218)
        Me.cboMatchingColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMatchingColumn.Name = "cboMatchingColumn"
        Me.cboMatchingColumn.Size = New System.Drawing.Size(160, 24)
        Me.cboMatchingColumn.TabIndex = 4
        '
        'cboWithColumn
        '
        Me.cboWithColumn.FormattingEnabled = True
        Me.cboWithColumn.Location = New System.Drawing.Point(324, 218)
        Me.cboWithColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboWithColumn.Name = "cboWithColumn"
        Me.cboWithColumn.Size = New System.Drawing.Size(160, 24)
        Me.cboWithColumn.TabIndex = 4
        '
        'lblWithColumn
        '
        Me.lblWithColumn.AutoSize = True
        Me.lblWithColumn.Location = New System.Drawing.Point(332, 186)
        Me.lblWithColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWithColumn.Name = "lblWithColumn"
        Me.lblWithColumn.Size = New System.Drawing.Size(80, 16)
        Me.lblWithColumn.TabIndex = 3
        Me.lblWithColumn.Tag = "With_column"
        Me.lblWithColumn.Text = "With column"
        '
        'rdoMatchingColumn
        '
        Me.rdoMatchingColumn.AutoSize = True
        Me.rdoMatchingColumn.Location = New System.Drawing.Point(17, 186)
        Me.rdoMatchingColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMatchingColumn.Name = "rdoMatchingColumn"
        Me.rdoMatchingColumn.Size = New System.Drawing.Size(133, 20)
        Me.rdoMatchingColumn.TabIndex = 5
        Me.rdoMatchingColumn.TabStop = True
        Me.rdoMatchingColumn.Tag = "Matching_column"
        Me.rdoMatchingColumn.Text = "Matching column"
        Me.rdoMatchingColumn.UseVisualStyleBackColor = True
        '
        'rdoMatchingValues
        '
        Me.rdoMatchingValues.AutoSize = True
        Me.rdoMatchingValues.Location = New System.Drawing.Point(16, 251)
        Me.rdoMatchingValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMatchingValues.Name = "rdoMatchingValues"
        Me.rdoMatchingValues.Size = New System.Drawing.Size(179, 20)
        Me.rdoMatchingValues.TabIndex = 5
        Me.rdoMatchingValues.TabStop = True
        Me.rdoMatchingValues.Tag = "or_MatchingValues_1_to_n"
        Me.rdoMatchingValues.Text = "or matching values 1 to n"
        Me.rdoMatchingValues.UseVisualStyleBackColor = True
        '
        'dlgExpand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 357)
        Me.Controls.Add(Me.rdoMatchingValues)
        Me.Controls.Add(Me.rdoMatchingColumn)
        Me.Controls.Add(Me.cboWithColumn)
        Me.Controls.Add(Me.cboMatchingColumn)
        Me.Controls.Add(Me.lblWithColumn)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.ucrReceiverExpand)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExpand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Expand"
        Me.Text = "Expand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverExpand As ucrReceiverMultiple
    Friend WithEvents lblInto As Label
    Friend WithEvents cboMatchingColumn As ComboBox
    Friend WithEvents cboWithColumn As ComboBox
    Friend WithEvents lblWithColumn As Label
    Friend WithEvents rdoMatchingColumn As RadioButton
    Friend WithEvents rdoMatchingValues As RadioButton
End Class
