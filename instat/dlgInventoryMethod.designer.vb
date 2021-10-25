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
Partial Class dlgInventoryMethod
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtVariableLabel = New System.Windows.Forms.TextBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkSort = New System.Windows.Forms.CheckBox()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(32, 252)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 39)
        Me.ucrBase.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(28, 39)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(49, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label1"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(183, 39)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(132, 22)
        Me.txtTitle.TabIndex = 2
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(183, 133)
        Me.txtYLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(132, 22)
        Me.txtYLabel.TabIndex = 3
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(183, 103)
        Me.txtColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(132, 22)
        Me.txtColour.TabIndex = 4
        '
        'txtVariableLabel
        '
        Me.txtVariableLabel.Location = New System.Drawing.Point(183, 71)
        Me.txtVariableLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVariableLabel.Name = "txtVariableLabel"
        Me.txtVariableLabel.Size = New System.Drawing.Size(132, 22)
        Me.txtVariableLabel.TabIndex = 5
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(412, 196)
        Me.chkRemoveNA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(102, 21)
        Me.chkRemoveNA.TabIndex = 7
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox1"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkSort
        '
        Me.chkSort.AutoSize = True
        Me.chkSort.Location = New System.Drawing.Point(183, 196)
        Me.chkSort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSort.Name = "chkSort"
        Me.chkSort.Size = New System.Drawing.Size(102, 21)
        Me.chkSort.TabIndex = 8
        Me.chkSort.Tag = "Sort"
        Me.chkSort.Text = "CheckBox2"
        Me.chkSort.UseVisualStyleBackColor = True
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(28, 75)
        Me.lblVariableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblVariableLabel.TabIndex = 9
        Me.lblVariableLabel.Tag = "Variable_Label"
        Me.lblVariableLabel.Text = "Label2"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(28, 103)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(49, 16)
        Me.lblColour.TabIndex = 10
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Label3"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(28, 133)
        Me.lblYLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblYLabel.TabIndex = 11
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Data list not implemented"
        '
        'dlgInventoryMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.chkSort)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.txtVariableLabel)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtVariableLabel As TextBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkSort As CheckBox
    Friend WithEvents lblVariableLabel As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents Label1 As Label
End Class
