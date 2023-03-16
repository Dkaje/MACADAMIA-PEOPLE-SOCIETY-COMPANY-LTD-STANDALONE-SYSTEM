<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_report
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
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)


        Me.farmersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BSearch = New System.Windows.Forms.Button()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.my_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.farmersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.my_databaseDataSet
        '
        'my_databaseDataSet
        '
        Me.my_databaseDataSet.DataSetName = "my_databaseDataSet"
        Me.my_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'farmersBindingSource
        '
        Me.farmersBindingSource.DataMember = "farmers"
        '
        'My_databaseDataSet1
        '
        'farmersTableAdapter
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        '
        'My_databaseDataSet2
        '
        'ProductsTableAdapter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LvRecord)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 475)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'LvRecord
        '
        Me.LvRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvRecord.Location = New System.Drawing.Point(6, 32)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(806, 400)
        Me.LvRecord.TabIndex = 2
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "REPORT"
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSearch.Location = New System.Drawing.Point(22, 11)
        Me.BSearch.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(85, 43)
        Me.BSearch.TabIndex = 29
        Me.BSearch.Text = "Print report:"
        Me.BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSearch.UseVisualStyleBackColor = True
        '
        'Customer_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 538)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BSearch)
        Me.Name = "Customer_report"
        Me.Text = "Customer_report"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.my_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.farmersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents my_databaseDataSet As Global.Farmers.my_databaseDataSet
    Friend WithEvents CustomersTableAdapter As Global.Farmers.my_databaseDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents farmersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BSearch As System.Windows.Forms.Button
End Class
