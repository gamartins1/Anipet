Public Class frmCadastroFuncionario
    Dim substringUser, numeroUser As String

    Sub randomizarUsuario()

    End Sub
    Sub limpaCampos()
        txtCelular.Clear()
        txtCpf.Clear()
        txtDataAdmissao.Clear()
        txtDataNascimento.Clear()
        txtNome.Clear()
        txtObservacoes.Clear()
        txtRg.Clear()
        txtSenha.Clear()
        txtUsuario.Clear()
        cbCargo.Text = ""
        txtUsuario.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtDataAdmissao.Text = DateTimePicker1.Value
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpaCampos()
    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        If txtCpf.Text = "" Then
            Exit Sub
        End If
        Try
            conexaoBanco()
            sql = "SELECT cpfFuncionario FROM tbFuncionario WHERE cpfFuncionario = '" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Esse CPF já está vinculado a um funcionário", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
                txtCpf.Focus()
                db.Close()
                btnCadastrar.Enabled = False
            Else
                btnCadastrar.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbFuncionario (cpfFuncionario, rgFuncionario, nomeFuncionario, telefoneFuncionario, " _
            & "dataNascFunc, dataAdmissaoFunc, cargoFuncionario, userFuncionario, senhaFuncionario, obsFuncionario)" _
            & "VALUES ('" & txtCpf.Text & "', '" & txtRg.Text & "', '" & txtNome.Text & "', '" & txtCelular.Text & "', '" _
            & txtDataNascimento.Text & "', '" & txtDataAdmissao.Text & "', '" & cbCargo.Text & "', '" & txtUsuario.Text _
            & "', '" & txtSenha.Text & "', '" & txtObservacoes.Text & "')"

            rs = db.Execute(UCase(sql))

            MsgBox("Novo funcionário cadastrado com sucesso")
            limpaCampos()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        txtDataNascimento.Text = DateTimePicker2.Value
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        Try
            conexaoBanco()
            sql = "SELECT idFuncionario, userFuncionario FROM tbFuncionario order by idFuncionario desc"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                substringUser = rs.Fields(1).Value
                numeroUser = CInt(substringUser.Substring(2, 4))
                numeroUser = numeroUser + 1
                txtUsuario.Text = "FA" & numeroUser
                txtUsuario.Enabled = False
                txtSenha.Focus()
                db.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class