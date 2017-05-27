Public Class frmAtleta
    Private Sub ATLETABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ATLETABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ATLETABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PATLETADataSet)

    End Sub

    Private Sub frmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PATLETADataSet.ATLETA' table. You can move, or remove it, as needed.
        Me.ATLETATableAdapter.Fill(Me.PATLETADataSet.ATLETA)

    End Sub
End Class