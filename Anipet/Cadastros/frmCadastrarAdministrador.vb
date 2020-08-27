Public Class frmCadastrarAdministrador
    Dim substringUser, numeroUser As String
    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarFuncionario.ShowDialog()
    End Sub

    Private Sub frmCadastrarAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT idFuncionario, cpffuncionario, nomeFuncionario FROM tbFuncionario"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dataCollection.Add(rs.Fields(0).Value)
                dataCollection.Add(rs.Fields(1).Value)
                dataCollection.Add(rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            txtIdentificacao.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtIdentificacao.AutoCompleteCustomSource = dataCollection
            txtIdentificacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtIdentificacao_LostFocus(sender As Object, e As EventArgs) Handles txtIdentificacao.LostFocus
        If txtIdentificacao.Text = "" Then

        Else
            Try
                conexaoBanco()
                sql = "SELECT idFuncionario, cpfFuncionario, nomeFuncionario, telefoneFuncionario, dataNascFunc FROM" _
                    & "tbFuncionario WHERE nomeFuncionario = '" & txtIdentificacao.Text & "' "
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    idFuncionario = rs.Fields(0).Value
                    lblCpf.Text = rs.Fields(1).Value
                    lblNome.Text = rs.Fields(2).Value
                    lblTelefone.Text = rs.Fields(2).Value
                    lblDataNascimento.Text = rs.Fields(3).Value
                    GroupBox1.Visible = True
                Else
                    GroupBox1.Visible = False
                    MsgBox("Produto não encontrado!" & vbCrLf & "Digite um produto cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                End If
                db.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbAdministrador (cpfAdm, nomeAdm, telefoneAdm, emailAdm, dataNascAdm, userAdm, senhaAdm, " _
                & "obsAdm) VALUES ('" & lblCpf.Text & "', '" & lblNome.Text & "', '" & lblTelefone.Text & "', '" _
                & txtEmail.Text & "', '" & lblDataNascimento.Text & "', '" & txtUsuario.Text & "', '" & txtSenha.Text _
                & "', '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Novo administrador cadastrado com sucesso")
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdentificacao.Text = ""
        GroupBox1.Visible = False
        txtUsuario.Text = ""
        txtUsuario.Enabled = True
        txtIdentificacao.Focus()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        Try
            conexaoBanco()
            sql = "SELECT idAdm, userAdm FROM tbAdministrador order by idAdm desc"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                substringUser = rs.Fields(1).Value
                numeroUser = CInt(substringUser.Substring(2, 4))
                numeroUser = numeroUser + 1
                txtUsuario.Text = "AD" & numeroUser
                txtUsuario.Enabled = False
                txtSenha.Focus()
                db.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class