<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimsoftWizard
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
        Me.panelConnectDatabase = New System.Windows.Forms.Panel()
        Me.ucrComboBoxPort = New instat.ucrInputComboBox()
        Me.ucrTxtHost = New instat.ucrInputTextBox()
        Me.ucrComboBoxDatabaseName = New instat.ucrInputComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkRememberCredentials = New System.Windows.Forms.CheckBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ucrTxtUserName = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.lblConnectionTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelStations = New System.Windows.Forms.Panel()
        Me.ucrChkObservationData = New instat.ucrCheck()
        Me.lblStationsTitle = New System.Windows.Forms.Label()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrSelectorStations = New instat.ucrSelectorAddRemove()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.panelElementsData = New System.Windows.Forms.Panel()
        Me.ucrChkUnstackData = New instat.ucrCheck()
        Me.ucrChkFlagsData = New instat.ucrCheck()
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkDateRange = New instat.ucrCheck()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartdate = New instat.ucrDateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblElementsTitle = New System.Windows.Forms.Label()
        Me.ucrSelectorElements = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.panelConnectDatabase.SuspendLayout()
        Me.panelStations.SuspendLayout()
        Me.panelElementsData.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelConnectDatabase
        '
        Me.panelConnectDatabase.Controls.Add(Me.ucrComboBoxPort)
        Me.panelConnectDatabase.Controls.Add(Me.ucrTxtHost)
        Me.panelConnectDatabase.Controls.Add(Me.ucrComboBoxDatabaseName)
        Me.panelConnectDatabase.Controls.Add(Me.btnConnect)
        Me.panelConnectDatabase.Controls.Add(Me.chkRememberCredentials)
        Me.panelConnectDatabase.Controls.Add(Me.lblConnection)
        Me.panelConnectDatabase.Controls.Add(Me.lblUserName)
        Me.panelConnectDatabase.Controls.Add(Me.ucrTxtUserName)
        Me.panelConnectDatabase.Controls.Add(Me.lblPort)
        Me.panelConnectDatabase.Controls.Add(Me.lblHost)
        Me.panelConnectDatabase.Controls.Add(Me.lblDatabaseName)
        Me.panelConnectDatabase.Controls.Add(Me.lblConnectionTitle)
        Me.panelConnectDatabase.Location = New System.Drawing.Point(187, 18)
        Me.panelConnectDatabase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelConnectDatabase.Name = "panelConnectDatabase"
        Me.panelConnectDatabase.Size = New System.Drawing.Size(411, 334)
        Me.panelConnectDatabase.TabIndex = 1
        '
        'ucrComboBoxPort
        '
        Me.ucrComboBoxPort.AddQuotesIfUnrecognised = False
        Me.ucrComboBoxPort.GetSetSelectedIndex = -1
        Me.ucrComboBoxPort.IsReadOnly = False
        Me.ucrComboBoxPort.Location = New System.Drawing.Point(204, 122)
        Me.ucrComboBoxPort.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        Me.ucrComboBoxPort.Size = New System.Drawing.Size(193, 26)
        Me.ucrComboBoxPort.TabIndex = 15
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(204, 85)
        Me.ucrTxtHost.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(193, 26)
        Me.ucrTxtHost.TabIndex = 13
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        Me.ucrComboBoxDatabaseName.Location = New System.Drawing.Point(204, 46)
        Me.ucrComboBoxDatabaseName.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        Me.ucrComboBoxDatabaseName.Size = New System.Drawing.Size(193, 26)
        Me.ucrComboBoxDatabaseName.TabIndex = 12
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(127, 258)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(101, 27)
        Me.btnConnect.TabIndex = 19
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(125, 202)
        Me.chkRememberCredentials.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(239, 21)
        Me.chkRememberCredentials.TabIndex = 18
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(235, 265)
        Me.lblConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(96, 16)
        Me.lblConnection.TabIndex = 21
        Me.lblConnection.Text = "No Connection"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(44, 162)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 16)
        Me.lblUserName.TabIndex = 20
        Me.lblUserName.Text = "Username:"
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        Me.ucrTxtUserName.Location = New System.Drawing.Point(204, 158)
        Me.ucrTxtUserName.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(193, 26)
        Me.ucrTxtUserName.TabIndex = 16
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(83, 126)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(35, 16)
        Me.lblPort.TabIndex = 17
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(77, 90)
        Me.lblHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(39, 16)
        Me.lblHost.TabIndex = 14
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(4, 49)
        Me.lblDatabaseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(111, 16)
        Me.lblDatabaseName.TabIndex = 11
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'lblConnectionTitle
        '
        Me.lblConnectionTitle.AutoSize = True
        Me.lblConnectionTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnectionTitle.Location = New System.Drawing.Point(109, 12)
        Me.lblConnectionTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnectionTitle.Name = "lblConnectionTitle"
        Me.lblConnectionTitle.Size = New System.Drawing.Size(184, 16)
        Me.lblConnectionTitle.TabIndex = 10
        Me.lblConnectionTitle.Text = "Connect to Climsoft Database"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(116, 442)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 28)
        Me.btnNext.TabIndex = 50
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 442)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 52
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'panelStations
        '
        Me.panelStations.Controls.Add(Me.ucrChkObservationData)
        Me.panelStations.Controls.Add(Me.lblStationsTitle)
        Me.panelStations.Controls.Add(Me.ucrComboBoxStations)
        Me.panelStations.Controls.Add(Me.ucrSelectorStations)
        Me.panelStations.Controls.Add(Me.lblStations)
        Me.panelStations.Controls.Add(Me.ucrReceiverMultipleStations)
        Me.panelStations.Location = New System.Drawing.Point(80, 12)
        Me.panelStations.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelStations.Name = "panelStations"
        Me.panelStations.Size = New System.Drawing.Size(515, 354)
        Me.panelStations.TabIndex = 2
        '
        'ucrChkObservationData
        '
        Me.ucrChkObservationData.Checked = False
        Me.ucrChkObservationData.Location = New System.Drawing.Point(9, 261)
        Me.ucrChkObservationData.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrChkObservationData.Name = "ucrChkObservationData"
        Me.ucrChkObservationData.Size = New System.Drawing.Size(237, 25)
        Me.ucrChkObservationData.TabIndex = 10
        '
        'lblStationsTitle
        '
        Me.lblStationsTitle.AutoSize = True
        Me.lblStationsTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationsTitle.Location = New System.Drawing.Point(173, 12)
        Me.lblStationsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationsTitle.Name = "lblStationsTitle"
        Me.lblStationsTitle.Size = New System.Drawing.Size(151, 16)
        Me.lblStationsTitle.TabIndex = 9
        Me.lblStationsTitle.Text = "Select Stations to Import"
        Me.lblStationsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrComboBoxStations
        '
        Me.ucrComboBoxStations.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxStations.GetSetSelectedIndex = -1
        Me.ucrComboBoxStations.IsReadOnly = False
        Me.ucrComboBoxStations.Location = New System.Drawing.Point(9, 46)
        Me.ucrComboBoxStations.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrComboBoxStations.Name = "ucrComboBoxStations"
        Me.ucrComboBoxStations.Size = New System.Drawing.Size(197, 26)
        Me.ucrComboBoxStations.TabIndex = 7
        '
        'ucrSelectorStations
        '
        Me.ucrSelectorStations.bShowHiddenColumns = False
        Me.ucrSelectorStations.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStations.Name = "ucrSelectorStations"
        Me.ucrSelectorStations.Size = New System.Drawing.Size(288, 171)
        Me.ucrSelectorStations.TabIndex = 5
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStations.Location = New System.Drawing.Point(308, 55)
        Me.lblStations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(116, 16)
        Me.lblStations.TabIndex = 6
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.frmParent = Me
        Me.ucrReceiverMultipleStations.Location = New System.Drawing.Point(312, 75)
        Me.ucrReceiverMultipleStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.Size = New System.Drawing.Size(183, 123)
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.TabIndex = 8
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'panelElementsData
        '
        Me.panelElementsData.Controls.Add(Me.ucrChkUnstackData)
        Me.panelElementsData.Controls.Add(Me.ucrChkFlagsData)
        Me.panelElementsData.Controls.Add(Me.ucrChkElements)
        Me.panelElementsData.Controls.Add(Me.ucrChkDateRange)
        Me.panelElementsData.Controls.Add(Me.ucrDtpEndDate)
        Me.panelElementsData.Controls.Add(Me.ucrDtpStartdate)
        Me.panelElementsData.Controls.Add(Me.lblEndDate)
        Me.panelElementsData.Controls.Add(Me.lblStartDate)
        Me.panelElementsData.Controls.Add(Me.ucrComboBoxElements)
        Me.panelElementsData.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.panelElementsData.Controls.Add(Me.lblElements)
        Me.panelElementsData.Controls.Add(Me.lblElementsTitle)
        Me.panelElementsData.Controls.Add(Me.ucrSelectorElements)
        Me.panelElementsData.Location = New System.Drawing.Point(80, 12)
        Me.panelElementsData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelElementsData.Name = "panelElementsData"
        Me.panelElementsData.Size = New System.Drawing.Size(591, 422)
        Me.panelElementsData.TabIndex = 3
        '
        'ucrChkUnstackData
        '
        Me.ucrChkUnstackData.Checked = False
        Me.ucrChkUnstackData.Location = New System.Drawing.Point(67, 271)
        Me.ucrChkUnstackData.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrChkUnstackData.Name = "ucrChkUnstackData"
        Me.ucrChkUnstackData.Size = New System.Drawing.Size(283, 25)
        Me.ucrChkUnstackData.TabIndex = 20
        '
        'ucrChkFlagsData
        '
        Me.ucrChkFlagsData.Checked = False
        Me.ucrChkFlagsData.Location = New System.Drawing.Point(67, 245)
        Me.ucrChkFlagsData.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrChkFlagsData.Name = "ucrChkFlagsData"
        Me.ucrChkFlagsData.Size = New System.Drawing.Size(283, 25)
        Me.ucrChkFlagsData.TabIndex = 19
        '
        'ucrChkElements
        '
        Me.ucrChkElements.Checked = False
        Me.ucrChkElements.Location = New System.Drawing.Point(67, 298)
        Me.ucrChkElements.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ucrChkElements.Size = New System.Drawing.Size(283, 25)
        Me.ucrChkElements.TabIndex = 13
        '
        'ucrChkDateRange
        '
        Me.ucrChkDateRange.Checked = False
        Me.ucrChkDateRange.Location = New System.Drawing.Point(67, 325)
        Me.ucrChkDateRange.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrChkDateRange.Name = "ucrChkDateRange"
        Me.ucrChkDateRange.Size = New System.Drawing.Size(271, 25)
        Me.ucrChkDateRange.TabIndex = 15
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 18, 16, 55, 57, 146)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDate.Location = New System.Drawing.Point(327, 368)
        Me.ucrDtpEndDate.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ucrDtpEndDate.Size = New System.Drawing.Size(217, 25)
        Me.ucrDtpEndDate.TabIndex = 17
        '
        'ucrDtpStartdate
        '
        Me.ucrDtpStartdate.DateValue = New Date(2021, 5, 18, 16, 55, 57, 157)
        Me.ucrDtpStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpStartdate.Location = New System.Drawing.Point(99, 369)
        Me.ucrDtpStartdate.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.ucrDtpStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartdate.Name = "ucrDtpStartdate"
        Me.ucrDtpStartdate.Size = New System.Drawing.Size(217, 25)
        Me.ucrDtpStartdate.TabIndex = 16
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndDate.Location = New System.Drawing.Point(324, 348)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(67, 16)
        Me.lblEndDate.TabIndex = 18
        Me.lblEndDate.Text = "End Date:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartDate.Location = New System.Drawing.Point(93, 351)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(70, 16)
        Me.lblStartDate.TabIndex = 14
        Me.lblStartDate.Text = "Start Date:"
        '
        'ucrComboBoxElements
        '
        Me.ucrComboBoxElements.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxElements.GetSetSelectedIndex = -1
        Me.ucrComboBoxElements.IsReadOnly = False
        Me.ucrComboBoxElements.Location = New System.Drawing.Point(67, 46)
        Me.ucrComboBoxElements.Margin = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.ucrComboBoxElements.Name = "ucrComboBoxElements"
        Me.ucrComboBoxElements.Size = New System.Drawing.Size(199, 26)
        Me.ucrComboBoxElements.TabIndex = 10
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(369, 75)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(183, 123)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 12
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(365, 55)
        Me.lblElements.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(124, 16)
        Me.lblElements.TabIndex = 11
        Me.lblElements.Text = "Selected Elements:"
        '
        'lblElementsTitle
        '
        Me.lblElementsTitle.AutoSize = True
        Me.lblElementsTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElementsTitle.Location = New System.Drawing.Point(165, 12)
        Me.lblElementsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElementsTitle.Name = "lblElementsTitle"
        Me.lblElementsTitle.Size = New System.Drawing.Size(267, 16)
        Me.lblElementsTitle.TabIndex = 9
        Me.lblElementsTitle.Text = "Select Elements Observation Data to Import"
        Me.lblElementsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrSelectorElements
        '
        Me.ucrSelectorElements.bShowHiddenColumns = False
        Me.ucrSelectorElements.Location = New System.Drawing.Point(67, 75)
        Me.ucrSelectorElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorElements.Name = "ucrSelectorElements"
        Me.ucrSelectorElements.Size = New System.Drawing.Size(288, 169)
        Me.ucrSelectorElements.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(221, 410)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 51
        '
        'dlgClimsoftWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 482)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelElementsData)
        Me.Controls.Add(Me.panelStations)
        Me.Controls.Add(Me.panelConnectDatabase)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimsoftWizard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From Climsoft Wizard"
        Me.panelConnectDatabase.ResumeLayout(False)
        Me.panelConnectDatabase.PerformLayout()
        Me.panelStations.ResumeLayout(False)
        Me.panelStations.PerformLayout()
        Me.panelElementsData.ResumeLayout(False)
        Me.panelElementsData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelConnectDatabase As Panel
    Friend WithEvents lblConnectionTitle As Label
    Friend WithEvents ucrComboBoxPort As ucrInputComboBox
    Friend WithEvents ucrTxtHost As ucrInputTextBox
    Friend WithEvents ucrComboBoxDatabaseName As ucrInputComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents chkRememberCredentials As CheckBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents ucrTxtUserName As ucrInputTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents panelStations As Panel
    Friend WithEvents lblStationsTitle As Label
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrSelectorStations As ucrSelectorAddRemove
    Friend WithEvents lblStations As Label
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents btnBack As Button
    Friend WithEvents ucrChkObservationData As ucrCheck
    Friend WithEvents panelElementsData As Panel
    Friend WithEvents lblElementsTitle As Label
    Friend WithEvents ucrSelectorElements As ucrSelectorAddRemove
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblElements As Label
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents ucrChkDateRange As ucrCheck
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartdate As ucrDateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkFlagsData As ucrCheck
    Friend WithEvents ucrChkUnstackData As ucrCheck
End Class
