Public Class Seles_report

    Private Sub Seles_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'my_databaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.staffTableAdapter.Fill(Me.my_databaseDataSet.staff)
        'TODO: This line of code loads data into the 'my_databaseDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.my_databaseDataSet.Sales)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class