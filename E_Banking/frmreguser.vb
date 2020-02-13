Public Class frmreguser

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmreguser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Ebankdataset.users)
        UsersBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)
            MessageBox.Show("Record saved", "saving", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            frmLogin.ShowDialog()
            Me.Close()
        Catch ex As Exception

            MessageBox.Show("Error saving record ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        frmLogin.ShowDialog()
        Me.Close()
    End Sub
End Class