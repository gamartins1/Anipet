<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvServicos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAgendado = New System.Windows.Forms.CheckBox()
        Me.cbAndamento = New System.Windows.Forms.CheckBox()
        Me.cbFinalizado = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHorario = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataServico = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNovoServico = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(393, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Serviços"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(381, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'dgvServicos
        '
        Me.dgvServicos.AllowUserToAddRows = False
        Me.dgvServicos.AllowUserToResizeRows = False
        Me.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvServicos.Location = New System.Drawing.Point(12, 157)
        Me.dgvServicos.Name = "dgvServicos"
        Me.dgvServicos.ReadOnly = True
        Me.dgvServicos.Size = New System.Drawing.Size(817, 326)
        Me.dgvServicos.TabIndex = 32
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAgendado)
        Me.GroupBox1.Controls.Add(Me.cbAndamento)
        Me.GroupBox1.Controls.Add(Me.cbFinalizado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(717, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 91)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'cbAgendado
        '
        Me.cbAgendado.AutoSize = True
        Me.cbAgendado.Checked = True
        Me.cbAgendado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAgendado.Location = New System.Drawing.Point(6, 68)
        Me.cbAgendado.Name = "cbAgendado"
        Me.cbAgendado.Size = New System.Drawing.Size(75, 17)
        Me.cbAgendado.TabIndex = 53
        Me.cbAgendado.Text = "Agendado"
        Me.cbAgendado.UseVisualStyleBackColor = True
        '
        'cbAndamento
        '
        Me.cbAndamento.AutoSize = True
        Me.cbAndamento.Checked = True
        Me.cbAndamento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAndamento.Location = New System.Drawing.Point(6, 50)
        Me.cbAndamento.Name = "cbAndamento"
        Me.cbAndamento.Size = New System.Drawing.Size(97, 17)
        Me.cbAndamento.TabIndex = 52
        Me.cbAndamento.Text = "Em andamento"
        Me.cbAndamento.UseVisualStyleBackColor = True
        '
        'cbFinalizado
        '
        Me.cbFinalizado.AutoSize = True
        Me.cbFinalizado.Checked = True
        Me.cbFinalizado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFinalizado.Location = New System.Drawing.Point(6, 32)
        Me.cbFinalizado.Name = "cbFinalizado"
        Me.cbFinalizado.Size = New System.Drawing.Size(73, 17)
        Me.cbFinalizado.TabIndex = 51
        Me.cbFinalizado.Text = "Finalizado"
        Me.cbFinalizado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHorario)
        Me.GroupBox2.Controls.Add(Me.txtDataServico)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(601, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 91)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'txtHorario
        '
        Me.txtHorario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHorario.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.Location = New System.Drawing.Point(33, 62)
        Me.txtHorario.Mask = "00:00"
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(44, 25)
        Me.txtHorario.TabIndex = 52
        Me.txtHorario.ValidatingType = GetType(Date)
        '
        'txtDataServico
        '
        Me.txtDataServico.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataServico.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataServico.Location = New System.Drawing.Point(17, 32)
        Me.txtDataServico.Mask = " 00/00/0000"
        Me.txtDataServico.Name = "txtDataServico"
        Me.txtDataServico.Size = New System.Drawing.Size(78, 25)
        Me.txtDataServico.TabIndex = 51
        Me.txtDataServico.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(14, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Data/Horário"
        '
        'btnNovoServico
        '
        Me.btnNovoServico.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnNovoServico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoServico.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoServico.Location = New System.Drawing.Point(835, 433)
        Me.btnNovoServico.Name = "btnNovoServico"
        Me.btnNovoServico.Size = New System.Drawing.Size(86, 27)
        Me.btnNovoServico.TabIndex = 55
        Me.btnNovoServico.Text = "Novo Servico"
        Me.btnNovoServico.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(861, 466)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(60, 27)
        Me.btnFechar.TabIndex = 56
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(923, 495)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnNovoServico)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvServicos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Serviços"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvServicos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbAgendado As CheckBox
    Friend WithEvents cbAndamento As CheckBox
    Friend WithEvents cbFinalizado As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHorario As MaskedTextBox
    Friend WithEvents txtDataServico As MaskedTextBox
    Friend WithEvents btnNovoServico As Button
    Friend WithEvents btnFechar As Button
End Class
