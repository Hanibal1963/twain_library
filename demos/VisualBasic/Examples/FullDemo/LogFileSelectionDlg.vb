Public Class LogFileSelectionDlg

    Private sFileName As String
    Private nWhichOption As Integer

    Public Sub New(ByVal item As Integer)
        Me.nWhichOption = 1
        Me.InitializeComponent() ' This call is required by the Windows Form Designer.
    End Sub

    Public Function GetDebugOption() As Integer
        Return Me.nWhichOption
    End Function

    Public Function GetFileName() As String
        Return Me.sFileName
    End Function

    Private Sub RadioLogToFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioLogToFile.CheckedChanged
        Me.edFileName.Enabled = Me.radioLogToFile.Checked
    End Sub

    Private Sub OKbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKbutton.Click
        If Me.radioLogToFile.Checked Then
            Me.sFileName = Me.edFileName.Text
            Me.nWhichOption = 2
        ElseIf Me.radioLogConsole.Checked Then
            Me.nWhichOption = 3
        End If
    End Sub

    Private Sub LogFileSelectionDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioLogDebugMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles radioLogConsole.CheckedChanged

    End Sub
End Class
