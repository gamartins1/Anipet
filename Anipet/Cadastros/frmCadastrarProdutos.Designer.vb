<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarProdutos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecoCusto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtdInicial = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(144, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cadastrar novo produto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(182, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(8, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(12, 167)
        Me.txtNome.MaxLength = 110
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 25)
        Me.txtNome.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(8, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fornecedor"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtFornecedor.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornecedor.Location = New System.Drawing.Point(12, 232)
        Me.txtFornecedor.MaxLength = 70
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(173, 25)
        Me.txtFornecedor.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(231, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Preco de custo"
        '
        'txtPrecoCusto
        '
        Me.txtPrecoCusto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPrecoCusto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoCusto.Location = New System.Drawing.Point(235, 167)
        Me.txtPrecoCusto.MaxLength = 10
        Me.txtPrecoCusto.Name = "txtPrecoCusto"
        Me.txtPrecoCusto.Size = New System.Drawing.Size(91, 25)
        Me.txtPrecoCusto.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(360, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Preco de venda"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPrecoVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVenda.Location = New System.Drawing.Point(364, 167)
        Me.txtPrecoVenda.MaxLength = 10
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(91, 25)
        Me.txtPrecoVenda.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(231, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Quantidade inicial"
        '
        'txtQtdInicial
        '
        Me.txtQtdInicial.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtQtdInicial.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdInicial.Location = New System.Drawing.Point(235, 232)
        Me.txtQtdInicial.MaxLength = 10
        Me.txtQtdInicial.Name = "txtQtdInicial"
        Me.txtQtdInicial.Size = New System.Drawing.Size(91, 25)
        Me.txtQtdInicial.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(7, 273)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 17)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtObservacoes.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoes.Location = New System.Drawing.Point(11, 296)
        Me.txtObservacoes.MaxLength = 70
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(332, 25)
        Me.txtObservacoes.TabIndex = 44
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(429, 325)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 49
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(409, 294)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 48
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(389, 262)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 27)
        Me.btnCadastrar.TabIndex = 47
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(187, 234)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 54
        Me.pbBuscar.TabStop = False
        '
        'frmCadastrarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(504, 354)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQtdInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecoVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrecoCusto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Cadastrar novos produtos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecoCusto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtdInicial As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents pbBuscar As PictureBox
End Class
