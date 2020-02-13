Public Class Deposit

    Private Sub DepositBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DepositBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.deposit' table. You can move, or remove it, as needed.
        Me.DepositTableAdapter.Fill(Me.Ebankdataset.deposit)
        DepositBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Me.Validate()
            Me.DepositBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

            MessageBox.Show("Record saved", "saving", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception

            MessageBox.Show("Error saving record ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class