Public Class frmConsultaProduto
    Private Sub frmConsultaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listagemProdutos()
    End Sub

    Private Sub listagemProdutos()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT tbProduto.idProduto, tbProduto.nomeProduto, tbProduto.precoVendaProduto, 
            tbProduto.qtdEstoqueProduto, tbProduto.idFornecedor, tbFornecedor.idFornecedor, 
            tbFornecedor.nomeFornecedor, tbProduto.obsProduto
            FROM tbFornecedor INNER JOIN tbProduto ON tbFornecedor.idFornecedor = tbProduto.idFornecedor;"

            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(6).Value, rs.Fields(7).Value)
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
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbProduto SET nomeProduto = '" & txtNome.Text & "', obsProduto = '" & txtObservacoes.Text _
                & "' WHERE idProduto = " & dgvDados.CurrentRow.Cells(0).Value
            rs = db.Execute(UCase(sql))

            MsgBox("Produto alterado com sucesso", vbInformation, "Aviso")
            db.Close()
            listagemProdutos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNome.Text = ""
        txtObservacoes.Text = ""
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class