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
Partial Class dlgLockUnlock
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverLockUnlock = New instat.ucrReceiverMultiple()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.rdoLock = New System.Windows.Forms.RadioButton()
        Me.rdoUnlock = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLock = New instat.UcrPanel()
        Me.ucrChkReserveFreeSpace = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 289)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(591, 97)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 48)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(271, 191)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverLockUnlock
        '
        Me.ucrReceiverLockUnlock.frmParent = Me
        Me.ucrReceiverLockUnlock.Location = New System.Drawing.Point(347, 48)
        Me.ucrReceiverLockUnlock.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLockUnlock.Name = "ucrReceiverLockUnlock"
        Me.ucrReceiverLockUnlock.Selector = Nothing
        Me.ucrReceiverLockUnlock.Size = New System.Drawing.Size(161, 165)
        Me.ucrReceiverLockUnlock.strNcFilePath = ""
        Me.ucrReceiverLockUnlock.TabIndex = 2
        Me.ucrReceiverLockUnlock.ucrSelector = Nothing
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(347, 30)
        Me.lblSelectedColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(126, 16)
        Me.lblSelectedColumns.TabIndex = 3
        Me.lblSelectedColumns.Tag = "Selected_Variables:"
        Me.lblSelectedColumns.Text = "Selected Variables:"
        '
        'rdoLock
        '
        Me.rdoLock.AutoSize = True
        Me.rdoLock.Location = New System.Drawing.Point(16, 242)
        Me.rdoLock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoLock.Name = "rdoLock"
        Me.rdoLock.Size = New System.Drawing.Size(62, 20)
        Me.rdoLock.TabIndex = 4
        Me.rdoLock.TabStop = True
        Me.rdoLock.Tag = "Lock"
        Me.rdoLock.Text = "Lock"
        Me.rdoLock.UseVisualStyleBackColor = True
        '
        'rdoUnlock
        '
        Me.rdoUnlock.AutoSize = True
        Me.rdoUnlock.Location = New System.Drawing.Point(113, 242)
        Me.rdoUnlock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoUnlock.Name = "rdoUnlock"
        Me.rdoUnlock.Size = New System.Drawing.Size(75, 20)
        Me.rdoUnlock.TabIndex = 5
        Me.rdoUnlock.TabStop = True
        Me.rdoUnlock.Tag = "Unlock"
        Me.rdoUnlock.Text = "Unlock"
        Me.rdoUnlock.UseVisualStyleBackColor = True
        '
        'ucrPnlLock
        '
        Me.ucrPnlLock.Location = New System.Drawing.Point(8, 233)
        Me.ucrPnlLock.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrPnlLock.Name = "ucrPnlLock"
        Me.ucrPnlLock.Size = New System.Drawing.Size(217, 41)
        Me.ucrPnlLock.TabIndex = 7
        '
        'ucrChkReserveFreeSpace
        '
        Me.ucrChkReserveFreeSpace.Checked = False
        Me.ucrChkReserveFreeSpace.Location = New System.Drawing.Point(251, 242)
        Me.ucrChkReserveFreeSpace.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkReserveFreeSpace.Name = "ucrChkReserveFreeSpace"
        Me.ucrChkReserveFreeSpace.Size = New System.Drawing.Size(272, 25)
        Me.ucrChkReserveFreeSpace.TabIndex = 8
        '
        'dlgLockUnlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 380)
        Me.Controls.Add(Me.ucrChkReserveFreeSpace)
        Me.Controls.Add(Me.rdoUnlock)
        Me.Controls.Add(Me.rdoLock)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrReceiverLockUnlock)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlLock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLockUnlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Lock_and_unlock"
        Me.Text = "Lock and unlock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverLockUnlock As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents rdoLock As RadioButton
    Friend WithEvents rdoUnlock As RadioButton
    Friend WithEvents ucrPnlLock As UcrPanel
    Friend WithEvents ucrChkReserveFreeSpace As ucrCheck
End Class
