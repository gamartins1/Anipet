<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarAnimal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cbEspecie = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbRaca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPorte = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdentificacaoDono = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(139, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cadastrar novo animal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(175, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(8, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nome do animal"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(12, 182)
        Me.txtNome.MaxLength = 10
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 25)
        Me.txtNome.TabIndex = 24
        '
        'cbEspecie
        '
        Me.cbEspecie.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Items.AddRange(New Object() {"Cachorro", "Gato", "Pássaro"})
        Me.cbEspecie.Location = New System.Drawing.Point(11, 246)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(174, 21)
        Me.cbEspecie.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(8, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Espécie"
        '
        'cbRaca
        '
        Me.cbRaca.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbRaca.FormattingEnabled = True
        Me.cbRaca.Location = New System.Drawing.Point(12, 308)
        Me.cbRaca.Name = "cbRaca"
        Me.cbRaca.Size = New System.Drawing.Size(174, 21)
        Me.cbRaca.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(9, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Raça"
        '
        'cbPorte
        '
        Me.cbPorte.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cbPorte.FormattingEnabled = True
        Me.cbPorte.Items.AddRange(New Object() {"Pequeno", "Médio", "Grande"})
        Me.cbPorte.Location = New System.Drawing.Point(237, 185)
        Me.cbPorte.Name = "cbPorte"
        Me.cbPorte.Size = New System.Drawing.Size(136, 21)
        Me.cbPorte.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(234, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Porte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(233, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Identificação do dono"
        '
        'txtIdentificacaoDono
        '
        Me.txtIdentificacaoDono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtIdentificacaoDono.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIdentificacaoDono.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacaoDono.Location = New System.Drawing.Point(237, 243)
        Me.txtIdentificacaoDono.MaxLength = 10
        Me.txtIdentificacaoDono.Name = "txtIdentificacaoDono"
        Me.txtIdentificacaoDono.Size = New System.Drawing.Size(136, 25)
        Me.txtIdentificacaoDono.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(8, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 17)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Observações"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtObservacoes.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoes.Location = New System.Drawing.Point(12, 364)
        Me.txtObservacoes.MaxLength = 350
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(361, 25)
        Me.txtObservacoes.TabIndex = 46
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(432, 365)
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
        Me.btnCancelar.Location = New System.Drawing.Point(412, 334)
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
        Me.btnCadastrar.Location = New System.Drawing.Point(392, 302)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(110, 27)
        Me.btnCadastrar.TabIndex = 50
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(373, 244)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 53
        Me.pbBuscar.TabStop = False
        '
        'frmCadastrarAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(506, 394)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtObservacoes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdentificacaoDono)
        Me.Controls.Add(Me.cbPorte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbRaca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbEspecie)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Cadastrar Animal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cbEspecie As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbRaca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbPorte As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdentificacaoDono As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtObservacoes As TextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents pbBuscar As PictureBox
End Class
