Public Class frmAdicionarProdutos
    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarProduto.ShowDialog()
    End Sub

    Private Sub txtBuscaProduto_LostFocus(sender As Object, e As EventArgs) Handles txtBuscaProduto.LostFocus
        If txtBuscaProduto.Text = "" Then

        Else
            Try
                conexaoBanco()
                sql = "SELECT idProduto, nomeProduto, qtdEstoqueProduto FROM tbProduto WHERE nomeProduto = '" & txtBuscaProduto.Text & "' "
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    idProduto = rs.Fields(0).Value
                    lblNome.Text = rs.Fields(1).Value
                    lblQtdAtual.Text = rs.Fields(2).Value
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

    Private Sub frmAdicionarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbGerenciamentoProduto (idProduto, loteProduto, qtdProduto, dataEntradaProduto, dataVencimentoLote) " _
                & "VALUES ('" & idProduto & "', '" & txtLote.Text & "', '" & txtQtd.Text & "', '" & txtDataRecebimento.Text _
                & "', '" & txtDataValidade.Text & "')"
            rs = db.Execute(UCase(sql))

            MsgBox("Cadastrado com sucesso")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        GroupBox1.Visible = False
        txtBuscaProduto.Text = ""
        txtBuscaProduto.Focus()
    End Sub
End Class