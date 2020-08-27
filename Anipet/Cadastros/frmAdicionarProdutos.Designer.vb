<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarProdutos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaProduto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataValidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataRecebimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.lblQtdAtual = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(92, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Adicionar produtos no estoque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(111, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Digite o ID ou o nome do produto:"
        '
        'txtBuscaProduto
        '
        Me.txtBuscaProduto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaProduto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaProduto.Location = New System.Drawing.Point(130, 164)
        Me.txtBuscaProduto.MaxLength = 10
        Me.txtBuscaProduto.Name = "txtBuscaProduto"
        Me.txtBuscaProduto.Size = New System.Drawing.Size(173, 25)
        Me.txtBuscaProduto.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDataValidade)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDataRecebimento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQtd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.lblQtdAtual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 231)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(382, 200)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 41
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(362, 169)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(342, 137)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(110, 27)
        Me.btnAdicionar.TabIndex = 39
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(328, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Válido até"
        '
        'txtDataValidade
        '
        Me.txtDataValidade.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataValidade.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataValidade.Location = New System.Drawing.Point(331, 108)
        Me.txtDataValidade.Mask = "00/00/0000"
        Me.txtDataValidade.Name = "txtDataValidade"
        Me.txtDataValidade.Size = New System.Drawing.Size(64, 25)
        Me.txtDataValidade.TabIndex = 37
        Me.txtDataValidade.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(319, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Data Recebida"
        '
        'txtDataRecebimento
        '
        Me.txtDataRecebimento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataRecebimento.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataRecebimento.Location = New System.Drawing.Point(331, 51)
        Me.txtDataRecebimento.Mask = "00/00/0000"
        Me.txtDataRecebimento.Name = "txtDataRecebimento"
        Me.txtDataRecebimento.Size = New System.Drawing.Size(64, 25)
        Me.txtDataRecebimento.TabIndex = 35
        Me.txtDataRecebimento.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(165, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Quantidade recebida"
        '
        'txtQtd
        '
        Me.txtQtd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtQtd.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(168, 108)
        Me.txtQtd.MaxLength = 10
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(95, 25)
        Me.txtQtd.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(165, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Lote:"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtLote.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(168, 51)
        Me.txtLote.MaxLength = 10
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(95, 25)
        Me.txtLote.TabIndex = 31
        '
        'lblQtdAtual
        '
        Me.lblQtdAtual.AutoSize = True
        Me.lblQtdAtual.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdAtual.ForeColor = System.Drawing.SystemColors.Info
        Me.lblQtdAtual.Location = New System.Drawing.Point(8, 92)
        Me.lblQtdAtual.Name = "lblQtdAtual"
        Me.lblQtdAtual.Size = New System.Drawing.Size(94, 17)
        Me.lblQtdAtual.TabIndex = 30
        Me.lblQtdAtual.Text = ":QUANTIDADE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Quantidade atual: "
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNome.Location = New System.Drawing.Point(8, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 28
        Me.lblNome.Text = ":NOME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nome: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(154, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(307, 165)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 30
        Me.pbBuscar.TabStop = False
        '
        'frmAdicionarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(462, 423)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaProduto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdicionarProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Adicionar produtos em estoque"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaProduto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNome As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQtdAtual As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDataValidade As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataRecebimento As MaskedTextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents pbBuscar As PictureBox
End Class
