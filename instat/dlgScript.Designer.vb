<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScript
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
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.btnAddDataFrame = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrInputComboPackage = New instat.ucrInputComboBox()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrDataFrameCopySheets = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(16, 32)
        Me.lblPackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(90, 16)
        Me.lblPackage.TabIndex = 19
        Me.lblPackage.Text = "Get Package:"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewName.Location = New System.Drawing.Point(12, 165)
        Me.lblNewName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(136, 16)
        Me.lblNewName.TabIndex = 21
        Me.lblNewName.Tag = ""
        Me.lblNewName.Text = "Write new data frame:"
        '
        'btnAddDataFrame
        '
        Me.btnAddDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddDataFrame.Location = New System.Drawing.Point(243, 114)
        Me.btnAddDataFrame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddDataFrame.Name = "btnAddDataFrame"
        Me.btnAddDataFrame.Size = New System.Drawing.Size(99, 28)
        Me.btnAddDataFrame.TabIndex = 23
        Me.btnAddDataFrame.Text = "Add"
        Me.btnAddDataFrame.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(243, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(243, 182)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 28)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(12, 185)
        Me.ucrInputNewDataFrameName.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputNewDataFrameName.TabIndex = 22
        '
        'ucrInputComboPackage
        '
        Me.ucrInputComboPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPackage.GetSetSelectedIndex = -1
        Me.ucrInputComboPackage.IsReadOnly = False
        Me.ucrInputComboPackage.Location = New System.Drawing.Point(20, 52)
        Me.ucrInputComboPackage.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputComboPackage.Name = "ucrInputComboPackage"
        Me.ucrInputComboPackage.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputComboPackage.TabIndex = 20
        '
        'ucrInputCommand
        '
        Me.ucrInputCommand.AddQuotesIfUnrecognised = True
        Me.ucrInputCommand.IsMultiline = True
        Me.ucrInputCommand.IsReadOnly = False
        Me.ucrInputCommand.Location = New System.Drawing.Point(393, 14)
        Me.ucrInputCommand.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputCommand.Name = "ucrInputCommand"
        Me.ucrInputCommand.Size = New System.Drawing.Size(591, 514)
        Me.ucrInputCommand.TabIndex = 18
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(12, 92)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(197, 62)
        Me.ucrDataFrameCopySheets.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(149, 538)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(555, 70)
        Me.ucrBase.TabIndex = 16
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 617)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddDataFrame)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.ucrInputComboPackage)
        Me.Controls.Add(Me.ucrInputCommand)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.Text = "Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents ucrInputCommand As ucrInputTextBox
    Friend WithEvents lblPackage As Label
    Friend WithEvents ucrInputComboPackage As ucrInputComboBox
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents lblNewName As Label
    Friend WithEvents btnAddDataFrame As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
