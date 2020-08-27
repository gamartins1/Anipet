Public Class frmPopUpBuscarServicos
    Private Sub frmPopUpBuscarServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDados.Rows.Clear()

        Try
            conexaoBanco()
            sql = "SELECT idServico, precoServico, nomeServico FROM tbServicos"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xtBusca_TextChanged(sender As Object, e As EventArgs) Handles xtBusca.TextChanged
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idServico, precoServico, nomeServico FROM tbServicos WHERE nomeServico LIKE '" & xtBusca.Text & "%'"
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

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Then
            idProduto = dgvDados.CurrentRow.Cells(0).Value

            If Application.OpenForms.OfType(Of frmAlterarPrecoServico)().Count() > 0 Then
                frmAlterarPrecoServico.txtBuscaServico.Text = dgvDados.CurrentRow.Cells(2).Value
                frmAlterarPrecoServico.lblNomeServico.Text = dgvDados.CurrentRow.Cells(2).Value
                frmAlterarPrecoServico.lblPrecoCustoAtual.Text = dgvDados.CurrentRow.Cells(1).Value
                idServico = dgvDados.CurrentRow.Cells(0).Value
                frmAlterarPrecoServico.GroupBox1.Visible = True
            End If
            Me.Close()
        End If

    End Sub
End Class