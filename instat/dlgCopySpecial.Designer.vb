﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCopySpecial
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
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'UcrCheck2
        '
        Me.UcrCheck2.Checked = False
        Me.UcrCheck2.Location = New System.Drawing.Point(91, 78)
        Me.UcrCheck2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrCheck2.Name = "UcrCheck2"
        Me.UcrCheck2.Size = New System.Drawing.Size(133, 25)
        Me.UcrCheck2.TabIndex = 2
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(91, 32)
        Me.UcrCheck1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(133, 25)
        Me.UcrCheck1.TabIndex = 1
        '
        'dlgCopySpecial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 225)
        Me.Controls.Add(Me.UcrCheck2)
        Me.Controls.Add(Me.UcrCheck1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dlgCopySpecial"
        Me.Text = "dlgCopySpecial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents UcrCheck2 As ucrCheck
End Class
