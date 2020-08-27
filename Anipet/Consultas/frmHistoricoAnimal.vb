Public Class frmHistoricoAnimal
    Dim valorGasto As Double
    Dim qtdServicos As Integer
    Private Sub frmHistoricoAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexaoBanco()
            sql = "SELECT idAnimal, nomeAnimal FROM tbAnimal"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dataCollection.Add(rs.Fields(0).Value)
                dataCollection.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            txtBuscaAnimal.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBuscaAnimal.AutoCompleteCustomSource = dataCollection
            txtBuscaAnimal.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            db.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBuscaAnimal_LostFocus(sender As Object, e As EventArgs) Handles txtBuscaAnimal.LostFocus
        If txtBuscaAnimal.Text = "" Then
            Exit Sub
        End If
        Try
            conexaoBanco()
            sql = "SELECT idAnimal, nomeAnimal FROM tbAnimal WHERE nomeAnimal = '" & txtBuscaAnimal.Text & "' "
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                idAnimal = rs.Fields(0).Value
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
                        MsgBox("Não há serviços vinculados ao animal: " & DataGridView1.CurrentRow.Cells(1).Value, MsgBoxStyle.Critical, "Aviso")
                        DataGridView1.Rows.Clear()
                    Else
                        qtdServicos = 0
                        valorGasto = 0
                        DataGridView1.Rows.Clear()
                        Do While rs.EOF = False
                            DataGridView1.Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value & " " & rs.Fields(6).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                            qtdServicos = qtdServicos + 1
                            valorGasto = valorGasto + rs.Fields(4).Value
                            rs.MoveNext()
                        Loop
                    End If
                    lblQtdServicos.Text = qtdServicos.ToString
                    lblValorGasto.Text = "R$ " & valorGasto.ToString

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Animal não encontrado!" & vbCrLf & "Digite um animal cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                GroupBox1.Visible = False
            End If
            db.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarAnimal.ShowDialog()
    End Sub

    Private Sub btnNovaConsulta_Click(sender As Object, e As EventArgs) Handles btnNovaConsulta.Click
        DataGridView1.Rows.Clear()
        txtBuscaAnimal.Focus()
    End Sub
End Class