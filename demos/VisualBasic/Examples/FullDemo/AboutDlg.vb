
Public Class AboutDlg : Inherits System.Windows.Forms.Form

    Private Sub OK_Button_Click(sender As Object, e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AboutDlg_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Dim nChars As Integer = DTWAINAPI.DTWAIN_GetVersionInfo(Nothing, -1)
        Dim szInfo As New System.Text.StringBuilder(nChars)
        Dim unused As Integer = DTWAINAPI.DTWAIN_GetVersionInfo(szInfo, nChars)
        Me.EdInfo.Text = szInfo.ToString()
        Me.EdInfo.Text = Me.EdInfo.Text.Replace(vbLf, vbCrLf)

    End Sub

#Region "Windows Form Designer generated code "

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private ReadOnly components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OKbutton = New System.Windows.Forms.Button
        Me.EdInfo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'OKbutton
        '
        Me.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKbutton.Location = New System.Drawing.Point(137, 279)
        Me.OKbutton.Name = "OKbutton"
        Me.OKbutton.Size = New System.Drawing.Size(75, 23)
        Me.OKbutton.TabIndex = 7
        Me.OKbutton.Text = "OK"
        Me.OKbutton.UseVisualStyleBackColor = True
        '
        'edInfo
        '
        Me.EdInfo.BackColor = System.Drawing.SystemColors.Control
        Me.EdInfo.Location = New System.Drawing.Point(23, 72)
        Me.EdInfo.Multiline = True
        Me.EdInfo.Name = "edInfo"
        Me.EdInfo.ReadOnly = True
        Me.EdInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.EdInfo.Size = New System.Drawing.Size(301, 201)
        Me.EdInfo.TabIndex = 6
        Me.EdInfo.TabStop = False
        '
        'label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DTWAIN Info:"
        '
        'label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 8)
        Me.Label1.Name = "label1"
        Me.Label1.Size = New System.Drawing.Size(231, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DynaRithmic TWAIN Library Visual Basic Demo"
        '
        'AboutDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 317)
        Me.Controls.Add(Me.OKbutton)
        Me.Controls.Add(Me.EdInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DTWAIN Visual Basic Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents OKbutton As System.Windows.Forms.Button
    Private WithEvents EdInfo As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label

#End Region

End Class
