Public Class frmviewcustomers

   
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmviewcustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Ebankdataset.customers)

    End Sub
End Class