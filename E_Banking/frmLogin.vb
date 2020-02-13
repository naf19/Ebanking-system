Public Class frmLogin

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ebankdataset)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ebankdataset.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Ebankdataset.users)

    End Sub
    Sub login(username As String, password As String)
        Dim state As Boolean = False
        For Each row As DataRow In Ebankdataset.users.Rows
            If row.Item("username") = username And row.Item("password") = password Then
                state = True
                Exit For
            End If

        Next
        If (state = True) Then
            Me.Hide()
            frmmain.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid login details")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login(txtusername.Text, txtpassword.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()

        frmreguser.ShowDialog()
        Me.Close()
    End Sub
End Class