

Public Class fmquanlysinhvien
    'khai bao bien nhan ket qua tra ve cua form login
    Private _loginresult As DialogResult

    Private Sub fmquanlysinhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _loginresult <> DialogResult.OK Then
            Me.Close() 'dong main form neu nguoi dung click cancel
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New fmdangnhap
        frm.ShowDialog()
        _loginresult = frm.DialogResult

    End Sub
End Class