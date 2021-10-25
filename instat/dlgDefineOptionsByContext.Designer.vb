<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineOptionsByContext
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
        Me.ucrSelectorOptionsByContext = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblOptionOther = New System.Windows.Forms.Label()
        Me.ucrReceiverOptionOther = New instat.ucrReceiverMultiple()
        Me.ucrReceiverContextOther = New instat.ucrReceiverMultiple()
        Me.lblContextsOther = New System.Windows.Forms.Label()
        Me.ucrReceiverMeasurementOther = New instat.ucrReceiverMultiple()
        Me.lblMeasurementOther = New System.Windows.Forms.Label()
        Me.ucrReceiverOption1 = New instat.ucrReceiverSingle()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblMeasurement1 = New System.Windows.Forms.Label()
        Me.ucrReceiverMeasurement1 = New instat.ucrReceiverSingle()
        Me.lblContext2 = New System.Windows.Forms.Label()
        Me.ucrReceiverContext2 = New instat.ucrReceiverSingle()
        Me.lblContext1 = New System.Windows.Forms.Label()
        Me.ucrReceiverContext1 = New instat.ucrReceiverSingle()
        Me.lblContext4 = New System.Windows.Forms.Label()
        Me.ucrReceiverContext4 = New instat.ucrReceiverSingle()
        Me.lblContext3 = New System.Windows.Forms.Label()
        Me.ucrReceiverContext3 = New instat.ucrReceiverSingle()
        Me.grpContexts = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.grpMeasurements = New System.Windows.Forms.GroupBox()
        Me.grpIDs = New System.Windows.Forms.GroupBox()
        Me.lblID1 = New System.Windows.Forms.Label()
        Me.lblIDOther = New System.Windows.Forms.Label()
        Me.ucrReceiverIDOther = New instat.ucrReceiverMultiple()
        Me.ucrReceiverID1 = New instat.ucrReceiverSingle()
        Me.ucrInputKeyCheck = New instat.ucrInputTextBox()
        Me.ucrInputKeyColumns = New instat.ucrInputTextBox()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.lblKeyCheck = New System.Windows.Forms.Label()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.grpBlockingVariables = New System.Windows.Forms.GroupBox()
        Me.lblBlockingMain = New System.Windows.Forms.Label()
        Me.lblBlockingOther = New System.Windows.Forms.Label()
        Me.ucrReceiverBlockingOther = New instat.ucrReceiverMultiple()
        Me.ucrReceiverBlocking1 = New instat.ucrReceiverSingle()
        Me.grpContexts.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpMeasurements.SuspendLayout()
        Me.grpIDs.SuspendLayout()
        Me.grpBlockingVariables.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 577)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 11
        '
        'ucrSelectorOptionsByContext
        '
        Me.ucrSelectorOptionsByContext.bDropUnusedFilterLevels = False
        Me.ucrSelectorOptionsByContext.bShowHiddenColumns = False
        Me.ucrSelectorOptionsByContext.bUseCurrentFilter = True
        Me.ucrSelectorOptionsByContext.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorOptionsByContext.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOptionsByContext.Name = "ucrSelectorOptionsByContext"
        Me.ucrSelectorOptionsByContext.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorOptionsByContext.TabIndex = 0
        '
        'lblOptionOther
        '
        Me.lblOptionOther.AutoSize = True
        Me.lblOptionOther.Location = New System.Drawing.Point(11, 78)
        Me.lblOptionOther.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOptionOther.Name = "lblOptionOther"
        Me.lblOptionOther.Size = New System.Drawing.Size(92, 16)
        Me.lblOptionOther.TabIndex = 2
        Me.lblOptionOther.Text = "Other Options:"
        '
        'ucrReceiverOptionOther
        '
        Me.ucrReceiverOptionOther.frmParent = Me
        Me.ucrReceiverOptionOther.Location = New System.Drawing.Point(11, 96)
        Me.ucrReceiverOptionOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOptionOther.Name = "ucrReceiverOptionOther"
        Me.ucrReceiverOptionOther.Selector = Nothing
        Me.ucrReceiverOptionOther.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverOptionOther.strNcFilePath = ""
        Me.ucrReceiverOptionOther.TabIndex = 3
        Me.ucrReceiverOptionOther.ucrSelector = Nothing
        '
        'ucrReceiverContextOther
        '
        Me.ucrReceiverContextOther.frmParent = Me
        Me.ucrReceiverContextOther.Location = New System.Drawing.Point(11, 263)
        Me.ucrReceiverContextOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContextOther.Name = "ucrReceiverContextOther"
        Me.ucrReceiverContextOther.Selector = Nothing
        Me.ucrReceiverContextOther.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverContextOther.strNcFilePath = ""
        Me.ucrReceiverContextOther.TabIndex = 9
        Me.ucrReceiverContextOther.ucrSelector = Nothing
        '
        'lblContextsOther
        '
        Me.lblContextsOther.AutoSize = True
        Me.lblContextsOther.Location = New System.Drawing.Point(11, 245)
        Me.lblContextsOther.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContextsOther.Name = "lblContextsOther"
        Me.lblContextsOther.Size = New System.Drawing.Size(97, 16)
        Me.lblContextsOther.TabIndex = 8
        Me.lblContextsOther.Text = "Other Contexts:"
        '
        'ucrReceiverMeasurementOther
        '
        Me.ucrReceiverMeasurementOther.frmParent = Me
        Me.ucrReceiverMeasurementOther.Location = New System.Drawing.Point(11, 96)
        Me.ucrReceiverMeasurementOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurementOther.Name = "ucrReceiverMeasurementOther"
        Me.ucrReceiverMeasurementOther.Selector = Nothing
        Me.ucrReceiverMeasurementOther.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverMeasurementOther.strNcFilePath = ""
        Me.ucrReceiverMeasurementOther.TabIndex = 3
        Me.ucrReceiverMeasurementOther.ucrSelector = Nothing
        '
        'lblMeasurementOther
        '
        Me.lblMeasurementOther.AutoSize = True
        Me.lblMeasurementOther.Location = New System.Drawing.Point(11, 78)
        Me.lblMeasurementOther.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeasurementOther.Name = "lblMeasurementOther"
        Me.lblMeasurementOther.Size = New System.Drawing.Size(135, 16)
        Me.lblMeasurementOther.TabIndex = 2
        Me.lblMeasurementOther.Text = "Other Measurements:"
        '
        'ucrReceiverOption1
        '
        Me.ucrReceiverOption1.frmParent = Me
        Me.ucrReceiverOption1.Location = New System.Drawing.Point(11, 39)
        Me.ucrReceiverOption1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOption1.Name = "ucrReceiverOption1"
        Me.ucrReceiverOption1.Selector = Nothing
        Me.ucrReceiverOption1.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverOption1.strNcFilePath = ""
        Me.ucrReceiverOption1.TabIndex = 1
        Me.ucrReceiverOption1.ucrSelector = Nothing
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.Location = New System.Drawing.Point(11, 21)
        Me.lblOption1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(82, 16)
        Me.lblOption1.TabIndex = 0
        Me.lblOption1.Text = "Main Option:"
        '
        'lblMeasurement1
        '
        Me.lblMeasurement1.AutoSize = True
        Me.lblMeasurement1.Location = New System.Drawing.Point(11, 23)
        Me.lblMeasurement1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeasurement1.Name = "lblMeasurement1"
        Me.lblMeasurement1.Size = New System.Drawing.Size(125, 16)
        Me.lblMeasurement1.TabIndex = 0
        Me.lblMeasurement1.Text = "Main Measurement:"
        '
        'ucrReceiverMeasurement1
        '
        Me.ucrReceiverMeasurement1.frmParent = Me
        Me.ucrReceiverMeasurement1.Location = New System.Drawing.Point(11, 42)
        Me.ucrReceiverMeasurement1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement1.Name = "ucrReceiverMeasurement1"
        Me.ucrReceiverMeasurement1.Selector = Nothing
        Me.ucrReceiverMeasurement1.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverMeasurement1.strNcFilePath = ""
        Me.ucrReceiverMeasurement1.TabIndex = 1
        Me.ucrReceiverMeasurement1.ucrSelector = Nothing
        '
        'lblContext2
        '
        Me.lblContext2.AutoSize = True
        Me.lblContext2.Location = New System.Drawing.Point(11, 78)
        Me.lblContext2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContext2.Name = "lblContext2"
        Me.lblContext2.Size = New System.Drawing.Size(105, 16)
        Me.lblContext2.TabIndex = 2
        Me.lblContext2.Text = "Second Context:"
        '
        'ucrReceiverContext2
        '
        Me.ucrReceiverContext2.frmParent = Me
        Me.ucrReceiverContext2.Location = New System.Drawing.Point(11, 96)
        Me.ucrReceiverContext2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext2.Name = "ucrReceiverContext2"
        Me.ucrReceiverContext2.Selector = Nothing
        Me.ucrReceiverContext2.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContext2.strNcFilePath = ""
        Me.ucrReceiverContext2.TabIndex = 3
        Me.ucrReceiverContext2.ucrSelector = Nothing
        '
        'lblContext1
        '
        Me.lblContext1.AutoSize = True
        Me.lblContext1.Location = New System.Drawing.Point(11, 21)
        Me.lblContext1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContext1.Name = "lblContext1"
        Me.lblContext1.Size = New System.Drawing.Size(87, 16)
        Me.lblContext1.TabIndex = 0
        Me.lblContext1.Text = "Main Context:"
        '
        'ucrReceiverContext1
        '
        Me.ucrReceiverContext1.frmParent = Me
        Me.ucrReceiverContext1.Location = New System.Drawing.Point(11, 39)
        Me.ucrReceiverContext1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext1.Name = "ucrReceiverContext1"
        Me.ucrReceiverContext1.Selector = Nothing
        Me.ucrReceiverContext1.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContext1.strNcFilePath = ""
        Me.ucrReceiverContext1.TabIndex = 1
        Me.ucrReceiverContext1.ucrSelector = Nothing
        '
        'lblContext4
        '
        Me.lblContext4.AutoSize = True
        Me.lblContext4.Location = New System.Drawing.Point(11, 191)
        Me.lblContext4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContext4.Name = "lblContext4"
        Me.lblContext4.Size = New System.Drawing.Size(95, 16)
        Me.lblContext4.TabIndex = 6
        Me.lblContext4.Text = "Fourth Context:"
        '
        'ucrReceiverContext4
        '
        Me.ucrReceiverContext4.frmParent = Me
        Me.ucrReceiverContext4.Location = New System.Drawing.Point(11, 209)
        Me.ucrReceiverContext4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext4.Name = "ucrReceiverContext4"
        Me.ucrReceiverContext4.Selector = Nothing
        Me.ucrReceiverContext4.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContext4.strNcFilePath = ""
        Me.ucrReceiverContext4.TabIndex = 7
        Me.ucrReceiverContext4.ucrSelector = Nothing
        '
        'lblContext3
        '
        Me.lblContext3.AutoSize = True
        Me.lblContext3.Location = New System.Drawing.Point(11, 134)
        Me.lblContext3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContext3.Name = "lblContext3"
        Me.lblContext3.Size = New System.Drawing.Size(89, 16)
        Me.lblContext3.TabIndex = 4
        Me.lblContext3.Text = "Third Context:"
        '
        'ucrReceiverContext3
        '
        Me.ucrReceiverContext3.frmParent = Me
        Me.ucrReceiverContext3.Location = New System.Drawing.Point(11, 153)
        Me.ucrReceiverContext3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext3.Name = "ucrReceiverContext3"
        Me.ucrReceiverContext3.Selector = Nothing
        Me.ucrReceiverContext3.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContext3.strNcFilePath = ""
        Me.ucrReceiverContext3.TabIndex = 5
        Me.ucrReceiverContext3.ucrSelector = Nothing
        '
        'grpContexts
        '
        Me.grpContexts.Controls.Add(Me.lblContext1)
        Me.grpContexts.Controls.Add(Me.lblContext4)
        Me.grpContexts.Controls.Add(Me.lblContextsOther)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext4)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContextOther)
        Me.grpContexts.Controls.Add(Me.lblContext3)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext1)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext3)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext2)
        Me.grpContexts.Controls.Add(Me.lblContext2)
        Me.grpContexts.Location = New System.Drawing.Point(596, 15)
        Me.grpContexts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpContexts.Name = "grpContexts"
        Me.grpContexts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpContexts.Size = New System.Drawing.Size(181, 395)
        Me.grpContexts.TabIndex = 2
        Me.grpContexts.TabStop = False
        Me.grpContexts.Text = "Contexts"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblOption1)
        Me.grpOptions.Controls.Add(Me.lblOptionOther)
        Me.grpOptions.Controls.Add(Me.ucrReceiverOptionOther)
        Me.grpOptions.Controls.Add(Me.ucrReceiverOption1)
        Me.grpOptions.Location = New System.Drawing.Point(401, 16)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOptions.Size = New System.Drawing.Size(181, 230)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'grpMeasurements
        '
        Me.grpMeasurements.Controls.Add(Me.lblMeasurement1)
        Me.grpMeasurements.Controls.Add(Me.lblMeasurementOther)
        Me.grpMeasurements.Controls.Add(Me.ucrReceiverMeasurementOther)
        Me.grpMeasurements.Controls.Add(Me.ucrReceiverMeasurement1)
        Me.grpMeasurements.Location = New System.Drawing.Point(401, 254)
        Me.grpMeasurements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMeasurements.Name = "grpMeasurements"
        Me.grpMeasurements.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMeasurements.Size = New System.Drawing.Size(181, 230)
        Me.grpMeasurements.TabIndex = 5
        Me.grpMeasurements.TabStop = False
        Me.grpMeasurements.Text = "Measurements"
        '
        'grpIDs
        '
        Me.grpIDs.Controls.Add(Me.lblID1)
        Me.grpIDs.Controls.Add(Me.lblIDOther)
        Me.grpIDs.Controls.Add(Me.ucrReceiverIDOther)
        Me.grpIDs.Controls.Add(Me.ucrReceiverID1)
        Me.grpIDs.Location = New System.Drawing.Point(13, 254)
        Me.grpIDs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDs.Name = "grpIDs"
        Me.grpIDs.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDs.Size = New System.Drawing.Size(161, 230)
        Me.grpIDs.TabIndex = 3
        Me.grpIDs.TabStop = False
        Me.grpIDs.Text = "IDs"
        '
        'lblID1
        '
        Me.lblID1.AutoSize = True
        Me.lblID1.Location = New System.Drawing.Point(11, 23)
        Me.lblID1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID1.Name = "lblID1"
        Me.lblID1.Size = New System.Drawing.Size(56, 16)
        Me.lblID1.TabIndex = 0
        Me.lblID1.Text = "Main ID:"
        '
        'lblIDOther
        '
        Me.lblIDOther.AutoSize = True
        Me.lblIDOther.Location = New System.Drawing.Point(11, 78)
        Me.lblIDOther.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDOther.Name = "lblIDOther"
        Me.lblIDOther.Size = New System.Drawing.Size(66, 16)
        Me.lblIDOther.TabIndex = 2
        Me.lblIDOther.Text = "Other IDs:"
        '
        'ucrReceiverIDOther
        '
        Me.ucrReceiverIDOther.frmParent = Me
        Me.ucrReceiverIDOther.Location = New System.Drawing.Point(11, 96)
        Me.ucrReceiverIDOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDOther.Name = "ucrReceiverIDOther"
        Me.ucrReceiverIDOther.Selector = Nothing
        Me.ucrReceiverIDOther.Size = New System.Drawing.Size(139, 123)
        Me.ucrReceiverIDOther.strNcFilePath = ""
        Me.ucrReceiverIDOther.TabIndex = 3
        Me.ucrReceiverIDOther.ucrSelector = Nothing
        '
        'ucrReceiverID1
        '
        Me.ucrReceiverID1.frmParent = Me
        Me.ucrReceiverID1.Location = New System.Drawing.Point(11, 42)
        Me.ucrReceiverID1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverID1.Name = "ucrReceiverID1"
        Me.ucrReceiverID1.Selector = Nothing
        Me.ucrReceiverID1.Size = New System.Drawing.Size(139, 25)
        Me.ucrReceiverID1.strNcFilePath = ""
        Me.ucrReceiverID1.TabIndex = 1
        Me.ucrReceiverID1.ucrSelector = Nothing
        '
        'ucrInputKeyCheck
        '
        Me.ucrInputKeyCheck.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyCheck.IsMultiline = False
        Me.ucrInputKeyCheck.IsReadOnly = False
        Me.ucrInputKeyCheck.Location = New System.Drawing.Point(139, 542)
        Me.ucrInputKeyCheck.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputKeyCheck.Name = "ucrInputKeyCheck"
        Me.ucrInputKeyCheck.Size = New System.Drawing.Size(405, 26)
        Me.ucrInputKeyCheck.TabIndex = 10
        '
        'ucrInputKeyColumns
        '
        Me.ucrInputKeyColumns.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyColumns.IsMultiline = False
        Me.ucrInputKeyColumns.IsReadOnly = False
        Me.ucrInputKeyColumns.Location = New System.Drawing.Point(139, 503)
        Me.ucrInputKeyColumns.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputKeyColumns.Name = "ucrInputKeyColumns"
        Me.ucrInputKeyColumns.Size = New System.Drawing.Size(405, 26)
        Me.ucrInputKeyColumns.TabIndex = 7
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.Location = New System.Drawing.Point(13, 507)
        Me.lblKeyColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(89, 16)
        Me.lblKeyColumns.TabIndex = 6
        Me.lblKeyColumns.Text = "Key Columns:"
        '
        'lblKeyCheck
        '
        Me.lblKeyCheck.AutoSize = True
        Me.lblKeyCheck.Location = New System.Drawing.Point(25, 545)
        Me.lblKeyCheck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKeyCheck.Name = "lblKeyCheck"
        Me.lblKeyCheck.Size = New System.Drawing.Size(75, 16)
        Me.lblKeyCheck.TabIndex = 9
        Me.lblKeyCheck.Text = "Key Check:"
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(563, 501)
        Me.cmdModify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(100, 28)
        Me.cmdModify.TabIndex = 8
        Me.cmdModify.Text = "Modify"
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'grpBlockingVariables
        '
        Me.grpBlockingVariables.Controls.Add(Me.lblBlockingMain)
        Me.grpBlockingVariables.Controls.Add(Me.lblBlockingOther)
        Me.grpBlockingVariables.Controls.Add(Me.ucrReceiverBlockingOther)
        Me.grpBlockingVariables.Controls.Add(Me.ucrReceiverBlocking1)
        Me.grpBlockingVariables.Location = New System.Drawing.Point(183, 254)
        Me.grpBlockingVariables.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBlockingVariables.Name = "grpBlockingVariables"
        Me.grpBlockingVariables.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBlockingVariables.Size = New System.Drawing.Size(211, 230)
        Me.grpBlockingVariables.TabIndex = 4
        Me.grpBlockingVariables.TabStop = False
        Me.grpBlockingVariables.Text = "Blocking Variables"
        '
        'lblBlockingMain
        '
        Me.lblBlockingMain.AutoSize = True
        Me.lblBlockingMain.Location = New System.Drawing.Point(11, 23)
        Me.lblBlockingMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlockingMain.Name = "lblBlockingMain"
        Me.lblBlockingMain.Size = New System.Drawing.Size(149, 16)
        Me.lblBlockingMain.TabIndex = 0
        Me.lblBlockingMain.Text = "Main Blocking Variable:"
        '
        'lblBlockingOther
        '
        Me.lblBlockingOther.AutoSize = True
        Me.lblBlockingOther.Location = New System.Drawing.Point(11, 78)
        Me.lblBlockingOther.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlockingOther.Name = "lblBlockingOther"
        Me.lblBlockingOther.Size = New System.Drawing.Size(159, 16)
        Me.lblBlockingOther.TabIndex = 2
        Me.lblBlockingOther.Text = "Other Blocking Variables:"
        '
        'ucrReceiverBlockingOther
        '
        Me.ucrReceiverBlockingOther.frmParent = Me
        Me.ucrReceiverBlockingOther.Location = New System.Drawing.Point(12, 96)
        Me.ucrReceiverBlockingOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBlockingOther.Name = "ucrReceiverBlockingOther"
        Me.ucrReceiverBlockingOther.Selector = Nothing
        Me.ucrReceiverBlockingOther.Size = New System.Drawing.Size(187, 123)
        Me.ucrReceiverBlockingOther.strNcFilePath = ""
        Me.ucrReceiverBlockingOther.TabIndex = 3
        Me.ucrReceiverBlockingOther.ucrSelector = Nothing
        '
        'ucrReceiverBlocking1
        '
        Me.ucrReceiverBlocking1.frmParent = Me
        Me.ucrReceiverBlocking1.Location = New System.Drawing.Point(12, 42)
        Me.ucrReceiverBlocking1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBlocking1.Name = "ucrReceiverBlocking1"
        Me.ucrReceiverBlocking1.Selector = Nothing
        Me.ucrReceiverBlocking1.Size = New System.Drawing.Size(187, 25)
        Me.ucrReceiverBlocking1.strNcFilePath = ""
        Me.ucrReceiverBlocking1.TabIndex = 1
        Me.ucrReceiverBlocking1.ucrSelector = Nothing
        '
        'dlgDefineOptionsByContext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 651)
        Me.Controls.Add(Me.grpBlockingVariables)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.lblKeyCheck)
        Me.Controls.Add(Me.lblKeyColumns)
        Me.Controls.Add(Me.ucrInputKeyColumns)
        Me.Controls.Add(Me.ucrInputKeyCheck)
        Me.Controls.Add(Me.grpIDs)
        Me.Controls.Add(Me.grpMeasurements)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpContexts)
        Me.Controls.Add(Me.ucrSelectorOptionsByContext)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineOptionsByContext"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Options By Context Data"
        Me.grpContexts.ResumeLayout(False)
        Me.grpContexts.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpMeasurements.ResumeLayout(False)
        Me.grpMeasurements.PerformLayout()
        Me.grpIDs.ResumeLayout(False)
        Me.grpIDs.PerformLayout()
        Me.grpBlockingVariables.ResumeLayout(False)
        Me.grpBlockingVariables.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorOptionsByContext As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblOptionOther As Label
    Friend WithEvents ucrReceiverOptionOther As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMeasurementOther As ucrReceiverMultiple
    Friend WithEvents lblMeasurementOther As Label
    Friend WithEvents ucrReceiverContextOther As ucrReceiverMultiple
    Friend WithEvents lblContextsOther As Label
    Friend WithEvents lblOption1 As Label
    Friend WithEvents ucrReceiverOption1 As ucrReceiverSingle
    Friend WithEvents lblMeasurement1 As Label
    Friend WithEvents ucrReceiverMeasurement1 As ucrReceiverSingle
    Friend WithEvents lblContext4 As Label
    Friend WithEvents ucrReceiverContext4 As ucrReceiverSingle
    Friend WithEvents lblContext3 As Label
    Friend WithEvents ucrReceiverContext3 As ucrReceiverSingle
    Friend WithEvents lblContext2 As Label
    Friend WithEvents ucrReceiverContext2 As ucrReceiverSingle
    Friend WithEvents lblContext1 As Label
    Friend WithEvents ucrReceiverContext1 As ucrReceiverSingle
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents ucrInputKeyColumns As ucrInputTextBox
    Friend WithEvents ucrInputKeyCheck As ucrInputTextBox
    Friend WithEvents grpIDs As GroupBox
    Friend WithEvents lblID1 As Label
    Friend WithEvents lblIDOther As Label
    Friend WithEvents ucrReceiverIDOther As ucrReceiverMultiple
    Friend WithEvents ucrReceiverID1 As ucrReceiverSingle
    Friend WithEvents grpMeasurements As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpContexts As GroupBox
    Friend WithEvents lblKeyCheck As Label
    Friend WithEvents cmdModify As Button
    Friend WithEvents grpBlockingVariables As GroupBox
    Friend WithEvents lblBlockingMain As Label
    Friend WithEvents lblBlockingOther As Label
    Friend WithEvents ucrReceiverBlockingOther As ucrReceiverMultiple
    Friend WithEvents ucrReceiverBlocking1 As ucrReceiverSingle
End Class
