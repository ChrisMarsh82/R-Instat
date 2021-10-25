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
Partial Class dlgDefineCorruption
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
        Me.ucrDefineCorruptionSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblNoBidsReceived = New System.Windows.Forms.Label()
        Me.ucrReceiverNoBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcedureType = New instat.ucrReceiverSingle()
        Me.lblProcedureType = New System.Windows.Forms.Label()
        Me.ucrReceiverContractValue = New instat.ucrReceiverSingle()
        Me.lblContractValue = New System.Windows.Forms.Label()
        Me.ucrReceiverNoConsideredBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerCountry = New instat.ucrReceiverSingle()
        Me.lblNoConsideredBids = New System.Windows.Forms.Label()
        Me.lblWinnerCountry = New System.Windows.Forms.Label()
        Me.ucrReceiverProcuringAuthority = New instat.ucrReceiverSingle()
        Me.lblProcuringAuthority = New System.Windows.Forms.Label()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrReceiverSignatureDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractSector = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcurementCategory = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerName = New instat.ucrReceiverSingle()
        Me.lblWinnerName = New System.Windows.Forms.Label()
        Me.lblContractSector = New System.Windows.Forms.Label()
        Me.lblProcurementCategory = New System.Windows.Forms.Label()
        Me.lblContractTitle = New System.Windows.Forms.Label()
        Me.ucrReceiverAwardDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractTitle = New instat.ucrReceiverSingle()
        Me.lblAwardDate = New System.Windows.Forms.Label()
        Me.lblSignatureDate = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblFiscalYear = New System.Windows.Forms.Label()
        Me.ucrReceiverFiscalYear = New instat.ucrReceiverSingle()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.ucrReceiverRegion = New instat.ucrReceiverSingle()
        Me.ucrChkAutoGenerate = New instat.ucrCheck()
        Me.cmdCountryLevel = New System.Windows.Forms.Button()
        Me.cmdCalculatedColumns = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrDefineCorruptionSelector
        '
        Me.ucrDefineCorruptionSelector.bDropUnusedFilterLevels = False
        Me.ucrDefineCorruptionSelector.bShowHiddenColumns = False
        Me.ucrDefineCorruptionSelector.bUseCurrentFilter = True
        Me.ucrDefineCorruptionSelector.Location = New System.Drawing.Point(13, 12)
        Me.ucrDefineCorruptionSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDefineCorruptionSelector.Name = "ucrDefineCorruptionSelector"
        Me.ucrDefineCorruptionSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrDefineCorruptionSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 464)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 34
        '
        'lblNoBidsReceived
        '
        Me.lblNoBidsReceived.AutoSize = True
        Me.lblNoBidsReceived.Location = New System.Drawing.Point(552, 33)
        Me.lblNoBidsReceived.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoBidsReceived.Name = "lblNoBidsReceived"
        Me.lblNoBidsReceived.Size = New System.Drawing.Size(124, 16)
        Me.lblNoBidsReceived.TabIndex = 17
        Me.lblNoBidsReceived.Text = "No. Bids Received:"
        '
        'ucrReceiverNoBids
        '
        Me.ucrReceiverNoBids.frmParent = Me
        Me.ucrReceiverNoBids.Location = New System.Drawing.Point(552, 52)
        Me.ucrReceiverNoBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoBids.Name = "ucrReceiverNoBids"
        Me.ucrReceiverNoBids.Selector = Nothing
        Me.ucrReceiverNoBids.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverNoBids.strNcFilePath = ""
        Me.ucrReceiverNoBids.TabIndex = 18
        Me.ucrReceiverNoBids.ucrSelector = Nothing
        '
        'ucrReceiverProcedureType
        '
        Me.ucrReceiverProcedureType.frmParent = Me
        Me.ucrReceiverProcedureType.Location = New System.Drawing.Point(552, 158)
        Me.ucrReceiverProcedureType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcedureType.Name = "ucrReceiverProcedureType"
        Me.ucrReceiverProcedureType.Selector = Nothing
        Me.ucrReceiverProcedureType.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverProcedureType.strNcFilePath = ""
        Me.ucrReceiverProcedureType.TabIndex = 22
        Me.ucrReceiverProcedureType.ucrSelector = Nothing
        '
        'lblProcedureType
        '
        Me.lblProcedureType.AutoSize = True
        Me.lblProcedureType.Location = New System.Drawing.Point(552, 139)
        Me.lblProcedureType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcedureType.Name = "lblProcedureType"
        Me.lblProcedureType.Size = New System.Drawing.Size(109, 16)
        Me.lblProcedureType.TabIndex = 21
        Me.lblProcedureType.Text = "Procedure Type:"
        '
        'ucrReceiverContractValue
        '
        Me.ucrReceiverContractValue.frmParent = Me
        Me.ucrReceiverContractValue.Location = New System.Drawing.Point(552, 316)
        Me.ucrReceiverContractValue.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractValue.Name = "ucrReceiverContractValue"
        Me.ucrReceiverContractValue.Selector = Nothing
        Me.ucrReceiverContractValue.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContractValue.strNcFilePath = ""
        Me.ucrReceiverContractValue.TabIndex = 28
        Me.ucrReceiverContractValue.ucrSelector = Nothing
        '
        'lblContractValue
        '
        Me.lblContractValue.AutoSize = True
        Me.lblContractValue.Location = New System.Drawing.Point(552, 298)
        Me.lblContractValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContractValue.Name = "lblContractValue"
        Me.lblContractValue.Size = New System.Drawing.Size(98, 16)
        Me.lblContractValue.TabIndex = 27
        Me.lblContractValue.Text = "Contract Value:"
        '
        'ucrReceiverNoConsideredBids
        '
        Me.ucrReceiverNoConsideredBids.frmParent = Me
        Me.ucrReceiverNoConsideredBids.Location = New System.Drawing.Point(552, 105)
        Me.ucrReceiverNoConsideredBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoConsideredBids.Name = "ucrReceiverNoConsideredBids"
        Me.ucrReceiverNoConsideredBids.Selector = Nothing
        Me.ucrReceiverNoConsideredBids.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverNoConsideredBids.strNcFilePath = ""
        Me.ucrReceiverNoConsideredBids.TabIndex = 20
        Me.ucrReceiverNoConsideredBids.ucrSelector = Nothing
        '
        'ucrReceiverWinnerCountry
        '
        Me.ucrReceiverWinnerCountry.frmParent = Me
        Me.ucrReceiverWinnerCountry.Location = New System.Drawing.Point(552, 263)
        Me.ucrReceiverWinnerCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerCountry.Name = "ucrReceiverWinnerCountry"
        Me.ucrReceiverWinnerCountry.Selector = Nothing
        Me.ucrReceiverWinnerCountry.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWinnerCountry.strNcFilePath = ""
        Me.ucrReceiverWinnerCountry.TabIndex = 26
        Me.ucrReceiverWinnerCountry.ucrSelector = Nothing
        '
        'lblNoConsideredBids
        '
        Me.lblNoConsideredBids.AutoSize = True
        Me.lblNoConsideredBids.Location = New System.Drawing.Point(552, 86)
        Me.lblNoConsideredBids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoConsideredBids.Name = "lblNoConsideredBids"
        Me.lblNoConsideredBids.Size = New System.Drawing.Size(135, 16)
        Me.lblNoConsideredBids.TabIndex = 19
        Me.lblNoConsideredBids.Text = "No. Considered Bids:"
        '
        'lblWinnerCountry
        '
        Me.lblWinnerCountry.AutoSize = True
        Me.lblWinnerCountry.Location = New System.Drawing.Point(552, 245)
        Me.lblWinnerCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinnerCountry.Name = "lblWinnerCountry"
        Me.lblWinnerCountry.Size = New System.Drawing.Size(101, 16)
        Me.lblWinnerCountry.TabIndex = 25
        Me.lblWinnerCountry.Text = "Winner Country:"
        '
        'ucrReceiverProcuringAuthority
        '
        Me.ucrReceiverProcuringAuthority.frmParent = Me
        Me.ucrReceiverProcuringAuthority.Location = New System.Drawing.Point(335, 158)
        Me.ucrReceiverProcuringAuthority.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcuringAuthority.Name = "ucrReceiverProcuringAuthority"
        Me.ucrReceiverProcuringAuthority.Selector = Nothing
        Me.ucrReceiverProcuringAuthority.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverProcuringAuthority.strNcFilePath = ""
        Me.ucrReceiverProcuringAuthority.TabIndex = 6
        Me.ucrReceiverProcuringAuthority.ucrSelector = Nothing
        '
        'lblProcuringAuthority
        '
        Me.lblProcuringAuthority.AutoSize = True
        Me.lblProcuringAuthority.Location = New System.Drawing.Point(335, 139)
        Me.lblProcuringAuthority.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
        Me.lblProcuringAuthority.Size = New System.Drawing.Size(122, 16)
        Me.lblProcuringAuthority.TabIndex = 5
        Me.lblProcuringAuthority.Text = "Procuring Authority:"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(335, 52)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.TabIndex = 2
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverSignatureDate
        '
        Me.ucrReceiverSignatureDate.frmParent = Me
        Me.ucrReceiverSignatureDate.Location = New System.Drawing.Point(335, 263)
        Me.ucrReceiverSignatureDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSignatureDate.Name = "ucrReceiverSignatureDate"
        Me.ucrReceiverSignatureDate.Selector = Nothing
        Me.ucrReceiverSignatureDate.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverSignatureDate.strNcFilePath = ""
        Me.ucrReceiverSignatureDate.TabIndex = 10
        Me.ucrReceiverSignatureDate.ucrSelector = Nothing
        '
        'ucrReceiverContractSector
        '
        Me.ucrReceiverContractSector.frmParent = Me
        Me.ucrReceiverContractSector.Location = New System.Drawing.Point(335, 369)
        Me.ucrReceiverContractSector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractSector.Name = "ucrReceiverContractSector"
        Me.ucrReceiverContractSector.Selector = Nothing
        Me.ucrReceiverContractSector.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContractSector.strNcFilePath = ""
        Me.ucrReceiverContractSector.TabIndex = 14
        Me.ucrReceiverContractSector.ucrSelector = Nothing
        '
        'ucrReceiverProcurementCategory
        '
        Me.ucrReceiverProcurementCategory.frmParent = Me
        Me.ucrReceiverProcurementCategory.Location = New System.Drawing.Point(335, 426)
        Me.ucrReceiverProcurementCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementCategory.Name = "ucrReceiverProcurementCategory"
        Me.ucrReceiverProcurementCategory.Selector = Nothing
        Me.ucrReceiverProcurementCategory.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverProcurementCategory.strNcFilePath = ""
        Me.ucrReceiverProcurementCategory.TabIndex = 16
        Me.ucrReceiverProcurementCategory.ucrSelector = Nothing
        '
        'ucrReceiverWinnerName
        '
        Me.ucrReceiverWinnerName.frmParent = Me
        Me.ucrReceiverWinnerName.Location = New System.Drawing.Point(552, 210)
        Me.ucrReceiverWinnerName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerName.Name = "ucrReceiverWinnerName"
        Me.ucrReceiverWinnerName.Selector = Nothing
        Me.ucrReceiverWinnerName.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverWinnerName.strNcFilePath = ""
        Me.ucrReceiverWinnerName.TabIndex = 24
        Me.ucrReceiverWinnerName.ucrSelector = Nothing
        '
        'lblWinnerName
        '
        Me.lblWinnerName.AutoSize = True
        Me.lblWinnerName.Location = New System.Drawing.Point(552, 192)
        Me.lblWinnerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinnerName.Name = "lblWinnerName"
        Me.lblWinnerName.Size = New System.Drawing.Size(93, 16)
        Me.lblWinnerName.TabIndex = 23
        Me.lblWinnerName.Text = "Winner Name:"
        '
        'lblContractSector
        '
        Me.lblContractSector.AutoSize = True
        Me.lblContractSector.Location = New System.Drawing.Point(335, 351)
        Me.lblContractSector.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContractSector.Name = "lblContractSector"
        Me.lblContractSector.Size = New System.Drawing.Size(102, 16)
        Me.lblContractSector.TabIndex = 13
        Me.lblContractSector.Text = "Contract Sector:"
        '
        'lblProcurementCategory
        '
        Me.lblProcurementCategory.AutoSize = True
        Me.lblProcurementCategory.Location = New System.Drawing.Point(335, 407)
        Me.lblProcurementCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcurementCategory.Name = "lblProcurementCategory"
        Me.lblProcurementCategory.Size = New System.Drawing.Size(145, 16)
        Me.lblProcurementCategory.TabIndex = 15
        Me.lblProcurementCategory.Text = "Procurement Category:"
        '
        'lblContractTitle
        '
        Me.lblContractTitle.AutoSize = True
        Me.lblContractTitle.Location = New System.Drawing.Point(335, 298)
        Me.lblContractTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContractTitle.Name = "lblContractTitle"
        Me.lblContractTitle.Size = New System.Drawing.Size(89, 16)
        Me.lblContractTitle.TabIndex = 11
        Me.lblContractTitle.Text = "Contract Title:"
        '
        'ucrReceiverAwardDate
        '
        Me.ucrReceiverAwardDate.frmParent = Me
        Me.ucrReceiverAwardDate.Location = New System.Drawing.Point(335, 210)
        Me.ucrReceiverAwardDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAwardDate.Name = "ucrReceiverAwardDate"
        Me.ucrReceiverAwardDate.Selector = Nothing
        Me.ucrReceiverAwardDate.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverAwardDate.strNcFilePath = ""
        Me.ucrReceiverAwardDate.TabIndex = 8
        Me.ucrReceiverAwardDate.ucrSelector = Nothing
        '
        'ucrReceiverContractTitle
        '
        Me.ucrReceiverContractTitle.frmParent = Me
        Me.ucrReceiverContractTitle.Location = New System.Drawing.Point(335, 316)
        Me.ucrReceiverContractTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractTitle.Name = "ucrReceiverContractTitle"
        Me.ucrReceiverContractTitle.Selector = Nothing
        Me.ucrReceiverContractTitle.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverContractTitle.strNcFilePath = ""
        Me.ucrReceiverContractTitle.TabIndex = 12
        Me.ucrReceiverContractTitle.ucrSelector = Nothing
        '
        'lblAwardDate
        '
        Me.lblAwardDate.AutoSize = True
        Me.lblAwardDate.Location = New System.Drawing.Point(335, 192)
        Me.lblAwardDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAwardDate.Name = "lblAwardDate"
        Me.lblAwardDate.Size = New System.Drawing.Size(81, 16)
        Me.lblAwardDate.TabIndex = 7
        Me.lblAwardDate.Text = "Award Date:"
        '
        'lblSignatureDate
        '
        Me.lblSignatureDate.AutoSize = True
        Me.lblSignatureDate.Location = New System.Drawing.Point(335, 245)
        Me.lblSignatureDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSignatureDate.Name = "lblSignatureDate"
        Me.lblSignatureDate.Size = New System.Drawing.Size(100, 16)
        Me.lblSignatureDate.TabIndex = 9
        Me.lblSignatureDate.Text = "Signature Date:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(335, 33)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(56, 16)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "Country:"
        '
        'lblFiscalYear
        '
        Me.lblFiscalYear.AutoSize = True
        Me.lblFiscalYear.Location = New System.Drawing.Point(552, 351)
        Me.lblFiscalYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFiscalYear.Name = "lblFiscalYear"
        Me.lblFiscalYear.Size = New System.Drawing.Size(79, 16)
        Me.lblFiscalYear.TabIndex = 29
        Me.lblFiscalYear.Text = "Fiscal Year:"
        '
        'ucrReceiverFiscalYear
        '
        Me.ucrReceiverFiscalYear.frmParent = Me
        Me.ucrReceiverFiscalYear.Location = New System.Drawing.Point(552, 369)
        Me.ucrReceiverFiscalYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFiscalYear.Name = "ucrReceiverFiscalYear"
        Me.ucrReceiverFiscalYear.Selector = Nothing
        Me.ucrReceiverFiscalYear.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverFiscalYear.strNcFilePath = ""
        Me.ucrReceiverFiscalYear.TabIndex = 30
        Me.ucrReceiverFiscalYear.ucrSelector = Nothing
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(335, 86)
        Me.lblRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(55, 16)
        Me.lblRegion.TabIndex = 3
        Me.lblRegion.Text = "Region:"
        '
        'ucrReceiverRegion
        '
        Me.ucrReceiverRegion.frmParent = Me
        Me.ucrReceiverRegion.Location = New System.Drawing.Point(335, 105)
        Me.ucrReceiverRegion.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRegion.Name = "ucrReceiverRegion"
        Me.ucrReceiverRegion.Selector = Nothing
        Me.ucrReceiverRegion.Size = New System.Drawing.Size(160, 25)
        Me.ucrReceiverRegion.strNcFilePath = ""
        Me.ucrReceiverRegion.TabIndex = 4
        Me.ucrReceiverRegion.ucrSelector = Nothing
        '
        'ucrChkAutoGenerate
        '
        Me.ucrChkAutoGenerate.Checked = False
        Me.ucrChkAutoGenerate.Location = New System.Drawing.Point(13, 326)
        Me.ucrChkAutoGenerate.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkAutoGenerate.Name = "ucrChkAutoGenerate"
        Me.ucrChkAutoGenerate.Size = New System.Drawing.Size(160, 25)
        Me.ucrChkAutoGenerate.TabIndex = 31
        '
        'cmdCountryLevel
        '
        Me.cmdCountryLevel.Location = New System.Drawing.Point(13, 250)
        Me.cmdCountryLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCountryLevel.Name = "cmdCountryLevel"
        Me.cmdCountryLevel.Size = New System.Drawing.Size(159, 28)
        Me.cmdCountryLevel.TabIndex = 32
        Me.cmdCountryLevel.Text = "Country Level"
        Me.cmdCountryLevel.UseVisualStyleBackColor = True
        '
        'cmdCalculatedColumns
        '
        Me.cmdCalculatedColumns.Location = New System.Drawing.Point(13, 287)
        Me.cmdCalculatedColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCalculatedColumns.Name = "cmdCalculatedColumns"
        Me.cmdCalculatedColumns.Size = New System.Drawing.Size(159, 28)
        Me.cmdCalculatedColumns.TabIndex = 33
        Me.cmdCalculatedColumns.Text = "Calculated Columns"
        Me.cmdCalculatedColumns.UseVisualStyleBackColor = True
        '
        'dlgDefineCorruption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 539)
        Me.Controls.Add(Me.cmdCalculatedColumns)
        Me.Controls.Add(Me.cmdCountryLevel)
        Me.Controls.Add(Me.ucrChkAutoGenerate)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.ucrReceiverRegion)
        Me.Controls.Add(Me.lblFiscalYear)
        Me.Controls.Add(Me.ucrReceiverFiscalYear)
        Me.Controls.Add(Me.ucrReceiverContractValue)
        Me.Controls.Add(Me.lblContractValue)
        Me.Controls.Add(Me.lblNoBidsReceived)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDefineCorruptionSelector)
        Me.Controls.Add(Me.ucrReceiverNoBids)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblSignatureDate)
        Me.Controls.Add(Me.ucrReceiverProcedureType)
        Me.Controls.Add(Me.lblAwardDate)
        Me.Controls.Add(Me.lblProcedureType)
        Me.Controls.Add(Me.ucrReceiverContractTitle)
        Me.Controls.Add(Me.ucrReceiverAwardDate)
        Me.Controls.Add(Me.lblContractTitle)
        Me.Controls.Add(Me.ucrReceiverSignatureDate)
        Me.Controls.Add(Me.ucrReceiverNoConsideredBids)
        Me.Controls.Add(Me.lblNoConsideredBids)
        Me.Controls.Add(Me.ucrReceiverCountry)
        Me.Controls.Add(Me.ucrReceiverWinnerCountry)
        Me.Controls.Add(Me.lblProcuringAuthority)
        Me.Controls.Add(Me.ucrReceiverProcuringAuthority)
        Me.Controls.Add(Me.lblWinnerCountry)
        Me.Controls.Add(Me.lblContractSector)
        Me.Controls.Add(Me.ucrReceiverContractSector)
        Me.Controls.Add(Me.lblProcurementCategory)
        Me.Controls.Add(Me.ucrReceiverProcurementCategory)
        Me.Controls.Add(Me.lblWinnerName)
        Me.Controls.Add(Me.ucrReceiverWinnerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCorruption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Procurement Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDefineCorruptionSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNoBidsReceived As Label
    Friend WithEvents ucrReceiverNoBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcedureType As ucrReceiverSingle
    Friend WithEvents lblProcedureType As Label
    Friend WithEvents ucrReceiverContractValue As ucrReceiverSingle
    Friend WithEvents lblContractValue As Label
    Friend WithEvents ucrReceiverNoConsideredBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerCountry As ucrReceiverSingle
    Friend WithEvents lblNoConsideredBids As Label
    Friend WithEvents lblWinnerCountry As Label
    Friend WithEvents ucrReceiverProcuringAuthority As ucrReceiverSingle
    Friend WithEvents lblProcuringAuthority As Label
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents ucrReceiverSignatureDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractSector As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcurementCategory As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerName As ucrReceiverSingle
    Friend WithEvents lblWinnerName As Label
    Friend WithEvents lblContractSector As Label
    Friend WithEvents lblProcurementCategory As Label
    Friend WithEvents lblContractTitle As Label
    Friend WithEvents ucrReceiverAwardDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractTitle As ucrReceiverSingle
    Friend WithEvents lblAwardDate As Label
    Friend WithEvents lblSignatureDate As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents ucrReceiverRegion As ucrReceiverSingle
    Friend WithEvents lblFiscalYear As Label
    Friend WithEvents ucrReceiverFiscalYear As ucrReceiverSingle
    Friend WithEvents ucrChkAutoGenerate As ucrCheck
    Friend WithEvents cmdCalculatedColumns As Button
    Friend WithEvents cmdCountryLevel As Button
End Class
