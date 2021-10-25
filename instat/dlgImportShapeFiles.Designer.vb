<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgImportShapeFiles
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
        Me.lblFile = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdLibrary = New System.Windows.Forms.Button()
        Me.ucrChkSplitGeometry = New instat.ucrCheck()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFile.Location = New System.Drawing.Point(9, 28)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(33, 16)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(388, 22)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(163, 28)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdLibrary
        '
        Me.cmdLibrary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLibrary.Location = New System.Drawing.Point(388, 74)
        Me.cmdLibrary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdLibrary.Name = "cmdLibrary"
        Me.cmdLibrary.Size = New System.Drawing.Size(163, 28)
        Me.cmdLibrary.TabIndex = 3
        Me.cmdLibrary.Text = "From Library"
        Me.cmdLibrary.UseVisualStyleBackColor = True
        '
        'ucrChkSplitGeometry
        '
        Me.ucrChkSplitGeometry.Checked = False
        Me.ucrChkSplitGeometry.Location = New System.Drawing.Point(9, 110)
        Me.ucrChkSplitGeometry.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrChkSplitGeometry.Name = "ucrChkSplitGeometry"
        Me.ucrChkSplitGeometry.Size = New System.Drawing.Size(200, 25)
        Me.ucrChkSplitGeometry.TabIndex = 5
        '
        'ucrSaveDataframeName
        '
        Me.ucrSaveDataframeName.Location = New System.Drawing.Point(9, 74)
        Me.ucrSaveDataframeName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        Me.ucrSaveDataframeName.Size = New System.Drawing.Size(360, 30)
        Me.ucrSaveDataframeName.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 148)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(529, 64)
        Me.ucrBase.TabIndex = 6
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(65, 22)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(319, 28)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'dlgImportShapeFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 215)
        Me.Controls.Add(Me.ucrChkSplitGeometry)
        Me.Controls.Add(Me.ucrSaveDataframeName)
        Me.Controls.Add(Me.cmdLibrary)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportShapeFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Shapefiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFile As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibrary As Button
    Friend WithEvents ucrSaveDataframeName As ucrSave
    Friend WithEvents ucrChkSplitGeometry As ucrCheck
End Class
