Public Class frmviewwithdrawal

    Private Sub WithdrawalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WithdrawalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmviewwithdrawal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.withdrawal' table. You can move, or remove it, as needed.
        Me.WithdrawalTableAdapter.Fill(Me.Ebankdataset.withdrawal)

    End Sub
End Class