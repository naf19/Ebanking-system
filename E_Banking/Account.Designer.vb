<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.GrpCustomers = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ebankdataset = New E_Banking.ebankdataset()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTableAdapter = New E_Banking.ebankdatasetTableAdapters.accountsTableAdapter()
        Me.TableAdapterManager = New E_Banking.ebankdatasetTableAdapters.TableAdapterManager()
        Me.AccountidTextBox = New System.Windows.Forms.TextBox()
        Me.UseridTextBox = New System.Windows.Forms.TextBox()
        Me.AccountbalanceTextBox = New System.Windows.Forms.TextBox()
        Me.GrpCustomers.SuspendLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpCustomers
        '
        Me.GrpCustomers.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GrpCustomers.Controls.Add(Me.AccountidTextBox)
        Me.GrpCustomers.Controls.Add(Me.UseridTextBox)
        Me.GrpCustomers.Controls.Add(Me.AccountbalanceTextBox)
        Me.GrpCustomers.Controls.Add(Me.Label4)
        Me.GrpCustomers.Controls.Add(Me.Label3)
        Me.GrpCustomers.Controls.Add(Me.Label2)
        Me.GrpCustomers.Controls.Add(Me.Label1)
        Me.GrpCustomers.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCustomers.Location = New System.Drawing.Point(-2, 59)
        Me.GrpCustomers.Name = "GrpCustomers"
        Me.GrpCustomers.Size = New System.Drawing.Size(484, 213)
        Me.GrpCustomers.TabIndex = 1
        Me.GrpCustomers.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Account Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account ID"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(356, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 45)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "KENTA Accounts Details"
        '
        'Ebankdataset
        '
        Me.Ebankdataset.DataSetName = "ebankdataset"
        Me.Ebankdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "accounts"
        Me.AccountsBindingSource.DataSource = Me.Ebankdataset
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountsTableAdapter = Me.AccountsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Nothing
        Me.TableAdapterManager.depositTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_Banking.ebankdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.withdrawalTableAdapter = Nothing
        '
        'AccountidTextBox
        '
        Me.AccountidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "accountid", True))
        Me.AccountidTextBox.Location = New System.Drawing.Point(194, 38)
        Me.AccountidTextBox.Name = "AccountidTextBox"
        Me.AccountidTextBox.Size = New System.Drawing.Size(218, 28)
        Me.AccountidTextBox.TabIndex = 8
        '
        'UseridTextBox
        '
        Me.UseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "userid", True))
        Me.UseridTextBox.Location = New System.Drawing.Point(194, 86)
        Me.UseridTextBox.Name = "UseridTextBox"
        Me.UseridTextBox.Size = New System.Drawing.Size(218, 28)
        Me.UseridTextBox.TabIndex = 10
        '
        'AccountbalanceTextBox
        '
        Me.AccountbalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "accountbalance", True))
        Me.AccountbalanceTextBox.Location = New System.Drawing.Point(194, 137)
        Me.AccountbalanceTextBox.Name = "AccountbalanceTextBox"
        Me.AccountbalanceTextBox.Size = New System.Drawing.Size(218, 28)
        Me.AccountbalanceTextBox.TabIndex = 12
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(548, 359)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrpCustomers)
        Me.Name = "Account"
        Me.Text = "Account Details"
        Me.GrpCustomers.ResumeLayout(False)
        Me.GrpCustomers.PerformLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ebankdataset As E_Banking.ebankdataset
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountsTableAdapter As E_Banking.ebankdatasetTableAdapters.accountsTableAdapter
    Friend WithEvents TableAdapterManager As E_Banking.ebankdatasetTableAdapters.TableAdapterManager
    Friend WithEvents AccountidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountbalanceTextBox As System.Windows.Forms.TextBox
End Class
