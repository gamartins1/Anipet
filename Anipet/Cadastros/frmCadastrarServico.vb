Public Class frmCadastrarServico
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbServicos (nomeServico, precoServico, obsServico) VALUES ('" & txtNome.Text _
                & "', '" & txtPrecoServico.Text & "', '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Novo servico cadastrado com sucesso")
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNome.Text = ""
        txtObservacoes.Text = ""
        txtPrecoServico.Text = ""

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class