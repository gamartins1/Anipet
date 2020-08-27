Public Class frmConsultaAnimal
    Private Sub frmConsultaAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarAnimais()
    End Sub

    Private Sub listarAnimais()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT tbAnimal.idAnimal, tbCliente.nomeCliente, tbAnimal.nomeAnimal, tbAnimal.especieAnimal, 
            tbAnimal.racaAnimal, tbRacaAnimal.racaAnimal, tbAnimal.obsAnimal FROM tbCliente INNER JOIN 
            (tbRacaAnimal INNER JOIN tbAnimal ON tbRacaAnimal.idRaca = tbAnimal.racaAnimal) ON 
            tbCliente.idCliente = tbAnimal.idDonoAnimal;"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(6).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Or dgvDados.CurrentRow.Cells(3).Selected = True Or dgvDados.CurrentRow.Cells(4).Selected = True Then
            txtNome.Text = dgvDados.CurrentRow.Cells(1).Value
            txtObservacoes.Text = dgvDados.CurrentRow.Cells(5).Value
            cbPorte.Text = "MÉDIO"
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbAnimal SET nomeAnimal = '" & txtNome.Text & "', porteAnimal = '" & cbPorte.Text & "', " _
                & "obsAnimal = '" & txtObservacoes.Text & "' WHERE idAnimal = " & dgvDados.CurrentRow.Cells(0).Value
            rs = db.Execute(UCase(sql))
            MsgBox("Registro alterado com sucesso", vbInformation, "Aviso")
            db.Close()
            listarAnimais()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNome.Text = ""
        txtObservacoes.Text = ""
        cbPorte.Text = ""
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class