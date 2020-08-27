<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVenda = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelarVenda = New System.Windows.Forms.Button()
        Me.btnNovaVenda = New System.Windows.Forms.Button()
        Me.btnPausarVenda = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbPagamento = New System.Windows.Forms.GroupBox()
        Me.rbDinheiro = New System.Windows.Forms.RadioButton()
        Me.rbCartao = New System.Windows.Forms.RadioButton()
        Me.lblQuantiaEntregue = New System.Windows.Forms.Label()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.txtQuantiaEntregue = New System.Windows.Forms.TextBox()
        Me.btnFinalizarVenda = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPagamento = New System.Windows.Forms.Button()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbBuscarServicos = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscaServicos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaProduto = New System.Windows.Forms.TextBox()
        Me.btnContinuarVenda = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbPagamento.SuspendLayout()
        CType(Me.pbBuscarServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(453, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Vendas"
        '
        'dgvVenda
        '
        Me.dgvVenda.AllowUserToAddRows = False
        Me.dgvVenda.AllowUserToDeleteRows = False
        Me.dgvVenda.AllowUserToResizeColumns = False
        Me.dgvVenda.AllowUserToResizeRows = False
        Me.dgvVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.dgvVenda.Location = New System.Drawing.Point(1, 102)
        Me.dgvVenda.Name = "dgvVenda"
        Me.dgvVenda.ReadOnly = True
        Me.dgvVenda.RowHeadersVisible = False
        Me.dgvVenda.ShowEditingIcon = False
        Me.dgvVenda.Size = New System.Drawing.Size(606, 460)
        Me.dgvVenda.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "N° Venda"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 78
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "ID Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 83
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Val. Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "Qtd"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Val. Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 77
        '
        'btnCancelarVenda
        '
        Me.btnCancelarVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarVenda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancelarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnCancelarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarVenda.Location = New System.Drawing.Point(2, 48)
        Me.btnCancelarVenda.Name = "btnCancelarVenda"
        Me.btnCancelarVenda.Size = New System.Drawing.Size(104, 27)
        Me.btnCancelarVenda.TabIndex = 49
        Me.btnCancelarVenda.Text = "Cancelar venda"
        Me.btnCancelarVenda.UseVisualStyleBackColor = False
        '
        'btnNovaVenda
        '
        Me.btnNovaVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovaVenda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnNovaVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNovaVenda.Location = New System.Drawing.Point(110, 5)
        Me.btnNovaVenda.Name = "btnNovaVenda"
        Me.btnNovaVenda.Size = New System.Drawing.Size(104, 27)
        Me.btnNovaVenda.TabIndex = 50
        Me.btnNovaVenda.Text = "Nova venda"
        Me.btnNovaVenda.UseVisualStyleBackColor = False
        '
        'btnPausarVenda
        '
        Me.btnPausarVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPausarVenda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPausarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPausarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPausarVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnPausarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPausarVenda.Location = New System.Drawing.Point(2, 5)
        Me.btnPausarVenda.Name = "btnPausarVenda"
        Me.btnPausarVenda.Size = New System.Drawing.Size(104, 27)
        Me.btnPausarVenda.TabIndex = 51
        Me.btnPausarVenda.Text = "Pausar venda"
        Me.btnPausarVenda.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbPagamento)
        Me.GroupBox1.Controls.Add(Me.btnPagamento)
        Me.GroupBox1.Controls.Add(Me.lblValorTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pbBuscarServicos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBuscaServicos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQuantidade)
        Me.GroupBox1.Controls.Add(Me.pbBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBuscaProduto)
        Me.GroupBox1.Location = New System.Drawing.Point(613, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 466)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'gbPagamento
        '
        Me.gbPagamento.Controls.Add(Me.rbDinheiro)
        Me.gbPagamento.Controls.Add(Me.rbCartao)
        Me.gbPagamento.Controls.Add(Me.lblQuantiaEntregue)
        Me.gbPagamento.Controls.Add(Me.lblTroco)
        Me.gbPagamento.Controls.Add(Me.txtQuantiaEntregue)
        Me.gbPagamento.Controls.Add(Me.btnFinalizarVenda)
        Me.gbPagamento.Controls.Add(Me.Label7)
        Me.gbPagamento.Location = New System.Drawing.Point(207, 361)
        Me.gbPagamento.Name = "gbPagamento"
        Me.gbPagamento.Size = New System.Drawing.Size(195, 100)
        Me.gbPagamento.TabIndex = 56
        Me.gbPagamento.TabStop = False
        Me.gbPagamento.Visible = False
        '
        'rbDinheiro
        '
        Me.rbDinheiro.AutoSize = True
        Me.rbDinheiro.Location = New System.Drawing.Point(4, 33)
        Me.rbDinheiro.Name = "rbDinheiro"
        Me.rbDinheiro.Size = New System.Drawing.Size(64, 17)
        Me.rbDinheiro.TabIndex = 60
        Me.rbDinheiro.TabStop = True
        Me.rbDinheiro.Text = "Dinheiro"
        Me.rbDinheiro.UseVisualStyleBackColor = True
        '
        'rbCartao
        '
        Me.rbCartao.AutoSize = True
        Me.rbCartao.Location = New System.Drawing.Point(4, 13)
        Me.rbCartao.Name = "rbCartao"
        Me.rbCartao.Size = New System.Drawing.Size(56, 17)
        Me.rbCartao.TabIndex = 59
        Me.rbCartao.TabStop = True
        Me.rbCartao.Text = "Cartão"
        Me.rbCartao.UseVisualStyleBackColor = True
        '
        'lblQuantiaEntregue
        '
        Me.lblQuantiaEntregue.AutoSize = True
        Me.lblQuantiaEntregue.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantiaEntregue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblQuantiaEntregue.Location = New System.Drawing.Point(78, 11)
        Me.lblQuantiaEntregue.Name = "lblQuantiaEntregue"
        Me.lblQuantiaEntregue.Size = New System.Drawing.Size(112, 17)
        Me.lblQuantiaEntregue.TabIndex = 58
        Me.lblQuantiaEntregue.Text = "Quantia entregue:"
        Me.lblQuantiaEntregue.Visible = False
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.BackColor = System.Drawing.Color.Transparent
        Me.lblTroco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTroco.Location = New System.Drawing.Point(6, 74)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(77, 21)
        Me.lblTroco.TabIndex = 58
        Me.lblTroco.Text = "R$000,00"
        '
        'txtQuantiaEntregue
        '
        Me.txtQuantiaEntregue.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtQuantiaEntregue.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantiaEntregue.Location = New System.Drawing.Point(87, 33)
        Me.txtQuantiaEntregue.MaxLength = 10
        Me.txtQuantiaEntregue.Name = "txtQuantiaEntregue"
        Me.txtQuantiaEntregue.Size = New System.Drawing.Size(103, 25)
        Me.txtQuantiaEntregue.TabIndex = 57
        Me.txtQuantiaEntregue.Visible = False
        '
        'btnFinalizarVenda
        '
        Me.btnFinalizarVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarVenda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFinalizarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnFinalizarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFinalizarVenda.Location = New System.Drawing.Point(85, 62)
        Me.btnFinalizarVenda.Name = "btnFinalizarVenda"
        Me.btnFinalizarVenda.Size = New System.Drawing.Size(104, 33)
        Me.btnFinalizarVenda.TabIndex = 57
        Me.btnFinalizarVenda.Text = "Finalizar Venda"
        Me.btnFinalizarVenda.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(6, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 25)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Troco:"
        '
        'btnPagamento
        '
        Me.btnPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagamento.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagamento.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPagamento.Location = New System.Drawing.Point(6, 428)
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.Size = New System.Drawing.Size(104, 33)
        Me.btnPagamento.TabIndex = 54
        Me.btnPagamento.Text = "Pagamento"
        Me.btnPagamento.UseVisualStyleBackColor = False
        Me.btnPagamento.Visible = False
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblValorTotal.Location = New System.Drawing.Point(6, 400)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(87, 25)
        Me.lblValorTotal.TabIndex = 55
        Me.lblValorTotal.Text = "R$000,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(4, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 30)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Valor total:"
        '
        'pbBuscarServicos
        '
        Me.pbBuscarServicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscarServicos.Image = CType(resources.GetObject("pbBuscarServicos.Image"), System.Drawing.Image)
        Me.pbBuscarServicos.Location = New System.Drawing.Point(184, 146)
        Me.pbBuscarServicos.Name = "pbBuscarServicos"
        Me.pbBuscarServicos.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscarServicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscarServicos.TabIndex = 41
        Me.pbBuscarServicos.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(6, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Serviço:"
        '
        'txtBuscaServicos
        '
        Me.txtBuscaServicos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaServicos.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaServicos.Location = New System.Drawing.Point(9, 146)
        Me.txtBuscaServicos.MaxLength = 110
        Me.txtBuscaServicos.Name = "txtBuscaServicos"
        Me.txtBuscaServicos.Size = New System.Drawing.Size(173, 25)
        Me.txtBuscaServicos.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtQuantidade.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 89)
        Me.txtQuantidade.MaxLength = 10
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(73, 25)
        Me.txtQuantidade.TabIndex = 37
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(184, 38)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 36
        Me.pbBuscar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "ID ou o nome do produto:"
        '
        'txtBuscaProduto
        '
        Me.txtBuscaProduto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaProduto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaProduto.Location = New System.Drawing.Point(9, 38)
        Me.txtBuscaProduto.MaxLength = 110
        Me.txtBuscaProduto.Name = "txtBuscaProduto"
        Me.txtBuscaProduto.Size = New System.Drawing.Size(173, 25)
        Me.txtBuscaProduto.TabIndex = 34
        '
        'btnContinuarVenda
        '
        Me.btnContinuarVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinuarVenda.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinuarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuarVenda.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.btnContinuarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnContinuarVenda.Location = New System.Drawing.Point(110, 48)
        Me.btnContinuarVenda.Name = "btnContinuarVenda"
        Me.btnContinuarVenda.Size = New System.Drawing.Size(104, 27)
        Me.btnContinuarVenda.TabIndex = 53
        Me.btnContinuarVenda.Text = "Continuar venda"
        Me.btnContinuarVenda.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(438, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1024, 574)
        Me.Controls.Add(Me.btnContinuarVenda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPausarVenda)
        Me.Controls.Add(Me.btnNovaVenda)
        Me.Controls.Add(Me.btnCancelarVenda)
        Me.Controls.Add(Me.dgvVenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Realizar Venda"
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbPagamento.ResumeLayout(False)
        Me.gbPagamento.PerformLayout()
        CType(Me.pbBuscarServicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvVenda As DataGridView
    Friend WithEvents btnCancelarVenda As Button
    Friend WithEvents btnNovaVenda As Button
    Friend WithEvents btnPausarVenda As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnContinuarVenda As Button
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaProduto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents pbBuscarServicos As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscaServicos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPagamento As Button
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents gbPagamento As GroupBox
    Friend WithEvents lblQuantiaEntregue As Label
    Friend WithEvents lblTroco As Label
    Friend WithEvents txtQuantiaEntregue As TextBox
    Friend WithEvents btnFinalizarVenda As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents rbDinheiro As RadioButton
    Friend WithEvents rbCartao As RadioButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
