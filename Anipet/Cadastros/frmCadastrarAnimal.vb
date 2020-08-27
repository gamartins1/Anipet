Public Class frmCadastrarAnimal
    Private Sub pbBuscar_Click(sender As Object, e As EventArgs) Handles pbBuscar.Click
        frmPopUpBuscaCliente.ShowDialog()
    End Sub

    Private Sub cbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEspecie.SelectedIndexChanged
        cbRaca.Items.Clear()
        cbRaca.Text = ""
        Try
            conexaoBanco()
            sql = "SELECT idRaca, racaAnimal FROM tbRacaAnimal WHERE especieAnimal = '" & cbEspecie.Text & "'"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                cbRaca.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCadastrarAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If cliente = "" Then
                conexaoBanco()
                sql = "SELECT idCliente, nomeCliente, cpfCliente FROM tbCliente"
                rs = db.Execute(UCase(sql))

                Do While rs.EOF = False
                    dataCollection.Add(rs.Fields(0).Value)
                    dataCollection.Add(rs.Fields(1).Value)
                    dataCollection.Add(rs.Fields(2).Value)
                    rs.MoveNext()
                Loop
                txtIdentificacaoDono.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtIdentificacaoDono.AutoCompleteCustomSource = dataCollection
                txtIdentificacaoDono.AutoCompleteMode = AutoCompleteMode.Suggest
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim subStringIdRaca As String

        subStringIdRaca = cbRaca.Text.Substring(0, 2).Trim
        Try
            conexaoBanco()
            sql = "INSERT INTO tbAnimal (nomeAnimal, especieAnimal, racaAnimal, porteAnimal, idDonoAnimal, obsAnimal)" _
                & "VALUES ('" & txtNome.Text & "', '" & cbEspecie.Text & "', " & subStringIdRaca & ", '" & cbPorte.Text _
                & "', " & cliente & ", '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Novo animal cadastrado com sucesso!")
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtIdentificacaoDono_LostFocus(sender As Object, e As EventArgs) Handles txtIdentificacaoDono.LostFocus
        If txtIdentificacaoDono.Text = "" Then
            Exit Sub
        End If
        Try
            conexaoBanco()
            sql = "SELECT idCliente, nomeCliente FROM tbCliente WHERE nomeCliente = '" & txtIdentificacaoDono.Text & "' " _
                & "OR cpfCliente = '" & txtIdentificacaoDono.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                cliente = rs.Fields(0).Value
                btnCadastrar.Enabled = True
            Else
                MsgBox("Cliente não encontrado!" & vbCrLf & "Digite um cliente cadastrado", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
                btnCadastrar.Enabled = False
            End If
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdentificacaoDono.Text = ""
        txtNome.Text = ""
        txtObservacoes.Text = ""
        cbEspecie.Text = ""
        cbPorte.Text = ""
        cbRaca.Text = ""
    End Sub
End Class