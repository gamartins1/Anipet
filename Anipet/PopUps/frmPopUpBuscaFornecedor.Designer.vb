<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUpBuscaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopUpBuscaFornecedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Digite o CNPJ ou " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o nome do fornecedor:"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(120, 12)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(256, 20)
        Me.txtBusca.TabIndex = 4
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvDados.Location = New System.Drawing.Point(7, 35)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(376, 247)
        Me.dgvDados.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.Column1.HeaderText = "--"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 21
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.Column2.FillWeight = 80.0!
        Me.Column2.HeaderText = "CNPJ"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 21
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        '
        'frmPopUpBuscaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 285)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.dgvDados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopUpBuscaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anipet - Buscar fornecedor"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
