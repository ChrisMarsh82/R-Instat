<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPSummaryFile
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
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrSelectorA6 = New instat.ucrDataFrame()
        Me.ucrSelectorA4 = New instat.ucrDataFrame()
        Me.ucrSelectorA2 = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveSummary = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(9, 235)
        Me.lblSaveFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(92, 16)
        Me.lblSaveFile.TabIndex = 4
        Me.lblSaveFile.Text = "Save file(s) to:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(448, 230)
        Me.cmdChooseFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(100, 28)
        Me.cmdChooseFile.TabIndex = 6
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(215, 231)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(232, 26)
        Me.ucrInputFilePath.TabIndex = 5
        '
        'ucrSelectorA6
        '
        Me.ucrSelectorA6.bDropUnusedFilterLevels = False
        Me.ucrSelectorA6.bUseCurrentFilter = True
        Me.ucrSelectorA6.Location = New System.Drawing.Point(13, 135)
        Me.ucrSelectorA6.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA6.Name = "ucrSelectorA6"
        Me.ucrSelectorA6.Size = New System.Drawing.Size(197, 62)
        Me.ucrSelectorA6.TabIndex = 2
        '
        'ucrSelectorA4
        '
        Me.ucrSelectorA4.bDropUnusedFilterLevels = False
        Me.ucrSelectorA4.bUseCurrentFilter = True
        Me.ucrSelectorA4.Location = New System.Drawing.Point(13, 74)
        Me.ucrSelectorA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA4.Name = "ucrSelectorA4"
        Me.ucrSelectorA4.Size = New System.Drawing.Size(197, 62)
        Me.ucrSelectorA4.TabIndex = 1
        '
        'ucrSelectorA2
        '
        Me.ucrSelectorA2.bDropUnusedFilterLevels = False
        Me.ucrSelectorA2.bUseCurrentFilter = True
        Me.ucrSelectorA2.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA2.Name = "ucrSelectorA2"
        Me.ucrSelectorA2.Size = New System.Drawing.Size(197, 62)
        Me.ucrSelectorA2.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 266)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(540, 64)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSaveSummary
        '
        Me.ucrSaveSummary.Location = New System.Drawing.Point(13, 196)
        Me.ucrSaveSummary.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveSummary.Name = "ucrSaveSummary"
        Me.ucrSaveSummary.Size = New System.Drawing.Size(385, 27)
        Me.ucrSaveSummary.TabIndex = 3
        '
        'dlgClimaticNCMPSummaryFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 337)
        Me.Controls.Add(Me.ucrSaveSummary)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorA6)
        Me.Controls.Add(Me.ucrSelectorA4)
        Me.Controls.Add(Me.ucrSelectorA2)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPSummaryFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Summary File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaveFile As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrSelectorA6 As ucrDataFrame
    Friend WithEvents ucrSelectorA4 As ucrDataFrame
    Friend WithEvents ucrSelectorA2 As ucrDataFrame
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveSummary As ucrSave
End Class