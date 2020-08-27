<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarPrecoServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlterarPrecoServico))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lblNomeServico = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecoCusto = New System.Windows.Forms.TextBox()
        Me.lblPrecoCustoAtual = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbBuscar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaServico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.lblNomeServico)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecoCusto)
        Me.GroupBox1.Controls.Add(Me.lblPrecoCustoAtual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 172)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(322, 140)
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
        Me.btnCancelar.Location = New System.Drawing.Point(302, 109)
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
        Me.btnAdicionar.Location = New System.Drawing.Point(282, 77)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(110, 27)
        Me.btnAdicionar.TabIndex = 42
        Me.btnAdicionar.Text = "Alterar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'lblNomeServico
        '
        Me.lblNomeServico.AutoSize = True
        Me.lblNomeServico.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeServico.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNomeServico.Location = New System.Drawing.Point(125, 38)
        Me.lblNomeServico.Name = "lblNomeServico"
        Me.lblNomeServico.Size = New System.Drawing.Size(52, 17)
        Me.lblNomeServico.TabIndex = 40
        Me.lblNomeServico.Text = ":$$$,$$:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(126, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Nome do serviço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(126, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Novo Preço de custo:"
        '
        'txtPrecoCusto
        '
        Me.txtPrecoCusto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPrecoCusto.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoCusto.Location = New System.Drawing.Point(128, 136)
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
        Me.lblPrecoCustoAtual.Location = New System.Drawing.Point(126, 86)
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
        Me.Label5.Location = New System.Drawing.Point(125, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Preço atual do serviço"
        '
        'pbBuscar
        '
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Image = CType(resources.GetObject("pbBuscar.Image"), System.Drawing.Image)
        Me.pbBuscar.Location = New System.Drawing.Point(286, 146)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(23, 23)
        Me.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBuscar.TabIndex = 39
        Me.pbBuscar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(90, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Digite o ID ou o nome do serviço:"
        '
        'txtBuscaServico
        '
        Me.txtBuscaServico.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBuscaServico.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaServico.Location = New System.Drawing.Point(109, 145)
        Me.txtBuscaServico.MaxLength = 110
        Me.txtBuscaServico.Name = "txtBuscaServico"
        Me.txtBuscaServico.Size = New System.Drawing.Size(173, 25)
        Me.txtBuscaServico.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(87, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Alterar Preço de Serviço"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anipet.My.Resources.Resources.Logo_Petshop
        Me.PictureBox1.Location = New System.Drawing.Point(128, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'frmAlterarPrecoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(402, 349)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaServico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlterarPrecoServico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Alterar Preço de um Serviço"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents lblNomeServico As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecoCusto As TextBox
    Friend WithEvents pbBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaServico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrecoCustoAtual As Label
    Friend WithEvents Label5 As Label
End Class
