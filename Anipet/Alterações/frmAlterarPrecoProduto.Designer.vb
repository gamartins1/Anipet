<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarPrecoProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlterarPrecoProduto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaProduto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lblQtdEstoque = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecoCusto = New System.Windows.Forms.TextBox()
        Me.lblPrecoCustoAtual = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(139, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Alterar Preço de Produto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(180, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(338, 156)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 33
        Me.pbBuscar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(142, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Digite o ID ou o nome do produto:"
        '
        'txtBuscaProduto
        '
        Me.txtBuscaProduto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaProduto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaProduto.Location = New System.Drawing.Point(161, 155)
        Me.txtBuscaProduto.MaxLength = 110
        Me.txtBuscaProduto.Name = "txtBuscaProduto"
        Me.txtBuscaProduto.Size = New System.Drawing.Size(173, 25)
        Me.txtBuscaProduto.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.lblQtdEstoque)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPrecoVenda)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecoCusto)
        Me.GroupBox1.Controls.Add(Me.lblPrecoCustoAtual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPrecoVenda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 154)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(409, 123)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 44
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(389, 92)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 43
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(369, 60)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(110, 27)
        Me.btnAdicionar.TabIndex = 42
        Me.btnAdicionar.Text = "Alterar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'lblQtdEstoque
        '
        Me.lblQtdEstoque.AutoSize = True
        Me.lblQtdEstoque.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdEstoque.ForeColor = System.Drawing.SystemColors.Info
        Me.lblQtdEstoque.Location = New System.Drawing.Point(51, 38)
        Me.lblQtdEstoque.Name = "lblQtdEstoque"
        Me.lblQtdEstoque.Size = New System.Drawing.Size(52, 17)
        Me.lblQtdEstoque.TabIndex = 40
        Me.lblQtdEstoque.Text = ":$$$,$$:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(51, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Quantidade em estoque:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(215, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Novo Preço de venda:"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPrecoVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVenda.Location = New System.Drawing.Point(218, 106)
        Me.txtPrecoVenda.MaxLength = 10
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(73, 25)
        Me.txtPrecoVenda.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(215, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Novo Preço de custo:"
        '
        'txtPrecoCusto
        '
        Me.txtPrecoCusto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPrecoCusto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoCusto.Location = New System.Drawing.Point(218, 39)
        Me.txtPrecoCusto.MaxLength = 10
        Me.txtPrecoCusto.Name = "txtPrecoCusto"
        Me.txtPrecoCusto.Size = New System.Drawing.Size(73, 25)
        Me.txtPrecoCusto.TabIndex = 35
        '
        'lblPrecoCustoAtual
        '
        Me.lblPrecoCustoAtual.AutoSize = True
        Me.lblPrecoCustoAtual.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoCustoAtual.ForeColor = System.Drawing.SystemColors.Info
        Me.lblPrecoCustoAtual.Location = New System.Drawing.Point(51, 86)
        Me.lblPrecoCustoAtual.Name = "lblPrecoCustoAtual"
        Me.lblPrecoCustoAtual.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecoCustoAtual.TabIndex = 32
        Me.lblPrecoCustoAtual.Text = ":$$$,$$:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(51, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Preço de custo atual:"
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVenda.ForeColor = System.Drawing.SystemColors.Info
        Me.lblPrecoVenda.Location = New System.Drawing.Point(51, 131)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecoVenda.TabIndex = 30
        Me.lblPrecoVenda.Text = ":$$$,$$:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(51, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Preço de venda atual:"
        '
        'frmAlterarPrecoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(486, 347)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaProduto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlterarPrecoProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Alterar Preço de Produto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaProduto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrecoCustoAtual As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrecoVenda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecoCusto As TextBox
    Friend WithEvents lblQtdEstoque As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAdicionar As Button
End Class
