Public Class FrmCustomers

    
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'Ebankdataset.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Ebankdataset.customers)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmCustomers_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Ebankdataset.customers)
        CustomersBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)
        Me.Close()
    End Sub
End Class
