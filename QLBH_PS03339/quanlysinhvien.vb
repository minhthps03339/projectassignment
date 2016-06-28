Public Class quanlysinhvien
    'khai báo biến để truy xuất database từ lớp DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến trạng thái kiểm tra dữ liệu dạng Load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load dữ liệu từ bảng lớp vào combobox
    Private Sub LoadDataOnComBoBox()
        Dim sqlQuery As String = "select MaLop, TenLop from dbo.Lop"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbclass.DataSource = dTable
        Me.cmbclass.ValueMember = "MaLop"
        Me.cmbclass.DisplayMember = "TenLop"
    End Sub

    'Định nghĩa thủ tục load dữ liệu từ bảng thongtinsinhvien và Gridview
    Private Sub LoadDataOnGridView(MaLop As String)
        Dim sqlQuery As String =
            String.Format("select MSSV, HoTen, SDT, DiaChi, MaLop from dbo.thongtinsv where MaLop = '{0}'", MaLop)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dTable
        With Me.dgvsinhvien
            .Columns(0).HeaderText = "MSSV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(3).Width = 200

        End With
    End Sub
    Private Sub quanlysinhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'True khi dữ liệu bắt đầu load

        LoadDataOnComBoBox()
        LoadDataOnGridView(Me.cmbclass.SelectedValue)

        _isLoading = False 'False khi load dữ liệu xong
    End Sub

    Private Sub cmbclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbclass.SelectedIndexChanged
        If Not _isLoading Then 'nếu load dữ liệu xong
            LoadDataOnGridView(Me.cmbclass.SelectedValue)
        End If
    End Sub


    'Định nghĩa thủ tục  hiển thị kết quả tìm kiếm: theo MSSV, Họ Tên bằng phương pháp tìm kiếm tương tự
    Private Sub timkiemsv(MaLop As String, value As String)
        Dim sqlQuery As String =
            String.Format("select MSSV, HoTen, SDT, DiaChi, MaLop from dbo.thongtinsv where MaLop = '{0}'", MaLop)
        If Me.cmbtimkiem.SelectedIndex = 0 Then 'tìm kiếm theo MSSV
            sqlQuery += String.Format("AND MSSV LIKE'{0}%'", value)
        ElseIf Me.cmbtimkiem.SelectedIndex = 1 Then 'tìm kiếm họ tên
            sqlQuery += String.Format("AND HoTen LIKE'{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dTable
        With Me.dgvsinhvien
            .Columns(0).HeaderText = "MSSV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(3).Width = 200

        End With
    End Sub
    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        timkiemsv(Me.cmbclass.SelectedValue, Me.txttimkiem.Text)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New fmsinhvien(False)
        frm.txtmalop.Text = Me.cmbclass.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            'Load dữ liệu 
            LoadDataOnGridView(Me.cmbclass.SelectedValue)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New fmsinhvien(True)
        frm.txtmalop.Text = Me.cmbclass.SelectedValue
        frm.txtmssv.ReadOnly = True 'Chỉ cho đọc, trường hợp này không cho phép thay đổi khi sửa dữ liệu
        With Me.dgvsinhvien
            frm.txtmssv.Text = .Rows(.CurrentCell.RowIndex).Cells("MSSV").Value
            frm.txthoten.Text = .Rows(.CurrentCell.RowIndex).Cells("HoTen").Value
            frm.txtdienthoai.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'sửa dữ liệu thành công thì load vào gridview
            LoadDataOnGridView(Me.cmbclass.SelectedValue)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'khai báo biến lấy mssv cần xóa được chọn trên girdview
        Dim mssv As String = Me.dgvsinhvien.Rows(Me.dgvsinhvien.CurrentCell.RowIndex).Cells("MSSV").Value

        'khai báo câu lệnh xóa
        Dim sqlquery As String = String.Format("delete thongtinsv where MSSV = '{0}'", mssv)

        'thực hiện xóa
        If _DBAccess.ExecuteNoneQuery(sqlquery) Then 'xóa thành công
            MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK)
            'load lại dữ liệu trên gridview
            LoadDataOnGridView(Me.cmbclass.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu", "thông báo", MessageBoxButtons.OK)
        End If

    End Sub
End Class