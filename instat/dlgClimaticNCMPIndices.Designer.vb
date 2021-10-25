<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPIndices
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
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorIndices = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdStationMetadata = New System.Windows.Forms.Button()
        Me.lblQCT = New System.Windows.Forms.Label()
        Me.ucrNudQCT = New instat.ucrNud()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudNYBR = New instat.ucrNud()
        Me.lblNYBR = New System.Windows.Forms.Label()
        Me.lblNYER = New System.Windows.Forms.Label()
        Me.ucrNudNYER = New instat.ucrNud()
        Me.ucrNudQCPR = New instat.ucrNud()
        Me.lblQCPR = New System.Windows.Forms.Label()
        Me.ucrSaveIndices = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(356, 204)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 8
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(356, 258)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.TabIndex = 10
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmin.Location = New System.Drawing.Point(355, 186)
        Me.lblTmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(145, 16)
        Me.lblTmin.TabIndex = 7
        Me.lblTmin.Text = "Minimum Temperature:"
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(356, 150)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 6
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmax.Location = New System.Drawing.Point(355, 240)
        Me.lblTmax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(149, 16)
        Me.lblTmax.TabIndex = 9
        Me.lblTmax.Text = "Maximum Temperature:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(356, 96)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRain.Location = New System.Drawing.Point(355, 132)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(87, 16)
        Me.lblRain.TabIndex = 5
        Me.lblRain.Text = "Rain Column:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(355, 78)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(356, 42)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorIndices
        '
        Me.ucrSelectorIndices.bDropUnusedFilterLevels = False
        Me.ucrSelectorIndices.bShowHiddenColumns = False
        Me.ucrSelectorIndices.bUseCurrentFilter = True
        Me.ucrSelectorIndices.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorIndices.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIndices.Name = "ucrSelectorIndices"
        Me.ucrSelectorIndices.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorIndices.TabIndex = 0
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(355, 23)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(52, 16)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStationMetadata.Location = New System.Drawing.Point(331, 294)
        Me.cmdStationMetadata.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(207, 28)
        Me.cmdStationMetadata.TabIndex = 11
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'lblQCT
        '
        Me.lblQCT.AutoSize = True
        Me.lblQCT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQCT.Location = New System.Drawing.Point(5, 30)
        Me.lblQCT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQCT.Name = "lblQCT"
        Me.lblQCT.Size = New System.Drawing.Size(232, 16)
        Me.lblQCT.TabIndex = 0
        Me.lblQCT.Text = "Quality Control Level for Temperature:"
        '
        'ucrNudQCT
        '
        Me.ucrNudQCT.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQCT.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudQCT.Location = New System.Drawing.Point(255, 27)
        Me.ucrNudQCT.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudQCT.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQCT.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQCT.Name = "ucrNudQCT"
        Me.ucrNudQCT.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudQCT.TabIndex = 1
        Me.ucrNudQCT.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrNudNYBR)
        Me.grpOptions.Controls.Add(Me.lblNYBR)
        Me.grpOptions.Controls.Add(Me.lblNYER)
        Me.grpOptions.Controls.Add(Me.ucrNudNYER)
        Me.grpOptions.Controls.Add(Me.ucrNudQCPR)
        Me.grpOptions.Controls.Add(Me.lblQCPR)
        Me.grpOptions.Controls.Add(Me.ucrNudQCT)
        Me.grpOptions.Controls.Add(Me.lblQCT)
        Me.grpOptions.Location = New System.Drawing.Point(13, 247)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Size = New System.Drawing.Size(329, 161)
        Me.grpOptions.TabIndex = 13
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrNudNYBR
        '
        Me.ucrNudNYBR.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYBR.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYBR.Location = New System.Drawing.Point(255, 91)
        Me.ucrNudNYBR.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudNYBR.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYBR.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYBR.Name = "ucrNudNYBR"
        Me.ucrNudNYBR.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudNYBR.TabIndex = 5
        Me.ucrNudNYBR.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNYBR
        '
        Me.lblNYBR.AutoSize = True
        Me.lblNYBR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYBR.Location = New System.Drawing.Point(5, 95)
        Me.lblNYBR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNYBR.Name = "lblNYBR"
        Me.lblNYBR.Size = New System.Drawing.Size(219, 16)
        Me.lblNYBR.TabIndex = 4
        Me.lblNYBR.Text = "Start Year for Climatological Period:"
        '
        'lblNYER
        '
        Me.lblNYER.AutoSize = True
        Me.lblNYER.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYER.Location = New System.Drawing.Point(5, 126)
        Me.lblNYER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNYER.Name = "lblNYER"
        Me.lblNYER.Size = New System.Drawing.Size(216, 16)
        Me.lblNYER.TabIndex = 14
        Me.lblNYER.Text = "End Year for Climatological Period:"
        '
        'ucrNudNYER
        '
        Me.ucrNudNYER.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYER.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYER.Location = New System.Drawing.Point(255, 123)
        Me.ucrNudNYER.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudNYER.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYER.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYER.Name = "ucrNudNYER"
        Me.ucrNudNYER.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudNYER.TabIndex = 15
        Me.ucrNudNYER.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudQCPR
        '
        Me.ucrNudQCPR.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQCPR.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudQCPR.Location = New System.Drawing.Point(255, 59)
        Me.ucrNudQCPR.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudQCPR.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQCPR.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQCPR.Name = "ucrNudQCPR"
        Me.ucrNudQCPR.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudQCPR.TabIndex = 3
        Me.ucrNudQCPR.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQCPR
        '
        Me.lblQCPR.AutoSize = True
        Me.lblQCPR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQCPR.Location = New System.Drawing.Point(5, 62)
        Me.lblQCPR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQCPR.Name = "lblQCPR"
        Me.lblQCPR.Size = New System.Drawing.Size(182, 16)
        Me.lblQCPR.TabIndex = 2
        Me.lblQCPR.Text = "Quality Control Level for Rain:"
        '
        'ucrSaveIndices
        '
        Me.ucrSaveIndices.Location = New System.Drawing.Point(13, 340)
        Me.ucrSaveIndices.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveIndices.Name = "ucrSaveIndices"
        Me.ucrSaveIndices.Size = New System.Drawing.Size(427, 30)
        Me.ucrSaveIndices.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 377)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(540, 64)
        Me.ucrBase.TabIndex = 16
        '
        'dlgClimaticNCMPIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.ucrSaveIndices)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Indices"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents lblTmin As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorIndices As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblStation As Label
    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrNudNYBR As ucrNud
    Friend WithEvents lblNYBR As Label
    Friend WithEvents ucrNudQCPR As ucrNud
    Friend WithEvents lblQCPR As Label
    Friend WithEvents ucrNudQCT As ucrNud
    Friend WithEvents lblQCT As Label
    Friend WithEvents ucrNudNYER As ucrNud
    Friend WithEvents lblNYER As Label
    Friend WithEvents ucrSaveIndices As ucrSave
    Friend WithEvents ucrBase As ucrButtons
End Class
