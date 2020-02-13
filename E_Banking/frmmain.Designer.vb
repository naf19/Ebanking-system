<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDepositsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactWithdrawalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewWithdrawalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.WithdrawalsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDepositToolStripMenuItem, Me.ViewDepositsToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TransactionsToolStripMenuItem.Text = "Deposits"
        '
        'NewDepositToolStripMenuItem
        '
        Me.NewDepositToolStripMenuItem.Name = "NewDepositToolStripMenuItem"
        Me.NewDepositToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewDepositToolStripMenuItem.Text = "New Deposit"
        '
        'ViewDepositsToolStripMenuItem
        '
        Me.ViewDepositsToolStripMenuItem.Name = "ViewDepositsToolStripMenuItem"
        Me.ViewDepositsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ViewDepositsToolStripMenuItem.Text = "View Deposits"
        '
        'WithdrawalsToolStripMenuItem
        '
        Me.WithdrawalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactWithdrawalToolStripMenuItem, Me.ViewWithdrawalsToolStripMenuItem})
        Me.WithdrawalsToolStripMenuItem.Name = "WithdrawalsToolStripMenuItem"
        Me.WithdrawalsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.WithdrawalsToolStripMenuItem.Text = "Withdrawals"
        '
        'TransactWithdrawalToolStripMenuItem
        '
        Me.TransactWithdrawalToolStripMenuItem.Name = "TransactWithdrawalToolStripMenuItem"
        Me.TransactWithdrawalToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TransactWithdrawalToolStripMenuItem.Text = "Transact Withdrawal"
        '
        'ViewWithdrawalsToolStripMenuItem
        '
        Me.ViewWithdrawalsToolStripMenuItem.Name = "ViewWithdrawalsToolStripMenuItem"
        Me.ViewWithdrawalsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ViewWithdrawalsToolStripMenuItem.Text = "View Withdrawals"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAccountToolStripMenuItem, Me.ViewAccountsToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'AddAccountToolStripMenuItem
        '
        Me.AddAccountToolStripMenuItem.Name = "AddAccountToolStripMenuItem"
        Me.AddAccountToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddAccountToolStripMenuItem.Text = "Add Account"
        '
        'ViewAccountsToolStripMenuItem
        '
        Me.ViewAccountsToolStripMenuItem.Name = "ViewAccountsToolStripMenuItem"
        Me.ViewAccountsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewAccountsToolStripMenuItem.Text = "View Accounts"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterCustomerToolStripMenuItem, Me.ViewCustomersToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'RegisterCustomerToolStripMenuItem
        '
        Me.RegisterCustomerToolStripMenuItem.Name = "RegisterCustomerToolStripMenuItem"
        Me.RegisterCustomerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegisterCustomerToolStripMenuItem.Text = "Register Customer"
        '
        'ViewCustomersToolStripMenuItem
        '
        Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
        Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ViewCustomersToolStripMenuItem.Text = "View Customers"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 546)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.Text = "frmmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDepositToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDepositsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactWithdrawalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewWithdrawalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
