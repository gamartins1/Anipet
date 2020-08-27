<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaFornecedor))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cbUf = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 160)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(795, 315)
        Me.TabControl1.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvDados)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(787, 287)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listagem de fornecedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column9, Me.Column3, Me.Column4, Me.Column5, Me.Column2, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvDados.Location = New System.Drawing.Point(3, 1)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(778, 280)
        Me.dgvDados.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.Column1.HeaderText = "--"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 5
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column9.HeaderText = "CNPJ"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 57
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 62
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Telefone"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 76
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "E-mail"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 63
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "CEP"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 51
        '
        'Column6
        '
        Me.Column6.HeaderText = "Rua"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cidade"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = "Observações"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 97
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtObservacoes)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtComplemento)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtNumero)
        Me.TabPage2.Controls.Add(Me.cbUf)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtCidade)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtBairro)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtRua)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtCep)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtDataCadastro)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtTelefone)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtNome)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtCnpj)
        Me.TabPage2.Controls.Add(Me.btnFechar)
        Me.TabPage2.Controls.Add(Me.btnCancelar)
        Me.TabPage2.Controls.Add(Me.btnAlterar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(787, 287)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fornecedores"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(35, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 17)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtObservacoes.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoes.Location = New System.Drawing.Point(39, 247)
        Me.txtObservacoes.MaxLength = 360
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(576, 25)
        Me.txtObservacoes.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(459, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Complemento"
        '
        'txtComplemento
        '
        Me.txtComplemento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtComplemento.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(463, 191)
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(152, 25)
        Me.txtComplemento.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(460, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 17)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "N° "
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNumero.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(464, 138)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(97, 25)
        Me.txtNumero.TabIndex = 64
        '
        'cbUf
        '
        Me.cbUf.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbUf.FormattingEnabled = True
        Me.cbUf.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cbUf.Location = New System.Drawing.Point(463, 82)
        Me.cbUf.Name = "cbUf"
        Me.cbUf.Size = New System.Drawing.Size(153, 23)
        Me.cbUf.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(460, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 17)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "UF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(460, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCidade.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(464, 31)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(152, 25)
        Me.txtCidade.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(264, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBairro.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(268, 191)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(152, 25)
        Me.txtBairro.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(265, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Rua"
        '
        'txtRua
        '
        Me.txtRua.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtRua.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.Location = New System.Drawing.Point(269, 138)
        Me.txtRua.MaxLength = 60
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(152, 25)
        Me.txtRua.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(266, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "CEP"
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCep.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(269, 80)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(84, 25)
        Me.txtCep.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(242, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Data de Cadastro"
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataCadastro.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Location = New System.Drawing.Point(269, 31)
        Me.txtDataCadastro.Mask = "00/00/0000"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(84, 25)
        Me.txtDataCadastro.TabIndex = 52
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(35, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTelefone.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(39, 191)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(105, 25)
        Me.txtTelefone.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(35, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(39, 138)
        Me.txtEmail.MaxLength = 70
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 25)
        Me.txtEmail.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(35, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(39, 80)
        Me.txtNome.MaxLength = 45
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 25)
        Me.txtNome.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(35, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "CNPJ"
        '
        'txtCnpj
        '
        Me.txtCnpj.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCnpj.Enabled = False
        Me.txtCnpj.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnpj.Location = New System.Drawing.Point(38, 31)
        Me.txtCnpj.Mask = "99,999,999/9999-99"
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(131, 25)
        Me.txtCnpj.TabIndex = 44
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(718, 254)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(66, 27)
        Me.btnFechar.TabIndex = 30
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(698, 221)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 27)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(674, 188)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(110, 27)
        Me.btnAlterar.TabIndex = 28
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(302, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Consulta de fornecedores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(324, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'frmConsultaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Consulta de fornecedor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cbUf As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataCadastro As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCnpj As MaskedTextBox
End Class
