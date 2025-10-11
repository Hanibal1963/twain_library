Imports System.Drawing
Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Diagnostics

Public Class VB_FullDemo : Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        thisObject = Me
        InitializeComponent()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If dllExists = True Then
                DTWAINAPI.DTWAIN_SysDestroy()
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End If
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private WithEvents MenuItemExitDemo As MenuItem
    Private WithEvents MenuItemSelectSource As MenuItem
    Private WithEvents MenuItemSelectSourceByName As MenuItem
    Private WithEvents MenuItemSelectDefaultSource As MenuItem
    Private WithEvents MenuItemSelectSourceCustom As MenuItem
    Private WithEvents MenuItemSourceProperties As MenuItem
    Private WithEvents MenuItemCloseSource As MenuItem
    Private WithEvents MenuItemAcquireNative As MenuItem
    Private WithEvents MenuItemAcquireBuffered As MenuItem
    Private WithEvents MenuItemAcquireFile As MenuItem
    Private WithEvents MenuItemAcquireFileUsingDriver As MenuItem
    Private WithEvents MenuItemShowPreview As MenuItem
    Private WithEvents MenuItemUseSourceUI As MenuItem
    Private WithEvents MenuItemDiscardBlankPages As MenuItem
    Private WithEvents MenuItemLoggingOptions As MenuItem
    Private WithEvents MenuItemDTWAINVersion As MenuItem
    Private WithEvents MenuItemDutch As MenuItem
    Private WithEvents MenuItemEnglish As MenuItem
    Private WithEvents MenuItemFrench As MenuItem
    Private WithEvents MenuItemGerman As MenuItem
    Private WithEvents MenuItemItalian As MenuItem
    Private WithEvents MenuItemPortuguese As MenuItem
    Private WithEvents MenuItemRomanian As MenuItem
    Private WithEvents MenuItemRussian As MenuItem
    Private WithEvents MenuItemSimplifiedChinese As MenuItem
    Private WithEvents MenuItemSpanish As MenuItem
    Private WithEvents MenuItemCustomLanguage As MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MainMenu As System.Windows.Forms.MainMenu
        Dim MainMenuItemSourceSelectionTest As System.Windows.Forms.MenuItem
        Dim MenuItemSeperator1 As System.Windows.Forms.MenuItem
        Dim MenuItemSeperator2 As System.Windows.Forms.MenuItem
        Dim MainMenuItemAcquireTest As System.Windows.Forms.MenuItem
        Dim MenuItemSeperator3 As System.Windows.Forms.MenuItem
        Dim MainMenuItemTWAINLogging As System.Windows.Forms.MenuItem
        Dim MainMenuItemLanguage As System.Windows.Forms.MenuItem
        Dim MainMenuItemHelp As System.Windows.Forms.MenuItem
        Me.MenuItemSelectSource = New System.Windows.Forms.MenuItem()
        Me.MenuItemSelectSourceByName = New System.Windows.Forms.MenuItem()
        Me.MenuItemSelectDefaultSource = New System.Windows.Forms.MenuItem()
        Me.MenuItemSelectSourceCustom = New System.Windows.Forms.MenuItem()
        Me.MenuItemSourceProperties = New System.Windows.Forms.MenuItem()
        Me.MenuItemCloseSource = New System.Windows.Forms.MenuItem()
        Me.MenuItemExitDemo = New System.Windows.Forms.MenuItem()
        Me.MenuItemAcquireNative = New System.Windows.Forms.MenuItem()
        Me.MenuItemAcquireBuffered = New System.Windows.Forms.MenuItem()
        Me.MenuItemAcquireFile = New System.Windows.Forms.MenuItem()
        Me.MenuItemAcquireFileUsingDriver = New System.Windows.Forms.MenuItem()
        Me.MenuItemShowPreview = New System.Windows.Forms.MenuItem()
        Me.MenuItemUseSourceUI = New System.Windows.Forms.MenuItem()
        Me.MenuItemDiscardBlankPages = New System.Windows.Forms.MenuItem()
        Me.MenuItemLoggingOptions = New System.Windows.Forms.MenuItem()
        Me.MenuItemDutch = New System.Windows.Forms.MenuItem()
        Me.MenuItemEnglish = New System.Windows.Forms.MenuItem()
        Me.MenuItemFrench = New System.Windows.Forms.MenuItem()
        Me.MenuItemGerman = New System.Windows.Forms.MenuItem()
        Me.MenuItemItalian = New System.Windows.Forms.MenuItem()
        Me.MenuItemPortuguese = New System.Windows.Forms.MenuItem()
        Me.MenuItemRomanian = New System.Windows.Forms.MenuItem()
        Me.MenuItemRussian = New System.Windows.Forms.MenuItem()
        Me.MenuItemSimplifiedChinese = New System.Windows.Forms.MenuItem()
        Me.MenuItemSpanish = New System.Windows.Forms.MenuItem()
        Me.MenuItemCustomLanguage = New System.Windows.Forms.MenuItem()
        Me.MenuItemDTWAINVersion = New System.Windows.Forms.MenuItem()
        MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        MainMenuItemSourceSelectionTest = New System.Windows.Forms.MenuItem()
        MenuItemSeperator1 = New System.Windows.Forms.MenuItem()
        MenuItemSeperator2 = New System.Windows.Forms.MenuItem()
        MainMenuItemAcquireTest = New System.Windows.Forms.MenuItem()
        MenuItemSeperator3 = New System.Windows.Forms.MenuItem()
        MainMenuItemTWAINLogging = New System.Windows.Forms.MenuItem()
        MainMenuItemLanguage = New System.Windows.Forms.MenuItem()
        MainMenuItemHelp = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MainMenuItemSourceSelectionTest, MainMenuItemAcquireTest, MainMenuItemTWAINLogging, MainMenuItemLanguage, MainMenuItemHelp})
        '
        'MainMenuItemSourceSelectionTest
        '
        MainMenuItemSourceSelectionTest.Index = 0
        MainMenuItemSourceSelectionTest.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemSelectSource, Me.MenuItemSelectSourceByName, Me.MenuItemSelectDefaultSource, Me.MenuItemSelectSourceCustom, MenuItemSeperator1, Me.MenuItemSourceProperties, MenuItemSeperator2, Me.MenuItemCloseSource, Me.MenuItemExitDemo})
        MainMenuItemSourceSelectionTest.Text = "&Source Selection Test"
        '
        'MenuItemSelectSource
        '
        Me.MenuItemSelectSource.Index = 0
        Me.MenuItemSelectSource.Text = "Select Source..."
        '
        'MenuItemSelectSourceByName
        '
        Me.MenuItemSelectSourceByName.Index = 1
        Me.MenuItemSelectSourceByName.Text = "Select Source By Name..."
        '
        'MenuItemSelectDefaultSource
        '
        Me.MenuItemSelectDefaultSource.Index = 2
        Me.MenuItemSelectDefaultSource.Text = "Select Default Source..."
        '
        'MenuItemSelectSourceCustom
        '
        Me.MenuItemSelectSourceCustom.Index = 3
        Me.MenuItemSelectSourceCustom.Text = "Select Source Custom..."
        '
        'MenuItemSeperator1
        '
        MenuItemSeperator1.Index = 4
        MenuItemSeperator1.Text = "-"
        '
        'MenuItemSourceProperties
        '
        Me.MenuItemSourceProperties.Index = 5
        Me.MenuItemSourceProperties.Text = "Source Properties..."
        '
        'MenuItemSeperator2
        '
        MenuItemSeperator2.Index = 6
        MenuItemSeperator2.Text = "-"
        '
        'MenuItemCloseSource
        '
        Me.MenuItemCloseSource.Index = 7
        Me.MenuItemCloseSource.Text = "Close Source..."
        '
        'MenuItemExitDemo
        '
        Me.MenuItemExitDemo.Index = 8
        Me.MenuItemExitDemo.Text = "Exit Demo"
        '
        'MainMenuItemAcquireTest
        '
        MainMenuItemAcquireTest.Index = 1
        MainMenuItemAcquireTest.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemAcquireNative, Me.MenuItemAcquireBuffered, Me.MenuItemAcquireFile, Me.MenuItemAcquireFileUsingDriver, MenuItemSeperator3, Me.MenuItemShowPreview, Me.MenuItemUseSourceUI, Me.MenuItemDiscardBlankPages})
        MainMenuItemAcquireTest.Text = "&Acquire Test"
        '
        'MenuItemAcquireNative
        '
        Me.MenuItemAcquireNative.Index = 0
        Me.MenuItemAcquireNative.Text = "Acquire Native..."
        '
        'MenuItemAcquireBuffered
        '
        Me.MenuItemAcquireBuffered.Index = 1
        Me.MenuItemAcquireBuffered.Text = "Acquire Buffered..."
        '
        'MenuItemAcquireFile
        '
        Me.MenuItemAcquireFile.Index = 2
        Me.MenuItemAcquireFile.Text = "Acquire File..."
        '
        'MenuItemAcquireFileUsingDriver
        '
        Me.MenuItemAcquireFileUsingDriver.Index = 3
        Me.MenuItemAcquireFileUsingDriver.Text = "Acquire File Using Driver..."
        '
        'MenuItemSeperator3
        '
        MenuItemSeperator3.Index = 4
        MenuItemSeperator3.Text = "-"
        '
        'MenuItemShowPreview
        '
        Me.MenuItemShowPreview.Checked = True
        Me.MenuItemShowPreview.Index = 5
        Me.MenuItemShowPreview.Text = "Show Preview"
        '
        'MenuItemUseSourceUI
        '
        Me.MenuItemUseSourceUI.Checked = True
        Me.MenuItemUseSourceUI.Index = 6
        Me.MenuItemUseSourceUI.Text = "Use Source UI"
        '
        'MenuItemDiscardBlankPages
        '
        Me.MenuItemDiscardBlankPages.Index = 7
        Me.MenuItemDiscardBlankPages.Text = "Discard Blank Pages"
        '
        'MainMenuItemTWAINLogging
        '
        MainMenuItemTWAINLogging.Index = 2
        MainMenuItemTWAINLogging.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemLoggingOptions})
        MainMenuItemTWAINLogging.Text = "&TWAIN Logging"
        '
        'MenuItemLoggingOptions
        '
        Me.MenuItemLoggingOptions.Index = 0
        Me.MenuItemLoggingOptions.Text = "Logging Options..."
        '
        'MainMenuItemLanguage
        '
        MainMenuItemLanguage.Index = 3
        MainMenuItemLanguage.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDutch, Me.MenuItemEnglish, Me.MenuItemFrench, Me.MenuItemGerman, Me.MenuItemItalian, Me.MenuItemPortuguese, Me.MenuItemRomanian, Me.MenuItemRussian, Me.MenuItemSimplifiedChinese, Me.MenuItemSpanish, Me.MenuItemCustomLanguage})
        MainMenuItemLanguage.Text = "Language"
        '
        'MenuItemDutch
        '
        Me.MenuItemDutch.Index = 0
        Me.MenuItemDutch.Text = "Dutch"
        '
        'MenuItemEnglish
        '
        Me.MenuItemEnglish.Index = 1
        Me.MenuItemEnglish.Text = "English"
        '
        'MenuItemFrench
        '
        Me.MenuItemFrench.Index = 2
        Me.MenuItemFrench.Text = "French"
        '
        'MenuItemGerman
        '
        Me.MenuItemGerman.Index = 3
        Me.MenuItemGerman.Text = "German"
        '
        'MenuItemItalian
        '
        Me.MenuItemItalian.Index = 4
        Me.MenuItemItalian.Text = "Italian"
        '
        'MenuItemPortuguese
        '
        Me.MenuItemPortuguese.Index = 5
        Me.MenuItemPortuguese.Text = "Portuguese"
        '
        'MenuItemRomanian
        '
        Me.MenuItemRomanian.Index = 6
        Me.MenuItemRomanian.Text = "Romanian"
        '
        'MenuItemRussian
        '
        Me.MenuItemRussian.Index = 7
        Me.MenuItemRussian.Text = "Russian"
        '
        'MenuItemSimplifiedChinese
        '
        Me.MenuItemSimplifiedChinese.Index = 8
        Me.MenuItemSimplifiedChinese.Text = "Simplified Chinese"
        '
        'MenuItemSpanish
        '
        Me.MenuItemSpanish.Index = 9
        Me.MenuItemSpanish.Text = "Spanish"
        '
        'MenuItemCustomLanguage
        '
        Me.MenuItemCustomLanguage.Index = 10
        Me.MenuItemCustomLanguage.Text = "Cusstom Language..."
        '
        'MainMenuItemHelp
        '
        MainMenuItemHelp.Index = 4
        MainMenuItemHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDTWAINVersion})
        MainMenuItemHelp.Text = "Help"
        '
        'MenuItemDTWAINVersion
        '
        Me.MenuItemDTWAINVersion.Index = 0
        Me.MenuItemDTWAINVersion.Text = "DTWAIN Version..."
        '
        'VB_FullDemo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(673, 357)
        Me.Menu = MainMenu
        Me.Name = "VB_FullDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTWAIN VB .NET Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private TwainOK As Integer
    Private TwainHandle As System.IntPtr
    Private Shared SelectedSource As System.IntPtr
    Private sOrigTitle As String
    Private Shared thisObject As VB_FullDemo
    Private dllExists As Boolean
    Private Shared cb As DTWAINAPI.DTwainCallback = New DTWAINAPI.DTwainCallback(AddressOf callbackfn)

    Private Sub VB_FullDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MenuItemSelectSource.Enabled = False
        dllExists = True
        sOrigTitle = Me.Text
        Try
            TwainOK = DTWAINAPI.DTWAIN_IsTwainAvailable()
        Catch ex As System.DllNotFoundException
            MessageBox.Show(ex.Message)
            dllExists = False
            Dispose()
        End Try
        SelectedSource = CType(0, IntPtr)
        If TwainOK <> 0 Then
            TwainHandle = DTWAINAPI.DTWAIN_SysInitialize()
            Me.MenuItemSelectSource.Enabled = True
            If TwainHandle <> CType(0, IntPtr) Then
                DTWAINAPI.DTWAIN_EnableMsgNotify(1)
                DTWAINAPI.DTWAIN_SetCallback(cb, 0)
            Else
                Application.Exit()
            End If
        End If
        EnableSourceItems(False)
    End Sub

    Public Shared Function callbackfn(ByVal wparam As Integer, ByVal lparam As Integer, ByVal userval As Integer) As Integer
        Select Case wparam
            Case DTWAINAPI.DTWAIN_TN_QUERYPAGEDISCARD
                If thisObject.MenuItemShowPreview.Checked Then
                    Dim sDIBDlg As New DibDisplayerDlg2(DTWAINAPI.DTWAIN_GetCurrentAcquiredImage(SelectedSource))
                    If sDIBDlg.ShowDialog() = DialogResult.Cancel Then
                        Return 0
                    End If
                End If
                Exit Select
        End Select
        Return 1
    End Function

    Private Sub SetCaptionToSourceName()
        Dim SourceName As New StringBuilder(256)
        Dim sTitle As New StringBuilder
        sTitle.Append(sOrigTitle)
        If SelectedSource <> CType(0, IntPtr) Then
            DTWAINAPI.DTWAIN_GetSourceProductName(SelectedSource, SourceName, 255)
            sTitle.Append(" - ")
            sTitle.Append(SourceName)
            Me.Text = sTitle.ToString
        Else
            Me.Text = sOrigTitle
        End If
    End Sub

    Private Sub SelectTheSource(ByVal nWhich As Long)
        Dim nReturn As Long
        If SelectedSource <> CType(0, IntPtr) Then
            nReturn = MessageBox.Show("For this demo, only one Source can be opened.  Close current Source?", "DTWAIN Message", MessageBoxButtons.YesNo)
            If nReturn = DialogResult.Yes Then
                DTWAINAPI.DTWAIN_CloseSource(SelectedSource)
                SelectedSource = CType(0, IntPtr)
            Else
                Return
            End If
        End If
        Me.Enabled = False
        Select Case nWhich
            Case 0
                Dim nullString As String
                nullString = CStr(IntPtr.Zero)
                SelectedSource = DTWAINAPI.DTWAIN_SelectSource2A(IntPtr.Zero, Nothing, 0, 0,
                                                                DTWAINAPI.DTWAIN_DLG_CENTER_SCREEN Or DTWAINAPI.DTWAIN_DLG_TOPMOSTWINDOW)
            Case 1
                Dim objSelectSourceByName As SelectSourceByName = New SelectSourceByName()
                Dim nResult As DialogResult = objSelectSourceByName.ShowDialog()
                If nResult = DialogResult.OK Then
                    SelectedSource = DTWAINAPI.DTWAIN_SelectSourceByName(objSelectSourceByName.GetText())
                End If
            Case 2
                SelectedSource = DTWAINAPI.DTWAIN_SelectDefaultSource
            Case 3
                Dim customSourceDlg As New CustomSelectSource()
                Dim dResult As DialogResult = customSourceDlg.ShowDialog()
                If dResult = DialogResult.OK Then
                    SelectedSource = DTWAINAPI.DTWAIN_SelectSourceByName(customSourceDlg.GetSourceName())
                End If
        End Select
        Me.Enabled = True
        If SelectedSource <> CType(0, IntPtr) Then
            If DTWAINAPI.DTWAIN_OpenSource(SelectedSource) <> 0 Then
                DTWAINAPI.DTWAIN_EnableFeeder(SelectedSource, 1)
                SetCaptionToSourceName()
                EnableSourceItems(True)
                Return
            Else
                MessageBox.Show("Error Opening selected Source", "TWAIN Error", MessageBoxButtons.OK)
                SetCaptionToSourceName()
                EnableSourceItems(False)
            End If
        Else
            Dim lastError As Integer
            lastError = DTWAINAPI.DTWAIN_GetLastError()
            If lastError = DTWAINAPI.DTWAIN_ERR_SOURCESELECTION_CANCELED Then
                MessageBox.Show("Source selection canceled", "TWAIN Info", MessageBoxButtons.OK)
            Else
                Dim szErr As StringBuilder = New StringBuilder(100)
                DTWAINAPI.DTWAIN_GetErrorString(lastError, szErr, 100)
                MessageBox.Show("Error Selecting and/or opening Source.\r\n" + szErr.ToString(), "TWAIN Error", MessageBoxButtons.OK)
            End If
            SetCaptionToSourceName()
            EnableSourceItems(False)
        End If
    End Sub


    Public Function GetImageFromClipboard() As Image
        If Not Clipboard.GetDataObject() Is Nothing Then
            Dim dobj As IDataObject = Clipboard.GetDataObject()
            If dobj.GetDataPresent(DataFormats.Bitmap) Then
                Dim img_obj As Object = dobj.GetData(DataFormats.Bitmap)
                Return CType(img_obj, Bitmap)
            End If
        End If
    End Function


    Private Sub GenericAcquire(ByVal nWhich As Integer)
        If SelectedSource <> CType(0, IntPtr) Then
            Dim isChecked As Integer
            Dim isUI As Integer
            isChecked = 0
            isUI = 0
            If MenuItemDiscardBlankPages.Checked Then
                isChecked = 1
            End If
            If MenuItemUseSourceUI.Checked Then
                isUI = 1
            End If

            DTWAINAPI.DTWAIN_SetBlankPageDetection(SelectedSource, 98.5, DTWAINAPI.DTWAIN_BP_AUTODISCARD_ANY, isChecked)
            Dim acquireArray As System.IntPtr = DTWAINAPI.DTWAIN_CreateAcquisitionArray()
            Me.Enabled = False
            Dim status As Integer = 0
            Dim returnVal As Integer = 0
            If nWhich = 0 Then
                returnVal = DTWAINAPI.DTWAIN_AcquireNativeEx(SelectedSource, DTWAINAPI.DTWAIN_PT_DEFAULT, DTWAINAPI.DTWAIN_ACQUIREALL, isUI, 0, acquireArray, status)
            Else
                returnVal = DTWAINAPI.DTWAIN_AcquireBufferedEx(SelectedSource, DTWAINAPI.DTWAIN_PT_DEFAULT, DTWAINAPI.DTWAIN_ACQUIREALL, isUI, 0, acquireArray, status)
            End If

            If returnVal = 0 Then
                If status = DTWAINAPI.DTWAIN_TN_ACQUIRECANCELLED Then
                    MessageBox.Show("No Images acquired", "TWAIN Information")
                Else
                    Dim errorVal As Integer = DTWAINAPI.DTWAIN_GetLastError()
                    Dim errorString As StringBuilder = New StringBuilder(256)
                    DTWAINAPI.DTWAIN_GetErrorString(errorVal, errorString, 255)
                    MessageBox.Show(errorString.ToString(), "TWAIN Information")
                End If
                Me.Enabled = True
                Return
            End If

            Dim nCount As Integer = DTWAINAPI.DTWAIN_GetNumAcquisitions(acquireArray)
            If nCount = 0 Then
                MessageBox.Show("No Images acquired", "TWAIN Information")
                Me.Enabled = True
                Return
            End If

            Dim sDIBDlg As DibDisplayerDlg = New DibDisplayerDlg(acquireArray)
            sDIBDlg.ShowDialog()
            Me.Enabled = True
        End If
    End Sub

    Private Sub AcquireToFile(ByVal nWhich As Integer)
        If SelectedSource <> CType(0, IntPtr) Then
            Dim status As Integer = 0
            Dim bError As Integer = 0
            Dim FileFlags As Long = 0
            Dim tFileName As String = ""
            Dim fileType As Integer = 0
            Select Case nWhich
                Case 0
                    FileFlags = DTWAINAPI.DTWAIN_USELONGNAME Or DTWAINAPI.DTWAIN_USENATIVE
                    DTWAINAPI.DTWAIN_SetBlankPageDetection(SelectedSource, 98.5, CInt(DTWAINAPI.DTWAIN_BP_AUTODISCARD_ANY), IsDiscardPages())
                    Dim fDlg As New FileTypeDlg()
                    fDlg.ShowDialog()
                    tFileName = fDlg.GetFileName()
                    Dim szSourceName As New StringBuilder(tFileName)
                    fileType = fDlg.GetFileType()
                    Exit Select

                Case 1
                    If DTWAINAPI.DTWAIN_IsFileXferSupported(SelectedSource, DTWAINAPI.DTWAIN_ANYSUPPORT) = 0 Then
                        MessageBox.Show("Sorry.  The selected driver does Not have built-in file transfer support.")
                        Return
                    End If
                    If DTWAINAPI.DTWAIN_IsFileXferSupported(SelectedSource, DTWAINAPI.DTWAIN_FF_BMP) = 0 Then
                        Dim sText As String = "Sorry.  This demo program only supports built-in BMP file transfers." & vbCr & vbLf
                        sText += "However, the DTWAIN library will support all built-in formats if your driver" & vbCr & vbLf
                        sText += "supports other formats."
                        MessageBox.Show(sText)
                        Return
                    End If
                    FileFlags = DTWAINAPI.DTWAIN_USESOURCEMODE Or DTWAINAPI.DTWAIN_USELONGNAME
                    fileType = DTWAINAPI.DTWAIN_FF_BMP
                    tFileName = ".\IMAGE.BMP"
                    MessageBox.Show("The name of the image file that will be saved is IMAGE.BMP" & vbLf)
                    Exit Select
            End Select

            ' Use default 
            ' Get all pages 
            ' Close Source when UI is closed 
            Me.Enabled = False
            bError = DTWAINAPI.DTWAIN_AcquireFile(SelectedSource, tFileName, fileType, CInt(FileFlags + DTWAINAPI.DTWAIN_CREATE_DIRECTORY), DTWAINAPI.DTWAIN_PT_DEFAULT, DTWAINAPI.DTWAIN_ACQUIREALL, IsSourceUI(), 1, status)
            Me.Enabled = True

            If bError = 0 Then
                If status = DTWAINAPI.DTWAIN_TN_ACQUIRECANCELLED Then
                    MessageBox.Show("No Images acquired", "TWAIN Information")
                Else
                    Dim errorVal As Integer = DTWAINAPI.DTWAIN_GetLastError()
                    Dim errorString As StringBuilder = New StringBuilder(256)
                    DTWAINAPI.DTWAIN_GetErrorString(errorVal, errorString, 255)
                    MessageBox.Show(errorString.ToString(), "TWAIN Information")
                End If
                Return
            End If
            If DTWAINAPI.DTWAIN_GetSavedFilesCount(SelectedSource) = 0 Then
                MessageBox.Show("No files were saved")
            Else
                MessageBox.Show("Image file saved successfully")
            End If
        End If
    End Sub

    Private Sub ExitApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExitDemo.Click
        Dispose(True)
    End Sub


    Private Sub SourceProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSourceProperties.Click
        If SelectedSource <> CType(0, IntPtr) Then
            Dim sPropDlg As SourcePropertiesDlg
            sPropDlg = New SourcePropertiesDlg(SelectedSource)
            sPropDlg.ShowDialog()
        End If
    End Sub

    Private Sub SelectSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelectSource.Click
        SelectTheSource(0)
        Focus()
    End Sub

    Private Sub SelectSourceByName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelectSourceByName.Click
        SelectTheSource(1)
        Focus()
    End Sub

    Private Sub SelectSourceCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelectSourceCustom.Click
        SelectTheSource(3)
        Focus()
    End Sub

    Private Sub SelectDefaultSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelectDefaultSource.Click
        SelectTheSource(2)
        Focus()
    End Sub

    Private Sub CloseSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCloseSource.Click
        If SelectedSource <> CType(0, IntPtr) Then
            DTWAINAPI.DTWAIN_CloseSource(SelectedSource)
            SelectedSource = CType(0, IntPtr)
            SetCaptionToSourceName()
            EnableSourceItems(False)
        End If
    End Sub

    Private Sub EnableSourceItems(ByVal bEnable As Boolean)
        MenuItemSourceProperties.Enabled = bEnable
        MenuItemCloseSource.Enabled = bEnable
        MenuItemAcquireNative.Enabled = bEnable
        MenuItemAcquireBuffered.Enabled = bEnable
        MenuItemAcquireFile.Enabled = bEnable
        MenuItemAcquireFileUsingDriver.Enabled = bEnable
    End Sub

    Private Function IsDiscardPages() As Integer
        If MenuItemDiscardBlankPages.Enabled Then
            Return 1
        End If
        Return 0
    End Function

    Private Function IsSourceUI() As Integer
        If MenuItemUseSourceUI.Checked Then
            Return 1
        End If
        Return 0
    End Function

    Private Sub LoadLanguage(ByVal lang As String)
        Dim retVal As Integer
        retVal = DTWAINAPI.DTWAIN_LoadCustomStringResources(lang)
        If retVal = 0 Then
            MessageBox.Show("Error loading custom resource " + lang)
        Else
            MessageBox.Show("Language " + " loaded successfully.  Select a Source or choose Logging/Log To Console to see the results")
        End If
    End Sub









    Private Sub SourceSelectionTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AcquireTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItemAcquireBuffered.Click, MenuItemAcquireNative.Click, MenuItemAcquireFile.Click,
        MenuItemUseSourceUI.Click, MenuItemAcquireFileUsingDriver.Click, MenuItemShowPreview.Click, MenuItemDiscardBlankPages.Click

        Select Case True
            Case sender Is MenuItemAcquireBuffered
                Me.Enabled = False
                Dim Status As Integer
                If SelectedSource <> CType(0, IntPtr) Then
                    If CBool(DTWAINAPI.DTWAIN_AcquireToClipboard(SelectedSource, DTWAINAPI.DTWAIN_PT_DEFAULT, DTWAINAPI.DTWAIN_ACQUIREALL, DTWAINAPI.DTWAIN_USENATIVE, 1, 1, 0, Status)) Then
                        'setting clipboard data to picturebox 
                        Me.Focus()
                    End If
                End If
                Me.Enabled = True

            Case sender Is MenuItemAcquireNative : GenericAcquire(0)
            Case sender Is MenuItemAcquireFile
                Dim Dlg As New FileTypeDlg()
                Dlg.ShowDialog()
                Dim FileName As String = Dlg.GetFileName()
                Dim FileType As Integer = Dlg.GetFileType()
                If FileType = -1 Then
                    Return
                End If
                Me.Enabled = False
                Dim Status As Integer
                If SelectedSource <> CType(0, IntPtr) Then
                    If CBool(DTWAINAPI.DTWAIN_AcquireFile(SelectedSource, FileName, FileType,
                                            DTWAINAPI.DTWAIN_USENATIVE + DTWAINAPI.DTWAIN_USELONGNAME + DTWAINAPI.DTWAIN_CREATE_DIRECTORY,
                                            DTWAINAPI.DTWAIN_PT_DEFAULT, DTWAINAPI.DTWAIN_ACQUIREALL, 1, 0, Status)) Then
                        MsgBox(FileName + " has been created")
                    Else
                        Dim numFiles As Integer
                        numFiles = DTWAINAPI.DTWAIN_GetSavedFilesCount(SelectedSource)
                        If numFiles = 0 Then
                            MessageBox.Show("No files were acquired", "TWAIN Info", MessageBoxButtons.OK)
                        End If
                    End If
                End If
                Me.Enabled = True

            Case sender Is MenuItemUseSourceUI : MenuItemUseSourceUI.Checked = Not MenuItemUseSourceUI.Checked
            Case sender Is MenuItemAcquireFileUsingDriver : AcquireToFile(1)
            Case sender Is MenuItemShowPreview : MenuItemShowPreview.Checked = Not MenuItemShowPreview.Checked
            Case sender Is MenuItemDiscardBlankPages : MenuItemDiscardBlankPages.Checked = Not MenuItemDiscardBlankPages.Checked
        End Select

    End Sub

    Private Sub MenuItemLoggingOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItemLoggingOptions.Click

        Dim LogFlags As Long = DTWAINAPI.DTWAIN_LOG_ALL And Not DTWAINAPI.DTWAIN_LOG_ERRORMSGBOX
        Dim logDlg As New LogFileSelectionDlg(1)
        Dim nResult As DialogResult = logDlg.ShowDialog()

        If nResult = DialogResult.OK Then
            Dim debugOption As Integer = logDlg.GetDebugOption()
            DTWAINAPI.DTWAIN_SetTwainLog(0, "")

            Select Case debugOption
                Case 0
                    Exit Select
                Case 1
                    Exit Select
                Case 2
                    DTWAINAPI.DTWAIN_SetTwainLog(CUInt(LogFlags Or DTWAINAPI.DTWAIN_LOG_USEFILE), logDlg.GetFileName())
                    Exit Select
                Case 3
                    DTWAINAPI.DTWAIN_SetTwainLog(CUInt(LogFlags Or DTWAINAPI.DTWAIN_LOG_CONSOLE), "")
                    Exit Select
            End Select

        End If

    End Sub

    Private Sub MenuItemLanguage_Click(sender As Object, e As EventArgs) _
        Handles MenuItemSpanish.Click, MenuItemCustomLanguage.Click, MenuItemSimplifiedChinese.Click,
        MenuItemRussian.Click, MenuItemRomanian.Click, MenuItemPortuguese.Click, MenuItemItalian.Click,
        MenuItemGerman.Click, MenuItemFrench.Click, MenuItemEnglish.Click, MenuItemDutch.Click

        Select Case True
            Case sender Is MenuItemDutch : LoadLanguage("dutch")
            Case sender Is MenuItemEnglish : LoadLanguage("english")
            Case sender Is MenuItemFrench : LoadLanguage("french")
            Case sender Is MenuItemGerman : LoadLanguage("german")
            Case sender Is MenuItemItalian : LoadLanguage("italian")
            Case sender Is MenuItemPortuguese : LoadLanguage("portuguese")
            Case sender Is MenuItemRomanian : LoadLanguage("romanian")
            Case sender Is MenuItemRussian : LoadLanguage("russian")
            Case sender Is MenuItemSimplifiedChinese : LoadLanguage("simplified_chinese")
            Case sender Is MenuItemSpanish : LoadLanguage("spanish")
            Case sender Is MenuItemCustomLanguage
                Dim objCustomLanguage As CustomLanguageDlg = New CustomLanguageDlg()
                Dim nResult As DialogResult = objCustomLanguage.ShowDialog()
                If nResult = DialogResult.OK Then
                    LoadLanguage(objCustomLanguage.GetText())
                End If
        End Select

    End Sub

    Private Sub MenuItemDTWAINVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItemDTWAINVersion.Click

        Dim aDlg As New AboutDlg()
        aDlg.ShowDialog()

    End Sub

End Class
