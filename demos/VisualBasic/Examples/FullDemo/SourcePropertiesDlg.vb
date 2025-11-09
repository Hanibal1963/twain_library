Option Strict Off

Imports System.Text


Public Class SourcePropertiesDlg

    Private m_Source As System.IntPtr

    Public Sub New(ByVal item As System.IntPtr)
        Me.InitializeComponent() ' This call is required by the Windows Form Designer.
        Me.m_Source = item
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SourcePropertiesDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim szInfo As New System.Text.StringBuilder(256)
        Dim szInfoName As New System.Text.StringBuilder(256)
        Dim unused13 = DTWAINAPI.DTWAIN_GetSourceProductName(Me.m_Source, szInfoName, 255)
        Me.edProductName.Text = szInfoName.ToString()
        Dim unused12 = DTWAINAPI.DTWAIN_GetSourceProductFamily(Me.m_Source, szInfo, 255)
        Me.edFamilyName.Text = szInfo.ToString()
        Dim unused11 = DTWAINAPI.DTWAIN_GetSourceManufacturer(Me.m_Source, szInfo, 255)
        Me.edManufacturer.Text = szInfo.ToString()
        Dim unused10 = DTWAINAPI.DTWAIN_GetSourceVersionInfo(Me.m_Source, szInfo, 255)
        Me.edVersionInfo.Text = szInfo.ToString()

        Dim lMajor As Integer
        Dim lMinor As Integer
        lMajor = 0
        lMinor = 0
        Dim unused9 = DTWAINAPI.DTWAIN_GetSourceVersionNumber(Me.m_Source, lMajor, lMinor)
        Dim sVersion As String
        sVersion = lMajor.ToString() + "." + lMinor.ToString()
        Me.edVersion.Text = sVersion

        Dim AllCaps As System.IntPtr
        Dim Val As Integer
        Dim unused8 = DTWAINAPI.DTWAIN_EnumSupportedCaps(Me.m_Source, AllCaps)
        Dim nSize As Integer
        nSize = DTWAINAPI.DTWAIN_ArrayGetCount(AllCaps)
        For i As Integer = 0 To nSize - 1
            Dim unused7 = DTWAINAPI.DTWAIN_ArrayGetAtLong(AllCaps, i, Val)
            Dim unused6 = DTWAINAPI.DTWAIN_GetNameFromCap(Val, szInfo, 255)
            Dim unused5 = Me.listCaps.Items.Add(szInfo.ToString())
        Next i

        Me.edTotalCaps.Text = nSize.ToString()
        Dim unused4 = DTWAINAPI.DTWAIN_EnumCustomCaps(Me.m_Source, AllCaps)
        Me.edCustomCaps.Text = DTWAINAPI.DTWAIN_ArrayGetCount(AllCaps).ToString()
        Dim unused3 = DTWAINAPI.DTWAIN_EnumExtendedCaps(Me.m_Source, AllCaps)
        Me.edExtendedCaps.Text = DTWAINAPI.DTWAIN_ArrayGetCount(AllCaps).ToString()

        Dim customDSLength As UInteger
        Dim jsonLength As Integer
        Dim enc8 As Encoding = Encoding.UTF8
        Dim unused2 = DTWAINAPI.DTWAIN_GetCustomDSData(Me.m_Source, Nothing, 0, customDSLength, DTWAINAPI.DTWAINGCD_COPYDATA)
        Dim szCustomData(customDSLength) As Byte
        Dim unused1 = DTWAINAPI.DTWAIN_GetCustomDSData(Me.m_Source, szCustomData, customDSLength, customDSLength, DTWAINAPI.DTWAINGCD_COPYDATA)
        Dim contents As String
        contents = enc8.GetString(szCustomData, 0, customDSLength)
        Me.txtDSData.Text = contents
        Dim sName As String
        sName = szInfoName.ToString()
        jsonLength = DTWAINAPI.DTWAIN_GetSourceDetails(sName, Nothing, 0, 2, 1)
        szInfo = New StringBuilder(jsonLength)
        Dim unused = DTWAINAPI.DTWAIN_GetSourceDetails(sName, szInfo, jsonLength, 2, 1)

        ' Convert string to one with /r/n, since these are the types of strings for edit controls
        Dim sNewData As String = szInfo.ToString().Replace(vbLf, vbCrLf)
        Me.txtJSON.Text = sNewData
    End Sub
End Class
