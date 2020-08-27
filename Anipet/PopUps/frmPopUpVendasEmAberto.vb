Public Class frmPopUpVendasEmAberto
    Private Sub frmPopUpVendasEmAberto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvVenda.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idVenda, dataVenda, horaVenda, statusVenda FROM tbVenda WHERE statusVenda = '" _
                & "EM ANDAMENTO' OR statusVenda = 'PAUSADA'"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvVenda.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value.ToString.Substring(0, 10), rs.Fields(2).Value.ToString.Substring(10, 9).Trim, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
            db.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenda.CellContentClick
        If dgvVenda.CurrentRow.Cells(0).Selected = True Or dgvVenda.CurrentRow.Cells(1).Selected = True Or dgvVenda.CurrentRow.Cells(2).Selected = True Or dgvVenda.CurrentRow.Cells(3).Selected = True Then
            frmVendas.dgvVenda.Rows.Clear()
            Try
                conexaoBanco()
                sql = "SELECT tbItemVenda.idVenda, tbItemVenda.idProduto, tbItemVenda.qtdVenda, 
                        tbItemVenda.valorUnitarioItem, tbItemVenda.valorTotalItem, tbProduto.idProduto, 
                        tbProduto.nomeProduto, tbVenda.idVenda FROM tbProduto INNER JOIN 
                        (tbVenda INNER JOIN tbItemVenda ON tbVenda.idVenda = tbItemVenda.idVenda) 
                        ON tbProduto.idProduto = tbItemVenda.idProduto WHERE (((tbVenda.idVenda)=" _
                        & dgvVenda.CurrentRow.Cells(0).Value & "));"
                rs = db.Execute(UCase(sql))
                idVenda = rs.Fields(0).Value
                precoTotalVenda = 0
                Do While rs.EOF = False
                    frmVendas.dgvVenda.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(4).Value)
                    precoTotalVenda = precoTotalVenda + rs.Fields(4).Value
                    rs.MoveNext()
                Loop
                frmVendas.GroupBox1.Visible = True
                frmVendas.btnPagamento.Visible = True
                frmVendas.lblValorTotal.Text = "R$" & precoTotalVenda
                db.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class