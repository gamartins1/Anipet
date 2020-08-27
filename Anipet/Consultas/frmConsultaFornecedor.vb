Public Class frmConsultaFornecedor
    Private Sub frmConsultaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuario.Substring(0, 2) = "AD" Then

        ElseIf usuario.Substring(0, 2) = "FA" Then
            TabControl1.TabPages.Remove(TabPage2)
        End If
        listagemFornecedores()

    End Sub

    Private Sub listagemFornecedores()
        Try
            dgvDados.Rows.Clear()
            conexaoBanco()
            sql = "SELECT idFornecedor, nomeFornecedor, telContatoFornecedor, emailFornecedor, cepFornecedor, " _
                & "ruaFornecedor, cidadeFornecedor, obsFornecedor, cnpjFornecedor FROM tbFornecedor"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(8).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(0).Selected = True Or dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Or dgvDados.CurrentRow.Cells(3).Selected = True Or dgvDados.CurrentRow.Cells(4).Selected = True Then
            If usuario.Substring(0, 2) = "AD" Then
                Try
                    conexaoBanco()
                    sql = "SELECT * FROM tbFornecedor WHERE idFornecedor = " & dgvDados.CurrentRow.Cells(0).Value

                    rs = db.Execute(UCase(sql))
                    If rs.EOF = False Then
                        idFornecedor = rs.Fields(0).Value
                        txtCnpj.Text = rs.Fields(1).Value
                        txtNome.Text = rs.Fields(2).Value
                        txtTelefone.Text = rs.Fields(3).Value
                        txtDataCadastro.Text = rs.Fields(4).Value
                        txtEmail.Text = rs.Fields(5).Value
                        txtCep.Text = rs.Fields(6).Value
                        txtRua.Text = rs.Fields(7).Value
                        txtNumero.Text = rs.Fields(8).Value
                        txtBairro.Text = rs.Fields(9).Value
                        txtCidade.Text = rs.Fields(10).Value
                        cbUf.Text = rs.Fields(11).Value
                        txtComplemento.Text = rs.Fields(12).Value
                        txtObservacoes.Text = rs.Fields(13).Value
                    End If
                    db.Close()
                    TabControl1.SelectedTab = TabPage2
                Catch ex As Exception

                End Try
            ElseIf usuario.Substring(0, 2) = "FA" Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCep.LostFocus
        Try
            Dim ds As New DataSet()
            Dim xml As String = String.Format("http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=xml", txtCep.Text)
            ds.ReadXml(xml)

            cbUf.Text = (ds.Tables(0).Rows(0)(2).ToString())
            txtCidade.Text = (ds.Tables(0).Rows(0)(3).ToString())
            txtBairro.Text = (ds.Tables(0).Rows(0)(4).ToString())
            txtRua.Text = (ds.Tables(0).Rows(0)(5).ToString()) & " " & ds.Tables(0).Rows(0)(6).ToString()

            cbUf.Enabled = False
            txtRua.Enabled = False
            txtBairro.Enabled = False
            txtCidade.Enabled = False
            txtNumero.Focus()

        Catch ex As Exception
            txtRua.Focus()
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            conexaoBanco()
            sql = "UPDATE tbFornecedor SET nomeFornecedor = '" & txtNome.Text & "', telContatoFornecedor = '" & txtTelefone.Text _
                & "', dataCadFornecedor = '" & txtDataCadastro.Text & "', emailFornecedor = '" & txtEmail.Text & "', cepFornecedor " _
                & "= '" & txtCep.Text & "', ruaFornecedor = '" & txtRua.Text & "', numFornecedor = '" & txtNumero.Text & "', " _
                & "bairroFornecedor = '" & txtBairro.Text & "', cidadeFornecedor = '" & txtCidade.Text & "', ufFornecedor = '" _
                & cbUf.Text & "', complementoFornecedor = '" & txtComplemento.Text & "', obsFornecedor = '" & txtObservacoes.Text _
                & "' WHERE idFornecedor = " & idFornecedor
            rs = db.Execute(UCase(sql))
            MsgBox("Fornecedor alterado com sucesso", vbInformation, "Aviso")
            db.Close()
            listagemFornecedores()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtBairro.Text = ""
        txtCep.Text = ""
        txtCidade.Text = ""
        txtCnpj.Text = ""
        txtComplemento.Text = ""
        txtDataCadastro.Text = ""
        txtEmail.Text = ""
        txtNome.Text = ""
        txtNumero.Text = ""
        txtObservacoes.Text = ""
        txtRua.Text = ""
        txtTelefone.Text = ""
        cbUf.Text = ""
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class