<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlysinhvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quanlysinhvien))
        Me.dgvsinhvien = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.lbltimkiem = New System.Windows.Forms.Label()
        Me.gblop = New System.Windows.Forms.GroupBox()
        Me.cmbclass = New System.Windows.Forms.ComboBox()
        Me.lbllop = New System.Windows.Forms.Label()
        Me.cmbtimkiem = New System.Windows.Forms.ComboBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        CType(Me.dgvsinhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gblop.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvsinhvien
        '
        Me.dgvsinhvien.AllowUserToAddRows = False
        Me.dgvsinhvien.AllowUserToDeleteRows = False
        Me.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsinhvien.Location = New System.Drawing.Point(13, 119)
        Me.dgvsinhvien.MultiSelect = False
        Me.dgvsinhvien.Name = "dgvsinhvien"
        Me.dgvsinhvien.ReadOnly = True
        Me.dgvsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsinhvien.Size = New System.Drawing.Size(454, 387)
        Me.dgvsinhvien.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(473, 119)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(125, 50)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(473, 175)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(125, 42)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(474, 223)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(125, 45)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(195, 87)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(272, 20)
        Me.txttimkiem.TabIndex = 2
        '
        'lbltimkiem
        '
        Me.lbltimkiem.AutoSize = True
        Me.lbltimkiem.Location = New System.Drawing.Point(12, 90)
        Me.lbltimkiem.Name = "lbltimkiem"
        Me.lbltimkiem.Size = New System.Drawing.Size(50, 13)
        Me.lbltimkiem.TabIndex = 3
        Me.lbltimkiem.Text = "Tìm Kiếm"
        '
        'gblop
        '
        Me.gblop.Controls.Add(Me.cmbclass)
        Me.gblop.Controls.Add(Me.lbllop)
        Me.gblop.Location = New System.Drawing.Point(474, 274)
        Me.gblop.Name = "gblop"
        Me.gblop.Size = New System.Drawing.Size(124, 100)
        Me.gblop.TabIndex = 4
        Me.gblop.TabStop = False
        '
        'cmbclass
        '
        Me.cmbclass.FormattingEnabled = True
        Me.cmbclass.Location = New System.Drawing.Point(7, 56)
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Size = New System.Drawing.Size(111, 21)
        Me.cmbclass.TabIndex = 0
        '
        'lbllop
        '
        Me.lbllop.AutoSize = True
        Me.lbllop.Location = New System.Drawing.Point(38, 28)
        Me.lbllop.Name = "lbllop"
        Me.lbllop.Size = New System.Drawing.Size(25, 13)
        Me.lbllop.TabIndex = 3
        Me.lbllop.Text = "Lớp"
        '
        'cmbtimkiem
        '
        Me.cmbtimkiem.FormattingEnabled = True
        Me.cmbtimkiem.Items.AddRange(New Object() {"MSSV", "HoTen"})
        Me.cmbtimkiem.Location = New System.Drawing.Point(68, 86)
        Me.cmbtimkiem.Name = "cmbtimkiem"
        Me.cmbtimkiem.Size = New System.Drawing.Size(121, 21)
        Me.cmbtimkiem.TabIndex = 5
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Blue
        Me.lbltitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbltitle.Location = New System.Drawing.Point(83, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(449, 50)
        Me.lbltitle.TabIndex = 6
        Me.lbltitle.Text = "Quản Lý Sinh Viên  "
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'quanlysinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 518)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cmbtimkiem)
        Me.Controls.Add(Me.gblop)
        Me.Controls.Add(Me.lbltimkiem)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgvsinhvien)
        Me.Name = "quanlysinhvien"
        Me.Text = "Quản Lý Sinh Viên"
        CType(Me.dgvsinhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gblop.ResumeLayout(False)
        Me.gblop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvsinhvien As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txttimkiem As TextBox
    Friend WithEvents lbltimkiem As Label
    Friend WithEvents gblop As GroupBox
    Friend WithEvents cmbclass As ComboBox
    Friend WithEvents lbllop As Label
    Friend WithEvents cmbtimkiem As ComboBox
    Friend WithEvents lbltitle As Label
End Class
