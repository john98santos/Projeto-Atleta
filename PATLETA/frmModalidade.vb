Imports System.Data.SqlClient

Public Class frmmodalidade
    Private bnModalidade As New BindingSource
    Private bInclusao As Boolean = False
    Private dsModalidade As New DataSet()

    Private Sub frmModalidade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Dim Modal As New Modalidade()
            dsModalidade.Tables.Add(Modal.Listar())
            bnModalidade.DataSource = dsModalidade.Tables("MODALIDADE")
            dgvModalidade.DataSource = bnModalidade
            bnvModalidade.BindingSource = bnModalidade

            txtID.DataBindings.Add("TEXT", bnModalidade, "IDMODALIDADE")
            txtModalidade.DataBindings.Add("TEXT", bnModalidade, "NOMEMODALIDADE")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If TabControl1.SelectedIndex = 0 Then
            TabControl1.SelectTab(1)
        End If

        bnModalidade.AddNew()
        txtID.Enabled = True
        txtModalidade.Enabled = True
        txtID.Focus()
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnAdicionar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = True

        bInclusao = True
    End Sub


    Private Sub MODALIDADEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim RegModal As New Modalidade()

        RegModal.IDModalidade = CInt(txtID.Text)
        RegModal.Modalidade = txtModalidade.Text

        If bInclusao Then

            If RegModal.Salvar() > 0 Then

                btnSalvar.Enabled = False
                txtID.Enabled = False
                txtModalidade.Enabled = False
                btnSalvar.Enabled = False
                btnAlterar.Enabled = True
                btnAdicionar.Enabled = True
                btnExcluir.Enabled = True
                btnCancelar.Enabled = False

                bInclusao = False

                ' recarrega o grid
                dsModalidade.Tables.Clear()
                dsModalidade.Tables.Add(RegModal.Listar())
                bnModalidade.DataSource = dsModalidade.Tables("MODALIDADE")
            End If
        Else
            If RegModal.Alterar() > 0 Then
                dsModalidade.Tables.Clear()
                dsModalidade.Tables.Add(RegModal.Listar())
                txtID.Enabled = False
                txtModalidade.Enabled = False
                btnSalvar.Enabled = False
                btnAlterar.Enabled = True
                btnAdicionar.Enabled = True
                btnExcluir.Enabled = True
                btnCancelar.Enabled = False
            End If

        End If
    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If TabControl1.SelectedIndex = 0 Then
            TabControl1.SelectTab(1)
        End If

        txtID.Enabled = False
        txtModalidade.Enabled = True
        txtID.Focus()
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnAdicionar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = True
        bInclusao = False
    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If TabControl1.SelectedIndex = 0 Then
            TabControl1.SelectTab(1)
        End If

        If MsgBox("Tem certeza que deseja excluir permanentemente a Modalidade?", MsgBoxStyle.YesNo, "Atenção!") = DialogResult.Yes Then

            Dim RegModal As New Modalidade()

            RegModal.IDModalidade = CInt(txtID.Text)
            RegModal.Modalidade = txtModalidade.Text

            If RegModal.Excluir() > 0 Then
                Dim R As New Modalidade()
                dsModalidade.Tables.Clear()
                dsModalidade.Tables.Add(R.Listar())
                bnModalidade.DataSource = dsModalidade.Tables("MODALIDADE")
            End If
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        bnModalidade.CancelEdit()

        btnSalvar.Enabled = False
        txtID.Enabled = False
        txtModalidade.Enabled = False
        btnAlterar.Enabled = True
        btnAdicionar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class