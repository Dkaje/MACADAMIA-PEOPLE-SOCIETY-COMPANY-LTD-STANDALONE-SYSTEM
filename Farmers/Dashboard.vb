Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomersBtn_Click(sender As Object, e As EventArgs) Handles CustomersBtn.Click
        Try
            Customers.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub StaffBtn_Click(sender As Object, e As EventArgs) Handles StaffBtn.Click
        Try

            Staff.ShowDialog()



          
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ProBtn As New Products
            With ProBtn
                '.State = Add_Or_Edit_state.AddRecordstate
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        Try

            Sales.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FramersBtn_Click(sender As Object, e As EventArgs) Handles FramersBtn.Click
        Try

            Farmers.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Stock_history.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Try
            Report_staff.ShowDialog()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Try
            Sup_report.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Try
            Cust_report.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Try
            Report_stock.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Try
            Sales_Histtory.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        Try
            Help.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub
End Class