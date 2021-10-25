' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPICSACrops
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
        Me.lblSelectedSet = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.grpSeasonReceivers = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStart = New instat.ucrReceiverSingle()
        Me.ucrReceiverEnd = New instat.ucrReceiverSingle()
        Me.grpCropDefinitions = New System.Windows.Forms.GroupBox()
        Me.lblPlantingDays = New System.Windows.Forms.Label()
        Me.lblCropLengthDays = New System.Windows.Forms.Label()
        Me.lblWaterAmounts = New System.Windows.Forms.Label()
        Me.ucrChkRequirePlantingDays = New instat.ucrCheck()
        Me.ucrInputCropLengths = New instat.ucrInputComboBox()
        Me.ucrInputWaterAmounts = New instat.ucrInputComboBox()
        Me.ucrInputPlantingDates = New instat.ucrInputComboBox()
        Me.ucrChkDataProp = New instat.ucrCheck()
        Me.ucrChkPrintDataProp = New instat.ucrCheck()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSeasonReceivers.SuspendLayout()
        Me.grpCropDefinitions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(309, 26)
        Me.lblSelectedSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(52, 16)
        Me.lblSelectedSet.TabIndex = 15
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Station:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = ""
        Me.Label2.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Tag = ""
        Me.Label3.Text = "Day in Year:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(309, 81)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(39, 16)
        Me.lblRain.TabIndex = 23
        Me.lblRain.Tag = ""
        Me.lblRain.Text = "Rain:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Tag = ""
        Me.Label5.Text = "Start:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(491, 441)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(160, 31)
        Me.cmdOptions.TabIndex = 31
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'grpSeasonReceivers
        '
        Me.grpSeasonReceivers.Controls.Add(Me.Label5)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverStart)
        Me.grpSeasonReceivers.Controls.Add(Me.Label6)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverEnd)
        Me.grpSeasonReceivers.Location = New System.Drawing.Point(301, 137)
        Me.grpSeasonReceivers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSeasonReceivers.Name = "grpSeasonReceivers"
        Me.grpSeasonReceivers.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSeasonReceivers.Size = New System.Drawing.Size(363, 81)
        Me.grpSeasonReceivers.TabIndex = 38
        Me.grpSeasonReceivers.TabStop = False
        Me.grpSeasonReceivers.Text = "Season Dates"
        '
        'ucrReceiverStart
        '
        Me.ucrReceiverStart.frmParent = Me
        Me.ucrReceiverStart.Location = New System.Drawing.Point(13, 42)
        Me.ucrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStart.Name = "ucrReceiverStart"
        Me.ucrReceiverStart.Selector = Nothing
        Me.ucrReceiverStart.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStart.strNcFilePath = ""
        Me.ucrReceiverStart.TabIndex = 19
        Me.ucrReceiverStart.ucrSelector = Nothing
        '
        'ucrReceiverEnd
        '
        Me.ucrReceiverEnd.frmParent = Me
        Me.ucrReceiverEnd.Location = New System.Drawing.Point(189, 42)
        Me.ucrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEnd.Name = "ucrReceiverEnd"
        Me.ucrReceiverEnd.Selector = Nothing
        Me.ucrReceiverEnd.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverEnd.strNcFilePath = ""
        Me.ucrReceiverEnd.TabIndex = 26
        Me.ucrReceiverEnd.ucrSelector = Nothing
        '
        'grpCropDefinitions
        '
        Me.grpCropDefinitions.Controls.Add(Me.lblPlantingDays)
        Me.grpCropDefinitions.Controls.Add(Me.lblCropLengthDays)
        Me.grpCropDefinitions.Controls.Add(Me.lblWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrChkRequirePlantingDays)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputCropLengths)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputPlantingDates)
        Me.grpCropDefinitions.Location = New System.Drawing.Point(8, 239)
        Me.grpCropDefinitions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCropDefinitions.Name = "grpCropDefinitions"
        Me.grpCropDefinitions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCropDefinitions.Size = New System.Drawing.Size(431, 194)
        Me.grpCropDefinitions.TabIndex = 39
        Me.grpCropDefinitions.TabStop = False
        Me.grpCropDefinitions.Text = "Crop Definitions"
        '
        'lblPlantingDays
        '
        Me.lblPlantingDays.AutoSize = True
        Me.lblPlantingDays.Location = New System.Drawing.Point(8, 63)
        Me.lblPlantingDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDays.Name = "lblPlantingDays"
        Me.lblPlantingDays.Size = New System.Drawing.Size(102, 16)
        Me.lblPlantingDays.TabIndex = 42
        Me.lblPlantingDays.Text = "Planting Day(s):"
        '
        'lblCropLengthDays
        '
        Me.lblCropLengthDays.AutoSize = True
        Me.lblCropLengthDays.Location = New System.Drawing.Point(8, 159)
        Me.lblCropLengthDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropLengthDays.Name = "lblCropLengthDays"
        Me.lblCropLengthDays.Size = New System.Drawing.Size(126, 16)
        Me.lblCropLengthDays.TabIndex = 41
        Me.lblCropLengthDays.Text = "Crop Length Day(s):"
        '
        'lblWaterAmounts
        '
        Me.lblWaterAmounts.AutoSize = True
        Me.lblWaterAmounts.Location = New System.Drawing.Point(8, 113)
        Me.lblWaterAmounts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterAmounts.Name = "lblWaterAmounts"
        Me.lblWaterAmounts.Size = New System.Drawing.Size(110, 16)
        Me.lblWaterAmounts.TabIndex = 40
        Me.lblWaterAmounts.Text = "Water Amount(s):"
        '
        'ucrChkRequirePlantingDays
        '
        Me.ucrChkRequirePlantingDays.Checked = False
        Me.ucrChkRequirePlantingDays.Location = New System.Drawing.Point(8, 22)
        Me.ucrChkRequirePlantingDays.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkRequirePlantingDays.Name = "ucrChkRequirePlantingDays"
        Me.ucrChkRequirePlantingDays.Size = New System.Drawing.Size(381, 25)
        Me.ucrChkRequirePlantingDays.TabIndex = 39
        '
        'ucrInputCropLengths
        '
        Me.ucrInputCropLengths.AddQuotesIfUnrecognised = True
        Me.ucrInputCropLengths.GetSetSelectedIndex = -1
        Me.ucrInputCropLengths.IsReadOnly = False
        Me.ucrInputCropLengths.Location = New System.Drawing.Point(229, 155)
        Me.ucrInputCropLengths.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputCropLengths.Name = "ucrInputCropLengths"
        Me.ucrInputCropLengths.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputCropLengths.TabIndex = 38
        '
        'ucrInputWaterAmounts
        '
        Me.ucrInputWaterAmounts.AddQuotesIfUnrecognised = True
        Me.ucrInputWaterAmounts.GetSetSelectedIndex = -1
        Me.ucrInputWaterAmounts.IsReadOnly = False
        Me.ucrInputWaterAmounts.Location = New System.Drawing.Point(229, 110)
        Me.ucrInputWaterAmounts.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputWaterAmounts.Name = "ucrInputWaterAmounts"
        Me.ucrInputWaterAmounts.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputWaterAmounts.TabIndex = 38
        '
        'ucrInputPlantingDates
        '
        Me.ucrInputPlantingDates.AddQuotesIfUnrecognised = True
        Me.ucrInputPlantingDates.GetSetSelectedIndex = -1
        Me.ucrInputPlantingDates.IsReadOnly = False
        Me.ucrInputPlantingDates.Location = New System.Drawing.Point(229, 63)
        Me.ucrInputPlantingDates.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputPlantingDates.Name = "ucrInputPlantingDates"
        Me.ucrInputPlantingDates.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputPlantingDates.TabIndex = 38
        '
        'ucrChkDataProp
        '
        Me.ucrChkDataProp.Checked = False
        Me.ucrChkDataProp.Location = New System.Drawing.Point(13, 441)
        Me.ucrChkDataProp.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkDataProp.Name = "ucrChkDataProp"
        Me.ucrChkDataProp.Size = New System.Drawing.Size(229, 25)
        Me.ucrChkDataProp.TabIndex = 37
        '
        'ucrChkPrintDataProp
        '
        Me.ucrChkPrintDataProp.Checked = False
        Me.ucrChkPrintDataProp.Location = New System.Drawing.Point(251, 441)
        Me.ucrChkPrintDataProp.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkPrintDataProp.Name = "ucrChkPrintDataProp"
        Me.ucrChkPrintDataProp.Size = New System.Drawing.Size(340, 25)
        Me.ucrChkPrintDataProp.TabIndex = 36
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(315, 100)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 17
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(491, 100)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 16
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(491, 46)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 3
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(315, 46)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForCrops
        '
        Me.ucrSelectorForCrops.bDropUnusedFilterLevels = False
        Me.ucrSelectorForCrops.bShowHiddenColumns = False
        Me.ucrSelectorForCrops.bUseCurrentFilter = True
        Me.ucrSelectorForCrops.Location = New System.Drawing.Point(8, 6)
        Me.ucrSelectorForCrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCrops.Name = "ucrSelectorForCrops"
        Me.ucrSelectorForCrops.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorForCrops.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 482)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 554)
        Me.Controls.Add(Me.grpCropDefinitions)
        Me.Controls.Add(Me.grpSeasonReceivers)
        Me.Controls.Add(Me.ucrChkDataProp)
        Me.Controls.Add(Me.ucrChkPrintDataProp)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.lblSelectedSet)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorForCrops)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSACrops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Crops"
        Me.grpSeasonReceivers.ResumeLayout(False)
        Me.grpSeasonReceivers.PerformLayout()
        Me.grpCropDefinitions.ResumeLayout(False)
        Me.grpCropDefinitions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrReceiverStart As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrReceiverEnd As ucrReceiverSingle
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkPrintDataProp As ucrCheck
    Friend WithEvents ucrChkDataProp As ucrCheck
    Friend WithEvents ucrInputPlantingDates As ucrInputComboBox
    Friend WithEvents ucrInputWaterAmounts As ucrInputComboBox
    Friend WithEvents ucrInputCropLengths As ucrInputComboBox
    Friend WithEvents grpSeasonReceivers As GroupBox
    Friend WithEvents grpCropDefinitions As GroupBox
    Friend WithEvents ucrChkRequirePlantingDays As ucrCheck
    Friend WithEvents lblCropLengthDays As Label
    Friend WithEvents lblWaterAmounts As Label
    Friend WithEvents lblPlantingDays As Label
End Class
