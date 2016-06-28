<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmsinhvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmsinhvien))
        Me.lblmalop = New System.Windows.Forms.Label()
        Me.lblmssv = New System.Windows.Forms.Label()
        Me.lblhoten = New System.Windows.Forms.Label()
        Me.lbldienthoai = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.txtmalop = New System.Windows.Forms.TextBox()
        Me.txtmssv = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtdienthoai = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblmalop
        '
        Me.lblmalop.AutoSize = True
        Me.lblmalop.Location = New System.Drawing.Point(75, 196)
        Me.lblmalop.Name = "lblmalop"
        Me.lblmalop.Size = New System.Drawing.Size(43, 13)
        Me.lblmalop.TabIndex = 0
        Me.lblmalop.Text = "Mã Lớp"
        '
        'lblmssv
        '
        Me.lblmssv.AutoSize = True
        Me.lblmssv.Location = New System.Drawing.Point(75, 92)
        Me.lblmssv.Name = "lblmssv"
        Me.lblmssv.Size = New System.Drawing.Size(37, 13)
        Me.lblmssv.TabIndex = 0
        Me.lblmssv.Text = "MSSV"
        '
        'lblhoten
        '
        Me.lblhoten.AutoSize = True
        Me.lblhoten.Location = New System.Drawing.Point(75, 118)
        Me.lblhoten.Name = "lblhoten"
        Me.lblhoten.Size = New System.Drawing.Size(43, 13)
        Me.lblhoten.TabIndex = 0
        Me.lblhoten.Text = "Họ Tên"
        '
        'lbldienthoai
        '
        Me.lbldienthoai.AutoSize = True
        Me.lbldienthoai.Location = New System.Drawing.Point(75, 144)
        Me.lbldienthoai.Name = "lbldienthoai"
        Me.lbldienthoai.Size = New System.Drawing.Size(59, 13)
        Me.lbldienthoai.TabIndex = 0
        Me.lbldienthoai.Text = "Điện Thoại"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(75, 170)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(41, 13)
        Me.lbldiachi.TabIndex = 0
        Me.lbldiachi.Text = "Địa Chỉ"
        '
        'txtmalop
        '
        Me.txtmalop.Location = New System.Drawing.Point(133, 193)
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.ReadOnly = True
        Me.txtmalop.Size = New System.Drawing.Size(100, 20)
        Me.txtmalop.TabIndex = 1
        '
        'txtmssv
        '
        Me.txtmssv.Location = New System.Drawing.Point(133, 89)
        Me.txtmssv.Name = "txtmssv"
        Me.txtmssv.Size = New System.Drawing.Size(100, 20)
        Me.txtmssv.TabIndex = 1
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(133, 115)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(100, 20)
        Me.txthoten.TabIndex = 2
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Location = New System.Drawing.Point(133, 141)
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(100, 20)
        Me.txtdienthoai.TabIndex = 3
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(133, 167)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 4
        '
        'btnok
        '
        Me.btnok.Image = CType(resources.GetObject("btnok.Image"), System.Drawing.Image)
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Location = New System.Drawing.Point(61, 237)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(92, 45)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(178, 237)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(100, 45)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Thông Tin Sinh Viên"
        '
        'fmsinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtdienthoai)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmssv)
        Me.Controls.Add(Me.txtmalop)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lbldienthoai)
        Me.Controls.Add(Me.lblhoten)
        Me.Controls.Add(Me.lblmssv)
        Me.Controls.Add(Me.lblmalop)
        Me.Name = "fmsinhvien"
        Me.Text = "Sinh Viên"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmalop As Label
    Friend WithEvents lblmssv As Label
    Friend WithEvents lblhoten As Label
    Friend WithEvents lbldienthoai As Label
    Friend WithEvents lbldiachi As Label
    Friend WithEvents txtmalop As TextBox
    Friend WithEvents txtmssv As TextBox
    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtdienthoai As TextBox
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label1 As Label
End Class
