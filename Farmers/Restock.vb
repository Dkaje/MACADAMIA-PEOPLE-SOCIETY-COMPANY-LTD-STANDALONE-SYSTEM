Public Class Restock
    Private Sub FillTextbox()



        'if Edit record State, Textboxes Fill
        Dim oledr As OleDb.OleDbDataReader



        Call OpenConnection()
        Call Initialized()
        With OleDa
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Products] WHERE ([Stock_ID] =[@StockID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@StockID", System.Data.OleDb.OleDbType.VarWChar, 50, "Stock ID").Value = AddStock.LvRecord.SelectedItems(0).Text
        End With

        oledr = OleDa.SelectCommand.ExecuteReader()

        With oledr
            If Not .HasRows Then
                'Nothing
            Else
                .Read()
                'Me.LableStaffID.Text = IIf(.IsDBNull(0), "", .Item("Staff_ID").ToString())
                Me.LableProID.Text = IIf(.IsDBNull(0), "", .Item("Stock_ID").ToString())
                Me.LabelProName.Text = IIf(.IsDBNull(1), "", .Item("Product_name").ToString())
                Me.LabelStock.Text = IIf(.IsDBNull(3), "", .Item("Stock").ToString())
                .Close()
            End If
            Call CloseConnection()
        End With
    End Sub

    Private Sub Restock_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        FillTextbox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class