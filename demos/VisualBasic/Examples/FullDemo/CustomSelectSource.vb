Public Class CustomSelectSource
    Private sourceSelected As Boolean
    Private sSourceName As String
    Public Function IsSourceSelected() As Boolean
        Return Me.sourceSelected
    End Function
    Public Function GetSourceName() As String
        Return Me.sSourceName
    End Function

    Private Sub CustomSelectSource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.sourceSelected = False
        Dim SourceArray As System.IntPtr
        Dim unused3 As Integer = DTWAINAPI.DTWAIN_EnumSources(SourceArray)
        Dim nCount As Integer = DTWAINAPI.DTWAIN_ArrayGetCount(SourceArray)

        If nCount <= 0 Then
            Me.Close()
        End If

        ' Display the sources
        Dim CurSource As System.IntPtr
        For i As Integer = 0 To nCount - 1
            Dim szName As New System.Text.StringBuilder(256)
            Dim unused2 As Integer = DTWAINAPI.DTWAIN_ArrayGetSourceAt(SourceArray, i, CurSource)
            Dim unused1 As Integer = DTWAINAPI.DTWAIN_GetSourceProductName(CurSource, szName, 255)
            Dim unused As Integer = Me.listSources.Items.Add(szName.ToString())
        Next

        If Me.listSources.Items.Count > 0 Then
            Me.listSources.SelectedIndex = 0
            ' Display Info about sources
            Dim sText As String = nCount.ToString() & " TWAIN Source(s) Available for Selection"
            Me.editSourceInfo.Text = sText
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Me.sSourceName = Me.listSources.SelectedItem.ToString()
        Me.sourceSelected = True
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.sourceSelected = False
        Me.Close()
    End Sub
End Class
