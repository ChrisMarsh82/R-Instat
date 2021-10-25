<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAugment
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
        Me.lblModels = New System.Windows.Forms.Label()
        Me.rdoAddToDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayInOutput = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrModelReceiver = New instat.ucrReceiverSingle()
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(345, 46)
        Me.lblModels.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(49, 16)
        Me.lblModels.TabIndex = 2
        Me.lblModels.Text = "Model:"
        '
        'rdoAddToDataFrame
        '
        Me.rdoAddToDataFrame.AutoSize = True
        Me.rdoAddToDataFrame.Location = New System.Drawing.Point(17, 246)
        Me.rdoAddToDataFrame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAddToDataFrame.Name = "rdoAddToDataFrame"
        Me.rdoAddToDataFrame.Size = New System.Drawing.Size(149, 20)
        Me.rdoAddToDataFrame.TabIndex = 9
        Me.rdoAddToDataFrame.TabStop = True
        Me.rdoAddToDataFrame.Text = "Add to Data Frame:"
        Me.rdoAddToDataFrame.UseVisualStyleBackColor = True
        '
        'rdoDisplayInOutput
        '
        Me.rdoDisplayInOutput.AutoSize = True
        Me.rdoDisplayInOutput.Location = New System.Drawing.Point(17, 292)
        Me.rdoDisplayInOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDisplayInOutput.Name = "rdoDisplayInOutput"
        Me.rdoDisplayInOutput.Size = New System.Drawing.Size(133, 20)
        Me.rdoDisplayInOutput.TabIndex = 10
        Me.rdoDisplayInOutput.TabStop = True
        Me.rdoDisplayInOutput.Text = "Display In Output"
        Me.rdoDisplayInOutput.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrame
        '
        Me.rdoNewDataFrame.AutoSize = True
        Me.rdoNewDataFrame.Location = New System.Drawing.Point(17, 342)
        Me.rdoNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoNewDataFrame.Name = "rdoNewDataFrame"
        Me.rdoNewDataFrame.Size = New System.Drawing.Size(177, 20)
        Me.rdoNewDataFrame.TabIndex = 11
        Me.rdoNewDataFrame.TabStop = True
        Me.rdoNewDataFrame.Text = "New Data Frame Name:"
        Me.rdoNewDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(13, 244)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(279, 130)
        Me.ucrPnlOptions.TabIndex = 8
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(313, 342)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(211, 32)
        Me.ucrSaveNewDataFrame.TabIndex = 7
        '
        'ucrModelReceiver
        '
        Me.ucrModelReceiver.frmParent = Me
        Me.ucrModelReceiver.Location = New System.Drawing.Point(345, 65)
        Me.ucrModelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelReceiver.Name = "ucrModelReceiver"
        Me.ucrModelReceiver.Selector = Nothing
        Me.ucrModelReceiver.Size = New System.Drawing.Size(179, 25)
        Me.ucrModelReceiver.strNcFilePath = ""
        Me.ucrModelReceiver.TabIndex = 6
        Me.ucrModelReceiver.ucrSelector = Nothing
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        Me.ucrModelSelector.Location = New System.Drawing.Point(12, 11)
        Me.ucrModelSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelSelector.Name = "ucrModelSelector"
        Me.ucrModelSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrModelSelector.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 407)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 71)
        Me.ucrBase.TabIndex = 0
        '
        'dlgAugment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 486)
        Me.Controls.Add(Me.rdoNewDataFrame)
        Me.Controls.Add(Me.rdoDisplayInOutput)
        Me.Controls.Add(Me.rdoAddToDataFrame)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrModelReceiver)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrModelSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAugment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Augment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrModelSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblModels As Label
    Friend WithEvents ucrModelReceiver As ucrReceiverSingle
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents rdoNewDataFrame As RadioButton
    Friend WithEvents rdoDisplayInOutput As RadioButton
    Friend WithEvents rdoAddToDataFrame As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
