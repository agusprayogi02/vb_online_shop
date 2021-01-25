<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Beli_idLabel As System.Windows.Forms.Label
        Dim Beli_jumlahLabel As System.Windows.Forms.Label
        Dim Beli_tanggalLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim NamaLabel1 As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Dim KdLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.pMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnPembelian = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.pheader = New System.Windows.Forms.Panel()
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pUser = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCencel = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboRole = New System.Windows.Forms.ComboBox()
        Me.btnInginUp = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.pBarang = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnKosongkan = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.pPembelian = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Beli_idTextBox = New System.Windows.Forms.TextBox()
        Me.Beli_jumlahTextBox = New System.Windows.Forms.TextBox()
        Me.Beli_tanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.NamaComboBox = New System.Windows.Forms.ComboBox()
        Me.KdTextBox = New System.Windows.Forms.TextBox()
        Me.StokTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UserDataSet = New online_shop.userDataSet()
        Me.UserDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New online_shop.userDataSetTableAdapters.barangTableAdapter()
        Me.KdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianTableAdapter = New online_shop.userDataSetTableAdapters.pembelianTableAdapter()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New online_shop.userDataSetTableAdapters.loginTableAdapter()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeliidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelitanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelijumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Beli_idLabel = New System.Windows.Forms.Label()
        Beli_jumlahLabel = New System.Windows.Forms.Label()
        Beli_tanggalLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        NamaLabel1 = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        KdLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.pMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pheader.SuspendLayout()
        Me.pUser.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pBarang.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pPembelian.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pMenu
        '
        Me.pMenu.BackColor = System.Drawing.Color.SteelBlue
        Me.pMenu.Controls.Add(Me.Panel1)
        Me.pMenu.Controls.Add(Me.btnUser)
        Me.pMenu.Controls.Add(Me.btnPembelian)
        Me.pMenu.Controls.Add(Me.btnBarang)
        Me.pMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pMenu.Location = New System.Drawing.Point(0, 0)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(179, 534)
        Me.pMenu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(23, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Menu Admin"
        '
        'btnUser
        '
        Me.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(3, 54)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(173, 38)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "Kelola User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnPembelian
        '
        Me.btnPembelian.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPembelian.FlatAppearance.BorderSize = 0
        Me.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembelian.Location = New System.Drawing.Point(2, 144)
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Size = New System.Drawing.Size(173, 38)
        Me.btnPembelian.TabIndex = 0
        Me.btnPembelian.Text = "Kelola Pembelian"
        Me.btnPembelian.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.Location = New System.Drawing.Point(3, 99)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(173, 38)
        Me.btnBarang.TabIndex = 0
        Me.btnBarang.Text = "Kelola Barang"
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'pheader
        '
        Me.pheader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pheader.Controls.Add(Me.LbTitle)
        Me.pheader.Controls.Add(Me.btnClose)
        Me.pheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pheader.Location = New System.Drawing.Point(179, 0)
        Me.pheader.Name = "pheader"
        Me.pheader.Size = New System.Drawing.Size(655, 50)
        Me.pheader.TabIndex = 1
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitle.Location = New System.Drawing.Point(15, 15)
        Me.LbTitle.Name = "LbTitle"
        Me.LbTitle.Size = New System.Drawing.Size(101, 20)
        Me.LbTitle.TabIndex = 1
        Me.LbTitle.Text = "Kelola User"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.online_shop.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(615, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pUser
        '
        Me.pUser.Controls.Add(Me.DataGridView1)
        Me.pUser.Controls.Add(Me.btnCencel)
        Me.pUser.Controls.Add(Me.btnHapus)
        Me.pUser.Controls.Add(Me.btnUpdate)
        Me.pUser.Controls.Add(Me.btnTambah)
        Me.pUser.Controls.Add(Me.Panel5)
        Me.pUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pUser.Location = New System.Drawing.Point(179, 50)
        Me.pUser.Name = "pUser"
        Me.pUser.Size = New System.Drawing.Size(655, 484)
        Me.pUser.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.UsernameDataGridViewTextBoxColumn1, Me.PasswordDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(634, 246)
        Me.DataGridView1.TabIndex = 3
        '
        'btnCencel
        '
        Me.btnCencel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnCencel.Location = New System.Drawing.Point(11, 431)
        Me.btnCencel.Name = "btnCencel"
        Me.btnCencel.Size = New System.Drawing.Size(182, 39)
        Me.btnCencel.TabIndex = 2
        Me.btnCencel.Text = "Cencel"
        Me.btnCencel.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnHapus.Location = New System.Drawing.Point(11, 377)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(182, 39)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnUpdate.Location = New System.Drawing.Point(11, 323)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 39)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnTambah.Location = New System.Drawing.Point(11, 269)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(182, 39)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.ComboRole)
        Me.Panel5.Controls.Add(Me.btnInginUp)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtPass)
        Me.Panel5.Controls.Add(Me.txtEmail)
        Me.Panel5.Controls.Add(Me.txtId)
        Me.Panel5.Controls.Add(Me.lblEdit)
        Me.Panel5.Location = New System.Drawing.Point(369, 269)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(276, 204)
        Me.Panel5.TabIndex = 1
        '
        'ComboRole
        '
        Me.ComboRole.Enabled = False
        Me.ComboRole.FormattingEnabled = True
        Me.ComboRole.Location = New System.Drawing.Point(89, 131)
        Me.ComboRole.Name = "ComboRole"
        Me.ComboRole.Size = New System.Drawing.Size(168, 21)
        Me.ComboRole.TabIndex = 4
        '
        'btnInginUp
        '
        Me.btnInginUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnInginUp.Location = New System.Drawing.Point(89, 164)
        Me.btnInginUp.Name = "btnInginUp"
        Me.btnInginUp.Size = New System.Drawing.Size(169, 33)
        Me.btnInginUp.TabIndex = 3
        Me.btnInginUp.Text = "Ingin Update ??"
        Me.btnInginUp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Role"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(88, 103)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ReadOnly = True
        Me.txtPass.Size = New System.Drawing.Size(170, 22)
        Me.txtPass.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(88, 75)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(170, 22)
        Me.txtEmail.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(88, 47)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(170, 22)
        Me.txtId.TabIndex = 1
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.Location = New System.Drawing.Point(104, 11)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(93, 20)
        Me.lblEdit.TabIndex = 0
        Me.lblEdit.Text = "Form User"
        '
        'pBarang
        '
        Me.pBarang.Controls.Add(Me.Button2)
        Me.pBarang.Controls.Add(Me.Button1)
        Me.pBarang.Controls.Add(Me.Tambah)
        Me.pBarang.Controls.Add(Me.Panel2)
        Me.pBarang.Controls.Add(Me.DataGridView2)
        Me.pBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBarang.Location = New System.Drawing.Point(179, 50)
        Me.pBarang.Name = "pBarang"
        Me.pBarang.Size = New System.Drawing.Size(655, 484)
        Me.pBarang.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(11, 285)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(203, 41)
        Me.Tambah.TabIndex = 2
        Me.Tambah.Text = "Tambah"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(IdLabel)
        Me.Panel2.Controls.Add(Me.IdTextBox)
        Me.Panel2.Controls.Add(HargaLabel)
        Me.Panel2.Controls.Add(Me.HargaTextBox)
        Me.Panel2.Controls.Add(NamaLabel)
        Me.Panel2.Controls.Add(Me.NamaTextBox)
        Me.Panel2.Controls.Add(KdLabel)
        Me.Panel2.Controls.Add(Me.KdTextBox)
        Me.Panel2.Controls.Add(StokLabel)
        Me.Panel2.Controls.Add(Me.StokTextBox)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnKosongkan)
        Me.Panel2.Location = New System.Drawing.Point(384, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 227)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Form Edit"
        '
        'btnKosongkan
        '
        Me.btnKosongkan.Location = New System.Drawing.Point(168, 194)
        Me.btnKosongkan.Name = "btnKosongkan"
        Me.btnKosongkan.Size = New System.Drawing.Size(75, 23)
        Me.btnKosongkan.TabIndex = 10
        Me.btnKosongkan.Text = "Kosongkan"
        Me.btnKosongkan.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BarangBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(11, 11)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(634, 228)
        Me.DataGridView2.TabIndex = 0
        '
        'pPembelian
        '
        Me.pPembelian.Controls.Add(Me.Button5)
        Me.pPembelian.Controls.Add(Me.Button4)
        Me.pPembelian.Controls.Add(Me.Panel3)
        Me.pPembelian.Controls.Add(Me.DataGridView3)
        Me.pPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPembelian.Location = New System.Drawing.Point(179, 50)
        Me.pPembelian.Name = "pPembelian"
        Me.pPembelian.Size = New System.Drawing.Size(655, 484)
        Me.pPembelian.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 41)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(11, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 41)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(NamaLabel1)
        Me.Panel3.Controls.Add(Me.NamaComboBox)
        Me.Panel3.Controls.Add(UsernameLabel)
        Me.Panel3.Controls.Add(Me.UsernameTextBox)
        Me.Panel3.Controls.Add(Beli_tanggalLabel)
        Me.Panel3.Controls.Add(Me.Beli_tanggalDateTimePicker)
        Me.Panel3.Controls.Add(Beli_jumlahLabel)
        Me.Panel3.Controls.Add(Me.Beli_jumlahTextBox)
        Me.Panel3.Controls.Add(Beli_idLabel)
        Me.Panel3.Controls.Add(Me.Beli_idTextBox)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(321, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 226)
        Me.Panel3.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(121, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Ingin Mengubah?"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BeliidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn1, Me.HargaDataGridViewTextBoxColumn1, Me.UserbeliDataGridViewTextBoxColumn, Me.BarangDataGridViewTextBoxColumn, Me.BelitanggalDataGridViewTextBoxColumn, Me.BelijumlahDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.PembelianBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(634, 231)
        Me.DataGridView3.TabIndex = 0
        '
        'Beli_idLabel
        '
        Beli_idLabel.AutoSize = True
        Beli_idLabel.Location = New System.Drawing.Point(44, 46)
        Beli_idLabel.Name = "Beli_idLabel"
        Beli_idLabel.Size = New System.Drawing.Size(37, 13)
        Beli_idLabel.TabIndex = 10
        Beli_idLabel.Text = "beli id:"
        '
        'Beli_idTextBox
        '
        Me.Beli_idTextBox.Location = New System.Drawing.Point(100, 43)
        Me.Beli_idTextBox.Name = "Beli_idTextBox"
        Me.Beli_idTextBox.ReadOnly = True
        Me.Beli_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Beli_idTextBox.TabIndex = 11
        '
        'Beli_jumlahLabel
        '
        Beli_jumlahLabel.AutoSize = True
        Beli_jumlahLabel.Location = New System.Drawing.Point(22, 127)
        Beli_jumlahLabel.Name = "Beli_jumlahLabel"
        Beli_jumlahLabel.Size = New System.Drawing.Size(59, 13)
        Beli_jumlahLabel.TabIndex = 11
        Beli_jumlahLabel.Text = "beli jumlah:"
        '
        'Beli_jumlahTextBox
        '
        Me.Beli_jumlahTextBox.Location = New System.Drawing.Point(100, 122)
        Me.Beli_jumlahTextBox.Name = "Beli_jumlahTextBox"
        Me.Beli_jumlahTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Beli_jumlahTextBox.TabIndex = 12
        '
        'Beli_tanggalLabel
        '
        Beli_tanggalLabel.AutoSize = True
        Beli_tanggalLabel.Location = New System.Drawing.Point(17, 154)
        Beli_tanggalLabel.Name = "Beli_tanggalLabel"
        Beli_tanggalLabel.Size = New System.Drawing.Size(64, 13)
        Beli_tanggalLabel.TabIndex = 12
        Beli_tanggalLabel.Text = "beli tanggal:"
        '
        'Beli_tanggalDateTimePicker
        '
        Me.Beli_tanggalDateTimePicker.Location = New System.Drawing.Point(100, 148)
        Me.Beli_tanggalDateTimePicker.Name = "Beli_tanggalDateTimePicker"
        Me.Beli_tanggalDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Beli_tanggalDateTimePicker.TabIndex = 13
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(25, 73)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 14
        UsernameLabel.Text = "username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(100, 69)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsernameTextBox.TabIndex = 15
        '
        'NamaLabel1
        '
        NamaLabel1.AutoSize = True
        NamaLabel1.Location = New System.Drawing.Point(42, 100)
        NamaLabel1.Name = "NamaLabel1"
        NamaLabel1.Size = New System.Drawing.Size(36, 13)
        NamaLabel1.TabIndex = 15
        NamaLabel1.Text = "nama:"
        '
        'NamaComboBox
        '
        Me.NamaComboBox.FormattingEnabled = True
        Me.NamaComboBox.Location = New System.Drawing.Point(100, 95)
        Me.NamaComboBox.Name = "NamaComboBox"
        Me.NamaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NamaComboBox.TabIndex = 16
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(26, 136)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(30, 13)
        StokLabel.TabIndex = 14
        StokLabel.Text = "stok:"
        '
        'KdLabel
        '
        KdLabel.AutoSize = True
        KdLabel.Location = New System.Drawing.Point(34, 52)
        KdLabel.Name = "KdLabel"
        KdLabel.Size = New System.Drawing.Size(22, 13)
        KdLabel.TabIndex = 15
        KdLabel.Text = "kd:"
        '
        'KdTextBox
        '
        Me.KdTextBox.Location = New System.Drawing.Point(70, 49)
        Me.KdTextBox.Name = "KdTextBox"
        Me.KdTextBox.ReadOnly = True
        Me.KdTextBox.Size = New System.Drawing.Size(172, 20)
        Me.KdTextBox.TabIndex = 16
        '
        'StokTextBox
        '
        Me.StokTextBox.Location = New System.Drawing.Point(70, 133)
        Me.StokTextBox.Name = "StokTextBox"
        Me.StokTextBox.Size = New System.Drawing.Size(173, 20)
        Me.StokTextBox.TabIndex = 15
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(20, 80)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 16
        NamaLabel.Text = "nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Location = New System.Drawing.Point(70, 77)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NamaTextBox.TabIndex = 17
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(19, 108)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(37, 13)
        HargaLabel.TabIndex = 17
        HargaLabel.Text = "harga:"
        '
        'HargaTextBox
        '
        Me.HargaTextBox.Location = New System.Drawing.Point(70, 105)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(172, 20)
        Me.HargaTextBox.TabIndex = 18
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(38, 164)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 18
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(70, 161)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(172, 20)
        Me.IdTextBox.TabIndex = 19
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "userDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserDataSetBindingSource
        '
        Me.UserDataSetBindingSource.DataSource = Me.UserDataSet
        Me.UserDataSetBindingSource.Position = 0
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.UserDataSetBindingSource
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'KdDataGridViewTextBoxColumn
        '
        Me.KdDataGridViewTextBoxColumn.DataPropertyName = "kd"
        Me.KdDataGridViewTextBoxColumn.HeaderText = "kd"
        Me.KdDataGridViewTextBoxColumn.Name = "KdDataGridViewTextBoxColumn"
        Me.KdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'PembelianBindingSource
        '
        Me.PembelianBindingSource.DataMember = "pembelian"
        Me.PembelianBindingSource.DataSource = Me.UserDataSetBindingSource
        '
        'PembelianTableAdapter
        '
        Me.PembelianTableAdapter.ClearBeforeFill = True
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.UserDataSetBindingSource
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        Me.UsernameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BeliidDataGridViewTextBoxColumn
        '
        Me.BeliidDataGridViewTextBoxColumn.DataPropertyName = "beli_id"
        Me.BeliidDataGridViewTextBoxColumn.HeaderText = "Kode Beli"
        Me.BeliidDataGridViewTextBoxColumn.Name = "BeliidDataGridViewTextBoxColumn"
        Me.BeliidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Nama Pembeli"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn1
        '
        Me.NamaDataGridViewTextBoxColumn1.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn1.HeaderText = "Nama Barang"
        Me.NamaDataGridViewTextBoxColumn1.Name = "NamaDataGridViewTextBoxColumn1"
        Me.NamaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn1
        '
        Me.HargaDataGridViewTextBoxColumn1.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn1.HeaderText = "Harga Beli"
        Me.HargaDataGridViewTextBoxColumn1.Name = "HargaDataGridViewTextBoxColumn1"
        Me.HargaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UserbeliDataGridViewTextBoxColumn
        '
        Me.UserbeliDataGridViewTextBoxColumn.DataPropertyName = "user_beli"
        Me.UserbeliDataGridViewTextBoxColumn.HeaderText = "user_beli"
        Me.UserbeliDataGridViewTextBoxColumn.Name = "UserbeliDataGridViewTextBoxColumn"
        Me.UserbeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BarangDataGridViewTextBoxColumn
        '
        Me.BarangDataGridViewTextBoxColumn.DataPropertyName = "barang"
        Me.BarangDataGridViewTextBoxColumn.HeaderText = "kd Barang"
        Me.BarangDataGridViewTextBoxColumn.Name = "BarangDataGridViewTextBoxColumn"
        Me.BarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BelitanggalDataGridViewTextBoxColumn
        '
        Me.BelitanggalDataGridViewTextBoxColumn.DataPropertyName = "beli_tanggal"
        Me.BelitanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal Beli"
        Me.BelitanggalDataGridViewTextBoxColumn.Name = "BelitanggalDataGridViewTextBoxColumn"
        Me.BelitanggalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BelijumlahDataGridViewTextBoxColumn
        '
        Me.BelijumlahDataGridViewTextBoxColumn.DataPropertyName = "beli_jumlah"
        Me.BelijumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah Beli"
        Me.BelijumlahDataGridViewTextBoxColumn.Name = "BelijumlahDataGridViewTextBoxColumn"
        Me.BelijumlahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.pPembelian)
        Me.Controls.Add(Me.pUser)
        Me.Controls.Add(Me.pBarang)
        Me.Controls.Add(Me.pheader)
        Me.Controls.Add(Me.pMenu)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pheader.ResumeLayout(False)
        Me.pheader.PerformLayout()
        Me.pUser.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pBarang.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pPembelian.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMenu As Panel
    Friend WithEvents pheader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents LbTitle As Label
    Friend WithEvents pUser As Panel
    Friend WithEvents btnCencel As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnInginUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblEdit As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboRole As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pBarang As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tambah As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPembelian As Button
    Friend WithEvents pPembelian As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NamaComboBox As ComboBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Beli_tanggalDateTimePicker As DateTimePicker
    Friend WithEvents Beli_jumlahTextBox As TextBox
    Friend WithEvents Beli_idTextBox As TextBox
    Friend WithEvents KdTextBox As TextBox
    Friend WithEvents StokTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents HargaTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents UserDataSetBindingSource As BindingSource
    Friend WithEvents UserDataSet As userDataSet
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As userDataSetTableAdapters.barangTableAdapter
    Friend WithEvents KdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PembelianBindingSource As BindingSource
    Friend WithEvents PembelianTableAdapter As userDataSetTableAdapters.pembelianTableAdapter
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As userDataSetTableAdapters.loginTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeliidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UserbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BelitanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BelijumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
