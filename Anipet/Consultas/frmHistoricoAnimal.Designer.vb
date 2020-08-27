<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoAnimal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaAnimal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnNovaConsulta = New System.Windows.Forms.Button()
        Me.lblValorGasto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQtdServicos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(158, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Consultar Histórico do Animal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(237, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(345, 156)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 47
        Me.pbBuscar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(215, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Digite o nome do animal"
        '
        'txtBuscaAnimal
        '
        Me.txtBuscaAnimal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaAnimal.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaAnimal.Location = New System.Drawing.Point(218, 156)
        Me.txtBuscaAnimal.MaxLength = 10
        Me.txtBuscaAnimal.Name = "txtBuscaAnimal"
        Me.txtBuscaAnimal.Size = New System.Drawing.Size(124, 25)
        Me.txtBuscaAnimal.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnNovaConsulta)
        Me.GroupBox1.Controls.Add(Me.lblValorGasto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblQtdServicos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 237)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(483, 205)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(76, 27)
        Me.btnFechar.TabIndex = 53
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnNovaConsulta
        '
        Me.btnNovaConsulta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnNovaConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaConsulta.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovaConsulta.Location = New System.Drawing.Point(372, 205)
        Me.btnNovaConsulta.Name = "btnNovaConsulta"
        Me.btnNovaConsulta.Size = New System.Drawing.Size(110, 27)
        Me.btnNovaConsulta.TabIndex = 49
        Me.btnNovaConsulta.Text = "Nova consulta"
        Me.btnNovaConsulta.UseVisualStyleBackColor = False
        '
        'lblValorGasto
        '
        Me.lblValorGasto.AutoSize = True
        Me.lblValorGasto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorGasto.ForeColor = System.Drawing.SystemColors.Info
        Me.lblValorGasto.Location = New System.Drawing.Point(167, 208)
        Me.lblValorGasto.Name = "lblValorGasto"
        Me.lblValorGasto.Size = New System.Drawing.Size(54, 17)
        Me.lblValorGasto.TabIndex = 52
        Me.lblValorGasto.Text = "R$00,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(167, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Valor já gasto:"
        '
        'lblQtdServicos
        '
        Me.lblQtdServicos.AutoSize = True
        Me.lblQtdServicos.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdServicos.ForeColor = System.Drawing.SystemColors.Info
        Me.lblQtdServicos.Location = New System.Drawing.Point(9, 208)
        Me.lblQtdServicos.Name = "lblQtdServicos"
        Me.lblQtdServicos.Size = New System.Drawing.Size(15, 17)
        Me.lblQtdServicos.TabIndex = 50
        Me.lblQtdServicos.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(9, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Quantidade de Serviços:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(552, 174)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Nome"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Serviço"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Data"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Valor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frmHistoricoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(580, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaAnimal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistoricoAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Histórico do Animal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaAnimal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblQtdServicos As Label
    Friend WithEvents lblValorGasto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnNovaConsulta As Button
End Class
