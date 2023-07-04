<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneVariableSummariseControl
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
        Me.DataframeSelectorControl1 = New instat.dataframeSelectorControl()
        Me.ColumnSelectorControl1 = New instat.columnSelectorControl()
        Me.NumberSelectorControl1 = New instat.numberSelectorControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DataframeSelectorControl1
        '
        Me.DataframeSelectorControl1.Location = New System.Drawing.Point(119, 91)
        Me.DataframeSelectorControl1.Name = "DataframeSelectorControl1"
        Me.DataframeSelectorControl1.Size = New System.Drawing.Size(326, 82)
        Me.DataframeSelectorControl1.TabIndex = 0
        '
        'ColumnSelectorControl1
        '
        Me.ColumnSelectorControl1.Location = New System.Drawing.Point(98, 208)
        Me.ColumnSelectorControl1.Name = "ColumnSelectorControl1"
        Me.ColumnSelectorControl1.Size = New System.Drawing.Size(819, 283)
        Me.ColumnSelectorControl1.TabIndex = 1
        '
        'NumberSelectorControl1
        '
        Me.NumberSelectorControl1.Location = New System.Drawing.Point(163, 524)
        Me.NumberSelectorControl1.Name = "NumberSelectorControl1"
        Me.NumberSelectorControl1.Size = New System.Drawing.Size(259, 80)
        Me.NumberSelectorControl1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 695)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 57)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OneVariableSummariseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumberSelectorControl1)
        Me.Controls.Add(Me.ColumnSelectorControl1)
        Me.Controls.Add(Me.DataframeSelectorControl1)
        Me.Name = "OneVariableSummariseControl"
        Me.Size = New System.Drawing.Size(1162, 778)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataframeSelectorControl1 As dataframeSelectorControl
    Friend WithEvents ColumnSelectorControl1 As columnSelectorControl
    Friend WithEvents NumberSelectorControl1 As numberSelectorControl
    Friend WithEvents Button1 As Button
End Class
