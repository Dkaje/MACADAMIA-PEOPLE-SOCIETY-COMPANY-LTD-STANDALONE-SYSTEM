Public Class Help

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            AxPDFViewer1.LoadFile("G:\vb_projects\Farmers\Help.pdf")
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub AxPDFViewer1_OnError(sender As Object, e As EventArgs) Handles AxPDFViewer1.OnError

    End Sub
End Class