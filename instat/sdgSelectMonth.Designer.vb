<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSelectMonth
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
        Me.lblSelectMonth = New System.Windows.Forms.Label()
        Me.ucrMonthAsFactor = New instat.ucrFactor()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblSelectMonth
        '
        Me.lblSelectMonth.AutoSize = True
        Me.lblSelectMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectMonth.Location = New System.Drawing.Point(24, 28)
        Me.lblSelectMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectMonth.Name = "lblSelectMonth"
        Me.lblSelectMonth.Size = New System.Drawing.Size(147, 16)
        Me.lblSelectMonth.TabIndex = 14
        Me.lblSelectMonth.Text = "Select Month(s) to Omit:"
        '
        'ucrMonthAsFactor
        '
        Me.ucrMonthAsFactor.AutoSize = True
        Me.ucrMonthAsFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrMonthAsFactor.clsReceiver = Nothing
        Me.ucrMonthAsFactor.Location = New System.Drawing.Point(19, 49)
        Me.ucrMonthAsFactor.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrMonthAsFactor.Name = "ucrMonthAsFactor"
        Me.ucrMonthAsFactor.shtCurrSheet = Nothing
        Me.ucrMonthAsFactor.Size = New System.Drawing.Size(307, 269)
        Me.ucrMonthAsFactor.TabIndex = 3
        Me.ucrMonthAsFactor.ucrChkLevels = Nothing
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.Location = New System.Drawing.Point(71, 326)
        Me.ucrBaseSdg.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(205, 37)
        Me.ucrBaseSdg.TabIndex = 0
        '
        'sdgSelectMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 367)
        Me.Controls.Add(Me.lblSelectMonth)
        Me.Controls.Add(Me.ucrMonthAsFactor)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSelectMonth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents ucrMonthAsFactor As ucrFactor
    Friend WithEvents lblSelectMonth As Label
End Class
