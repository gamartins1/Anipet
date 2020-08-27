Public Class frmCadastroCliente
    Sub limpaCampos()
        txtCelular.Clear()
        txtCpf.Clear()
        txtNome.Clear()
        txtObservacoes.Clear()
        txtTelefone.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpaCampos()
    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        Try
            conexaoBanco()
            sql = "SELECT cpfCliente FROM tbCliente WHERE cpfCliente = '" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Esse CPF já está vinculado a um cliente", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
                txtCpf.Focus()
                db.Close()
                btnCadastrar.Enabled = False
                Exit Sub
            Else
                btnCadastrar.Enabled = True
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbCliente (cpfCliente, nomeCliente, telCliente, celCliente, dataCadCliente, obsCliente) VALUES" _
                & "('" & txtCpf.Text & "', '" & txtNome.Text & "', '" & txtTelefone.Text & "', '" & txtCelular.Text & "', '" _
                & DateTime.Today & "', '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Novo cliente cadastrado com sucesso!")
            resp = MsgBox("Deseja cadastrar também um animal pra esse cliente?", MsgBoxStyle.Question + vbYesNo, "Anipet - Novo animal")
            If resp = vbYes Then
                'Abrir formulário de cadastro de animal, e passar o id do cliente como parâmetro
                sql = "SELECT idCliente FROM tbCliente WHERE cpfCliente = '" & txtCpf.Text & "'"
                rs = db.Execute(UCase(sql))
                cliente = rs.Fields(0).Value
                db.Close()
                frmCadastrarAnimal.Show()
                Me.Hide()
            Else
                limpaCampos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class