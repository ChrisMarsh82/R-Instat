﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrOutputGroup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.scriptPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'scriptPanel
        '
        Me.scriptPanel.AutoSize = True
        Me.scriptPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scriptPanel.Location = New System.Drawing.Point(0, 0)
        Me.scriptPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scriptPanel.Name = "scriptPanel"
        Me.scriptPanel.Size = New System.Drawing.Size(67, 25)
        Me.scriptPanel.TabIndex = 1
        '
        'ucrOutputGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.scriptPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(67, 25)
        Me.Name = "ucrOutputGroup"
        Me.Size = New System.Drawing.Size(67, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scriptPanel As Panel
End Class
