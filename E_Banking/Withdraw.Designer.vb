<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpCustomers = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ebankdataset = New E_Banking.ebankdataset()
        Me.WithdrawalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WithdrawalTableAdapter = New E_Banking.ebankdatasetTableAdapters.withdrawalTableAdapter()
        Me.TableAdapterManager = New E_Banking.ebankdatasetTableAdapters.TableAdapterManager()
        Me.UseridTextBox = New System.Windows.Forms.TextBox()
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.WithdrawaldateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GrpCustomers.SuspendLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WithdrawalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(263, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 45)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "KENTA Withdrawals Details"
        '
        'GrpCustomers
        '
        Me.GrpCustomers.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GrpCustomers.Controls.Add(Me.UseridTextBox)
        Me.GrpCustomers.Controls.Add(Me.AccountTextBox)
        Me.GrpCustomers.Controls.Add(Me.Button1)
        Me.GrpCustomers.Controls.Add(Me.AmountTextBox)
        Me.GrpCustomers.Controls.Add(Me.Button2)
        Me.GrpCustomers.Controls.Add(Me.WithdrawaldateDateTimePicker)
        Me.GrpCustomers.Controls.Add(Me.Label7)
        Me.GrpCustomers.Controls.Add(Me.Label6)
        Me.GrpCustomers.Controls.Add(Me.Label4)
        Me.GrpCustomers.Controls.Add(Me.Label3)
        Me.GrpCustomers.Controls.Add(Me.Label2)
        Me.GrpCustomers.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCustomers.Location = New System.Drawing.Point(35, 75)
        Me.GrpCustomers.Name = "GrpCustomers"
        Me.GrpCustomers.Size = New System.Drawing.Size(457, 285)
        Me.GrpCustomers.TabIndex = 10
        Me.GrpCustomers.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Withdrawal  Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Withdrawal  Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Account ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User ID"
        '
        'Ebankdataset
        '
        Me.Ebankdataset.DataSetName = "ebankdataset"
        Me.Ebankdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WithdrawalBindingSource
        '
        Me.WithdrawalBindingSource.DataMember = "withdrawal"
        Me.WithdrawalBindingSource.DataSource = Me.Ebankdataset
        '
        'WithdrawalTableAdapter
        '
        Me.WithdrawalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.depositTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_Banking.ebankdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.withdrawalTableAdapter = Me.WithdrawalTableAdapter
        '
        'UseridTextBox
        '
        Me.UseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WithdrawalBindingSource, "userid", True))
        Me.UseridTextBox.Location = New System.Drawing.Point(210, 25)
        Me.UseridTextBox.Name = "UseridTextBox"
        Me.UseridTextBox.Size = New System.Drawing.Size(200, 28)
        Me.UseridTextBox.TabIndex = 14
        '
        'AccountTextBox
        '
        Me.AccountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WithdrawalBindingSource, "account", True))
        Me.AccountTextBox.Location = New System.Drawing.Point(210, 72)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(200, 28)
        Me.AccountTextBox.TabIndex = 16
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WithdrawalBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(217, 114)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 28)
        Me.AmountTextBox.TabIndex = 18
        '
        'WithdrawaldateDateTimePicker
        '
        Me.WithdrawaldateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WithdrawalBindingSource, "withdrawaldate", True))
        Me.WithdrawaldateDateTimePicker.Location = New System.Drawing.Point(217, 157)
        Me.WithdrawaldateDateTimePicker.Name = "WithdrawaldateDateTimePicker"
        Me.WithdrawaldateDateTimePicker.Size = New System.Drawing.Size(200, 28)
        Me.WithdrawaldateDateTimePicker.TabIndex = 20
        '
        'Withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 424)
        Me.Controls.Add(Me.GrpCustomers)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Withdraw"
        Me.Text = "Withdraw"
        Me.GrpCustomers.ResumeLayout(False)
        Me.GrpCustomers.PerformLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WithdrawalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ebankdataset As E_Banking.ebankdataset
    Friend WithEvents WithdrawalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WithdrawalTableAdapter As E_Banking.ebankdatasetTableAdapters.withdrawalTableAdapter
    Friend WithEvents TableAdapterManager As E_Banking.ebankdatasetTableAdapters.TableAdapterManager
    Friend WithEvents UseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WithdrawaldateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
