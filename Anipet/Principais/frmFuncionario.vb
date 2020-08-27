Public Class frmFuncionario
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblData.Text = DateTime.Today
        lblUsuario.Text = usuario
    End Sub

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click
        frmCadastroCliente.ShowDialog()
    End Sub

    Private Sub btnCadastrarAnimal_Click(sender As Object, e As EventArgs) Handles btnCadastrarAnimal.Click
        frmCadastrarAnimal.ShowDialog()
    End Sub

    Private Sub btnRealizarVenda_Click(sender As Object, e As EventArgs) Handles btnRealizarVenda.Click
        frmVendas.ShowDialog()
    End Sub

    Private Sub btnNovoServico_Click(sender As Object, e As EventArgs) Handles btnNovoServico.Click
        frmNovoServico.ShowDialog()
    End Sub

    Private Sub btnConsultarFornecedor_Click(sender As Object, e As EventArgs) Handles btnConsultarFornecedor.Click
        frmConsultaFornecedor.ShowDialog()
    End Sub

    Private Sub btnHistoricoAnimal_Click(sender As Object, e As EventArgs) Handles btnHistoricoAnimal.Click
        frmHistoricoAnimal.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        usuario = ""
        Me.Hide()
        frmLogin.ShowDialog()

    End Sub

    Private Sub btnConsultarServico_Click(sender As Object, e As EventArgs) Handles btnConsultarServico.Click
        frmServicos.ShowDialog()
    End Sub

    Private Sub btnConsultarCliente_Click(sender As Object, e As EventArgs) Handles btnConsultarCliente.Click
        frmConsultaCliente.ShowDialog()
    End Sub
    Private Sub btnConsultarAnimal_Click(sender As Object, e As EventArgs) Handles btnConsultarAnimal.Click
        frmConsultaAnimal.ShowDialog()
    End Sub

    Private Sub btnConsultarProduto_Click(sender As Object, e As EventArgs) Handles btnConsultarProduto.Click
        frmConsultaProduto.ShowDialog()
    End Sub

    Private Sub btnCadastrarProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarProduto.Click
        frmCadastrarProdutos.ShowDialog()
    End Sub
End Class