<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class columnSelectorControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSelected = New System.Windows.Forms.ListBox()
        Me.lbColumns = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbColumns, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSelected, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(694, 238)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Variables"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(465, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 59)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selected Variable(s)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbSelected
        '
        Me.lbSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSelected.FormattingEnabled = True
        Me.lbSelected.ItemHeight = 20
        Me.lbSelected.Location = New System.Drawing.Point(465, 62)
        Me.lbSelected.Name = "lbSelected"
        Me.TableLayoutPanel1.SetRowSpan(Me.lbSelected, 3)
        Me.lbSelected.Size = New System.Drawing.Size(226, 173)
        Me.lbSelected.TabIndex = 2
        '
        'lbColumns
        '
        Me.lbColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbColumns.FormattingEnabled = True
        Me.lbColumns.ItemHeight = 20
        Me.lbColumns.Location = New System.Drawing.Point(3, 62)
        Me.lbColumns.Name = "lbColumns"
        Me.TableLayoutPanel1.SetRowSpan(Me.lbColumns, 3)
        Me.lbColumns.Size = New System.Drawing.Size(225, 173)
        Me.lbColumns.TabIndex = 3
        '
        'columnSelectorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "columnSelectorControl"
        Me.Size = New System.Drawing.Size(694, 238)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbColumns As ListBox
    Friend WithEvents lbSelected As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
