Imports System.Configuration
Imports System.Data.SqlClient


Public Class fmdangnhap
    'Khai báo biến toàn cục để kết nối với Database'
    Private _ConnectionString As String = ConfigurationSettings.AppSettings("MyconnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    'Định nghĩa hàm lấy dữ liệu đỗ vào table
    Private Function getdatatable(sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        'khoi tao bien conn
        conn = New SqlConnection(_ConnectionString)

        'khởi tạo biến DA
        da = New SqlDataAdapter(sqlQuery, conn)

        Try

            'Mở connection
            conn.Open()

            'Đổ dữ liệu và dTable
            da.Fill(dtable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") 'Thông báo nếu có lỗi xảy ra

        Finally
            conn.Close() 'Đóng Connection
        End Try

        Return dtable

    End Function

    ' Định nghĩa hàm kiểm tra username và password nhập vào
    Private Function CheckLogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("select * from dbo.Account where username = '{0}' and password = '{1}'", user, pass)
        Dim dtable As DataTable = getdatatable(sqlQuery)
        Return dtable.Rows.Count > 0
    End Function


    'Định nghĩa hàm kiểm tra user và pass nhập vào có rỗng hay không
    Private Function isempty() As Boolean
        'Hàm trả về True nếu Username hoặc Pass rỗng
        Return String.IsNullOrEmpty(Me.txtTK.Text) OrElse String.IsNullOrEmpty(Me.txtMK.Text)


    End Function

    Private Sub bntDangNhap_Click(sender As Object, e As EventArgs) Handles bntDangNhap.Click
        'Kiểm tra Username và Password có đúng hay không
        If isempty() Then
            MessageBox.Show("Username, password canot be empty!!")
        Else
            If CheckLogin(Me.txtTK.Text.ToLower, Me.txtMK.Text.ToLower) Then ' Đăng nhập thành công
                Me.DialogResult = DialogResult.OK
                MessageBox.Show("login succesful")
                Me.Close()

            Else 'Trường hợp sai Password

                MessageBox.Show("Username of password is incorrect")

            End If
        End If
    End Sub

    Private Sub bntthoat_Click(sender As Object, e As EventArgs) Handles bntthoat.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
