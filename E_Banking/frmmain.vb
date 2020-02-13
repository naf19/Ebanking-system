Public Class frmmain

    Private Sub NewDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDepositToolStripMenuItem.Click
        Deposit.ShowDialog()
    End Sub

    Private Sub ViewDepositsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDepositsToolStripMenuItem.Click
        frmViewDeposits.ShowDialog()
    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        Account.ShowDialog()
    End Sub

    Private Sub ViewAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAccountsToolStripMenuItem.Click
        frmviewaccounts.ShowDialog()
    End Sub

    Private Sub RegisterCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterCustomerToolStripMenuItem.Click
        FrmCustomers.ShowDialog()
    End Sub

    Private Sub ViewCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
        frmviewcustomers.ShowDialog()
    End Sub

    Private Sub TransactWithdrawalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactWithdrawalToolStripMenuItem.Click
        Withdraw.ShowDialog()
    End Sub

    Private Sub ViewWithdrawalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWithdrawalsToolStripMenuItem.Click
        frmviewwithdrawal.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class