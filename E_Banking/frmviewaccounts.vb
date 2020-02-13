Public Class frmviewaccounts

    Private Sub AccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmviewaccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.Ebankdataset.accounts)

    End Sub
End Class