Public Class frmConsultaCliente
    Private Sub frmConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizaClientes()
    End Sub

    Private Sub atualizaClientes()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idCliente, cpfCliente, nomeCliente, telCliente, celCliente, obsCliente FROM tbCliente"
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
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Or dgvDados.CurrentRow.Cells(3).Selected = True Then
            txtCpf.Text = dgvDados.CurrentRow.Cells(1).Value
            txtNome.Text = dgvDados.CurrentRow.Cells(2).Value
            txtTelefone.Text = dgvDados.CurrentRow.Cells(3).Value
            txtCelular.Text = dgvDados.CurrentRow.Cells(4).Value
            txtObservacoes.Text = dgvDados.CurrentRow.Cells(5).Value
            Try
                dgvAnimais.Rows.Clear()
                conexaoBanco()
                sql = "SELECT tbAnimal.idDonoAnimal, tbAnimal.nomeAnimal, tbAnimal.especieAnimal, 
                tbAnimal.racaAnimal, tbAnimal.obsAnimal, tbRacaAnimal.idRaca
                FROM tbRacaAnimal INNER JOIN tbAnimal ON tbRacaAnimal.idRaca = tbAnimal.racaAnimal
                WHERE (((tbAnimal.idDonoAnimal)=" & dgvDados.CurrentRow.Cells(0).Value.ToString & "));"
                rs = db.Execute(UCase(sql))
                Do While rs.EOF = False
                    dgvAnimais.Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
                db.Close()
                TabControl1.SelectedTab = TabPage2
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbCliente SET nomeCliente = '" & txtNome.Text & "', telCliente = '" & txtTelefone.Text _
                & "', celCliente = '" & txtCelular.Text & "', obsCliente = '" & txtObservacoes.Text & "' WHERE " _
                & "cpfCliente = '" & txtCpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("registro alterado com sucesso", vbInformation, "Aviso")
            db.Close()
            atualizaClientes()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCelular.Text = ""
        txtCpf.Text = ""
        txtNome.Text = ""
        txtObservacoes.Text = ""
        txtTelefone.Text = ""
        dgvAnimais.Rows.Clear()
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class