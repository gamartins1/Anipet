Public Class frmCadastrarProdutos
    Private Sub frmCadastrarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT idFornecedor, nomeFornecedor FROM tbFornecedor"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dataCollection.Add(rs.Fields(0).Value)
                dataCollection.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            txtFornecedor.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtFornecedor.AutoCompleteCustomSource = dataCollection
            txtFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFornecedor_LostFocus(sender As Object, e As EventArgs) Handles txtFornecedor.LostFocus
        Try

            conexaoBanco()
            sql = "SELECT idFornecedor, nomeFornecedor FROM tbFornecedor WHERE nomeFornecedor = '" & txtFornecedor.Text & "' "
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                idFornecedor = rs.Fields(0).Value
                btnCadastrar.Enabled = True
            Else
                MsgBox("Fornecedor não encontrado!" & vbCrLf & "Digite um fornecedor cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                btnCadastrar.Enabled = False
            End If
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscaFornecedor.ShowDialog()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If CDbl(txtPrecoCusto.Text) >= CDbl(txtPrecoVenda.Text) Then
            MsgBox("O preço de custo informado é maior que o preço de venda, dessa forma não haverá lucro." & vbCrLf & "Corriga os valores", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
            Exit Sub
        End If
        Try
            conexaoBanco()
            sql = "INSERT INTO tbProduto(nomeProduto, qtdEstoqueProduto, precoVendaProduto, precoCusto, idFornecedor, obsProduto)" _
                & " VALUES ('" & txtNome.Text & "', '" & txtQtdInicial.Text & "', '" & txtPrecoVenda.Text & "', '" _
                & txtPrecoCusto.Text & "', '" & idFornecedor & "', '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Novo produto cadastrado com sucesso")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtFornecedor_TextChanged(sender As Object, e As EventArgs) Handles txtFornecedor.TextChanged

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtFornecedor.Text = ""
        txtNome.Text = ""
        txtObservacoes.Text = ""
        txtPrecoCusto.Text = ""
        txtPrecoVenda.Text = ""
        txtQtdInicial.Text = ""
        txtNome.Focus()
    End Sub
End Class