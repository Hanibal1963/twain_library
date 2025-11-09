
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class DibDisplayerDlg
    Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private AcquireArray As System.IntPtr
    Private nCurrentAcquisition As Integer
    Private nCurDib As Integer
    Private Structure DibInfo
        Public acquisition As Integer
        Public pageNum As Integer
    End Structure

    Private DibDictionary As Dictionary(Of DibInfo, Bitmap) = New Dictionary(Of DibInfo, Bitmap)

    Public Sub New(ByVal item As System.IntPtr)
        Me.InitializeComponent() ' This call is required by the Windows Form Designer.
        Me.AcquireArray = item
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DisplayTheDib()
        Dim keyCurrent As New DibInfo()
        Dim dib As System.IntPtr
        keyCurrent.pageNum = Me.nCurDib
        keyCurrent.acquisition = Me.nCurrentAcquisition
        If Me.DibDictionary.ContainsKey(keyCurrent) Then
            Me.dibBox.Image = Me.DibDictionary.Item(keyCurrent)
        Else
            dib = DTWAINAPI.DTWAIN_GetAcquiredImage(Me.AcquireArray, Me.nCurrentAcquisition, Me.nCurDib)
            If dib <> CType(0, IntPtr) Then
                Me.dibBox.Image = BitmapFromDIB(dib)
                Me.DibDictionary.Add(keyCurrent, CType(Me.dibBox.Image, Bitmap))
            Else
                Dim unused As DialogResult = MessageBox.Show("Image was discarded or not available", "Image not available")
            End If
        End If
        Me.EnablePageButtons()
    End Sub

    Private Shared Function BitmapFromDIB(ByVal pDIB As IntPtr) As Bitmap
        Return Bitmap.FromHbitmap(DTWAINAPI.DTWAIN_ConvertDIBToBitmap(pDIB, System.IntPtr.Zero), System.IntPtr.Zero)
    End Function

    Private Sub EnablePageButtons()
        Dim nCount As Integer = DTWAINAPI.DTWAIN_GetNumAcquiredImages(Me.AcquireArray, Me.nCurrentAcquisition)
        Me.buttonNext.Enabled = Me.nCurDib < nCount - 1
        Me.buttonPrev.Enabled = Me.nCurDib > 0

        If nCount = 0 Then
        Else
            Dim sDib As Integer = Me.nCurDib + 1
            Me.edPageCurrent.Text = sDib.ToString()
            Me.edPageTotal.Text = nCount.ToString()
        End If
    End Sub
    Private Sub DibDisplayerDlg_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        For Each pair As KeyValuePair(Of DibInfo, Bitmap) In Me.DibDictionary
            Dim unused1 As Boolean = DeleteObject(pair.Value.GetHbitmap())
        Next
        Dim unused As Integer = DTWAINAPI.DTWAIN_DestroyAcquisitionArray(Me.AcquireArray, 1)
    End Sub

    Private Sub DibDisplayerDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.nCurrentAcquisition = 0
        Me.nCurDib = 0
        Dim nCount As Integer = DTWAINAPI.DTWAIN_GetNumAcquisitions(Me.AcquireArray)
        For i As Integer = 1 To nCount
            Dim unused As Integer = Me.cmbAcquisition.Items.Add(i.ToString())
            Me.cmbAcquisition.SelectedIndex = 0
        Next i
        Me.DisplayTheDib()
    End Sub

    Private Sub ButtonNext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonNext.Click
        Me.nCurDib += 1
        Me.DisplayTheDib()
    End Sub

    Private Sub ButtonPrev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPrev.Click
        Me.nCurDib -= 1
        Me.DisplayTheDib()
    End Sub

    Private Sub CmbAcquisition_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAcquisition.SelectedIndexChanged
        If Me.cmbAcquisition.SelectedIndex <> Me.nCurrentAcquisition Then
            Me.nCurrentAcquisition = Me.cmbAcquisition.SelectedIndex
            Me.nCurDib = 0
            Me.DisplayTheDib()
        End If
    End Sub
End Class
