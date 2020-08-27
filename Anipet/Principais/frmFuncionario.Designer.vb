<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultarServico = New Anipet.RoundButton()
        Me.btnConsultarFornecedor = New Anipet.RoundButton()
        Me.btnConsultarProduto = New Anipet.RoundButton()
        Me.btnHistoricoAnimal = New Anipet.RoundButton()
        Me.btnConsultarAnimal = New Anipet.RoundButton()
        Me.btnConsultarCliente = New Anipet.RoundButton()
        Me.btnRealizarVenda = New Anipet.RoundButton()
        Me.btnNovoServico = New Anipet.RoundButton()
        Me.btnCadastrarAnimal = New Anipet.RoundButton()
        Me.btnCadastrarCliente = New Anipet.RoundButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCadastrarProduto = New Anipet.RoundButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnLogout
        '
        resources.ApplyResources(Me.btnLogout, "btnLogout")
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblHora
        '
        resources.ApplyResources(Me.lblHora, "lblHora")
        Me.lblHora.ForeColor = System.Drawing.SystemColors.Info
        Me.lblHora.Name = "lblHora"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.ForeColor = System.Drawing.SystemColors.Info
        Me.lblData.Name = "lblData"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Name = "Label2"
        '
        'lblUsuario
        '
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.Info
        Me.lblUsuario.Name = "lblUsuario"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Name = "Label5"
        '
        'Timer1
        '
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.SystemColors.Info
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.SystemColors.Info
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.SystemColors.Info
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.Info
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.Info
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.SystemColors.Info
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Name = "Label6"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Name = "Label3"
        '
        'btnConsultarServico
        '
        Me.btnConsultarServico.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnConsultarServico, "btnConsultarServico")
        Me.btnConsultarServico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarServico.Name = "btnConsultarServico"
        Me.btnConsultarServico.UseVisualStyleBackColor = False
        '
        'btnConsultarFornecedor
        '
        Me.btnConsultarFornecedor.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnConsultarFornecedor, "btnConsultarFornecedor")
        Me.btnConsultarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarFornecedor.Name = "btnConsultarFornecedor"
        Me.btnConsultarFornecedor.UseVisualStyleBackColor = False
        '
        'btnConsultarProduto
        '
        Me.btnConsultarProduto.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnConsultarProduto, "btnConsultarProduto")
        Me.btnConsultarProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarProduto.Name = "btnConsultarProduto"
        Me.btnConsultarProduto.UseVisualStyleBackColor = False
        '
        'btnHistoricoAnimal
        '
        Me.btnHistoricoAnimal.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnHistoricoAnimal, "btnHistoricoAnimal")
        Me.btnHistoricoAnimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistoricoAnimal.Name = "btnHistoricoAnimal"
        Me.btnHistoricoAnimal.UseVisualStyleBackColor = False
        '
        'btnConsultarAnimal
        '
        Me.btnConsultarAnimal.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnConsultarAnimal, "btnConsultarAnimal")
        Me.btnConsultarAnimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarAnimal.Name = "btnConsultarAnimal"
        Me.btnConsultarAnimal.UseVisualStyleBackColor = False
        '
        'btnConsultarCliente
        '
        Me.btnConsultarCliente.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnConsultarCliente, "btnConsultarCliente")
        Me.btnConsultarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarCliente.Name = "btnConsultarCliente"
        Me.btnConsultarCliente.UseVisualStyleBackColor = False
        '
        'btnRealizarVenda
        '
        Me.btnRealizarVenda.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnRealizarVenda, "btnRealizarVenda")
        Me.btnRealizarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRealizarVenda.Name = "btnRealizarVenda"
        Me.btnRealizarVenda.UseVisualStyleBackColor = False
        '
        'btnNovoServico
        '
        Me.btnNovoServico.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnNovoServico, "btnNovoServico")
        Me.btnNovoServico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoServico.Name = "btnNovoServico"
        Me.btnNovoServico.UseVisualStyleBackColor = False
        '
        'btnCadastrarAnimal
        '
        Me.btnCadastrarAnimal.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnCadastrarAnimal, "btnCadastrarAnimal")
        Me.btnCadastrarAnimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrarAnimal.Name = "btnCadastrarAnimal"
        Me.btnCadastrarAnimal.UseVisualStyleBackColor = False
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnCadastrarCliente, "btnCadastrarCliente")
        Me.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.UseVisualStyleBackColor = False
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.SystemColors.Info
        Me.Label14.Name = "Label14"
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnCadastrarProduto, "btnCadastrarProduto")
        Me.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.UseVisualStyleBackColor = False
        '
        'frmFuncionario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCadastrarProduto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConsultarServico)
        Me.Controls.Add(Me.btnConsultarFornecedor)
        Me.Controls.Add(Me.btnConsultarProduto)
        Me.Controls.Add(Me.btnHistoricoAnimal)
        Me.Controls.Add(Me.btnConsultarAnimal)
        Me.Controls.Add(Me.btnConsultarCliente)
        Me.Controls.Add(Me.btnRealizarVenda)
        Me.Controls.Add(Me.btnNovoServico)
        Me.Controls.Add(Me.btnCadastrarAnimal)
        Me.Controls.Add(Me.btnCadastrarCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFuncionario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConsultarServico As RoundButton
    Friend WithEvents btnConsultarFornecedor As RoundButton
    Friend WithEvents btnConsultarProduto As RoundButton
    Friend WithEvents btnHistoricoAnimal As RoundButton
    Friend WithEvents btnConsultarAnimal As RoundButton
    Friend WithEvents btnConsultarCliente As RoundButton
    Friend WithEvents btnRealizarVenda As RoundButton
    Friend WithEvents btnNovoServico As RoundButton
    Friend WithEvents btnCadastrarAnimal As RoundButton
    Friend WithEvents btnCadastrarCliente As RoundButton
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCadastrarProduto As RoundButton
End Class
