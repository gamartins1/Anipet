Public Class frmConsultaAdministrador
    Private Sub frmConsultaAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listagemAdms()
    End Sub

    Sub listagemAdms()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idAdm, cpfAdm, nomeAdm, emailAdm, telefoneAdm, obsAdm FROM tbAdministrador"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Or dgvDados.CurrentRow.Cells(3).Selected = True Or dgvDados.CurrentRow.Cells(4).Selected = True Or dgvDados.CurrentRow.Cells(5).Selected = True Then
            idAdm = dgvDados.CurrentRow.Cells(0).Value
            txtCelular.Text = dgvDados.CurrentRow.Cells(4).Value
            txtCpf.Text = dgvDados.CurrentRow.Cells(1).Value
            txtNome.Text = dgvDados.CurrentRow.Cells(2).Value
            txtObservacoes.Text = dgvDados.CurrentRow.Cells(5).Value
            txtEmail.Text = dgvDados.CurrentRow.Cells(3).Value
            Try
                conexaoBanco()
                sql = "SELECT userAdm, senhaAdm, idAdm FROM tbAdministrador WHERE idAdm = " & idAdm
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    txtUsuario.Text = rs.Fields(0).Value
                    txtSenha.Text = rs.Fields(1).Value
                End If
                db.Close()
                txtCpf.Enabled = False
                txtUsuario.Enabled = False
                TabControl1.SelectedTab = TabPage2
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCelular.Text = ""
        txtCpf.Text = ""
        txtEmail.Text = ""
        txtNome.Text = ""
        txtObservacoes.Text = ""
        txtSenha.Text = ""
        txtUsuario.Text = ""
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbAdministrador SET nomeAdm = '" & txtNome.Text & "', emailAdm = '" & txtEmail.Text & "', " _
                & "telefoneAdm = '" & txtCelular.Text & "', senhaAdm = '" & txtSenha.Text & "', obsAdm = '" _
                & txtObservacoes.Text & "' WHERE idAdm = " & idAdm
            rs = db.Execute(UCase(sql))
            MsgBox("Administrador alterado com sucesso", vbInformation, "Informação")
            db.Close()
            listagemAdms()
            TabControl1.SelectedTab = TabPage1
        Catch ex As Exception

        End Try
    End Sub
End Class