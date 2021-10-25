<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremesDisplayOptions
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
        Me.rdoHist = New System.Windows.Forms.RadioButton()
        Me.rdoZPlot = New System.Windows.Forms.RadioButton()
        Me.rdoProbprob = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQ2 = New System.Windows.Forms.RadioButton()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoTrace = New System.Windows.Forms.RadioButton()
        Me.rdoRlplot = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExtreme = New instat.UcrPanel()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoHist
        '
        Me.rdoHist.AutoSize = True
        Me.rdoHist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHist.Location = New System.Drawing.Point(199, 85)
        Me.rdoHist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoHist.Name = "rdoHist"
        Me.rdoHist.Size = New System.Drawing.Size(82, 20)
        Me.rdoHist.TabIndex = 8
        Me.rdoHist.Text = "Hist Plot"
        Me.rdoHist.UseVisualStyleBackColor = True
        '
        'rdoZPlot
        '
        Me.rdoZPlot.AutoSize = True
        Me.rdoZPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoZPlot.Location = New System.Drawing.Point(199, 57)
        Me.rdoZPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoZPlot.Name = "rdoZPlot"
        Me.rdoZPlot.Size = New System.Drawing.Size(89, 20)
        Me.rdoZPlot.TabIndex = 7
        Me.rdoZPlot.Text = "Zplot Plot"
        Me.rdoZPlot.UseVisualStyleBackColor = True
        '
        'rdoProbprob
        '
        Me.rdoProbprob.AutoSize = True
        Me.rdoProbprob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoProbprob.Location = New System.Drawing.Point(17, 85)
        Me.rdoProbprob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoProbprob.Name = "rdoProbprob"
        Me.rdoProbprob.Size = New System.Drawing.Size(120, 20)
        Me.rdoProbprob.TabIndex = 3
        Me.rdoProbprob.Text = "Prob-prob Plot"
        Me.rdoProbprob.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQPlot.Location = New System.Drawing.Point(199, 28)
        Me.rdoQQPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(80, 20)
        Me.rdoQQPlot.TabIndex = 6
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoQQ2
        '
        Me.rdoQQ2.AutoSize = True
        Me.rdoQQ2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQ2.Location = New System.Drawing.Point(199, 142)
        Me.rdoQQ2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoQQ2.Name = "rdoQQ2"
        Me.rdoQQ2.Size = New System.Drawing.Size(86, 20)
        Me.rdoQQ2.TabIndex = 10
        Me.rdoQQ2.Text = "QQ2 Plot"
        Me.rdoQQ2.UseVisualStyleBackColor = True
        '
        'rdoPrimary
        '
        Me.rdoPrimary.AutoSize = True
        Me.rdoPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPrimary.Location = New System.Drawing.Point(17, 57)
        Me.rdoPrimary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.Size = New System.Drawing.Size(79, 20)
        Me.rdoPrimary.TabIndex = 2
        Me.rdoPrimary.Text = "Primary"
        Me.rdoPrimary.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoNoPlot)
        Me.grpPlots.Controls.Add(Me.rdoTrace)
        Me.grpPlots.Controls.Add(Me.rdoRlplot)
        Me.grpPlots.Controls.Add(Me.rdoHist)
        Me.grpPlots.Controls.Add(Me.rdoDensity)
        Me.grpPlots.Controls.Add(Me.rdoZPlot)
        Me.grpPlots.Controls.Add(Me.rdoProbprob)
        Me.grpPlots.Controls.Add(Me.rdoQQPlot)
        Me.grpPlots.Controls.Add(Me.rdoQQ2)
        Me.grpPlots.Controls.Add(Me.rdoPrimary)
        Me.grpPlots.Controls.Add(Me.ucrPnlExtreme)
        Me.grpPlots.Location = New System.Drawing.Point(16, 15)
        Me.grpPlots.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlots.Size = New System.Drawing.Size(348, 174)
        Me.grpPlots.TabIndex = 0
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoPlot.Location = New System.Drawing.Point(17, 28)
        Me.rdoNoPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(77, 20)
        Me.rdoNoPlot.TabIndex = 1
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoTrace
        '
        Me.rdoTrace.AutoSize = True
        Me.rdoTrace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrace.Location = New System.Drawing.Point(17, 142)
        Me.rdoTrace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoTrace.Name = "rdoTrace"
        Me.rdoTrace.Size = New System.Drawing.Size(95, 20)
        Me.rdoTrace.TabIndex = 5
        Me.rdoTrace.Text = "Trace Plot"
        Me.rdoTrace.UseVisualStyleBackColor = True
        '
        'rdoRlplot
        '
        Me.rdoRlplot.AutoSize = True
        Me.rdoRlplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRlplot.Location = New System.Drawing.Point(17, 113)
        Me.rdoRlplot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRlplot.Name = "rdoRlplot"
        Me.rdoRlplot.Size = New System.Drawing.Size(72, 20)
        Me.rdoRlplot.TabIndex = 4
        Me.rdoRlplot.Text = "Rl Plot"
        Me.rdoRlplot.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(199, 113)
        Me.rdoDensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(104, 20)
        Me.rdoDensity.TabIndex = 9
        Me.rdoDensity.Text = "Density Plot"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'ucrPnlExtreme
        '
        Me.ucrPnlExtreme.Location = New System.Drawing.Point(8, 23)
        Me.ucrPnlExtreme.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlExtreme.Name = "ucrPnlExtreme"
        Me.ucrPnlExtreme.Size = New System.Drawing.Size(319, 144)
        Me.ucrPnlExtreme.TabIndex = 0
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(16, 198)
        Me.ucrSavePlots.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(348, 30)
        Me.ucrSavePlots.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(88, 238)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(209, 37)
        Me.ucrBase.TabIndex = 2
        '
        'sdgExtremesDisplayOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 277)
        Me.Controls.Add(Me.ucrSavePlots)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesDisplayOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Display Options"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoHist As RadioButton
    Friend WithEvents rdoZPlot As RadioButton
    Friend WithEvents rdoProbprob As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoQQ2 As RadioButton
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoTrace As RadioButton
    Friend WithEvents rdoRlplot As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents ucrPnlExtreme As UcrPanel
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
End Class
