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
Partial Class dlgSelectAndStuck
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
        Me.ucrAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverSelectAndStuck = New instat.ucrReceiverMultiple()
        Me.grpAppend = New System.Windows.Forms.GroupBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.grpConditionForSelection = New System.Windows.Forms.GroupBox()
        Me.cboConditionForSelection = New System.Windows.Forms.ComboBox()
        Me.chkShowCalculator = New System.Windows.Forms.CheckBox()
        Me.cboInto = New System.Windows.Forms.ComboBox()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.cboCarry = New System.Windows.Forms.ComboBox()
        Me.cboCarryInto = New System.Windows.Forms.ComboBox()
        Me.lblCarry = New System.Windows.Forms.Label()
        Me.lblCarryInto = New System.Windows.Forms.Label()
        Me.grpAppend.SuspendLayout()
        Me.grpConditionForSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(60, 335)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(551, 75)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove1
        '
        Me.ucrAddRemove1.bShowHiddenColumns = False
        Me.ucrAddRemove1.Location = New System.Drawing.Point(13, 15)
        Me.ucrAddRemove1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove1.Name = "ucrAddRemove1"
        Me.ucrAddRemove1.Size = New System.Drawing.Size(271, 134)
        Me.ucrAddRemove1.TabIndex = 1
        '
        'ucrReceiverSelectAndStuck
        '
        Me.ucrReceiverSelectAndStuck.frmParent = Me
        Me.ucrReceiverSelectAndStuck.Location = New System.Drawing.Point(292, 15)
        Me.ucrReceiverSelectAndStuck.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectAndStuck.Name = "ucrReceiverSelectAndStuck"
        Me.ucrReceiverSelectAndStuck.Selector = Nothing
        Me.ucrReceiverSelectAndStuck.Size = New System.Drawing.Size(161, 134)
        Me.ucrReceiverSelectAndStuck.strNcFilePath = ""
        Me.ucrReceiverSelectAndStuck.TabIndex = 2
        Me.ucrReceiverSelectAndStuck.ucrSelector = Nothing
        '
        'grpAppend
        '
        Me.grpAppend.Controls.Add(Me.txtLast)
        Me.grpAppend.Controls.Add(Me.txtFirst)
        Me.grpAppend.Controls.Add(Me.rdoAll)
        Me.grpAppend.Controls.Add(Me.rdoLast)
        Me.grpAppend.Controls.Add(Me.rdoFirst)
        Me.grpAppend.Location = New System.Drawing.Point(32, 156)
        Me.grpAppend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAppend.Name = "grpAppend"
        Me.grpAppend.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAppend.Size = New System.Drawing.Size(151, 108)
        Me.grpAppend.TabIndex = 3
        Me.grpAppend.TabStop = False
        Me.grpAppend.Tag = "Append"
        Me.grpAppend.Text = "Append"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(88, 49)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(23, 22)
        Me.txtLast.TabIndex = 7
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(88, 21)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(23, 22)
        Me.txtFirst.TabIndex = 7
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(8, 80)
        Me.rdoAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(48, 20)
        Me.rdoAll.TabIndex = 0
        Me.rdoAll.TabStop = True
        Me.rdoAll.Tag = "All"
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(8, 53)
        Me.rdoLast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(58, 20)
        Me.rdoLast.TabIndex = 0
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(9, 25)
        Me.rdoFirst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(58, 20)
        Me.rdoFirst.TabIndex = 0
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'grpConditionForSelection
        '
        Me.grpConditionForSelection.Controls.Add(Me.cboConditionForSelection)
        Me.grpConditionForSelection.Controls.Add(Me.chkShowCalculator)
        Me.grpConditionForSelection.Location = New System.Drawing.Point(32, 272)
        Me.grpConditionForSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpConditionForSelection.Name = "grpConditionForSelection"
        Me.grpConditionForSelection.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpConditionForSelection.Size = New System.Drawing.Size(512, 55)
        Me.grpConditionForSelection.TabIndex = 4
        Me.grpConditionForSelection.TabStop = False
        Me.grpConditionForSelection.Tag = "Condtion_for_selection"
        Me.grpConditionForSelection.Text = "Condition for selection"
        '
        'cboConditionForSelection
        '
        Me.cboConditionForSelection.FormattingEnabled = True
        Me.cboConditionForSelection.Location = New System.Drawing.Point(8, 23)
        Me.cboConditionForSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboConditionForSelection.Name = "cboConditionForSelection"
        Me.cboConditionForSelection.Size = New System.Drawing.Size(243, 24)
        Me.cboConditionForSelection.TabIndex = 0
        '
        'chkShowCalculator
        '
        Me.chkShowCalculator.AutoSize = True
        Me.chkShowCalculator.Location = New System.Drawing.Point(275, 28)
        Me.chkShowCalculator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowCalculator.Name = "chkShowCalculator"
        Me.chkShowCalculator.Size = New System.Drawing.Size(128, 21)
        Me.chkShowCalculator.TabIndex = 0
        Me.chkShowCalculator.Tag = "Show_calculator"
        Me.chkShowCalculator.Text = "Show calculator"
        Me.chkShowCalculator.UseVisualStyleBackColor = True
        '
        'cboInto
        '
        Me.cboInto.FormattingEnabled = True
        Me.cboInto.Location = New System.Drawing.Point(461, 46)
        Me.cboInto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboInto.Name = "cboInto"
        Me.cboInto.Size = New System.Drawing.Size(160, 24)
        Me.cboInto.TabIndex = 5
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(476, 15)
        Me.lblInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(29, 16)
        Me.lblInto.TabIndex = 6
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'cboCarry
        '
        Me.cboCarry.FormattingEnabled = True
        Me.cboCarry.Location = New System.Drawing.Point(231, 193)
        Me.cboCarry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCarry.Name = "cboCarry"
        Me.cboCarry.Size = New System.Drawing.Size(160, 24)
        Me.cboCarry.TabIndex = 5
        '
        'cboCarryInto
        '
        Me.cboCarryInto.FormattingEnabled = True
        Me.cboCarryInto.Location = New System.Drawing.Point(449, 193)
        Me.cboCarryInto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCarryInto.Name = "cboCarryInto"
        Me.cboCarryInto.Size = New System.Drawing.Size(160, 24)
        Me.cboCarryInto.TabIndex = 5
        '
        'lblCarry
        '
        Me.lblCarry.AutoSize = True
        Me.lblCarry.Location = New System.Drawing.Point(232, 156)
        Me.lblCarry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarry.Name = "lblCarry"
        Me.lblCarry.Size = New System.Drawing.Size(40, 16)
        Me.lblCarry.TabIndex = 6
        Me.lblCarry.Tag = "Carry"
        Me.lblCarry.Text = "Carry"
        '
        'lblCarryInto
        '
        Me.lblCarryInto.AutoSize = True
        Me.lblCarryInto.Location = New System.Drawing.Point(476, 156)
        Me.lblCarryInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarryInto.Name = "lblCarryInto"
        Me.lblCarryInto.Size = New System.Drawing.Size(29, 16)
        Me.lblCarryInto.TabIndex = 6
        Me.lblCarryInto.Tag = "Into"
        Me.lblCarryInto.Text = "Into"
        '
        'dlgSelectAndStuck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 406)
        Me.Controls.Add(Me.lblCarryInto)
        Me.Controls.Add(Me.lblCarry)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.cboCarryInto)
        Me.Controls.Add(Me.cboCarry)
        Me.Controls.Add(Me.cboInto)
        Me.Controls.Add(Me.grpConditionForSelection)
        Me.Controls.Add(Me.grpAppend)
        Me.Controls.Add(Me.ucrReceiverSelectAndStuck)
        Me.Controls.Add(Me.ucrAddRemove1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSelectAndStuck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Select_And_Stuck"
        Me.Text = "Select And Stuck"
        Me.grpAppend.ResumeLayout(False)
        Me.grpAppend.PerformLayout()
        Me.grpConditionForSelection.ResumeLayout(False)
        Me.grpConditionForSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverSelectAndStuck As ucrReceiverMultiple
    Friend WithEvents grpAppend As GroupBox
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents grpConditionForSelection As GroupBox
    Friend WithEvents cboConditionForSelection As ComboBox
    Friend WithEvents chkShowCalculator As CheckBox
    Friend WithEvents cboInto As ComboBox
    Friend WithEvents lblInto As Label
    Friend WithEvents cboCarry As ComboBox
    Friend WithEvents cboCarryInto As ComboBox
    Friend WithEvents lblCarry As Label
    Friend WithEvents lblCarryInto As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
End Class
