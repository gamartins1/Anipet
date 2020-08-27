Public Class frmAlterarPrecoServico
    Private Sub frmAlterarPrecoServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT idServico, nomeServico FROM tbServicos"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dataCollection.Add(rs.Fields(0).Value)
                dataCollection.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            txtBuscaServico.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBuscaServico.AutoCompleteCustomSource = dataCollection
            txtBuscaServico.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscaServico_LostFocus(sender As Object, e As EventArgs) Handles txtBuscaServico.LostFocus
        If txtBuscaServico.Text = "" Then

        Else
            Try
                conexaoBanco()
                sql = "SELECT idServico, nomeServico, precoServico FROM tbServicos " _
                    & "WHERE nomeServico = '" & txtBuscaServico.Text & "' "
                rs = db.Execute(UCase(sql))

                If rs.EOF = False Then
                    idServico = rs.Fields(0).Value
                    txtBuscaServico.Text = rs.Fields(1).Value
                    lblNomeServico.Text = rs.Fields(1).Value
                    lblPrecoCustoAtual.Text = rs.Fields(2).Value
                    GroupBox1.Visible = True
                Else
                    GroupBox1.Visible = False
                    MsgBox("Serviço não encontrado!" & vbCrLf & "Digite um serviço cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                End If
                db.Close()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarServicos.ShowDialog()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbServicos SET precoServico = '" & txtPrecoCusto.Text & "' WHERE idServico = " & idServico
            rs = db.Execute(UCase(sql))
            MsgBox("Preço alterado com sucesso")
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        GroupBox1.Visible = False
        txtBuscaServico.Text = ""
        txtBuscaServico.Focus()
    End Sub
End Class