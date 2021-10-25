<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremesMethod
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
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoMLE = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrPanelExtreme = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoLmoments
        '
        Me.rdoLmoments.AutoSize = True
        Me.rdoLmoments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLmoments.Location = New System.Drawing.Point(16, 124)
        Me.rdoLmoments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.Size = New System.Drawing.Size(99, 20)
        Me.rdoLmoments.TabIndex = 4
        Me.rdoLmoments.TabStop = True
        Me.rdoLmoments.Text = "L-moments"
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        Me.rdoBayesian.AutoSize = True
        Me.rdoBayesian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBayesian.Location = New System.Drawing.Point(16, 96)
        Me.rdoBayesian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.Size = New System.Drawing.Size(90, 20)
        Me.rdoBayesian.TabIndex = 3
        Me.rdoBayesian.TabStop = True
        Me.rdoBayesian.Text = "Bayesian"
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        Me.rdoGMLE.AutoSize = True
        Me.rdoGMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGMLE.Location = New System.Drawing.Point(16, 52)
        Me.rdoGMLE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.Size = New System.Drawing.Size(265, 36)
        Me.rdoGMLE.TabIndex = 2
        Me.rdoGMLE.TabStop = True
        Me.rdoGMLE.Text = "General Maximum Likelihood Estimator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(GMLE)"
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoMLE
        '
        Me.rdoMLE.AutoSize = True
        Me.rdoMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMLE.Location = New System.Drawing.Point(16, 23)
        Me.rdoMLE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMLE.Name = "rdoMLE"
        Me.rdoMLE.Size = New System.Drawing.Size(193, 20)
        Me.rdoMLE.TabIndex = 1
        Me.rdoMLE.TabStop = True
        Me.rdoMLE.Text = "Maximum Likelihood (MLE)"
        Me.rdoMLE.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(52, 153)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(209, 37)
        Me.ucrBase.TabIndex = 5
        '
        'ucrPanelExtreme
        '
        Me.ucrPanelExtreme.Location = New System.Drawing.Point(7, 14)
        Me.ucrPanelExtreme.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPanelExtreme.Name = "ucrPanelExtreme"
        Me.ucrPanelExtreme.Size = New System.Drawing.Size(284, 146)
        Me.ucrPanelExtreme.TabIndex = 0
        '
        'sdgExtremesMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 197)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoLmoments)
        Me.Controls.Add(Me.rdoBayesian)
        Me.Controls.Add(Me.rdoGMLE)
        Me.Controls.Add(Me.rdoMLE)
        Me.Controls.Add(Me.ucrPanelExtreme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Method"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoMLE As RadioButton
    Friend WithEvents ucrPanelExtreme As UcrPanel
End Class
