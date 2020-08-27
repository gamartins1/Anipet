Public Class frmAlterarPrecoProduto
    Private Sub frmAlterarPrecoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT idProduto, nomeProduto FROM tbProduto"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dataCollection.Add(rs.Fields(0).Value)
                dataCollection.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            txtBuscaProduto.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBuscaProduto.AutoCompleteCustomSource = dataCollection
            txtBuscaProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarProduto.ShowDialog()
    End Sub

    Private Sub txtBuscaProduto_LostFocus(sender As Object, e As EventArgs) Handles txtBuscaProduto.LostFocus
        If txtBuscaProduto.Text = "" Then

        Else
            Try
                conexaoBanco()
                sql = "SELECT idProduto, nomeProduto, qtdEstoqueProduto, precoVendaProduto, precoCusto FROM tbProduto " _
                    & "WHERE nomeProduto = '" & txtBuscaProduto.Text & "' "
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    idProduto = rs.Fields(0).Value
                    txtBuscaProduto.Text = rs.Fields(1).Value
                    lblQtdEstoque.Text = rs.Fields(2).Value
                    lblPrecoVenda.Text = rs.Fields(3).Value
                    lblPrecoCustoAtual.Text = rs.Fields(4).Value
                    GroupBox1.Visible = True
                Else
                    GroupBox1.Visible = False
                    MsgBox("Produto não encontrado!" & vbCrLf & "Digite um produto cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                End If
                db.Close()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If CDbl(txtPrecoCusto.Text) >= CDbl(txtPrecoVenda.Text) Then
            MsgBox("O preço de custo é maior que o preço de venda!" & vbCrLf & "Dessa forma não haverá lucro nesse produto", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
            txtPrecoCusto.Focus()
            Exit Sub
        Else
            Try
                conexaoBanco()
                sql = "UPDATE tbProduto SET precoCusto = '" & txtPrecoCusto.Text & "', precoVendaProduto = '" _
                    & txtPrecoVenda.Text & "' WHERE idProduto = " & idProduto.ToString & ""
                rs = db.Execute(UCase(sql))
                MsgBox("Preços alterados com sucesso")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class