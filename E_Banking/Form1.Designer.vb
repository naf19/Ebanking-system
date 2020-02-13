<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ebankdataset = New E_Banking.ebankdataset()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New E_Banking.ebankdatasetTableAdapters.customersTableAdapter()
        Me.TableAdapterManager = New E_Banking.ebankdatasetTableAdapters.TableAdapterManager()
        Me.ClientidTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccountnumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.FnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.LnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.RegdateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PhonenumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.GrpCustomers.SuspendLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpCustomers
        '
        Me.GrpCustomers.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GrpCustomers.Controls.Add(Me.ClientidTextBox1)
        Me.GrpCustomers.Controls.Add(Me.AccountnumberTextBox1)
        Me.GrpCustomers.Controls.Add(Me.FnameTextBox1)
        Me.GrpCustomers.Controls.Add(Me.LnameTextBox1)
        Me.GrpCustomers.Controls.Add(Me.SurnameTextBox1)
        Me.GrpCustomers.Controls.Add(Me.RegdateDateTimePicker1)
        Me.GrpCustomers.Controls.Add(Me.PhonenumberTextBox1)
        Me.GrpCustomers.Controls.Add(Me.Label8)
        Me.GrpCustomers.Controls.Add(Me.Label7)
        Me.GrpCustomers.Controls.Add(Me.Label6)
        Me.GrpCustomers.Controls.Add(Me.Label5)
        Me.GrpCustomers.Controls.Add(Me.Label4)
        Me.GrpCustomers.Controls.Add(Me.Label3)
        Me.GrpCustomers.Controls.Add(Me.Label2)
        Me.GrpCustomers.Controls.Add(Me.Label1)
        Me.GrpCustomers.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCustomers.Location = New System.Drawing.Point(25, 74)
        Me.GrpCustomers.Name = "GrpCustomers"
        Me.GrpCustomers.Size = New System.Drawing.Size(493, 310)
        Me.GrpCustomers.TabIndex = 0
        Me.GrpCustomers.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Phone No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reg. Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(334, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(363, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(39, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(405, 45)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "KENTA Customers Details"
        '
        'Ebankdataset
        '
        Me.Ebankdataset.DataSetName = "ebankdataset"
        Me.Ebankdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.Ebankdataset
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.depositTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_Banking.ebankdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.withdrawalTableAdapter = Nothing
        '
        'ClientidTextBox1
        '
        Me.ClientidTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "clientid", True))
        Me.ClientidTextBox1.Location = New System.Drawing.Point(132, 41)
        Me.ClientidTextBox1.Name = "ClientidTextBox1"
        Me.ClientidTextBox1.Size = New System.Drawing.Size(200, 28)
        Me.ClientidTextBox1.TabIndex = 33
        '
        'AccountnumberTextBox1
        '
        Me.AccountnumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "accountnumber", True))
        Me.AccountnumberTextBox1.Location = New System.Drawing.Point(132, 91)
        Me.AccountnumberTextBox1.Name = "AccountnumberTextBox1"
        Me.AccountnumberTextBox1.Size = New System.Drawing.Size(200, 28)
        Me.AccountnumberTextBox1.TabIndex = 35
        '
        'FnameTextBox1
        '
        Me.FnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "fname", True))
        Me.FnameTextBox1.Location = New System.Drawing.Point(235, 133)
        Me.FnameTextBox1.Name = "FnameTextBox1"
        Me.FnameTextBox1.Size = New System.Drawing.Size(97, 28)
        Me.FnameTextBox1.TabIndex = 37
        '
        'LnameTextBox1
        '
        Me.LnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "lname", True))
        Me.LnameTextBox1.Location = New System.Drawing.Point(338, 134)
        Me.LnameTextBox1.Name = "LnameTextBox1"
        Me.LnameTextBox1.Size = New System.Drawing.Size(82, 28)
        Me.LnameTextBox1.TabIndex = 39
        '
        'SurnameTextBox1
        '
        Me.SurnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "surname", True))
        Me.SurnameTextBox1.Location = New System.Drawing.Point(132, 133)
        Me.SurnameTextBox1.Name = "SurnameTextBox1"
        Me.SurnameTextBox1.Size = New System.Drawing.Size(97, 28)
        Me.SurnameTextBox1.TabIndex = 41
        '
        'RegdateDateTimePicker1
        '
        Me.RegdateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "regdate", True))
        Me.RegdateDateTimePicker1.Location = New System.Drawing.Point(132, 203)
        Me.RegdateDateTimePicker1.Name = "RegdateDateTimePicker1"
        Me.RegdateDateTimePicker1.Size = New System.Drawing.Size(200, 28)
        Me.RegdateDateTimePicker1.TabIndex = 43
        '
        'PhonenumberTextBox1
        '
        Me.PhonenumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "phonenumber", True))
        Me.PhonenumberTextBox1.Location = New System.Drawing.Point(132, 257)
        Me.PhonenumberTextBox1.Name = "PhonenumberTextBox1"
        Me.PhonenumberTextBox1.Size = New System.Drawing.Size(200, 28)
        Me.PhonenumberTextBox1.TabIndex = 45
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(574, 439)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrpCustomers)
        Me.Name = "FrmCustomers"
        Me.Text = "Form1"
        Me.GrpCustomers.ResumeLayout(False)
        Me.GrpCustomers.PerformLayout()
        CType(Me.Ebankdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ebankdataset As E_Banking.ebankdataset
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As E_Banking.ebankdatasetTableAdapters.customersTableAdapter
    Friend WithEvents TableAdapterManager As E_Banking.ebankdatasetTableAdapters.TableAdapterManager
    Friend WithEvents ClientidTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccountnumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RegdateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PhonenumberTextBox1 As System.Windows.Forms.TextBox

End Class
