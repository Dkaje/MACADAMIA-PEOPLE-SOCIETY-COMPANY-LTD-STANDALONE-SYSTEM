Public Class Login

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        Try

            If TxtUsername.Text = "Admin" And TxtPassword.Text = "1234" Then
                Dashboard.ShowDialog()
            Else

                MessageBox.Show("Confrim your username and password")

                Me.Hide()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
