<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmdangnhap))
        Me.lblTK = New System.Windows.Forms.Label()
        Me.lblMK = New System.Windows.Forms.Label()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.bntDangNhap = New System.Windows.Forms.Button()
        Me.bntthoat = New System.Windows.Forms.Button()
        Me.lblQLBH = New System.Windows.Forms.Label()
        Me.chkghinho = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTK
        '
        Me.lblTK.AutoSize = True
        Me.lblTK.Location = New System.Drawing.Point(51, 83)
        Me.lblTK.Name = "lblTK"
        Me.lblTK.Size = New System.Drawing.Size(62, 13)
        Me.lblTK.TabIndex = 0
        Me.lblTK.Text = "Tài Khoảng"
        '
        'lblMK
        '
        Me.lblMK.AutoSize = True
        Me.lblMK.Location = New System.Drawing.Point(51, 130)
        Me.lblMK.Name = "lblMK"
        Me.lblMK.Size = New System.Drawing.Size(53, 13)
        Me.lblMK.TabIndex = 1
        Me.lblMK.Text = "Mật Khẩu"
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(150, 80)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(170, 20)
        Me.txtTK.TabIndex = 1
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(150, 127)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.Size = New System.Drawing.Size(170, 20)
        Me.txtMK.TabIndex = 2
        Me.txtMK.UseSystemPasswordChar = True
        '
        'bntDangNhap
        '
        Me.bntDangNhap.Image = CType(resources.GetObject("bntDangNhap.Image"), System.Drawing.Image)
        Me.bntDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntDangNhap.Location = New System.Drawing.Point(70, 153)
        Me.bntDangNhap.Name = "bntDangNhap"
        Me.bntDangNhap.Size = New System.Drawing.Size(107, 40)
        Me.bntDangNhap.TabIndex = 3
        Me.bntDangNhap.Text = "Đăng Nhập"
        Me.bntDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntDangNhap.UseVisualStyleBackColor = True
        '
        'bntthoat
        '
        Me.bntthoat.Image = CType(resources.GetObject("bntthoat.Image"), System.Drawing.Image)
        Me.bntthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntthoat.Location = New System.Drawing.Point(307, 153)
        Me.bntthoat.Name = "bntthoat"
        Me.bntthoat.Size = New System.Drawing.Size(98, 40)
        Me.bntthoat.TabIndex = 4
        Me.bntthoat.Text = "Thoát"
        Me.bntthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntthoat.UseVisualStyleBackColor = True
        '
        'lblQLBH
        '
        Me.lblQLBH.AutoSize = True
        Me.lblQLBH.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLBH.ForeColor = System.Drawing.Color.Red
        Me.lblQLBH.Location = New System.Drawing.Point(48, 19)
        Me.lblQLBH.Name = "lblQLBH"
        Me.lblQLBH.Size = New System.Drawing.Size(432, 34)
        Me.lblQLBH.TabIndex = 4
        Me.lblQLBH.Text = "Phần mềm quản lý sinh viên"
        '
        'chkghinho
        '
        Me.chkghinho.AutoSize = True
        Me.chkghinho.Location = New System.Drawing.Point(358, 107)
        Me.chkghinho.Name = "chkghinho"
        Me.chkghinho.Size = New System.Drawing.Size(65, 17)
        Me.chkghinho.TabIndex = 5
        Me.chkghinho.Text = "Ghi Nhớ"
        Me.chkghinho.UseVisualStyleBackColor = True
        '
        'fmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 205)
        Me.Controls.Add(Me.chkghinho)
        Me.Controls.Add(Me.lblQLBH)
        Me.Controls.Add(Me.bntthoat)
        Me.Controls.Add(Me.bntDangNhap)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Controls.Add(Me.lblMK)
        Me.Controls.Add(Me.lblTK)
        Me.Name = "fmdangnhap"
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTK As Label
    Friend WithEvents lblMK As Label
    Friend WithEvents txtTK As TextBox
    Friend WithEvents txtMK As TextBox
    Friend WithEvents bntDangNhap As Button
    Friend WithEvents bntthoat As Button
    Friend WithEvents lblQLBH As Label
    Friend WithEvents chkghinho As CheckBox
End Class
