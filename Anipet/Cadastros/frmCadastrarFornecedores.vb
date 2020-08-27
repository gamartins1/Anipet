Public Class frmCadastrarFornecedores
    Private Sub frmCadastrarFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCnpj_LostFocus(sender As Object, e As EventArgs) Handles txtCnpj.LostFocus
        Try
            conexaoBanco()
            sql = "SELECT cnpjFornecedor FROM tbFornecedor WHERE cnpjFornecedor = '" & txtCnpj.Text & "'"
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                MsgBox("CNPJ já vinculado a outro fornecdor!" & vbCrLf & "Verifique o CNPJ", vbCritical + vbOKOnly, "AVISO")
                btnCadastrar.Enabled = False
            Else
                btnCadastrar.Enabled = True
            End If
            db.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            conexaoBanco()
            sql = "INSERT INTO tbFornecedor (cnpjFornecedor, nomeFornecedor, telContatoFornecedor, dataCadFornecedor, " _
                & "emailFornecedor, cepFornecedor, ruaFornecedor, numFornecedor, bairroFornecedor, cidadeFornecedor, " _
                & "ufFornecedor, complementoFornecedor, obsFornecedor) VALUES ('" _
                & txtCnpj.Text & "', '" & txtNome.Text & "', '" & txtTelefone.Text & "', '" & txtDataCadastro.Text _
                & "', '" & txtEmail.Text & "', '" & txtCep.Text & "', '" & txtRua.Text & "', '" & txtNumero.Text _
                & "', '" & txtBairro.Text & "', '" & txtCidade.Text & "', '" & cbUf.Text & "', '" & txtComplemento.Text _
                & "', '" & txtObservacoes.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Fornecedor cadastrado com sucesso")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtCep_gotFocus(sender As Object, e As EventArgs) Handles txtCep.GotFocus
        cbUf.Enabled = True
        txtRua.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
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

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cbUf.Text = ""
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
        txtCnpj.Focus()
    End Sub
End Class