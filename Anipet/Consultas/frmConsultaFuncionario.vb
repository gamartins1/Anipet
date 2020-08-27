Public Class frmConsultaFuncionario
    Private Sub frmConsultaFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listagemFuncionarios()
    End Sub

    Sub listagemFuncionarios()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idFuncionario, cpfFuncionario, nomeFuncionario, cargoFuncionario, telefoneFuncionario, " _
                & "obsFuncionario FROM tbFuncionario"
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
            txtNome.Text = dgvDados.CurrentRow.Cells(2).Value
            txtCpf.Text = dgvDados.CurrentRow.Cells(1).Value
            txtCelular.Text = dgvDados.CurrentRow.Cells(4).Value
            txtObservacoes.Text = dgvDados.CurrentRow.Cells(5).Value
            cbCargo.Text = dgvDados.CurrentRow.Cells(3).Value
            txtCpf.Enabled = False
            txtUsuario.Enabled = False
            idFuncionario = dgvDados.CurrentRow.Cells(0).Value
            Try
                conexaoBanco()
                sql = "SELECT idFuncionario, userFuncionario, senhaFuncionario FROM tbFuncionario WHERE idFuncionario" _
                    & " = " & idFuncionario
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    txtUsuario.Text = rs.Fields(1).Value
                    txtSenha.Text = rs.Fields(2).Value
                End If
                db.Close()
                TabControl1.SelectedTab = TabPage2
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbFuncionario SET nomeFuncionario = '" & txtNome.Text & "', telefoneFuncionario = '" _
                & txtCelular.Text & "', cargoFuncionario = '" & cbCargo.Text & "', senhaFuncionario = '" & txtSenha.Text _
                & "', obsFuncionario = '" & txtObservacoes.Text & "' WHERE idFuncionario = " & idFuncionario
            rs = db.Execute(UCase(sql))
            db.Close()
            MsgBox("Dados do funcionário alterados com sucesso", vbInformation, "Informação")
            listagemFuncionarios()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TabControl1.SelectedTab = TabPage1
        txtCelular.Text = ""
        txtCpf.Text = ""
        txtNome.Text = ""
        txtObservacoes.Text = ""
        txtSenha.Text = ""
        txtUsuario.Text = ""
    End Sub
End Class