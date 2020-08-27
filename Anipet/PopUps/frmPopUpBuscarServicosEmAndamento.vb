Public Class frmPopUpBuscarServicosEmAndamento
    Dim data, hora As String

    Private Sub frmPopUpBuscarServicosEmAndamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT tbAnimal.idAnimal, tbAnimal.nomeAnimal, tbServicos.idServico,
                        tbServicos.nomeServico, tbServicos.precoServico, tbGerenciamentoServicos.dataServico, 
                        tbGerenciamentoServicos.horarioServico, tbGerenciamentoServicos.statusServico, tbGerenciamentoServicos.idServicoPrestado 
                        FROM tbServicos 
                        INNER JOIN (tbAnimal INNER JOIN tbGerenciamentoServicos 
                        ON tbAnimal.idAnimal = tbGerenciamentoServicos.idAnimal) 
                        ON tbServicos.idServico = tbGerenciamentoServicos.idServico"
            rs = db.Execute(UCase(sql))
            If rs.BOF = True Then
                dgvServicos.Rows.Clear()
            Else
                dgvServicos.Rows.Clear()

                Do While rs.EOF = False
                    If rs.Fields(7).Value = "EM ANDAMENTO" Then
                        dgvServicos.Rows.Add(rs.Fields(2).Value, rs.Fields(8).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value & " " & rs.Fields(6).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                        rs.MoveNext()
                    Else
                        rs.MoveNext()
                    End If

                Loop
                For i = 0 To dgvServicos.Rows.Count - 1
                    If dgvServicos.Rows(i).Cells(6).Value = "EM ANDAMENTO" Then
                        dgvServicos.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Next
            End If
            db.Close()
            dgvServicos.Sort(dgvServicos.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub dgvServicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicos.CellContentClick
        If dgvServicos.CurrentRow.Cells(1).Selected = True Or dgvServicos.CurrentRow.Cells(2).Selected = True Or dgvServicos.CurrentRow.Cells(0).Selected = True Or dgvServicos.CurrentRow.Cells(3).Selected = True Then
            If Application.OpenForms.OfType(Of frmVendas)().Count() > 0 Then
                Try
                    If frmVendas.dgvVenda.Rows.Count = 0 Then
                        Data = DateTime.Today
                        hora = TimeString.ToString
                        conexaoBanco()
                        sql = "INSERT INTO tbVenda (statusVenda, dataVenda, horaVenda) VALUES ('EM ANDAMENTO', '" _
                        & Data & "', '" & hora & "')"
                        rs = db.Execute(UCase(sql))
                        db.Close()

                        conexaoBanco()
                        sql = "SELECT idVenda, dataVenda, horaVenda FROM tbVenda WHERE dataVenda = #" & Data _
                            & "# AND horaVenda = #" & hora & "#"
                        rs = db.Execute(UCase(sql))

                        If rs.EOF = False Then
                            idVenda = rs.Fields(0).Value
                        End If
                        db.Close()
                    End If
                    idServico = dgvServicos.CurrentRow.Cells(0).Value
                    nomeProduto = dgvServicos.CurrentRow.Cells(3).Value
                    precoVendaProduto = dgvServicos.CurrentRow.Cells(5).Value
                    frmVendas.dgvVenda.Rows.Add(idVenda, idServico, nomeProduto, precoVendaProduto, 1, precoVendaProduto)
                    frmVendas.lblValorTotal.Text = CDbl(frmVendas.lblValorTotal.Text) + precoVendaProduto

                    conexaoBanco()
                    sql = "UPDATE tbGerenciamentoServicos SET statusServico = 'FINALIZADO' WHERE idServicoPrestado = " & dgvServicos.CurrentRow.Cells(1).Value
                    rs = db.Execute(UCase(sql))
                    Me.Close()
                Catch ex As Exception
                End Try
            End If
        End If

    End Sub
End Class