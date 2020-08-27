Public Class frmPrevisaoVencimentoProduto
    Private Sub frmPrevisaoVencimentoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data As DateTime
            data = DateTime.Today
            data = data.AddDays(10)
            dgvProdutos.Rows.Clear()
            conexaoBanco()
            sql = "SELECT tbGerenciamentoProduto.idItem, tbProduto.idProduto, 
            tbProduto.nomeProduto, tbGerenciamentoProduto.dataEntradaProduto, 
            tbGerenciamentoProduto.dataVencimentoLote, tbGerenciamentoProduto.loteProduto, 
            tbGerenciamentoProduto.qtdProduto FROM tbProduto INNER JOIN tbGerenciamentoProduto 
            ON tbProduto.idProduto = tbGerenciamentoProduto.idProduto WHERE 
            (((tbGerenciamentoProduto.dataVencimentoLote) BETWEEN#" & DateTime.Today & "# AND #" & data & "#));"

            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                Do While rs.EOF = False
                    dgvProdutos.Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value.ToString.Substring(0, 10), rs.Fields(4).Value.ToString.Substring(0, 10), rs.Fields(5).Value, rs.Fields(6).Value)
                    rs.MoveNext()
                Loop

            Else
                MsgBox("Não há produtos próximos da data de validade", vbInformation)
                db.Close()
                Me.Close()
                Exit Sub
            End If
            db.Close()
            For i = dgvProdutos.Rows.Count - 1 To 0 Step -1
                Dim dataVencimento As Date = Date.Parse(dgvProdutos.Rows(i).Cells(3).Value)

                Dim qtdDiasVencimento As Long = DateDiff(DateInterval.Day, DateTime.Today, dataVencimento)

                If qtdDiasVencimento < 3 Then
                    dgvProdutos.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                ElseIf qtdDiasVencimento >= 3 And qtdDiasVencimento < 7 Then
                    dgvProdutos.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    dgvProdutos.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAdicionarProdutos.Show()
        Me.Hide()
    End Sub
End Class