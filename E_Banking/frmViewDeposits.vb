Public Class frmViewDeposits

    Private Sub DepositBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepositBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmViewDeposits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.deposit' table. You can move, or remove it, as needed.
        Me.DepositTableAdapter.Fill(Me.Ebankdataset.deposit)

    End Sub
End Class