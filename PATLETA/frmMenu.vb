Imports System.Data.SqlClient

Public Class frmMenu
    Public Conexao As SqlConnection

    Private Sub FrmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Conexao = New SqlConnection("Data Source=JOHN-PC;Initial Catalog=PATLETA;Integrated Security=True")

            Conexao.Open()
        Catch ex As SqlException
            MsgBox("Erro ao carregar o banco de dados =/")
        Catch ex As Exception
            MsgBox("Outros Erros ocorreram ao carregar o banco de dados=/")
        End Try
    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Conexao.Close()
    End Sub

    Private Sub ProvasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvasToolStripMenuItem.Click
        frmProvas.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        frmSobre.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PaísesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísesToolStripMenuItem.Click
        frmPaís.Show()
    End Sub

    Private Sub ModalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadesToolStripMenuItem.Click
        frmmodalidade.Show()
    End Sub

    Private Sub AtletasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtletasToolStripMenuItem.Click
        frmAtleta.Show()
    End Sub
End Class
