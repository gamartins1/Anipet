Public Class frmPopUpBuscaFornecedor
    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Then
            idFornecedor = dgvDados.CurrentRow.Cells(0).Value
            frmCadastrarProdutos.txtFornecedor.Text = dgvDados.CurrentRow.Cells(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idFornecedor, cnpjFornecedor, nomeFornecedor FROM tbFornecedor WHERE nomeFornecedor LIKE '" & txtBusca.Text & "%' OR cnpjFornecedor LIKE '" & txtBusca.Text & "%'"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmPopUpBuscaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDados.Rows.Clear()
        Try
            conexaoBanco()
            sql = "SELECT idFornecedor, cnpjFornecedor, nomeFornecedor FROM tbFornecedor"
            rs = db.Execute(UCase(sql))
            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class