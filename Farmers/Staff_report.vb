Public Class Staff_report

    Private Sub Staff_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'my_databaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.staffTableAdapter.Fill(Me.my_databaseDataSet.staff)
        'TODO: This line of code loads data into the 'my_databaseDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.my_databaseDataSet.Customers)
        'Label1.Text = Sales.Label2.Text

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class