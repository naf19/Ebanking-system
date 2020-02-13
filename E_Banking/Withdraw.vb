Public Class Withdraw

    Private Sub WithdrawalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WithdrawalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub


    Private Sub WithdrawalBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WithdrawalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.withdrawal' table. You can move, or remove it, as needed.
        Me.WithdrawalTableAdapter.Fill(Me.Ebankdataset.withdrawal)
        WithdrawalBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.WithdrawalBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)
            MessageBox.Show("Record saved", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving record ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class