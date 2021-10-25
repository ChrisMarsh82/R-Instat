﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportToWWR
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
        Me.lblStationIdentifier = New System.Windows.Forms.Label()
        Me.lblMeanDailyMinAirTemperature = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblMeanStationPressure = New System.Windows.Forms.Label()
        Me.lblMeanSeaLevelPressure = New System.Windows.Forms.Label()
        Me.lblMeanMonthlyAirTemperature = New System.Windows.Forms.Label()
        Me.lblPrecipitation = New System.Windows.Forms.Label()
        Me.lblMeanDailyMaxAirTemperature = New System.Windows.Forms.Label()
        Me.lblMeanRelativeHumidity = New System.Windows.Forms.Label()
        Me.cmdStationMetadata = New System.Windows.Forms.Button()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverMeanRelativeHumidity = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrecipitation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanMonthlyAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanSeaLevelPressure = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanDailyMinAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanDailyMaxAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanStationPressure = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationIdentifier = New instat.ucrReceiverSingle()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputLinkby = New instat.ucrInputComboBox()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrSelectorExportToWWR = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpElements.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStationIdentifier
        '
        Me.lblStationIdentifier.AutoSize = True
        Me.lblStationIdentifier.Location = New System.Drawing.Point(317, 32)
        Me.lblStationIdentifier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationIdentifier.Name = "lblStationIdentifier"
        Me.lblStationIdentifier.Size = New System.Drawing.Size(105, 16)
        Me.lblStationIdentifier.TabIndex = 1
        Me.lblStationIdentifier.Text = "Station Identifier:"
        '
        'lblMeanDailyMinAirTemperature
        '
        Me.lblMeanDailyMinAirTemperature.AutoSize = True
        Me.lblMeanDailyMinAirTemperature.Location = New System.Drawing.Point(300, 70)
        Me.lblMeanDailyMinAirTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanDailyMinAirTemperature.Name = "lblMeanDailyMinAirTemperature"
        Me.lblMeanDailyMinAirTemperature.Size = New System.Drawing.Size(216, 16)
        Me.lblMeanDailyMinAirTemperature.TabIndex = 21
        Me.lblMeanDailyMinAirTemperature.Text = "7. Mean Daily Min Air Temperature:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(340, 127)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 16)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(340, 176)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(47, 16)
        Me.lblMonth.TabIndex = 8
        Me.lblMonth.Text = "Month:"
        '
        'lblMeanStationPressure
        '
        Me.lblMeanStationPressure.AutoSize = True
        Me.lblMeanStationPressure.Location = New System.Drawing.Point(8, 20)
        Me.lblMeanStationPressure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanStationPressure.Name = "lblMeanStationPressure"
        Me.lblMeanStationPressure.Size = New System.Drawing.Size(159, 16)
        Me.lblMeanStationPressure.TabIndex = 11
        Me.lblMeanStationPressure.Text = "2. Mean Station Pressure:"
        '
        'lblMeanSeaLevelPressure
        '
        Me.lblMeanSeaLevelPressure.AutoSize = True
        Me.lblMeanSeaLevelPressure.Location = New System.Drawing.Point(8, 70)
        Me.lblMeanSeaLevelPressure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanSeaLevelPressure.Name = "lblMeanSeaLevelPressure"
        Me.lblMeanSeaLevelPressure.Size = New System.Drawing.Size(179, 16)
        Me.lblMeanSeaLevelPressure.TabIndex = 13
        Me.lblMeanSeaLevelPressure.Text = "3. Mean Sea Level Pressure:"
        '
        'lblMeanMonthlyAirTemperature
        '
        Me.lblMeanMonthlyAirTemperature.AutoSize = True
        Me.lblMeanMonthlyAirTemperature.Location = New System.Drawing.Point(8, 121)
        Me.lblMeanMonthlyAirTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanMonthlyAirTemperature.Name = "lblMeanMonthlyAirTemperature"
        Me.lblMeanMonthlyAirTemperature.Size = New System.Drawing.Size(192, 16)
        Me.lblMeanMonthlyAirTemperature.TabIndex = 15
        Me.lblMeanMonthlyAirTemperature.Text = "4. Mean Daily Air Temperature:"
        '
        'lblPrecipitation
        '
        Me.lblPrecipitation.AutoSize = True
        Me.lblPrecipitation.Location = New System.Drawing.Point(8, 171)
        Me.lblPrecipitation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecipitation.Name = "lblPrecipitation"
        Me.lblPrecipitation.Size = New System.Drawing.Size(132, 16)
        Me.lblPrecipitation.TabIndex = 17
        Me.lblPrecipitation.Text = "5. Total Precipitation:"
        '
        'lblMeanDailyMaxAirTemperature
        '
        Me.lblMeanDailyMaxAirTemperature.AutoSize = True
        Me.lblMeanDailyMaxAirTemperature.Location = New System.Drawing.Point(300, 20)
        Me.lblMeanDailyMaxAirTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanDailyMaxAirTemperature.Name = "lblMeanDailyMaxAirTemperature"
        Me.lblMeanDailyMaxAirTemperature.Size = New System.Drawing.Size(220, 16)
        Me.lblMeanDailyMaxAirTemperature.TabIndex = 19
        Me.lblMeanDailyMaxAirTemperature.Text = "6. Mean Daily Max Air Temperature:"
        '
        'lblMeanRelativeHumidity
        '
        Me.lblMeanRelativeHumidity.AutoSize = True
        Me.lblMeanRelativeHumidity.Location = New System.Drawing.Point(300, 121)
        Me.lblMeanRelativeHumidity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanRelativeHumidity.Name = "lblMeanRelativeHumidity"
        Me.lblMeanRelativeHumidity.Size = New System.Drawing.Size(200, 16)
        Me.lblMeanRelativeHumidity.TabIndex = 23
        Me.lblMeanRelativeHumidity.Text = "8. Mean Daily Relative Humidity:"
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.Location = New System.Drawing.Point(323, 89)
        Me.cmdStationMetadata.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(188, 28)
        Me.cmdStationMetadata.TabIndex = 5
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(529, 464)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(129, 28)
        Me.cmdBrowse.TabIndex = 26
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblSaveFile
        '
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(9, 470)
        Me.lblSaveFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(219, 21)
        Me.lblSaveFile.TabIndex = 24
        Me.lblSaveFile.Text = "Save file(s) to:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(491, 31)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(43, 16)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "Type:"
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.lblMeanDailyMaxAirTemperature)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanRelativeHumidity)
        Me.grpElements.Controls.Add(Me.ucrReceiverPrecipitation)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanMonthlyAirTemperature)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanSeaLevelPressure)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanDailyMinAirTemperature)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanDailyMaxAirTemperature)
        Me.grpElements.Controls.Add(Me.ucrReceiverMeanStationPressure)
        Me.grpElements.Controls.Add(Me.lblMeanRelativeHumidity)
        Me.grpElements.Controls.Add(Me.lblMeanDailyMinAirTemperature)
        Me.grpElements.Controls.Add(Me.lblMeanStationPressure)
        Me.grpElements.Controls.Add(Me.lblPrecipitation)
        Me.grpElements.Controls.Add(Me.lblMeanSeaLevelPressure)
        Me.grpElements.Controls.Add(Me.lblMeanMonthlyAirTemperature)
        Me.grpElements.Location = New System.Drawing.Point(4, 234)
        Me.grpElements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpElements.Size = New System.Drawing.Size(659, 222)
        Me.grpElements.TabIndex = 10
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements"
        '
        'ucrReceiverMeanRelativeHumidity
        '
        Me.ucrReceiverMeanRelativeHumidity.frmParent = Me
        Me.ucrReceiverMeanRelativeHumidity.Location = New System.Drawing.Point(304, 140)
        Me.ucrReceiverMeanRelativeHumidity.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanRelativeHumidity.Name = "ucrReceiverMeanRelativeHumidity"
        Me.ucrReceiverMeanRelativeHumidity.Selector = Nothing
        Me.ucrReceiverMeanRelativeHumidity.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanRelativeHumidity.strNcFilePath = ""
        Me.ucrReceiverMeanRelativeHumidity.TabIndex = 24
        Me.ucrReceiverMeanRelativeHumidity.ucrSelector = Nothing
        '
        'ucrReceiverPrecipitation
        '
        Me.ucrReceiverPrecipitation.frmParent = Me
        Me.ucrReceiverPrecipitation.Location = New System.Drawing.Point(12, 191)
        Me.ucrReceiverPrecipitation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrecipitation.Name = "ucrReceiverPrecipitation"
        Me.ucrReceiverPrecipitation.Selector = Nothing
        Me.ucrReceiverPrecipitation.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverPrecipitation.strNcFilePath = ""
        Me.ucrReceiverPrecipitation.TabIndex = 18
        Me.ucrReceiverPrecipitation.ucrSelector = Nothing
        '
        'ucrReceiverMeanMonthlyAirTemperature
        '
        Me.ucrReceiverMeanMonthlyAirTemperature.frmParent = Me
        Me.ucrReceiverMeanMonthlyAirTemperature.Location = New System.Drawing.Point(12, 140)
        Me.ucrReceiverMeanMonthlyAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanMonthlyAirTemperature.Name = "ucrReceiverMeanMonthlyAirTemperature"
        Me.ucrReceiverMeanMonthlyAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanMonthlyAirTemperature.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanMonthlyAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanMonthlyAirTemperature.TabIndex = 16
        Me.ucrReceiverMeanMonthlyAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMeanSeaLevelPressure
        '
        Me.ucrReceiverMeanSeaLevelPressure.frmParent = Me
        Me.ucrReceiverMeanSeaLevelPressure.Location = New System.Drawing.Point(12, 90)
        Me.ucrReceiverMeanSeaLevelPressure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanSeaLevelPressure.Name = "ucrReceiverMeanSeaLevelPressure"
        Me.ucrReceiverMeanSeaLevelPressure.Selector = Nothing
        Me.ucrReceiverMeanSeaLevelPressure.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanSeaLevelPressure.strNcFilePath = ""
        Me.ucrReceiverMeanSeaLevelPressure.TabIndex = 14
        Me.ucrReceiverMeanSeaLevelPressure.ucrSelector = Nothing
        '
        'ucrReceiverMeanDailyMinAirTemperature
        '
        Me.ucrReceiverMeanDailyMinAirTemperature.frmParent = Me
        Me.ucrReceiverMeanDailyMinAirTemperature.Location = New System.Drawing.Point(304, 90)
        Me.ucrReceiverMeanDailyMinAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanDailyMinAirTemperature.Name = "ucrReceiverMeanDailyMinAirTemperature"
        Me.ucrReceiverMeanDailyMinAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanDailyMinAirTemperature.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanDailyMinAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanDailyMinAirTemperature.TabIndex = 22
        Me.ucrReceiverMeanDailyMinAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMeanDailyMaxAirTemperature
        '
        Me.ucrReceiverMeanDailyMaxAirTemperature.frmParent = Me
        Me.ucrReceiverMeanDailyMaxAirTemperature.Location = New System.Drawing.Point(304, 39)
        Me.ucrReceiverMeanDailyMaxAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanDailyMaxAirTemperature.Name = "ucrReceiverMeanDailyMaxAirTemperature"
        Me.ucrReceiverMeanDailyMaxAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanDailyMaxAirTemperature.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanDailyMaxAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanDailyMaxAirTemperature.TabIndex = 20
        Me.ucrReceiverMeanDailyMaxAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMeanStationPressure
        '
        Me.ucrReceiverMeanStationPressure.frmParent = Me
        Me.ucrReceiverMeanStationPressure.Location = New System.Drawing.Point(12, 39)
        Me.ucrReceiverMeanStationPressure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanStationPressure.Name = "ucrReceiverMeanStationPressure"
        Me.ucrReceiverMeanStationPressure.Selector = Nothing
        Me.ucrReceiverMeanStationPressure.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeanStationPressure.strNcFilePath = ""
        Me.ucrReceiverMeanStationPressure.TabIndex = 12
        Me.ucrReceiverMeanStationPressure.ucrSelector = Nothing
        '
        'ucrReceiverStationIdentifier
        '
        Me.ucrReceiverStationIdentifier.frmParent = Me
        Me.ucrReceiverStationIdentifier.Location = New System.Drawing.Point(323, 52)
        Me.ucrReceiverStationIdentifier.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationIdentifier.Name = "ucrReceiverStationIdentifier"
        Me.ucrReceiverStationIdentifier.Selector = Nothing
        Me.ucrReceiverStationIdentifier.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStationIdentifier.strNcFilePath = ""
        Me.ucrReceiverStationIdentifier.TabIndex = 2
        Me.ucrReceiverStationIdentifier.ucrSelector = Nothing
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(235, 465)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(293, 26)
        Me.ucrInputFilePath.TabIndex = 25
        '
        'ucrInputLinkby
        '
        Me.ucrInputLinkby.AddQuotesIfUnrecognised = True
        Me.ucrInputLinkby.GetSetSelectedIndex = -1
        Me.ucrInputLinkby.IsReadOnly = False
        Me.ucrInputLinkby.Location = New System.Drawing.Point(493, 50)
        Me.ucrInputLinkby.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputLinkby.Name = "ucrInputLinkby"
        Me.ucrInputLinkby.Size = New System.Drawing.Size(128, 26)
        Me.ucrInputLinkby.TabIndex = 4
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(323, 196)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 9
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(323, 146)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 7
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrSelectorExportToWWR
        '
        Me.ucrSelectorExportToWWR.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportToWWR.bShowHiddenColumns = False
        Me.ucrSelectorExportToWWR.bUseCurrentFilter = True
        Me.ucrSelectorExportToWWR.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorExportToWWR.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportToWWR.Name = "ucrSelectorExportToWWR"
        Me.ucrSelectorExportToWWR.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorExportToWWR.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 503)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 27
        '
        'dlgExportToWWR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 572)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrReceiverStationIdentifier)
        Me.Controls.Add(Me.lblSaveFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrInputLinkby)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStationIdentifier)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrSelectorExportToWWR)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToWWR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export To World Weather Record"
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorExportToWWR As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblMeanRelativeHumidity As Label
    Friend WithEvents lblMeanDailyMaxAirTemperature As Label
    Friend WithEvents lblPrecipitation As Label
    Friend WithEvents lblMeanMonthlyAirTemperature As Label
    Friend WithEvents lblMeanSeaLevelPressure As Label
    Friend WithEvents lblMeanStationPressure As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMeanDailyMinAirTemperature As Label
    Friend WithEvents lblStationIdentifier As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanStationPressure As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanDailyMaxAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanDailyMinAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanSeaLevelPressure As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanMonthlyAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrecipitation As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanRelativeHumidity As ucrReceiverSingle
    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents ucrInputLinkby As ucrInputComboBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents lblSaveFile As Label
    Friend WithEvents lblType As Label
    Friend WithEvents ucrReceiverStationIdentifier As ucrReceiverSingle
    Friend WithEvents grpElements As GroupBox
End Class
