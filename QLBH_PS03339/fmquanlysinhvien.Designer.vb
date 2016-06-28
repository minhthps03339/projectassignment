<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmquanlysinhvien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbthongtinsv = New System.Windows.Forms.GroupBox()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.txtMSSV = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnganhhoc = New System.Windows.Forms.TextBox()
        Me.txtkhoahoc = New System.Windows.Forms.TextBox()
        Me.txtlop = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.lblMSSV = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblnganhhoc = New System.Windows.Forms.Label()
        Me.lblkhoahoc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnChinhSua = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbthongtinsv.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbthongtinsv
        '
        Me.gbthongtinsv.Controls.Add(Me.txttimkiem)
        Me.gbthongtinsv.Controls.Add(Me.txtMSSV)
        Me.gbthongtinsv.Controls.Add(Me.btnTimKiem)
        Me.gbthongtinsv.Controls.Add(Me.txtemail)
        Me.gbthongtinsv.Controls.Add(Me.txtnganhhoc)
        Me.gbthongtinsv.Controls.Add(Me.txtkhoahoc)
        Me.gbthongtinsv.Controls.Add(Me.txtlop)
        Me.gbthongtinsv.Controls.Add(Me.txtHoTen)
        Me.gbthongtinsv.Controls.Add(Me.lblMSSV)
        Me.gbthongtinsv.Controls.Add(Me.lblemail)
        Me.gbthongtinsv.Controls.Add(Me.lblnganhhoc)
        Me.gbthongtinsv.Controls.Add(Me.lblkhoahoc)
        Me.gbthongtinsv.Controls.Add(Me.Label3)
        Me.gbthongtinsv.Controls.Add(Me.Label1)
        Me.gbthongtinsv.Location = New System.Drawing.Point(12, 27)
        Me.gbthongtinsv.Name = "gbthongtinsv"
        Me.gbthongtinsv.Size = New System.Drawing.Size(509, 189)
        Me.gbthongtinsv.TabIndex = 1
        Me.gbthongtinsv.TabStop = False
        Me.gbthongtinsv.Text = "Thông Tin Sinh Viên"
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(348, 61)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(146, 20)
        Me.txttimkiem.TabIndex = 3
        Me.txttimkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMSSV
        '
        Me.txtMSSV.Location = New System.Drawing.Point(114, 45)
        Me.txtMSSV.Name = "txtMSSV"
        Me.txtMSSV.Size = New System.Drawing.Size(210, 20)
        Me.txtMSSV.TabIndex = 1
        Me.txtMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(388, 19)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 2
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(114, 151)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(210, 20)
        Me.txtemail.TabIndex = 1
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnganhhoc
        '
        Me.txtnganhhoc.Location = New System.Drawing.Point(114, 123)
        Me.txtnganhhoc.Name = "txtnganhhoc"
        Me.txtnganhhoc.Size = New System.Drawing.Size(210, 20)
        Me.txtnganhhoc.TabIndex = 1
        Me.txtnganhhoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtkhoahoc
        '
        Me.txtkhoahoc.Location = New System.Drawing.Point(114, 97)
        Me.txtkhoahoc.Name = "txtkhoahoc"
        Me.txtkhoahoc.Size = New System.Drawing.Size(210, 20)
        Me.txtkhoahoc.TabIndex = 1
        Me.txtkhoahoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlop
        '
        Me.txtlop.Location = New System.Drawing.Point(114, 71)
        Me.txtlop.Name = "txtlop"
        Me.txtlop.Size = New System.Drawing.Size(210, 20)
        Me.txtlop.TabIndex = 1
        Me.txtlop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(114, 19)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 20)
        Me.txtHoTen.TabIndex = 1
        '
        'lblMSSV
        '
        Me.lblMSSV.AutoSize = True
        Me.lblMSSV.Location = New System.Drawing.Point(29, 48)
        Me.lblMSSV.Name = "lblMSSV"
        Me.lblMSSV.Size = New System.Drawing.Size(37, 13)
        Me.lblMSSV.TabIndex = 0
        Me.lblMSSV.Text = "MSSV"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(29, 154)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 0
        Me.lblemail.Text = "Email"
        '
        'lblnganhhoc
        '
        Me.lblnganhhoc.AutoSize = True
        Me.lblnganhhoc.Location = New System.Drawing.Point(29, 126)
        Me.lblnganhhoc.Name = "lblnganhhoc"
        Me.lblnganhhoc.Size = New System.Drawing.Size(62, 13)
        Me.lblnganhhoc.TabIndex = 0
        Me.lblnganhhoc.Text = "Ngành Học"
        '
        'lblkhoahoc
        '
        Me.lblkhoahoc.AutoSize = True
        Me.lblkhoahoc.Location = New System.Drawing.Point(29, 100)
        Me.lblkhoahoc.Name = "lblkhoahoc"
        Me.lblkhoahoc.Size = New System.Drawing.Size(55, 13)
        Me.lblkhoahoc.TabIndex = 0
        Me.lblkhoahoc.Text = "Khóa Học"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lớp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ và Tên"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(12, 232)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(228, 232)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnChinhSua
        '
        Me.btnChinhSua.Location = New System.Drawing.Point(431, 232)
        Me.btnChinhSua.Name = "btnChinhSua"
        Me.btnChinhSua.Size = New System.Drawing.Size(75, 23)
        Me.btnChinhSua.TabIndex = 2
        Me.btnChinhSua.Text = "Chỉnh Sửa"
        Me.btnChinhSua.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(509, 188)
        Me.DataGridView1.TabIndex = 3
        '
        'fmquanlysinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 481)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnChinhSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gbthongtinsv)
        Me.Name = "fmquanlysinhvien"
        Me.Text = "Quản Lý Sinh Viên"
        Me.gbthongtinsv.ResumeLayout(False)
        Me.gbthongtinsv.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbthongtinsv As GroupBox
    Friend WithEvents txtnganhhoc As TextBox
    Friend WithEvents txtkhoahoc As TextBox
    Friend WithEvents txtlop As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents lblnganhhoc As Label
    Friend WithEvents lblkhoahoc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnChinhSua As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtMSSV As TextBox
    Friend WithEvents lblMSSV As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents txttimkiem As TextBox
End Class
