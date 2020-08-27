Public Class frmServicos
    Dim data As String
    Private Sub frmServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexaoBanco()
            sql = "SELECT tbAnimal.idAnimal, tbAnimal.nomeAnimal, tbServicos.idServico,
                        tbServicos.nomeServico, tbServicos.precoServico, tbGerenciamentoServicos.dataServico, 
                        tbGerenciamentoServicos.horarioServico, tbGerenciamentoServicos.statusServico 
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
                    dgvServicos.Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value & " " & rs.Fields(6).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                    rs.MoveNext()
                Loop
                For i = 0 To dgvServicos.Rows.Count - 1
                    If dgvServicos.Rows(i).Cells(4).Value = "EM ANDAMENTO" Then
                        dgvServicos.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                    ElseIf dgvServicos.Rows(i).Cells(4).Value = "FINALIZADO" Then
                        dgvServicos.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    ElseIf dgvServicos.Rows(i).Cells(4).Value = "AGENDADO" Then
                        dgvServicos.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                    End If
                Next
            End If
            db.Close()
            dgvServicos.Sort(dgvServicos.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbFinalizado_CheckedChanged(sender As Object, e As EventArgs) Handles cbFinalizado.CheckedChanged

        If cbFinalizado.Checked = False Then
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "FINALIZADO" Then
                    dgvServicos.Rows.Item(i).Visible = False
                End If
            Next
        Else
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "FINALIZADO" Then
                    dgvServicos.Rows.Item(i).Visible = True
                End If
            Next
        End If

    End Sub

    Private Sub cbAndamento_CheckedChanged(sender As Object, e As EventArgs) Handles cbAndamento.CheckedChanged
        If cbAndamento.Checked = False Then
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "EM ANDAMENTO" Then
                    dgvServicos.Rows.Item(i).Visible = False
                End If
            Next
        Else
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "EM ANDAMENTO" Then
                    dgvServicos.Rows.Item(i).Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub cbAgendado_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgendado.CheckedChanged
        If cbAgendado.Checked = False Then
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "AGENDADO" Then
                    dgvServicos.Rows.Item(i).Visible = False
                End If
            Next
        Else
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                If dgvServicos.Rows(i).Cells(4).Value = "AGENDADO" Then
                    dgvServicos.Rows.Item(i).Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub txtDataServico_LostFocus(sender As Object, e As EventArgs) Handles txtDataServico.LostFocus
        If Not txtDataServico.MaskFull Then
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1
                dgvServicos.Rows.Item(i).Visible = True
            Next
            Exit Sub
        End If
        i = 0
        For i = dgvServicos.Rows.Count - 1 To 0 Step -1
            data = dgvServicos.Rows(i).Cells(2).Value.ToString.Substring(0, 10)
            If dgvServicos.Rows(i).Cells(2).Value.ToString.Substring(0, 10) = txtDataServico.Text.Trim Then
                dgvServicos.Rows.Item(i).Visible = True
            Else
                dgvServicos.Rows.Item(i).Visible = False
            End If
        Next
    End Sub

    Private Sub txtHorario_LostFocus(sender As Object, e As EventArgs) Handles txtHorario.LostFocus
        If Not txtHorario.MaskFull Then
            Exit Sub
        End If
        If txtHorario.MaskFull And txtDataServico.MaskFull Then
            data = txtDataServico.Text.Trim & " " & txtHorario.Text.Trim & ":00"
            i = 0
            For i = dgvServicos.Rows.Count - 1 To 0 Step -1

                If dgvServicos.Rows(i).Cells(2).Value = data Then
                    dgvServicos.Rows.Item(i).Visible = True
                Else
                    dgvServicos.Rows.Item(i).Visible = False
                End If
            Next
            Exit Sub
        End If
        i = 0
        For i = dgvServicos.Rows.Count - 1 To 0 Step -1
            If dgvServicos.Rows(i).Cells(2).Value.ToString.Substring(10, 9).Trim = txtHorario.Text.Trim & ":00" Then
                dgvServicos.Rows.Item(i).Visible = True
            Else
                dgvServicos.Rows.Item(i).Visible = False
            End If
        Next
    End Sub

    Private Sub btnNovoServico_Click(sender As Object, e As EventArgs) Handles btnNovoServico.Click
        frmNovoServico.Show()
        Me.Close()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class