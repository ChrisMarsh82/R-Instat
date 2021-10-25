<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTimeSeriesPlot
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
        Me.lblReferenceValues = New System.Windows.Forms.Label()
        Me.lblEstimates = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.ucrChkIncludeMeanLines = New instat.ucrCheck()
        Me.ucrChkNAValues = New instat.ucrCheck()
        Me.ucrChkIncludeLineOfBestFit = New instat.ucrCheck()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverTime = New instat.ucrReceiverSingle()
        Me.ucrReceiverEstimates = New instat.ucrReceiverSingle()
        Me.ucrReceiverReference = New instat.ucrReceiverSingle()
        Me.ucrSelectorTimeSeriesPlots = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblReferenceValues
        '
        Me.lblReferenceValues.AutoSize = True
        Me.lblReferenceValues.Location = New System.Drawing.Point(381, 30)
        Me.lblReferenceValues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReferenceValues.Name = "lblReferenceValues"
        Me.lblReferenceValues.Size = New System.Drawing.Size(119, 16)
        Me.lblReferenceValues.TabIndex = 1
        Me.lblReferenceValues.Text = "Reference Values:"
        '
        'lblEstimates
        '
        Me.lblEstimates.AutoSize = True
        Me.lblEstimates.Location = New System.Drawing.Point(381, 87)
        Me.lblEstimates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(70, 16)
        Me.lblEstimates.TabIndex = 3
        Me.lblEstimates.Text = "Estimates:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(381, 145)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(88, 16)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time (X axis):"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(381, 203)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(116, 16)
        Me.lblStation.TabIndex = 7
        Me.lblStation.Text = "Facet By (Station):"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(381, 436)
        Me.cmdSummaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(160, 28)
        Me.cmdSummaries.TabIndex = 12
        Me.cmdSummaries.Text = "Summary Annotations"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.Checked = False
        Me.ucrChkIncludePoints.Location = New System.Drawing.Point(13, 311)
        Me.ucrChkIncludePoints.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        Me.ucrChkIncludePoints.Size = New System.Drawing.Size(363, 25)
        Me.ucrChkIncludePoints.TabIndex = 10
        '
        'ucrChkIncludeMeanLines
        '
        Me.ucrChkIncludeMeanLines.Checked = False
        Me.ucrChkIncludeMeanLines.Location = New System.Drawing.Point(13, 357)
        Me.ucrChkIncludeMeanLines.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkIncludeMeanLines.Name = "ucrChkIncludeMeanLines"
        Me.ucrChkIncludeMeanLines.Size = New System.Drawing.Size(363, 25)
        Me.ucrChkIncludeMeanLines.TabIndex = 11
        '
        'ucrChkNAValues
        '
        Me.ucrChkNAValues.Checked = False
        Me.ucrChkNAValues.Location = New System.Drawing.Point(13, 266)
        Me.ucrChkNAValues.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkNAValues.Name = "ucrChkNAValues"
        Me.ucrChkNAValues.Size = New System.Drawing.Size(363, 25)
        Me.ucrChkNAValues.TabIndex = 9
        '
        'ucrChkIncludeLineOfBestFit
        '
        Me.ucrChkIncludeLineOfBestFit.Checked = False
        Me.ucrChkIncludeLineOfBestFit.Location = New System.Drawing.Point(13, 402)
        Me.ucrChkIncludeLineOfBestFit.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkIncludeLineOfBestFit.Name = "ucrChkIncludeLineOfBestFit"
        Me.ucrChkIncludeLineOfBestFit.Size = New System.Drawing.Size(347, 25)
        Me.ucrChkIncludeLineOfBestFit.TabIndex = 16
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(368, 402)
        Me.ucrChkWithSE.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(180, 25)
        Me.ucrChkWithSE.TabIndex = 17
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(13, 474)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(427, 30)
        Me.ucrSavePlot.TabIndex = 15
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(381, 222)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 8
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'ucrReceiverTime
        '
        Me.ucrReceiverTime.frmParent = Me
        Me.ucrReceiverTime.Location = New System.Drawing.Point(381, 164)
        Me.ucrReceiverTime.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTime.Name = "ucrReceiverTime"
        Me.ucrReceiverTime.Selector = Nothing
        Me.ucrReceiverTime.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverTime.strNcFilePath = ""
        Me.ucrReceiverTime.TabIndex = 6
        Me.ucrReceiverTime.ucrSelector = Nothing
        '
        'ucrReceiverEstimates
        '
        Me.ucrReceiverEstimates.frmParent = Me
        Me.ucrReceiverEstimates.Location = New System.Drawing.Point(381, 106)
        Me.ucrReceiverEstimates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimates.Name = "ucrReceiverEstimates"
        Me.ucrReceiverEstimates.Selector = Nothing
        Me.ucrReceiverEstimates.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverEstimates.strNcFilePath = ""
        Me.ucrReceiverEstimates.TabIndex = 4
        Me.ucrReceiverEstimates.ucrSelector = Nothing
        '
        'ucrReceiverReference
        '
        Me.ucrReceiverReference.frmParent = Me
        Me.ucrReceiverReference.Location = New System.Drawing.Point(381, 48)
        Me.ucrReceiverReference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReference.Name = "ucrReceiverReference"
        Me.ucrReceiverReference.Selector = Nothing
        Me.ucrReceiverReference.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverReference.strNcFilePath = ""
        Me.ucrReceiverReference.TabIndex = 2
        Me.ucrReceiverReference.ucrSelector = Nothing
        '
        'ucrSelectorTimeSeriesPlots
        '
        Me.ucrSelectorTimeSeriesPlots.bDropUnusedFilterLevels = False
        Me.ucrSelectorTimeSeriesPlots.bShowHiddenColumns = False
        Me.ucrSelectorTimeSeriesPlots.bUseCurrentFilter = True
        Me.ucrSelectorTimeSeriesPlots.Location = New System.Drawing.Point(16, 11)
        Me.ucrSelectorTimeSeriesPlots.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTimeSeriesPlots.Name = "ucrSelectorTimeSeriesPlots"
        Me.ucrSelectorTimeSeriesPlots.Size = New System.Drawing.Size(291, 222)
        Me.ucrSelectorTimeSeriesPlots.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 527)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 14
        '
        'dlgTimeSeriesPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 594)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkIncludeLineOfBestFit)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrChkIncludePoints)
        Me.Controls.Add(Me.ucrChkIncludeMeanLines)
        Me.Controls.Add(Me.ucrChkNAValues)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblEstimates)
        Me.Controls.Add(Me.ucrReceiverEstimates)
        Me.Controls.Add(Me.ucrReceiverReference)
        Me.Controls.Add(Me.lblReferenceValues)
        Me.Controls.Add(Me.ucrSelectorTimeSeriesPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTimeSeriesPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Series Comparisons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTimeSeriesPlots As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblReferenceValues As Label
    Friend WithEvents ucrReceiverReference As ucrReceiverSingle
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrChkIncludeMeanLines As ucrCheck
    Friend WithEvents ucrChkNAValues As ucrCheck
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverTime As ucrReceiverSingle
    Friend WithEvents lblTime As Label
    Friend WithEvents lblEstimates As Label
    Friend WithEvents ucrReceiverEstimates As ucrReceiverSingle
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrChkIncludeLineOfBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
End Class
