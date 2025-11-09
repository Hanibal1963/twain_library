Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class DibDisplayerDlg2
    Private theDib As System.IntPtr
    Private curBMP As Bitmap
    Declare Auto Function DeleteObject Lib "gdi32.dll" (hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean


    Public Sub New(ByVal item As System.IntPtr)
        Me.InitializeComponent() ' This call is required by the Windows Form Designer.
        Me.theDib = item
    End Sub

    Private Sub DisplayTheDib()
        Me.dibBox2.Image = Bitmap.FromHbitmap(DTWAINAPI.DTWAIN_ConvertDIBToBitmap(Me.theDib, System.IntPtr.Zero), System.IntPtr.Zero)
        Me.curBMP = CType(Me.dibBox2.Image, Bitmap)
    End Sub

    Private Sub DibDisplayerDlg2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DisplayTheDib()
    End Sub

    Private Sub DibDisplayerDlg2_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim unused As Boolean = DeleteObject(Me.curBMP.GetHbitmap())
    End Sub

End Class

