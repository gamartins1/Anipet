Module ModuloGeral
    Public resp As String
    Public sql As String
    Public usuario As String
    Public cliente As String
    Public idAdm As Integer
    Public idFornecedor As Integer
    Public idAnimal As Integer
    Public idProduto As Integer
    Public idFuncionario As Integer
    Public idServico As Integer
    Public idVenda As Integer
    Public i As Integer
    Public dataCollection As New AutoCompleteStringCollection()

    Public nomeProduto, precoVendaProduto As String
    Public precoTotalProduto, precoTotalVenda As Double

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public conexao = Application.StartupPath & "\banco\dbAnipet.mdb"

    Sub conexaoBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & conexao)
        Catch ex As Exception
            MsgBox("Erro ao conectar!\n")
        End Try
    End Sub
End Module
