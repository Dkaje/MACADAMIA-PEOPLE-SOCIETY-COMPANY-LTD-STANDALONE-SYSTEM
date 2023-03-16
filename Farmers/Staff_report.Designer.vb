<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.my_databaseDataSet = New Global.Farmers.my_databaseDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CustomersTableAdapter = New Global.Farmers.my_databaseDataSetTableAdapters.CustomersTableAdapter()
        Me.staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.staffTableAdapter = New Global.Farmers.my_databaseDataSetTableAdapters.staffTableAdapter()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.my_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.staffBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Farmers.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(700, 336)
        Me.ReportViewer1.TabIndex = 0
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'staffBindingSource
        '
        Me.staffBindingSource.DataMember = "staff"
        Me.staffBindingSource.DataSource = Me.my_databaseDataSet
        '
        'staffTableAdapter
        '
        Me.staffTableAdapter.ClearBeforeFill = True
        '
        'Staff_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 336)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Staff_report"
        Me.Text = "Staff_report"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.my_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents my_databaseDataSet As Global.Farmers.my_databaseDataSet
    Friend WithEvents CustomersTableAdapter As Global.Farmers.my_databaseDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents staffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents staffTableAdapter As Global.Farmers.my_databaseDataSetTableAdapters.staffTableAdapter
End Class
