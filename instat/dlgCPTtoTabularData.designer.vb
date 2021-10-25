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
Partial Class dlgCPTtoTabularData
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
        Me.grpDomain = New System.Windows.Forms.GroupBox()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.nudMaxLat = New System.Windows.Forms.NumericUpDown()
        Me.nudMinLon = New System.Windows.Forms.NumericUpDown()
        Me.nudMaxLongitude = New System.Windows.Forms.NumericUpDown()
        Me.nudMinLat = New System.Windows.Forms.NumericUpDown()
        Me.lbl = New System.Windows.Forms.Label()
        Me.chkWestEast = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDomain.SuspendLayout()
        CType(Me.nudMaxLat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinLon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinLat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDomain
        '
        Me.grpDomain.Controls.Add(Me.lblMaxLon)
        Me.grpDomain.Controls.Add(Me.lblMinLon)
        Me.grpDomain.Controls.Add(Me.lblMaxLat)
        Me.grpDomain.Controls.Add(Me.lblMinLat)
        Me.grpDomain.Controls.Add(Me.nudMaxLat)
        Me.grpDomain.Controls.Add(Me.nudMinLon)
        Me.grpDomain.Controls.Add(Me.nudMaxLongitude)
        Me.grpDomain.Controls.Add(Me.nudMinLat)
        Me.grpDomain.Location = New System.Drawing.Point(49, 54)
        Me.grpDomain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDomain.Name = "grpDomain"
        Me.grpDomain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDomain.Size = New System.Drawing.Size(376, 191)
        Me.grpDomain.TabIndex = 1
        Me.grpDomain.TabStop = False
        Me.grpDomain.Tag = "Domain"
        Me.grpDomain.Text = "Domain"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.Location = New System.Drawing.Point(11, 150)
        Me.lblMaxLon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(120, 16)
        Me.lblMaxLon.TabIndex = 7
        Me.lblMaxLon.Tag = "Maximum_Logitude"
        Me.lblMaxLon.Text = "Maximum Logitude"
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.Location = New System.Drawing.Point(11, 101)
        Me.lblMinLon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(123, 16)
        Me.lblMinLon.TabIndex = 6
        Me.lblMinLon.Tag = "Minimum_Longitude"
        Me.lblMinLon.Text = "Minimum Longitude"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.Location = New System.Drawing.Point(11, 78)
        Me.lblMaxLat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(115, 16)
        Me.lblMaxLat.TabIndex = 5
        Me.lblMaxLat.Tag = "Maximum_Latitude"
        Me.lblMaxLat.Text = "Maximum Latitude"
        '
        'lblMinLat
        '
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.Location = New System.Drawing.Point(11, 46)
        Me.lblMinLat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(111, 16)
        Me.lblMinLat.TabIndex = 4
        Me.lblMinLat.Tag = "Minimum_Latitude"
        Me.lblMinLat.Text = "Minimum Latitude"
        '
        'nudMaxLat
        '
        Me.nudMaxLat.Location = New System.Drawing.Point(153, 69)
        Me.nudMaxLat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMaxLat.Name = "nudMaxLat"
        Me.nudMaxLat.Size = New System.Drawing.Size(93, 22)
        Me.nudMaxLat.TabIndex = 3
        Me.nudMaxLat.Tag = ""
        '
        'nudMinLon
        '
        Me.nudMinLon.Location = New System.Drawing.Point(153, 101)
        Me.nudMinLon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMinLon.Name = "nudMinLon"
        Me.nudMinLon.Size = New System.Drawing.Size(93, 22)
        Me.nudMinLon.TabIndex = 2
        '
        'nudMaxLongitude
        '
        Me.nudMaxLongitude.Location = New System.Drawing.Point(153, 142)
        Me.nudMaxLongitude.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMaxLongitude.Name = "nudMaxLongitude"
        Me.nudMaxLongitude.Size = New System.Drawing.Size(93, 22)
        Me.nudMaxLongitude.TabIndex = 1
        Me.nudMaxLongitude.Tag = ""
        '
        'nudMinLat
        '
        Me.nudMinLat.Location = New System.Drawing.Point(153, 37)
        Me.nudMinLat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMinLat.Name = "nudMinLat"
        Me.nudMinLat.Size = New System.Drawing.Size(93, 22)
        Me.nudMinLat.TabIndex = 0
        Me.nudMinLat.Tag = ""
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(35, 11)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(110, 16)
        Me.lbl.TabIndex = 8
        Me.lbl.Tag = ""
        Me.lbl.Text = "Not implemented"
        '
        'chkWestEast
        '
        Me.chkWestEast.AutoSize = True
        Me.chkWestEast.Location = New System.Drawing.Point(49, 252)
        Me.chkWestEast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkWestEast.Name = "chkWestEast"
        Me.chkWestEast.Size = New System.Drawing.Size(95, 21)
        Me.chkWestEast.TabIndex = 8
        Me.chkWestEast.Tag = "West_East"
        Me.chkWestEast.Text = "West East"
        Me.chkWestEast.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 281)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 74)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCPTtoTabularData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 357)
        Me.Controls.Add(Me.chkWestEast)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.grpDomain)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCPTtoTabularData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CPT_to_Tabular_Data"
        Me.Text = "CPT to Tabular Data"
        Me.grpDomain.ResumeLayout(False)
        Me.grpDomain.PerformLayout()
        CType(Me.nudMaxLat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinLon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinLat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDomain As GroupBox
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblMinLat As Label
    Friend WithEvents nudMaxLat As NumericUpDown
    Friend WithEvents nudMinLon As NumericUpDown
    Friend WithEvents nudMaxLongitude As NumericUpDown
    Friend WithEvents nudMinLat As NumericUpDown
    Friend WithEvents lbl As Label
    Friend WithEvents chkWestEast As CheckBox
End Class