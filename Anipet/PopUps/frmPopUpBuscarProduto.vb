Public Class frmPopUpBuscarProduto
    Private Sub frmPopUpBuscarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDados.Rows.Clear()

        Try
            conexaoBanco()
            sql = "SELECT idProduto, qtdEstoqueProduto, nomeProduto FROM tbProduto"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                If rs.Fields(1).Value <= 0 Then
                    rs.MoveNext()
                Else
                    dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                End If

            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xtBusca_TextChanged(sender As Object, e As EventArgs) Handles xtBusca.TextChanged
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idProduto, qtdEstoqueProduto, nomeProduto FROM tbProduto WHERE nomeProduto LIKE '" & xtBusca.Text & "%'"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                If rs.Fields(1).Value <= 0 Then
                    rs.MoveNext()
                Else
                    dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                End If

            Loop
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Then
            idProduto = dgvDados.CurrentRow.Cells(0).Value

            If Application.OpenForms.OfType(Of frmAdicionarProdutos)().Count() > 0 Then
                frmAdicionarProdutos.txtBuscaProduto.Text = dgvDados.CurrentRow.Cells(2).Value
                frmAdicionarProdutos.lblNome.Text = dgvDados.CurrentRow.Cells(2).Value
                frmAdicionarProdutos.lblQtdAtual.Text = dgvDados.CurrentRow.Cells(1).Value
                idProduto = dgvDados.CurrentRow.Cells(0).Value
                frmAdicionarProdutos.GroupBox1.Visible = True
            ElseIf Application.OpenForms.OfType(Of frmAlterarPrecoProduto)().Count() > 0 Then
                Try
                    conexaoBanco()
                    sql = "SELECT idProduto, nomeProduto, qtdEstoqueProduto, precoVendaProduto, precoCusto FROM tbProduto " _
                        & "WHERE idProduto = " & idProduto.ToString & " "
                    rs = db.Execute(UCase(sql))

                    If rs.EOF = False Then
                        frmAlterarPrecoProduto.txtBuscaProduto.Text = rs.Fields(1).Value
                        frmAlterarPrecoProduto.lblQtdEstoque.Text = rs.Fields(2).Value
                        frmAlterarPrecoProduto.lblPrecoVenda.Text = rs.Fields(3).Value
                        frmAlterarPrecoProduto.lblPrecoCustoAtual.Text = rs.Fields(4).Value
                        frmAlterarPrecoProduto.GroupBox1.Visible = True
                    Else
                        frmAlterarPrecoProduto.GroupBox1.Visible = False
                        MsgBox("Produto não encontrado!" & vbCrLf & "Digite um produto cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                    End If
                    db.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf Application.OpenForms.OfType(Of frmVendas)().Count() > 0 Then
                Try
                    If frmVendas.dgvVenda.Rows.Count = 0 Then
                        Dim data, hora As String
                        data = DateTime.Today
                        hora = TimeString.ToString
                        conexaoBanco()
                        sql = "INSERT INTO tbVenda (statusVenda, dataVenda, horaVenda) VALUES ('EM ANDAMENTO', '" _
                        & data & "', '" & hora & "')"
                        rs = db.Execute(UCase(sql))
                        db.Close()
                        frmVendas.btnPagamento.Visible = True
                        conexaoBanco()
                        sql = "SELECT idVenda, dataVenda, horaVenda FROM tbVenda WHERE dataVenda = #" & data _
                            & "# AND horaVenda = #" & hora & "#"
                        rs = db.Execute(UCase(sql))

                        If rs.EOF = False Then
                            idVenda = rs.Fields(0).Value
                        End If
                        db.Close()
                    End If
                    conexaoBanco()
                    sql = "SELECT idProduto, nomeProduto, precoVendaProduto FROM tbProduto WHERE idProduto = " & idProduto
                    rs = db.Execute(UCase(sql))

                    If rs.EOF = False Then
                        nomeProduto = rs.Fields(1).Value
                        precoVendaProduto = rs.Fields(2).Value
                    End If
                    db.Close()
                    frmVendas.txtBuscaProduto.Text = nomeProduto
                    frmVendas.txtQuantidade.Focus()
                    Me.Close()
                Catch ex As Exception
                End Try
            End If

            Me.Close()
        End If
    End Sub
End Class