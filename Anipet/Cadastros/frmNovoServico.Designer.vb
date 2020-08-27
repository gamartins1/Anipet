<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovoServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoServico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbServicos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataServico = New System.Windows.Forms.MaskedTextBox()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaAnimal = New System.Windows.Forms.TextBox()
        Me.txtHorario = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(99, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Agendar um serviço"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'cbServicos
        '
        Me.cbServicos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbServicos.FormattingEnabled = True
        Me.cbServicos.Location = New System.Drawing.Point(113, 158)
        Me.cbServicos.Name = "cbServicos"
        Me.cbServicos.Size = New System.Drawing.Size(153, 21)
        Me.cbServicos.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(128, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Selecione o serviço:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(139, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Data do serviço"
        '
        'txtDataServico
        '
        Me.txtDataServico.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDataServico.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataServico.Location = New System.Drawing.Point(150, 210)
        Me.txtDataServico.Mask = " 00/00/0000"
        Me.txtDataServico.Name = "txtDataServico"
        Me.txtDataServico.Size = New System.Drawing.Size(78, 25)
        Me.txtDataServico.TabIndex = 40
        Me.txtDataServico.ValidatingType = GetType(Date)
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(252, 316)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 44
        Me.pbBuscar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(166, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Animal"
        '
        'txtBuscaAnimal
        '
        Me.txtBuscaAnimal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaAnimal.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaAnimal.Location = New System.Drawing.Point(127, 314)
        Me.txtBuscaAnimal.MaxLength = 10
        Me.txtBuscaAnimal.Name = "txtBuscaAnimal"
        Me.txtBuscaAnimal.Size = New System.Drawing.Size(124, 25)
        Me.txtBuscaAnimal.TabIndex = 42
        '
        'txtHorario
        '
        Me.txtHorario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHorario.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.Location = New System.Drawing.Point(167, 265)
        Me.txtHorario.Mask = "00:00"
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(44, 25)
        Me.txtHorario.TabIndex = 45
        Me.txtHorario.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(163, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Horário"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 212)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(15, 22)
        Me.DateTimePicker1.TabIndex = 47
        Me.DateTimePicker1.Value = New Date(2019, 5, 24, 19, 22, 4, 0)
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Agendado", "Em andamento", "Finalizado"})
        Me.cbStatus.Location = New System.Drawing.Point(113, 369)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(153, 21)
        Me.cbStatus.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(128, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Status do serviço"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(322, 415)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 27)
        Me.btnFechar.TabIndex = 52
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(302, 384)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(282, 352)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 27)
        Me.btnCadastrar.TabIndex = 50
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'frmNovoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(394, 444)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaAnimal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataServico)
        Me.Controls.Add(Me.cbServicos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNovoServico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Agendamento de serviço"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbServicos As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataServico As MaskedTextBox
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaAnimal As TextBox
    Friend WithEvents txtHorario As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCadastrar As Button
End Class
