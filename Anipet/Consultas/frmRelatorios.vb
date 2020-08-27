Public Class frmRelatorios
    Dim valorGanhos, valorDespesa As Double
    Private Sub frmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            valorGanhos = 0
            valorDespesa = 0
            dgvDespesas.Rows.Clear()
            dgvGanhos.Rows.Clear()

            conexaoBanco()
            sql = "SELECT idVenda, dataVenda, horaVenda, valorFinal, tipoPagamento FROM tbVenda WHERE statusVenda = 'FINALIZADA'"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvGanhos.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value.ToString.Substring(0, 10), rs.Fields(2).Value.ToString.Substring(10, 9), rs.Fields(3).Value, rs.Fields(4).Value)
                valorGanhos = valorGanhos + CDbl(rs.Fields(3).Value)
                rs.MoveNext()
            Loop
            db.Close()

            conexaoBanco()
            sql = "SELECT tbGerenciamentoProduto.idItem, tbGerenciamentoProduto.idProduto, tbProduto.idProduto, 
            tbProduto.nomeProduto, tbGerenciamentoProduto.loteProduto, tbGerenciamentoProduto.dataEntradaProduto, 
            tbGerenciamentoProduto.qtdProduto, tbProduto.precoCusto FROM tbProduto INNER JOIN 
            tbGerenciamentoProduto ON tbProduto.idProduto = tbGerenciamentoProduto.idProduto;"

            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDespesas.Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value.ToString.Substring(0, 10), rs.Fields(6).Value, rs.Fields(7).Value)
                valorDespesa = valorDespesa + CDbl(rs.Fields(7).Value)
                rs.MoveNext()
            Loop
            db.Close()
            lblNCompras.Text = dgvDespesas.Rows.Count
            lblNVendas.Text = dgvGanhos.Rows.Count
            lblValorGasto.Text = "R$" & Math.Round(valorDespesa, 2)
            lblValorRecebido.Text = "R$" & Math.Round(valorGanhos, 2)
        Catch ex As Exception
        End Try
    End Sub
End Class