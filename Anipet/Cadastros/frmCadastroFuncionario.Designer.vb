<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFuncionario))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRg = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataAdmissao = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(16, 274)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(211, 25)
        Me.txtNome.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CPF"
        '
        'txtCpf
        '
        Me.txtCpf.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCpf.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(15, 158)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(102, 25)
        Me.txtCpf.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(212, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Cadastrar novo colaborador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(13, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "RG"
        '
        'txtRg
        '
        Me.txtRg.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtRg.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRg.Location = New System.Drawing.Point(16, 210)
        Me.txtRg.Mask = "00,000,000-9"
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(101, 25)
        Me.txtRg.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(229, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Data de nascimento"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataNascimento.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataNascimento.Location = New System.Drawing.Point(258, 158)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(76, 25)
        Me.txtDataNascimento.TabIndex = 18
        Me.txtDataNascimento.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(254, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(258, 210)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(111, 25)
        Me.txtCelular.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(231, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Data de admissão"
        '
        'txtDataAdmissao
        '
        Me.txtDataAdmissao.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataAdmissao.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataAdmissao.Location = New System.Drawing.Point(258, 274)
        Me.txtDataAdmissao.Mask = "00/00/0000"
        Me.txtDataAdmissao.Name = "txtDataAdmissao"
        Me.txtDataAdmissao.Size = New System.Drawing.Size(76, 25)
        Me.txtDataAdmissao.TabIndex = 22
        Me.txtDataAdmissao.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(12, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtObservacoes.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoes.Location = New System.Drawing.Point(16, 327)
        Me.txtObservacoes.MaxLength = 300
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(549, 25)
        Me.txtObservacoes.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(412, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Cargo"
        '
        'cbCargo
        '
        Me.cbCargo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Items.AddRange(New Object() {"Atendente", "Banhista/tosador", "Caixa", "Estoquista", "Vendedor"})
        Me.cbCargo.Location = New System.Drawing.Point(415, 158)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(120, 23)
        Me.cbCargo.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(412, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Senha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(411, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Usuário"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtSenha.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(415, 274)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(121, 25)
        Me.txtSenha.TabIndex = 29
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(414, 210)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(122, 25)
        Me.txtUsuario.TabIndex = 28
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(608, 354)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 34
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(588, 325)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(568, 296)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 27)
        Me.btnCadastrar.TabIndex = 32
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(264, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(333, 276)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(14, 23)
        Me.DateTimePicker1.TabIndex = 48
        Me.DateTimePicker1.Value = New Date(2019, 5, 24, 19, 22, 4, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(333, 160)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(14, 23)
        Me.DateTimePicker2.TabIndex = 49
        Me.DateTimePicker2.Value = New Date(2019, 5, 24, 19, 22, 4, 0)
        '
        'frmCadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(680, 383)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataAdmissao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDataNascimento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCpf)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Cadastro de colaborador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRg As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDataNascimento As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataAdmissao As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSenha As MaskedTextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
