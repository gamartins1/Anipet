Public Class frmPopUpBuscarAnimal
    Dim valorGasto As Double
    Dim qtdServicos As Integer
    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If Application.OpenForms.OfType(Of frmNovoServico)().Count() > 0 Then
            If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Then
                idAnimal = dgvDados.CurrentRow.Cells(0).Value
                frmNovoServico.txtBuscaAnimal.Text = dgvDados.CurrentRow.Cells(1).Value
                Me.Close()
            End If
        ElseIf Application.OpenForms.OfType(Of frmHistoricoAnimal)().Count() > 0 Then
            If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Then
                idAnimal = dgvDados.CurrentRow.Cells(0).Value
                Try
                    conexaoBanco()
                    sql = "SELECT tbAnimal.idAnimal, tbAnimal.nomeAnimal, tbServicos.idServico,
                        tbServicos.nomeServico, tbServicos.precoServico, tbGerenciamentoServicos.dataServico, 
                        tbGerenciamentoServicos.horarioServico, tbGerenciamentoServicos.statusServico 
                        FROM tbServicos 
                        INNER JOIN (tbAnimal INNER JOIN tbGerenciamentoServicos 
                        ON tbAnimal.idAnimal = tbGerenciamentoServicos.idAnimal) 
                        ON tbServicos.idServico = tbGerenciamentoServicos.idServico 
                        WHERE tbAnimal.idAnimal = " & idAnimal
                    rs = db.Execute(UCase(sql))
                    If rs.BOF = True Then
                        MsgBox("Não há serviços vinculados ao animal: " & dgvDados.CurrentRow.Cells(1).Value, MsgBoxStyle.Critical, "Aviso")
                        frmHistoricoAnimal.DataGridView1.Rows.Clear()
                    Else
                        qtdServicos = 0
                        valorGasto = 0
                        frmHistoricoAnimal.DataGridView1.Rows.Clear()
                        Do While rs.EOF = False
                            frmHistoricoAnimal.DataGridView1.Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value & " " & rs.Fields(6).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                            qtdServicos = qtdServicos + 1
                            valorGasto = valorGasto + rs.Fields(4).Value
                            rs.MoveNext()
                        Loop
                    End If
                    frmHistoricoAnimal.lblQtdServicos.Text = qtdServicos.ToString
                    frmHistoricoAnimal.lblValorGasto.Text = "R$ " & valorGasto.ToString

                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If

    End Sub

    Private Sub frmPopUpBuscarAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDados.Rows.Clear()

        Try
            conexaoBanco()
            sql = "SELECT idAnimal, nomeAnimal FROM tbAnimal"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xtBusca_TextChanged(sender As Object, e As EventArgs) Handles xtBusca.TextChanged
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idAnimal, nomeAnimal FROM tbAnimal WHERE nomeAnimal LIKE '" & xtBusca.Text & "%' OR idCliente LIKE '" & xtBusca.Text & "%'"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class