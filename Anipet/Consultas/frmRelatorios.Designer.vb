<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvGanhos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDespesas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblValorRecebido = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNVendas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNCompras = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblValorGasto = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGanhos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDespesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(418, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 28)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Relatórios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(400, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'dgvGanhos
        '
        Me.dgvGanhos.AllowUserToAddRows = False
        Me.dgvGanhos.AllowUserToOrderColumns = True
        Me.dgvGanhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGanhos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dgvGanhos.Location = New System.Drawing.Point(3, 156)
        Me.dgvGanhos.Name = "dgvGanhos"
        Me.dgvGanhos.ReadOnly = True
        Me.dgvGanhos.RowHeadersVisible = False
        Me.dgvGanhos.Size = New System.Drawing.Size(453, 320)
        Me.dgvGanhos.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "--"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 38
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Data Venda"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Horário"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 66
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 56
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Pagamento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 86
        '
        'dgvDespesas
        '
        Me.dgvDespesas.AllowUserToAddRows = False
        Me.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDespesas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvDespesas.Location = New System.Drawing.Point(458, 156)
        Me.dgvDespesas.Name = "dgvDespesas"
        Me.dgvDespesas.ReadOnly = True
        Me.dgvDespesas.RowHeadersVisible = False
        Me.dgvDespesas.Size = New System.Drawing.Size(453, 320)
        Me.dgvDespesas.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(170, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Ganhos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(641, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Despesas"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "--"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 38
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Nome"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Lote"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 53
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Data de entrada"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 109
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Quantidade"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 87
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Valor"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNVendas)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblValorRecebido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 482)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 78)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNCompras)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblValorGasto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 482)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 78)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'lblValorRecebido
        '
        Me.lblValorRecebido.AutoSize = True
        Me.lblValorRecebido.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorRecebido.ForeColor = System.Drawing.SystemColors.Info
        Me.lblValorRecebido.Location = New System.Drawing.Point(8, 36)
        Me.lblValorRecebido.Name = "lblValorRecebido"
        Me.lblValorRecebido.Size = New System.Drawing.Size(54, 17)
        Me.lblValorRecebido.TabIndex = 54
        Me.lblValorRecebido.Text = "R$00,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Valor recebido:"
        '
        'lblNVendas
        '
        Me.lblNVendas.AutoSize = True
        Me.lblNVendas.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNVendas.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNVendas.Location = New System.Drawing.Point(123, 37)
        Me.lblNVendas.Name = "lblNVendas"
        Me.lblNVendas.Size = New System.Drawing.Size(54, 17)
        Me.lblNVendas.TabIndex = 56
        Me.lblNVendas.Text = "R$00,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(123, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Número de vendas"
        '
        'lblNCompras
        '
        Me.lblNCompras.AutoSize = True
        Me.lblNCompras.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCompras.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNCompras.Location = New System.Drawing.Point(114, 38)
        Me.lblNCompras.Name = "lblNCompras"
        Me.lblNCompras.Size = New System.Drawing.Size(54, 17)
        Me.lblNCompras.TabIndex = 60
        Me.lblNCompras.Text = "R$00,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(114, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 17)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Número de compras:"
        '
        'lblValorGasto
        '
        Me.lblValorGasto.AutoSize = True
        Me.lblValorGasto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorGasto.ForeColor = System.Drawing.SystemColors.Info
        Me.lblValorGasto.Location = New System.Drawing.Point(6, 37)
        Me.lblValorGasto.Name = "lblValorGasto"
        Me.lblValorGasto.Size = New System.Drawing.Size(54, 17)
        Me.lblValorGasto.TabIndex = 58
        Me.lblValorGasto.Text = "R$00,00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Valor gasto:"
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(914, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDespesas)
        Me.Controls.Add(Me.dgvGanhos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Relatórios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGanhos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDespesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvGanhos As DataGridView
    Friend WithEvents dgvDespesas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblNVendas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblValorRecebido As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNCompras As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblValorGasto As Label
    Friend WithEvents Label10 As Label
End Class
