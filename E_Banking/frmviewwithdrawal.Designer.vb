<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewwithdrawal
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
        Me.Ebankdataset = New E_Banking.ebankdataset()
        Me.WithdrawalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WithdrawalTableAdapter = New E_Banking.ebankdatasetTableAdapters.withdrawalTableAdapter()
        Me.TableAdapterManager = New E_Banking.ebankdatasetTableAdapters.TableAdapterManager()
        Me.WithdrawalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WithdrawalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WithdrawalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'WithdrawalDataGridView
        '
        Me.WithdrawalDataGridView.AutoGenerateColumns = False
        Me.WithdrawalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WithdrawalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.WithdrawalDataGridView.DataSource = Me.WithdrawalBindingSource
        Me.WithdrawalDataGridView.Location = New System.Drawing.Point(24, 44)
        Me.WithdrawalDataGridView.Name = "WithdrawalDataGridView"
        Me.WithdrawalDataGridView.Size = New System.Drawing.Size(479, 336)
        Me.WithdrawalDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "userid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "account"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "withdrawaldate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmviewwithdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 413)
        Me.Controls.Add(Me.WithdrawalDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmviewwithdrawal"
        Me.Text = "Withdrawals"
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WithdrawalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WithdrawalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ebankdataset As E_Banking.ebankdataset
    Friend WithEvents WithdrawalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WithdrawalTableAdapter As E_Banking.ebankdatasetTableAdapters.withdrawalTableAdapter
    Friend WithEvents TableAdapterManager As E_Banking.ebankdatasetTableAdapters.TableAdapterManager
    Friend WithEvents WithdrawalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
