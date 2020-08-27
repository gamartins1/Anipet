Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conexaoBanco()
            Dim substringUser As String = UCase(txtUsuario.Text.Substring(0, 2))
            If substringUser = "AD" Then
                sql = "SELECT userAdm, senhaAdm FROM tbAdministrador WHERE userAdm='" & txtUsuario.Text & "' AND senhaAdm='" & txtSenha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then
                    usuario = UCase(txtUsuario.Text)
                    db.Close()
                    frmAdministrador.Show()
                    Me.Close()
                    frmSplash.Close()

                Else
                    MsgBox("Usuário ou senha incorretos!" & vbCrLf & "Verifique as informações", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                    db.Close()
                    txtUsuario.Focus()
                End If
            ElseIf substringUser = "FA" Then
                sql = "SELECT userFuncionario, senhaFuncionario FROM tbFuncionario WHERE userFuncionario='" & txtUsuario.Text & "' AND senhaFuncionario='" & txtSenha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then

                    usuario = UCase(txtUsuario.Text)
                    db.Close()
                    frmFuncionario.Show()
                    Me.Close()
                    frmSplash.Close()


                Else
                    MsgBox("Usuário ou senha incorretos!" & vbCrLf & "Verifique as informações", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                    db.Close()
                    txtUsuario.Focus()
                End If
            Else
                MsgBox("Usuário não encontrado, verifique as informações", MsgBoxStyle.Exclamation + vbOKOnly, "Anipet - AVISO")
                txtUsuario.Focus()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmSplash.Close()
    End Sub
End Class