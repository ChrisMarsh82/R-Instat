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
Partial Class dlgBoxplotMethod
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
        Me.lblDataList = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtInterestedVariable = New System.Windows.Forms.TextBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtFillColour = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.chkConvert = New System.Windows.Forms.CheckBox()
        Me.chkHorizontal = New System.Windows.Forms.CheckBox()
        Me.nudWhisklty = New System.Windows.Forms.NumericUpDown()
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblInterestedVariable = New System.Windows.Forms.Label()
        Me.lblWhisklty = New System.Windows.Forms.Label()
        Me.lblDataPeriodLabel = New System.Windows.Forms.Label()
        Me.txtDataPeriodLabel = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDataList
        '
        Me.lblDataList.AutoSize = True
        Me.lblDataList.Location = New System.Drawing.Point(195, 11)
        Me.lblDataList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataList.Name = "lblDataList"
        Me.lblDataList.Size = New System.Drawing.Size(158, 16)
        Me.lblDataList.TabIndex = 1
        Me.lblDataList.Text = "Data list not implemented"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(16, 60)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(34, 16)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'txtInterestedVariable
        '
        Me.txtInterestedVariable.Location = New System.Drawing.Point(183, 207)
        Me.txtInterestedVariable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInterestedVariable.Name = "txtInterestedVariable"
        Me.txtInterestedVariable.Size = New System.Drawing.Size(132, 22)
        Me.txtInterestedVariable.TabIndex = 3
        '
        'txtFactor
        '
        Me.txtFactor.Location = New System.Drawing.Point(183, 175)
        Me.txtFactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(132, 22)
        Me.txtFactor.TabIndex = 4
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(183, 143)
        Me.txtXLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(132, 22)
        Me.txtXLabel.TabIndex = 5
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(183, 111)
        Me.txtYLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(132, 22)
        Me.txtYLabel.TabIndex = 6
        Me.txtYLabel.Tag = "YLabel"
        '
        'txtFillColour
        '
        Me.txtFillColour.Location = New System.Drawing.Point(183, 79)
        Me.txtFillColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFillColour.Name = "txtFillColour"
        Me.txtFillColour.Size = New System.Drawing.Size(132, 22)
        Me.txtFillColour.TabIndex = 7
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(183, 50)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(132, 22)
        Me.txtTitle.TabIndex = 8
        '
        'chkConvert
        '
        Me.chkConvert.AutoSize = True
        Me.chkConvert.Location = New System.Drawing.Point(485, 230)
        Me.chkConvert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkConvert.Name = "chkConvert"
        Me.chkConvert.Size = New System.Drawing.Size(80, 21)
        Me.chkConvert.TabIndex = 9
        Me.chkConvert.Tag = "Convert"
        Me.chkConvert.Text = "Convert"
        Me.chkConvert.UseVisualStyleBackColor = True
        '
        'chkHorizontal
        '
        Me.chkHorizontal.AutoSize = True
        Me.chkHorizontal.Location = New System.Drawing.Point(485, 272)
        Me.chkHorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkHorizontal.Name = "chkHorizontal"
        Me.chkHorizontal.Size = New System.Drawing.Size(94, 21)
        Me.chkHorizontal.TabIndex = 10
        Me.chkHorizontal.Tag = "Horizontal"
        Me.chkHorizontal.Text = "Horizontal"
        Me.chkHorizontal.UseVisualStyleBackColor = True
        '
        'nudWhisklty
        '
        Me.nudWhisklty.Location = New System.Drawing.Point(183, 271)
        Me.nudWhisklty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudWhisklty.Name = "nudWhisklty"
        Me.nudWhisklty.Size = New System.Drawing.Size(88, 22)
        Me.nudWhisklty.TabIndex = 11
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.Location = New System.Drawing.Point(16, 86)
        Me.lblFillColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(60, 16)
        Me.lblFillColour.TabIndex = 12
        Me.lblFillColour.Tag = "Fill_Colour"
        Me.lblFillColour.Text = "Fill Color"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(16, 114)
        Me.lblYLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(54, 16)
        Me.lblYLabel.TabIndex = 14
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(16, 151)
        Me.lblXLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(53, 16)
        Me.lblXLabel.TabIndex = 15
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X Label"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(16, 183)
        Me.lblFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(46, 16)
        Me.lblFactor.TabIndex = 16
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'lblInterestedVariable
        '
        Me.lblInterestedVariable.AutoSize = True
        Me.lblInterestedVariable.Location = New System.Drawing.Point(16, 215)
        Me.lblInterestedVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInterestedVariable.Name = "lblInterestedVariable"
        Me.lblInterestedVariable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInterestedVariable.Size = New System.Drawing.Size(121, 16)
        Me.lblInterestedVariable.TabIndex = 17
        Me.lblInterestedVariable.Tag = "Interested_Variable"
        Me.lblInterestedVariable.Text = "Interested Variable"
        '
        'lblWhisklty
        '
        Me.lblWhisklty.AutoSize = True
        Me.lblWhisklty.Location = New System.Drawing.Point(16, 271)
        Me.lblWhisklty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWhisklty.Name = "lblWhisklty"
        Me.lblWhisklty.Size = New System.Drawing.Size(58, 16)
        Me.lblWhisklty.TabIndex = 18
        Me.lblWhisklty.Text = "Whisklty"
        '
        'lblDataPeriodLabel
        '
        Me.lblDataPeriodLabel.AutoSize = True
        Me.lblDataPeriodLabel.Location = New System.Drawing.Point(16, 239)
        Me.lblDataPeriodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataPeriodLabel.Name = "lblDataPeriodLabel"
        Me.lblDataPeriodLabel.Size = New System.Drawing.Size(80, 16)
        Me.lblDataPeriodLabel.TabIndex = 19
        Me.lblDataPeriodLabel.Tag = "Period_Label"
        Me.lblDataPeriodLabel.Text = "Data Period"
        '
        'txtDataPeriodLabel
        '
        Me.txtDataPeriodLabel.Location = New System.Drawing.Point(183, 239)
        Me.txtDataPeriodLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataPeriodLabel.Name = "txtDataPeriodLabel"
        Me.txtDataPeriodLabel.Size = New System.Drawing.Size(132, 22)
        Me.txtDataPeriodLabel.TabIndex = 20
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(47, 347)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 65)
        Me.ucrBase.TabIndex = 0
        '
        'dlgBoxplotMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 415)
        Me.Controls.Add(Me.txtDataPeriodLabel)
        Me.Controls.Add(Me.lblDataPeriodLabel)
        Me.Controls.Add(Me.lblWhisklty)
        Me.Controls.Add(Me.lblInterestedVariable)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblFillColour)
        Me.Controls.Add(Me.nudWhisklty)
        Me.Controls.Add(Me.chkHorizontal)
        Me.Controls.Add(Me.chkConvert)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtFillColour)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtInterestedVariable)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDataList)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplotMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boxplot Method"
        CType(Me.nudWhisklty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDataList As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtInterestedVariable As TextBox
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtFillColour As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents chkConvert As CheckBox
    Friend WithEvents chkHorizontal As CheckBox
    Friend WithEvents nudWhisklty As NumericUpDown
    Friend WithEvents lblFillColour As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblInterestedVariable As Label
    Friend WithEvents lblWhisklty As Label
    Friend WithEvents lblDataPeriodLabel As Label
    Friend WithEvents txtDataPeriodLabel As TextBox
End Class