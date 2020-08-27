Public Class frmVendas
    Dim tipoPagamento As String
    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarProduto.ShowDialog()
    End Sub

    Private Sub txtQuantidade_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBuscaProduto.Text <> "" Then
                precoTotalProduto = CDbl(txtQuantidade.Text) * CDbl(precoVendaProduto)
                precoTotalVenda = precoTotalVenda + precoTotalProduto
                dgvVenda.Rows.Add(idVenda, idProduto, nomeProduto, precoVendaProduto, txtQuantidade.Text, precoTotalProduto)
                lblValorTotal.Text = "R$" & precoTotalVenda
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbItemVenda (idVenda, idProduto, qtdVenda, valorUnitarioItem, valorTotalItem) " _
                        & "VALUES (" & idVenda & ", " & idProduto & ", " & txtQuantidade.Text & ", '" _
                        & precoVendaProduto & "', '" & precoTotalProduto & "')"
                    rs = db.Execute(UCase(sql))
                    db.Close()

                    conexaoBanco()
                    sql = "UPDATE tbProduto SET qtdEstoqueProduto = qtdEstoqueProduto - " & txtQuantidade.Text _
                        & " WHERE idProduto = " & idProduto
                    rs = db.Execute(UCase(sql))
                    db.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNovaVenda_Click(sender As Object, e As EventArgs) Handles btnNovaVenda.Click
        If dgvVenda.Rows.Count > 0 Then
            MsgBox("Você está com uma venda em andamento!" & vbCrLf & "Pra iniciar uma nova venda, pause a venda atual", vbCritical, "Aviso")
            Exit Sub
        Else
            GroupBox1.Visible = True
        End If

    End Sub

    Private Sub btnCancelarVenda_Click(sender As Object, e As EventArgs) Handles btnCancelarVenda.Click
        If dgvVenda.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim resp = MsgBox("Deseja realmente excluir toda a venda?", vbQuestion + vbYesNoCancel, "Aviso")
        If resp = vbYes Then
            Try
                conexaoBanco()
                sql = "UPDATE tbVenda SET statusVenda = 'CANCELADA' WHERE idVenda = " & idVenda
                rs = db.Execute(UCase(sql))
                db.Close()
                For i = dgvVenda.Rows.Count - 1 To 0 Step -1
                    conexaoBanco()
                    sql = "UPDATE tbProduto SET qtdEstoqueProduto = qtdEstoqueProduto + " _
                        & dgvVenda.Rows(i).Cells(4).Value & " WHERE idProduto = " _
                        & dgvVenda.Rows(i).Cells(1).Value
                    rs = db.Execute(UCase(sql))
                    dgvVenda.Rows.RemoveAt(i)
                    db.Close()
                Next
                txtBuscaProduto.Text = ""
                txtQuantidade.Text = ""
                GroupBox1.Visible = False
                MsgBox("Venda cancelada com sucesso", vbInformation, "Informação")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnPausarVenda_Click(sender As Object, e As EventArgs) Handles btnPausarVenda.Click
        If dgvVenda.Rows.Count = 0 Then
            MsgBox("Você não está com nenhuma venda em andamento!", vbExclamation, "Aviso")
            Exit Sub
        Else
            Try
                conexaoBanco()
                sql = "UPDATE tbVenda SET statusVenda = 'PAUSADA' WHERE idVenda = " & idVenda
                rs = db.Execute(UCase(sql))
                db.Close()
                For i = dgvVenda.Rows.Count - 1 To 0 Step -1
                    dgvVenda.Rows.RemoveAt(i)
                Next
                txtBuscaProduto.Text = ""
                txtQuantidade.Text = ""
                GroupBox1.Visible = False
                MsgBox("Venda pausada", vbInformation, "Informação")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnContinuarVenda_Click(sender As Object, e As EventArgs) Handles btnContinuarVenda.Click
        frmPopUpVendasEmAberto.ShowDialog()
    End Sub

    Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        If dgvVenda.Rows.Count = 0 Then
            MsgBox("Não há produtos na venda!", vbCritical, "Aviso")
        Else
            gbPagamento.Visible = True
        End If
    End Sub

    Private Sub rbDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rbDinheiro.CheckedChanged
        If rbDinheiro.Checked = True Then
            lblQuantiaEntregue.Visible = True
            txtQuantiaEntregue.Visible = True
            tipoPagamento = "Dinheiro"
        Else
            lblQuantiaEntregue.Visible = False
            txtQuantiaEntregue.Visible = False
            lblTroco.Text = "R$00,00"
            tipoPagamento = "Cartão"
        End If
    End Sub

    Private Sub txtQuantiaEntregue_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantiaEntregue.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CDbl(lblValorTotal.Text) > CDbl(txtQuantiaEntregue.Text) Then
                MsgBox("A quantia não paga o valor final da venda", vbExclamation, "Aviso")
            Else
                lblTroco.Text = "R$" & Math.Round(CDbl(txtQuantiaEntregue.Text) - CDbl(lblValorTotal.Text), 2)
            End If
        End If
    End Sub

    Private Sub pbBuscarServicos_Click(sender As Object, e As EventArgs) Handles pbBuscarServicos.Click
        frmPopUpBuscarServicosEmAndamento.ShowDialog()
    End Sub

    Private Sub btnFinalizarVenda_Click(sender As Object, e As EventArgs) Handles btnFinalizarVenda.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbVenda SET valorFinal = '" & lblValorTotal.Text & "', tipoPagamento = '" & tipoPagamento _
                & "', responsavelVenda = '" & usuario & "', statusVenda = 'FINALIZADA' WHERE idVenda = " & idVenda
            rs = db.Execute(UCase(sql))
            db.Close()
            MsgBox("Venda concluída com sucesso!", vbInformation)
            lblTroco.Text = "R$00,00"
            lblValorTotal.Text = "R$00,00"
            txtBuscaProduto.Text = ""
            txtBuscaServicos.Text = ""
            txtQuantiaEntregue.Text = ""
            GroupBox1.Visible = False
            dgvVenda.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenda.CellContentClick
        If dgvVenda.CurrentRow.Cells(0).Selected = True Or dgvVenda.CurrentRow.Cells(1).Selected = True Or dgvVenda.CurrentRow.Cells(2).Selected = True Or dgvVenda.CurrentRow.Cells(3).Selected = True Or dgvVenda.CurrentRow.Cells(4).Selected = True Then
            resp = MsgBox("Deseja realmente excluir o produto da venda?", vbQuestion + vbYesNo)
            If resp = vbYes Then
                Try
                    conexaoBanco()
                    sql = "DELETE * FROM tbItemVenda WHERE idVenda = " & dgvVenda.CurrentRow.Cells(0).Value _
                        & " AND idProduto = " & dgvVenda.CurrentRow.Cells(1).Value
                    rs = db.Execute(UCase(sql))
                    db.Close()

                    conexaoBanco()
                    sql = "UPDATE tbProduto SET qtdEstoqueProduto = qtdEstoqueProduto + " & dgvVenda.CurrentRow.Cells(4).Value _
                        & " WHERE idProduto = " & dgvVenda.CurrentRow.Cells(1).Value
                    rs = db.Execute(UCase(sql))

                    precoTotalVenda = precoTotalVenda - CDbl(dgvVenda.CurrentRow.Cells(5).Value)
                    lblValorTotal.Text = "R$" & precoTotalVenda
                    dgvVenda.CurrentRow.Visible = False

                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub rbCartao_CheckedChanged(sender As Object, e As EventArgs) Handles rbCartao.CheckedChanged
        If rbCartao.Checked = True Then
            lblQuantiaEntregue.Visible = False
            txtQuantiaEntregue.Visible = False
            lblTroco.Text = "R$00,00"
            tipoPagamento = "Cartão"
        End If
    End Sub
End Class