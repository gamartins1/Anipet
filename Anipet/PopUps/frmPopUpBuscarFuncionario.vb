Public Class frmPopUpBuscarFuncionario
    Private Sub frmPopUpBuscarFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDados.Rows.Clear()

        Try
            conexaoBanco()
            sql = "SELECT idFuncionario, cpffuncionario, nomeFuncionario FROM tbFuncionario"
            rs = db.Execute(UCase(sql))

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
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
            sql = "SELECT idFuncionario, cpfFuncionario, nomeFuncionario FROM tbFuncionario WHERE nomeFuncionario LIKE '" & xtBusca.Text & "%' OR cpfFuncionario LIKE '" & xtBusca.Text & "%'"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                dgvDados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        If dgvDados.CurrentRow.Cells(1).Selected = True Or dgvDados.CurrentRow.Cells(2).Selected = True Then
            idFuncionario = dgvDados.CurrentRow.Cells(0).Value
            Try
                conexaoBanco()
                sql = "SELECT telefoneFuncionario, dataNascFunc FROM tbFuncionario WHERE idFuncionario = " _
                    & idFuncionario.ToString & ""
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then
                    frmCadastrarAdministrador.lblTelefone.Text = rs.Fields(0).Value
                    frmCadastrarAdministrador.lblDataNascimento.Text = rs.Fields(1).Value
                End If
                db.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            frmCadastrarAdministrador.txtIdentificacao.Text = dgvDados.CurrentRow.Cells(2).Value
            frmCadastrarAdministrador.lblNome.Text = dgvDados.CurrentRow.Cells(2).Value
            frmCadastrarAdministrador.lblCpf.Text = dgvDados.CurrentRow.Cells(1).Value
            frmCadastrarAdministrador.GroupBox1.Visible = True
            Me.Close()
        End If
    End Sub
End Class