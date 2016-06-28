Public Class fmsinhvien

    'Khai báo biến truy xuất DB từ lớp DBAccess
    Private _DBAccess As New DataBaseAccess




    'Định nghĩa hàm thêm bản ghi sinh viên vào database
    Private Function insertStudent() As Boolean
        Dim sqlQuery As String = "insert into thongtinsv (MSSV,HoTen,SDT,DiaChi,MaLop)"
        sqlQuery += String.Format("values ('{0}',N'{1}',N'{2}',N'{3}','{4}')", txtmssv.Text, txthoten.Text, txtdienthoai.Text, txtdienthoai.Text, txtmalop.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Định nghĩa hàm update
    Private Function updatesinhvien() As Boolean
        Dim sqlquery As String = String.Format("update thongtinsv set HoTen = N'{0}', SDT=N'{1}', DiaChi =N'{2}' where MSSV = '{3}'",
                                               Me.txthoten.Text, Me.txtdienthoai.Text, Me.txtdiachi.Text, Me.txtmssv.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function

    'Khai báo biến để biết trạng thái edit hay insert
    Private _isedit As Boolean = False

    Public Sub New(isedit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isedit = isedit
    End Sub


    'Định nghĩa hàm kiểm tra giá trị trước khi insert dữ liệu vào database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtmssv.Text) OrElse String.IsNullOrEmpty(txthoten.Text) OrElse
            String.IsNullOrEmpty(txtdienthoai.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse
            String.IsNullOrEmpty(txtmalop.Text))

    End Function



    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If IsEmpty() Then 'kiểm tra trường dữ liệu trước khi thực hiện Add, Edit
            MessageBox.Show("Hãy nhập giá trị trước khi ghi vào Database", "ERROR", MessageBoxButtons.OK)
        Else
            If _isedit Then 'nếu là edit thì gọi hàm update
                If updatesinhvien() Then 'Nếu update thành công thì thông báo
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else 'Nếu có lỗi khi sửa thì thông báo
                    MessageBox.Show("Sửa dữ liệu Thất Bại!", "ERROR", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If
            Else 'nếu không phải edit thì gọi hàm insert
                    If insertStudent() Then 'Nếu insert thành công
                    MessageBox.Show("Dữ liệu được thêm thành công!", "Thông Báo", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Lỗi dữ liệu", "ERROR", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub fmsinhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class