﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDoyRange
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
        Me.rdoFromFixed = New System.Windows.Forms.RadioButton()
        Me.rdoFromVariable = New System.Windows.Forms.RadioButton()
        Me.grpFrom = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrDoyFrom = New instat.ucrDayOfYear()
        Me.ucrPnlFrom = New instat.UcrPanel()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.lblToDays = New System.Windows.Forms.Label()
        Me.ucrNudToDiff = New instat.ucrNud()
        Me.lblToPlus = New System.Windows.Forms.Label()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverTo = New instat.ucrReceiverSingle()
        Me.ucrDoyTo = New instat.ucrDayOfYear()
        Me.rdoToVariable = New System.Windows.Forms.RadioButton()
        Me.rdoToFixed = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTo = New instat.UcrPanel()
        Me.ucrSelectorDoy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseSub = New instat.ucrButtonsSubdialogue()
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoFromFixed
        '
        Me.rdoFromFixed.AutoSize = True
        Me.rdoFromFixed.Location = New System.Drawing.Point(48, 32)
        Me.rdoFromFixed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoFromFixed.Name = "rdoFromFixed"
        Me.rdoFromFixed.Size = New System.Drawing.Size(94, 20)
        Me.rdoFromFixed.TabIndex = 1
        Me.rdoFromFixed.TabStop = True
        Me.rdoFromFixed.Text = "Fixed Day"
        Me.rdoFromFixed.UseVisualStyleBackColor = True
        '
        'rdoFromVariable
        '
        Me.rdoFromVariable.AutoSize = True
        Me.rdoFromVariable.Location = New System.Drawing.Point(160, 32)
        Me.rdoFromVariable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoFromVariable.Name = "rdoFromVariable"
        Me.rdoFromVariable.Size = New System.Drawing.Size(112, 20)
        Me.rdoFromVariable.TabIndex = 2
        Me.rdoFromVariable.TabStop = True
        Me.rdoFromVariable.Text = "Variable Day"
        Me.rdoFromVariable.UseVisualStyleBackColor = True
        '
        'grpFrom
        '
        Me.grpFrom.Controls.Add(Me.ucrReceiverFrom)
        Me.grpFrom.Controls.Add(Me.ucrDoyFrom)
        Me.grpFrom.Controls.Add(Me.rdoFromVariable)
        Me.grpFrom.Controls.Add(Me.rdoFromFixed)
        Me.grpFrom.Controls.Add(Me.ucrPnlFrom)
        Me.grpFrom.Location = New System.Drawing.Point(13, 254)
        Me.grpFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpFrom.Size = New System.Drawing.Size(339, 127)
        Me.grpFrom.TabIndex = 1
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "From"
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.frmParent = Me
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(48, 84)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(165, 25)
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.TabIndex = 5
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrDoyFrom
        '
        Me.ucrDoyFrom.Location = New System.Drawing.Point(48, 82)
        Me.ucrDoyFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrDoyFrom.Name = "ucrDoyFrom"
        Me.ucrDoyFrom.Size = New System.Drawing.Size(279, 26)
        Me.ucrDoyFrom.TabIndex = 5
        '
        'ucrPnlFrom
        '
        Me.ucrPnlFrom.Location = New System.Drawing.Point(37, 21)
        Me.ucrPnlFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlFrom.Name = "ucrPnlFrom"
        Me.ucrPnlFrom.Size = New System.Drawing.Size(248, 44)
        Me.ucrPnlFrom.TabIndex = 3
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.lblToDays)
        Me.grpTo.Controls.Add(Me.ucrNudToDiff)
        Me.grpTo.Controls.Add(Me.lblToPlus)
        Me.grpTo.Controls.Add(Me.rdoLength)
        Me.grpTo.Controls.Add(Me.ucrReceiverTo)
        Me.grpTo.Controls.Add(Me.ucrDoyTo)
        Me.grpTo.Controls.Add(Me.rdoToVariable)
        Me.grpTo.Controls.Add(Me.rdoToFixed)
        Me.grpTo.Controls.Add(Me.ucrPnlTo)
        Me.grpTo.Location = New System.Drawing.Point(359, 254)
        Me.grpTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTo.Size = New System.Drawing.Size(419, 127)
        Me.grpTo.TabIndex = 2
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "To"
        '
        'lblToDays
        '
        Me.lblToDays.AutoSize = True
        Me.lblToDays.BackColor = System.Drawing.Color.Transparent
        Me.lblToDays.Location = New System.Drawing.Point(136, 89)
        Me.lblToDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDays.Name = "lblToDays"
        Me.lblToDays.Size = New System.Drawing.Size(38, 16)
        Me.lblToDays.TabIndex = 9
        Me.lblToDays.Text = "days"
        '
        'ucrNudToDiff
        '
        Me.ucrNudToDiff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudToDiff.Location = New System.Drawing.Point(67, 84)
        Me.ucrNudToDiff.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNudToDiff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudToDiff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Name = "ucrNudToDiff"
        Me.ucrNudToDiff.Size = New System.Drawing.Size(67, 25)
        Me.ucrNudToDiff.TabIndex = 7
        Me.ucrNudToDiff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblToPlus
        '
        Me.lblToPlus.AutoSize = True
        Me.lblToPlus.BackColor = System.Drawing.Color.Transparent
        Me.lblToPlus.Location = New System.Drawing.Point(21, 89)
        Me.lblToPlus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToPlus.Name = "lblToPlus"
        Me.lblToPlus.Size = New System.Drawing.Size(37, 16)
        Me.lblToPlus.TabIndex = 8
        Me.lblToPlus.Text = "Plus:"
        '
        'rdoLength
        '
        Me.rdoLength.AutoSize = True
        Me.rdoLength.Location = New System.Drawing.Point(252, 34)
        Me.rdoLength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(73, 20)
        Me.rdoLength.TabIndex = 6
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'ucrReceiverTo
        '
        Me.ucrReceiverTo.frmParent = Me
        Me.ucrReceiverTo.Location = New System.Drawing.Point(19, 82)
        Me.ucrReceiverTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTo.Name = "ucrReceiverTo"
        Me.ucrReceiverTo.Selector = Nothing
        Me.ucrReceiverTo.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverTo.strNcFilePath = ""
        Me.ucrReceiverTo.TabIndex = 5
        Me.ucrReceiverTo.ucrSelector = Nothing
        '
        'ucrDoyTo
        '
        Me.ucrDoyTo.Location = New System.Drawing.Point(21, 82)
        Me.ucrDoyTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrDoyTo.Name = "ucrDoyTo"
        Me.ucrDoyTo.Size = New System.Drawing.Size(279, 26)
        Me.ucrDoyTo.TabIndex = 5
        '
        'rdoToVariable
        '
        Me.rdoToVariable.AutoSize = True
        Me.rdoToVariable.Location = New System.Drawing.Point(131, 34)
        Me.rdoToVariable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoToVariable.Name = "rdoToVariable"
        Me.rdoToVariable.Size = New System.Drawing.Size(112, 20)
        Me.rdoToVariable.TabIndex = 2
        Me.rdoToVariable.TabStop = True
        Me.rdoToVariable.Text = "Variable Day"
        Me.rdoToVariable.UseVisualStyleBackColor = True
        '
        'rdoToFixed
        '
        Me.rdoToFixed.AutoSize = True
        Me.rdoToFixed.Location = New System.Drawing.Point(21, 34)
        Me.rdoToFixed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoToFixed.Name = "rdoToFixed"
        Me.rdoToFixed.Size = New System.Drawing.Size(94, 20)
        Me.rdoToFixed.TabIndex = 1
        Me.rdoToFixed.TabStop = True
        Me.rdoToFixed.Text = "Fixed Day"
        Me.rdoToFixed.UseVisualStyleBackColor = True
        '
        'ucrPnlTo
        '
        Me.ucrPnlTo.Location = New System.Drawing.Point(8, 21)
        Me.ucrPnlTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlTo.Name = "ucrPnlTo"
        Me.ucrPnlTo.Size = New System.Drawing.Size(393, 44)
        Me.ucrPnlTo.TabIndex = 3
        '
        'ucrSelectorDoy
        '
        Me.ucrSelectorDoy.bDropUnusedFilterLevels = False
        Me.ucrSelectorDoy.bShowHiddenColumns = False
        Me.ucrSelectorDoy.bUseCurrentFilter = True
        Me.ucrSelectorDoy.Location = New System.Drawing.Point(13, 11)
        Me.ucrSelectorDoy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDoy.Name = "ucrSelectorDoy"
        Me.ucrSelectorDoy.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorDoy.TabIndex = 0
        '
        'ucrBaseSub
        '
        Me.ucrBaseSub.Location = New System.Drawing.Point(284, 399)
        Me.ucrBaseSub.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBaseSub.Name = "ucrBaseSub"
        Me.ucrBaseSub.Size = New System.Drawing.Size(208, 37)
        Me.ucrBaseSub.TabIndex = 3
        '
        'sdgDoyRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 440)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.ucrSelectorDoy)
        Me.Controls.Add(Me.grpFrom)
        Me.Controls.Add(Me.ucrBaseSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDoyRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Day of Year Range"
        Me.grpFrom.ResumeLayout(False)
        Me.grpFrom.PerformLayout()
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSub As ucrButtonsSubdialogue
    Friend WithEvents rdoFromFixed As RadioButton
    Friend WithEvents rdoFromVariable As RadioButton
    Friend WithEvents ucrPnlFrom As UcrPanel
    Friend WithEvents grpFrom As GroupBox
    Friend WithEvents ucrReceiverFrom As ucrReceiverSingle
    Friend WithEvents grpTo As GroupBox
    Friend WithEvents ucrNudToDiff As ucrNud
    Friend WithEvents lblToPlus As Label
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents ucrReceiverTo As ucrReceiverSingle
    Friend WithEvents ucrDoyTo As ucrDayOfYear
    Friend WithEvents rdoToVariable As RadioButton
    Friend WithEvents rdoToFixed As RadioButton
    Friend WithEvents ucrPnlTo As UcrPanel
    Friend WithEvents ucrSelectorDoy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrDoyFrom As ucrDayOfYear
    Friend WithEvents lblToDays As Label
End Class
