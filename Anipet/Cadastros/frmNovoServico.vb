Public Class frmNovoServico
    Dim idServico As Integer
    Private Sub frmNovoServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now
        Try
            conexaoBanco()
            sql = "SELECT idServico, nomeServico FROM tbServicos"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                cbServicos.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try

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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtDataServico.Text = DateTimePicker1.Value
    End Sub

    Private Sub cbServicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServicos.SelectedIndexChanged
        idServico = CInt(cbServicos.Text.Substring(0, 2).Trim)
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
                btnCadastrar.Enabled = True
            Else
                MsgBox("Animal não encontrado!" & vbCrLf & "Digite um animal cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                btnCadastrar.Enabled = False
            End If
            db.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscarAnimal.ShowDialog()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            conexaoBanco()
            sql = "SELECT tbAnimal.idAnimal, tbAnimal.nomeAnimal, tbGerenciamentoServicos.dataServico, tbGerenciamentoServicos.horarioServico
FROM tbAnimal INNER JOIN tbGerenciamentoServicos ON tbAnimal.idAnimal = tbGerenciamentoServicos.idAnimal
WHERE (((tbGerenciamentoServicos.dataServico)=#" & txtDataServico.Text & "#) AND ((tbGerenciamentoServicos.horarioServico)=#" & txtHorario.Text & "#));"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                MsgBox("O animal " & rs.Fields(1).Value & " Já tem um serviço agendado nesse horário" & vbCrLf & "Escolha um outro horário", MsgBoxStyle.Critical, "Aviso")
                db.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            conexaoBanco()
            sql = "INSERT INTO tbGerenciamentoServicos (dataServico, idServico, idAnimal, horarioServico, statusServico) " _
                & "VALUES ('" & txtDataServico.Text & "', '" & idServico & "', '" & idAnimal & "', '" & txtHorario.Text _
                & "', '" & cbStatus.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Servico criado com sucesso")
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscaAnimal_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaAnimal.TextChanged

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtBuscaAnimal.Text = ""
        txtDataServico.Text = ""
        txtHorario.Text = ""
        cbServicos.Text = ""
        cbStatus.Text = ""
    End Sub
End Class