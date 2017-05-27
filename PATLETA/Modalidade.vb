Imports System.Data.SqlClient

Public Class Modalidade
    Private sIDModalidade As Integer
    Private sModalidade As String

    Public Property Modalidade As String
        Get
            Return sModalidade
        End Get
        Set(value As String)
            sModalidade = value
        End Set
    End Property

    Public Property IDModalidade As Integer
        Get
            Return sIDModalidade
        End Get
        Set(value As Integer)
            sIDModalidade = value
        End Set
    End Property

    Public Function Salvar() As Integer
        Dim retorno As Integer = 0

        If Not IsNumeric(sIDModalidade) Then
            MsgBox("O campo ID é composto apenas de números!", MsgBoxStyle.Critical, "Atenção")
            Return retorno
            Exit Function
        End If

        If sModalidade = "" Then
            MsgBox("O campo nome da modalidade não pode ser vazio!", MsgBoxStyle.Critical, "Atenção")
            Return retorno
            Exit Function
        End If

        If IsNumeric(sModalidade) Then
            MsgBox("O campo nome da modalidade só podem conter letras!", MsgBoxStyle.Critical, "Atenção")
            Return retorno
            Exit Function
        End If

        Try
            Dim MyCommand As SqlCommand
            Dim nReg As Integer

            MyCommand = New SqlCommand("INSERT INTO MODALIDADE VALUES (@IDMODALIDADE,@NOMEMODALIDADE)", frmMenu.Conexao)

            MyCommand.Parameters.Add(New SqlParameter("@IDMODALIDADE", SqlDbType.Int))
            MyCommand.Parameters.Add(New SqlParameter("@NOMEMODALIDADE", SqlDbType.VarChar))

            MyCommand.Parameters("@IDMODALIDADE").Value = sIDModalidade
            MyCommand.Parameters("@NOMEMODALIDADE").Value = sModalidade

            nReg = MyCommand.ExecuteNonQuery()

            If nReg > 0 Then
                MsgBox("Inserção realizada com sucesso!", MsgBoxStyle.Information, "Mensagem")
                retorno = nReg
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar incluir a modalidade!", MsgBoxStyle.Critical)
        End Try

        Return retorno
    End Function

    Public Function Alterar() As Integer
        Dim retorno As Integer = 0

        If sModalidade = "" Then
            MsgBox("A modalidade deve ser preenchida!", MsgBoxStyle.Critical, "Atenção")
            Return retorno
            Exit Function
        End If

        If IsNumeric(sModalidade) Then
            MsgBox("O campo nome da modalidade só podem conter letras!", MsgBoxStyle.Critical, "Atenção")
            Return retorno
            Exit Function
        End If

        Try
            Dim MyCommand As SqlCommand
            Dim nReg As Integer

            MyCommand = New SqlCommand("UPDATE MODALIDADE SET NOMEMODALIDADE = @NOMEMODALIDADE , WHERE IDMODALIDADE = @IDMODALIDADE", frmMenu.Conexao)

            MyCommand.Parameters.Add(New SqlParameter("@NOMEMODALIDADE", SqlDbType.VarChar))
            MyCommand.Parameters.Add(New SqlParameter("@IDMODALIDADE", SqlDbType.Int))

            MyCommand.Parameters("@IDMODALIDADE").Value = sIDModalidade
            MyCommand.Parameters("@NOMEMODALIDADE").Value = sModalidade

            nReg = MyCommand.ExecuteNonQuery()
            If nReg > 0 Then
                MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Mensagem")
                retorno = nReg
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar alterar a modalidade!", MsgBoxStyle.Critical)
        End Try
        Return retorno
    End Function

    Public Function Listar() As DataTable
        Dim daModalidade As SqlDataAdapter
        Dim dtCidade As New DataTable()
        Try
            daModalidade = New SqlDataAdapter("SELECT * FROM MODALIDADE", frmMenu.Conexao)
            daModalidade.Fill(dtCidade)
            daModalidade.FillSchema(dtCidade, SchemaType.Source)
        Catch ex As Exception
            MsgBox("Erro ao carregar cidades!!!")
        End Try
        Return dtCidade
    End Function


    Public Function Excluir() As Integer
        Dim nReg As Integer = 0

        Try
            Dim MyCommand As SqlCommand

            MyCommand = New SqlCommand("DELETE FROM MODALIDADE WHERE IDMODALIDADE=@IDMODALIDADE", frmMenu.Conexao)
            MyCommand.Parameters.Add(New SqlParameter("@IDMODALIDADE", SqlDbType.Int))
            MyCommand.Parameters("@IDMODALIDADE").Value = CInt(sIDModalidade)

            nReg = MyCommand.ExecuteNonQuery()
            If nReg > 0 Then
                MsgBox("Modalidade excluída com sucesso!", MsgBoxStyle.Information, "Mensagem")
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar excluir a modalidade, pode ser que existam alunos cadastrados com ela!", MsgBoxStyle.Critical)
        End Try

        Return nReg
    End Function
End Class
