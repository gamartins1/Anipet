<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarFornecedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarFornecedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataCadastro = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.cbUf = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(260, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cadastrar novo fornecedor"
        '
        'txtCnpj
        '
        Me.txtCnpj.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCnpj.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnpj.Location = New System.Drawing.Point(12, 175)
        Me.txtCnpj.Mask = "99,999,999/9999-99"
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(131, 25)
        Me.txtCnpj.TabIndex = 18
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(13, 232)
        Me.txtNome.MaxLength = 45
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 25)
        Me.txtNome.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(9, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(13, 299)
        Me.txtEmail.MaxLength = 70
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 25)
        Me.txtEmail.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(9, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTelefone.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(13, 361)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(105, 25)
        Me.txtTelefone.TabIndex = 24
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataCadastro.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Location = New System.Drawing.Point(243, 175)
        Me.txtDataCadastro.Mask = "00/00/0000"
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Size = New System.Drawing.Size(84, 25)
        Me.txtDataCadastro.TabIndex = 26
        Me.txtDataCadastro.ValidatingType = GetType(Date)
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCep.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(243, 232)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(84, 25)
        Me.txtCep.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(239, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Rua"
        '
        'txtRua
        '
        Me.txtRua.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtRua.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.Location = New System.Drawing.Point(243, 299)
        Me.txtRua.MaxLength = 60
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(152, 25)
        Me.txtRua.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(238, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBairro.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(242, 361)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(152, 25)
        Me.txtBairro.TabIndex = 32
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCidade.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(438, 175)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(152, 25)
        Me.txtCidade.TabIndex = 34
        '
        'cbUf
        '
        Me.cbUf.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbUf.FormattingEnabled = True
        Me.cbUf.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cbUf.Location = New System.Drawing.Point(437, 234)
        Me.cbUf.Name = "cbUf"
        Me.cbUf.Size = New System.Drawing.Size(153, 23)
        Me.cbUf.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(433, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "UF"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(434, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "N° "
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNumero.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(438, 299)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(97, 25)
        Me.txtNumero.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(433, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Complemento"
        '
        'txtComplemento
        '
        Me.txtComplemento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtComplemento.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(437, 361)
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(152, 25)
        Me.txtComplemento.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(9, 396)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 17)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtObservacoes.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoes.Location = New System.Drawing.Point(13, 420)
        Me.txtObservacoes.MaxLength = 360
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(576, 25)
        Me.txtObservacoes.TabIndex = 42
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(679, 444)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 46
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(659, 413)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 45
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(639, 381)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 27)
        Me.btnCadastrar.TabIndex = 44
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(310, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(9, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(10, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 17)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "CNPJ"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(217, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 17)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Data de Cadastro"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(241, 207)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "CEP"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(435, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 17)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Cidade"
        '
        'frmCadastrarFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(753, 473)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.cbUf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDataCadastro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCnpj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Cadastrar Fornecedores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCnpj As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtDataCadastro As MaskedTextBox
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents cbUf As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
