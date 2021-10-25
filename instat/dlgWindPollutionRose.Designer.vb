<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindPollutionRose
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
        Me.lblFacetTwo = New System.Windows.Forms.Label()
        Me.lblFacetOne = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.lblWindDirection2 = New System.Windows.Forms.Label()
        Me.lblWindSpeed2 = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.ucrChkCompareTwoSets = New instat.ucrCheck()
        Me.ucrReceiverFacetOne = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacetTwo = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrChkPaddle = New instat.ucrCheck()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection2 = New instat.ucrReceiverSingle()
        Me.ucrSelectorWindPollutionRose = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFacetTwo
        '
        Me.lblFacetTwo.AutoSize = True
        Me.lblFacetTwo.Location = New System.Drawing.Point(531, 94)
        Me.lblFacetTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetTwo.Name = "lblFacetTwo"
        Me.lblFacetTwo.Size = New System.Drawing.Size(116, 16)
        Me.lblFacetTwo.TabIndex = 16
        Me.lblFacetTwo.Text = "Facet 2 (Optional):"
        '
        'lblFacetOne
        '
        Me.lblFacetOne.AutoSize = True
        Me.lblFacetOne.Location = New System.Drawing.Point(531, 37)
        Me.lblFacetOne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetOne.Name = "lblFacetOne"
        Me.lblFacetOne.Size = New System.Drawing.Size(106, 16)
        Me.lblFacetOne.TabIndex = 14
        Me.lblFacetOne.Text = "Facet (Optional):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(343, 17)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(13, 265)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(43, 16)
        Me.lblColor.TabIndex = 18
        Me.lblColor.Text = "Color:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(13, 300)
        Me.lblStatistic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(57, 16)
        Me.lblStatistic.TabIndex = 20
        Me.lblStatistic.Text = "Statistic:"
        '
        'lblWindDirection2
        '
        Me.lblWindDirection2.AutoSize = True
        Me.lblWindDirection2.Location = New System.Drawing.Point(343, 338)
        Me.lblWindDirection2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindDirection2.Name = "lblWindDirection2"
        Me.lblWindDirection2.Size = New System.Drawing.Size(108, 16)
        Me.lblWindDirection2.TabIndex = 12
        Me.lblWindDirection2.Text = "Wind Direction 2:"
        '
        'lblWindSpeed2
        '
        Me.lblWindSpeed2.AutoSize = True
        Me.lblWindSpeed2.Location = New System.Drawing.Point(343, 286)
        Me.lblWindSpeed2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindSpeed2.Name = "lblWindSpeed2"
        Me.lblWindSpeed2.Size = New System.Drawing.Size(96, 16)
        Me.lblWindSpeed2.TabIndex = 10
        Me.lblWindSpeed2.Text = "Wind Speed 2:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(343, 128)
        Me.lblWindDirection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(98, 16)
        Me.lblWindDirection.TabIndex = 5
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(343, 71)
        Me.lblWindSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(86, 16)
        Me.lblWindSpeed.TabIndex = 3
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(343, 188)
        Me.lblPollutant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(123, 16)
        Me.lblPollutant.TabIndex = 7
        Me.lblPollutant.Text = "Pollutant (Optional):"
        '
        'ucrChkCompareTwoSets
        '
        Me.ucrChkCompareTwoSets.Checked = False
        Me.ucrChkCompareTwoSets.Location = New System.Drawing.Point(343, 255)
        Me.ucrChkCompareTwoSets.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkCompareTwoSets.Name = "ucrChkCompareTwoSets"
        Me.ucrChkCompareTwoSets.Size = New System.Drawing.Size(207, 25)
        Me.ucrChkCompareTwoSets.TabIndex = 9
        '
        'ucrReceiverFacetOne
        '
        Me.ucrReceiverFacetOne.frmParent = Me
        Me.ucrReceiverFacetOne.Location = New System.Drawing.Point(531, 58)
        Me.ucrReceiverFacetOne.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetOne.Name = "ucrReceiverFacetOne"
        Me.ucrReceiverFacetOne.Selector = Nothing
        Me.ucrReceiverFacetOne.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverFacetOne.strNcFilePath = ""
        Me.ucrReceiverFacetOne.TabIndex = 15
        Me.ucrReceiverFacetOne.ucrSelector = Nothing
        '
        'ucrReceiverFacetTwo
        '
        Me.ucrReceiverFacetTwo.frmParent = Me
        Me.ucrReceiverFacetTwo.Location = New System.Drawing.Point(531, 113)
        Me.ucrReceiverFacetTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetTwo.Name = "ucrReceiverFacetTwo"
        Me.ucrReceiverFacetTwo.Selector = Nothing
        Me.ucrReceiverFacetTwo.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverFacetTwo.strNcFilePath = ""
        Me.ucrReceiverFacetTwo.TabIndex = 17
        Me.ucrReceiverFacetTwo.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(343, 37)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 388)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(455, 42)
        Me.ucrSaveGraph.TabIndex = 23
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(95, 295)
        Me.ucrInputStatistic.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(145, 26)
        Me.ucrInputStatistic.TabIndex = 21
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(93, 260)
        Me.ucrInputColor.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(145, 26)
        Me.ucrInputColor.TabIndex = 19
        '
        'ucrChkPaddle
        '
        Me.ucrChkPaddle.Checked = False
        Me.ucrChkPaddle.Location = New System.Drawing.Point(13, 347)
        Me.ucrChkPaddle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkPaddle.Name = "ucrChkPaddle"
        Me.ucrChkPaddle.Size = New System.Drawing.Size(207, 25)
        Me.ucrChkPaddle.TabIndex = 22
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(343, 209)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 8
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(343, 92)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 4
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(343, 148)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 6
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed2
        '
        Me.ucrReceiverWindSpeed2.frmParent = Me
        Me.ucrReceiverWindSpeed2.Location = New System.Drawing.Point(343, 305)
        Me.ucrReceiverWindSpeed2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed2.Name = "ucrReceiverWindSpeed2"
        Me.ucrReceiverWindSpeed2.Selector = Nothing
        Me.ucrReceiverWindSpeed2.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindSpeed2.strNcFilePath = ""
        Me.ucrReceiverWindSpeed2.TabIndex = 11
        Me.ucrReceiverWindSpeed2.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection2
        '
        Me.ucrReceiverWindDirection2.frmParent = Me
        Me.ucrReceiverWindDirection2.Location = New System.Drawing.Point(343, 358)
        Me.ucrReceiverWindDirection2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection2.Name = "ucrReceiverWindDirection2"
        Me.ucrReceiverWindDirection2.Selector = Nothing
        Me.ucrReceiverWindDirection2.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWindDirection2.strNcFilePath = ""
        Me.ucrReceiverWindDirection2.TabIndex = 13
        Me.ucrReceiverWindDirection2.ucrSelector = Nothing
        '
        'ucrSelectorWindPollutionRose
        '
        Me.ucrSelectorWindPollutionRose.bDropUnusedFilterLevels = False
        Me.ucrSelectorWindPollutionRose.bShowHiddenColumns = False
        Me.ucrSelectorWindPollutionRose.bUseCurrentFilter = True
        Me.ucrSelectorWindPollutionRose.Location = New System.Drawing.Point(13, 6)
        Me.ucrSelectorWindPollutionRose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorWindPollutionRose.Name = "ucrSelectorWindPollutionRose"
        Me.ucrSelectorWindPollutionRose.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorWindPollutionRose.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 432)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 24
        '
        'dlgWindPollutionRose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 512)
        Me.Controls.Add(Me.ucrChkCompareTwoSets)
        Me.Controls.Add(Me.lblFacetTwo)
        Me.Controls.Add(Me.lblFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetTwo)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrChkPaddle)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.lblWindDirection2)
        Me.Controls.Add(Me.lblWindSpeed2)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed2)
        Me.Controls.Add(Me.ucrReceiverWindDirection2)
        Me.Controls.Add(Me.ucrSelectorWindPollutionRose)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindPollutionRose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind/Pollution Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFacetTwo As Label
    Friend WithEvents lblFacetOne As Label
    Friend WithEvents ucrReceiverFacetOne As ucrReceiverSingle
    Friend WithEvents ucrReceiverFacetTwo As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrChkPaddle As ucrCheck
    Friend WithEvents lblColor As Label
    Friend WithEvents lblStatistic As Label
    Friend WithEvents lblWindDirection2 As Label
    Friend WithEvents lblWindSpeed2 As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblPollutant As Label
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection2 As ucrReceiverSingle
    Friend WithEvents ucrSelectorWindPollutionRose As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkCompareTwoSets As ucrCheck
End Class
