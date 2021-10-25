﻿' R- Instat
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
Partial Class dlgCompareModels
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDistributionForCompareModels = New instat.ucrDistributionsWithParameters()
        Me.grpPlotGraphs = New System.Windows.Forms.GroupBox()
        Me.nudNumberofColumns = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.rdoCombine = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.cmdAddNewDistributions = New System.Windows.Forms.Button()
        Me.grpPlotOptions = New System.Windows.Forms.GroupBox()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoqq = New System.Windows.Forms.RadioButton()
        Me.rdoCDF = New System.Windows.Forms.RadioButton()
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.grpChangeLimits = New System.Windows.Forms.GroupBox()
        Me.nudYlimMax = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimMax = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimMin = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimMin = New System.Windows.Forms.NumericUpDown()
        Me.lblYlim = New System.Windows.Forms.Label()
        Me.lblXlim = New System.Windows.Forms.Label()
        Me.grpPlotGraphs.SuspendLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlotOptions.SuspendLayout()
        Me.grpChangeLimits.SuspendLayout()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 394)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDistributionForCompareModels
        '
        Me.ucrDistributionForCompareModels.Location = New System.Drawing.Point(17, 16)
        Me.ucrDistributionForCompareModels.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrDistributionForCompareModels.Name = "ucrDistributionForCompareModels"
        Me.ucrDistributionForCompareModels.Size = New System.Drawing.Size(295, 239)
        Me.ucrDistributionForCompareModels.TabIndex = 1
        '
        'grpPlotGraphs
        '
        Me.grpPlotGraphs.Controls.Add(Me.nudNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.lblNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.rdoCombine)
        Me.grpPlotGraphs.Controls.Add(Me.rdoSingle)
        Me.grpPlotGraphs.Location = New System.Drawing.Point(19, 249)
        Me.grpPlotGraphs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlotGraphs.Name = "grpPlotGraphs"
        Me.grpPlotGraphs.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlotGraphs.Size = New System.Drawing.Size(317, 90)
        Me.grpPlotGraphs.TabIndex = 2
        Me.grpPlotGraphs.TabStop = False
        Me.grpPlotGraphs.Text = "Plot Graph"
        '
        'nudNumberofColumns
        '
        Me.nudNumberofColumns.Location = New System.Drawing.Point(245, 54)
        Me.nudNumberofColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudNumberofColumns.Name = "nudNumberofColumns"
        Me.nudNumberofColumns.Size = New System.Drawing.Size(64, 22)
        Me.nudNumberofColumns.TabIndex = 3
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(105, 57)
        Me.lblNumberofColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(125, 16)
        Me.lblNumberofColumns.TabIndex = 2
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'rdoCombine
        '
        Me.rdoCombine.AutoSize = True
        Me.rdoCombine.Location = New System.Drawing.Point(9, 54)
        Me.rdoCombine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCombine.Name = "rdoCombine"
        Me.rdoCombine.Size = New System.Drawing.Size(87, 20)
        Me.rdoCombine.TabIndex = 1
        Me.rdoCombine.TabStop = True
        Me.rdoCombine.Text = "Combine"
        Me.rdoCombine.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Location = New System.Drawing.Point(9, 25)
        Me.rdoSingle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(71, 20)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'cmdAddNewDistributions
        '
        Me.cmdAddNewDistributions.Location = New System.Drawing.Point(17, 347)
        Me.cmdAddNewDistributions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAddNewDistributions.Name = "cmdAddNewDistributions"
        Me.cmdAddNewDistributions.Size = New System.Drawing.Size(171, 28)
        Me.cmdAddNewDistributions.TabIndex = 3
        Me.cmdAddNewDistributions.Text = "Add New Distribution"
        Me.cmdAddNewDistributions.UseVisualStyleBackColor = True
        '
        'grpPlotOptions
        '
        Me.grpPlotOptions.Controls.Add(Me.rdoDensity)
        Me.grpPlotOptions.Controls.Add(Me.rdoqq)
        Me.grpPlotOptions.Controls.Add(Me.rdoCDF)
        Me.grpPlotOptions.Controls.Add(Me.rdoHistogram)
        Me.grpPlotOptions.Location = New System.Drawing.Point(320, 15)
        Me.grpPlotOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlotOptions.Name = "grpPlotOptions"
        Me.grpPlotOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlotOptions.Size = New System.Drawing.Size(228, 127)
        Me.grpPlotOptions.TabIndex = 4
        Me.grpPlotOptions.TabStop = False
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.Location = New System.Drawing.Point(8, 12)
        Me.rdoDensity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(78, 20)
        Me.rdoDensity.TabIndex = 6
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoqq
        '
        Me.rdoqq.AutoSize = True
        Me.rdoqq.Location = New System.Drawing.Point(8, 97)
        Me.rdoqq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoqq.Name = "rdoqq"
        Me.rdoqq.Size = New System.Drawing.Size(49, 20)
        Me.rdoqq.TabIndex = 5
        Me.rdoqq.TabStop = True
        Me.rdoqq.Text = "qq"
        Me.rdoqq.UseVisualStyleBackColor = True
        '
        'rdoCDF
        '
        Me.rdoCDF.AutoSize = True
        Me.rdoCDF.Location = New System.Drawing.Point(8, 69)
        Me.rdoCDF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCDF.Name = "rdoCDF"
        Me.rdoCDF.Size = New System.Drawing.Size(60, 20)
        Me.rdoCDF.TabIndex = 4
        Me.rdoCDF.TabStop = True
        Me.rdoCDF.Text = "CDF"
        Me.rdoCDF.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.AutoSize = True
        Me.rdoHistogram.Location = New System.Drawing.Point(8, 41)
        Me.rdoHistogram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(95, 20)
        Me.rdoHistogram.TabIndex = 3
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Text = "Histogram"
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'grpChangeLimits
        '
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMin)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMin)
        Me.grpChangeLimits.Controls.Add(Me.lblYlim)
        Me.grpChangeLimits.Controls.Add(Me.lblXlim)
        Me.grpChangeLimits.Location = New System.Drawing.Point(320, 153)
        Me.grpChangeLimits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpChangeLimits.Name = "grpChangeLimits"
        Me.grpChangeLimits.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpChangeLimits.Size = New System.Drawing.Size(228, 102)
        Me.grpChangeLimits.TabIndex = 5
        Me.grpChangeLimits.TabStop = False
        Me.grpChangeLimits.Text = "Change Limits"
        '
        'nudYlimMax
        '
        Me.nudYlimMax.Location = New System.Drawing.Point(143, 54)
        Me.nudYlimMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudYlimMax.Name = "nudYlimMax"
        Me.nudYlimMax.Size = New System.Drawing.Size(60, 22)
        Me.nudYlimMax.TabIndex = 5
        '
        'nudXlimMax
        '
        Me.nudXlimMax.Location = New System.Drawing.Point(144, 25)
        Me.nudXlimMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudXlimMax.Name = "nudXlimMax"
        Me.nudXlimMax.Size = New System.Drawing.Size(59, 22)
        Me.nudXlimMax.TabIndex = 4
        '
        'nudYlimMin
        '
        Me.nudYlimMin.Location = New System.Drawing.Point(68, 54)
        Me.nudYlimMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudYlimMin.Name = "nudYlimMin"
        Me.nudYlimMin.Size = New System.Drawing.Size(60, 22)
        Me.nudYlimMin.TabIndex = 3
        '
        'nudXlimMin
        '
        Me.nudXlimMin.Location = New System.Drawing.Point(69, 25)
        Me.nudXlimMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudXlimMin.Name = "nudXlimMin"
        Me.nudXlimMin.Size = New System.Drawing.Size(59, 22)
        Me.nudXlimMin.TabIndex = 2
        '
        'lblYlim
        '
        Me.lblYlim.AutoSize = True
        Me.lblYlim.Location = New System.Drawing.Point(0, 57)
        Me.lblYlim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYlim.Name = "lblYlim"
        Me.lblYlim.Size = New System.Drawing.Size(34, 16)
        Me.lblYlim.TabIndex = 1
        Me.lblYlim.Text = "Ylim"
        '
        'lblXlim
        '
        Me.lblXlim.AutoSize = True
        Me.lblXlim.Location = New System.Drawing.Point(0, 25)
        Me.lblXlim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXlim.Name = "lblXlim"
        Me.lblXlim.Size = New System.Drawing.Size(33, 16)
        Me.lblXlim.TabIndex = 0
        Me.lblXlim.Text = "Xlim"
        '
        'dlgCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 474)
        Me.Controls.Add(Me.grpChangeLimits)
        Me.Controls.Add(Me.grpPlotOptions)
        Me.Controls.Add(Me.cmdAddNewDistributions)
        Me.Controls.Add(Me.grpPlotGraphs)
        Me.Controls.Add(Me.ucrDistributionForCompareModels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Models"
        Me.grpPlotGraphs.ResumeLayout(False)
        Me.grpPlotGraphs.PerformLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlotOptions.ResumeLayout(False)
        Me.grpPlotOptions.PerformLayout()
        Me.grpChangeLimits.ResumeLayout(False)
        Me.grpChangeLimits.PerformLayout()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistributionForCompareModels As ucrDistributionsWithParameters
    Friend WithEvents grpPlotGraphs As GroupBox
    Friend WithEvents nudNumberofColumns As NumericUpDown
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents rdoCombine As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents cmdAddNewDistributions As Button
    Friend WithEvents grpPlotOptions As GroupBox
    Friend WithEvents grpChangeLimits As GroupBox
    Friend WithEvents nudYlimMax As NumericUpDown
    Friend WithEvents nudXlimMax As NumericUpDown
    Friend WithEvents nudYlimMin As NumericUpDown
    Friend WithEvents nudXlimMin As NumericUpDown
    Friend WithEvents lblYlim As Label
    Friend WithEvents lblXlim As Label
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoqq As RadioButton
    Friend WithEvents rdoCDF As RadioButton
    Friend WithEvents rdoHistogram As RadioButton
End Class
