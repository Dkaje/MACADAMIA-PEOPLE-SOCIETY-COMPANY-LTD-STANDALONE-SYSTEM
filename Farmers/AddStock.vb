Public Class AddStock



    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            FillFarmerLabels()

            Call OpenConnection()
            Call List_View()
            Call Get_Items()
            Call PopulateListView()
            Call CloseConnection()

        Catch ex As Exception
            MsgBox("Sorry failed to connect, please check the connection...", MsgBoxStyle.Critical, "Error...")
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub


    Private Sub FillFarmerLabels()

        'if Edit record State, Textboxes Fill
        Dim oledr As OleDb.OleDbDataReader

        Call OpenConnection()
        Call Initialized()
        With OleDa
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [farmers] WHERE ([farmer_id] =[@FamerID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@FamerID", System.Data.OleDb.OleDbType.VarWChar, 50, "FamerID").Value = Farmers.LvRecord.SelectedItems(0).Text
        End With

        oledr = OleDa.SelectCommand.ExecuteReader()

        With oledr
            If Not .HasRows Then
                'Nothing
            Else
                .Read()
                Me.LabelFamerID.Text = IIf(.IsDBNull(0), "", .Item("Farmer_id").ToString())
                Me.LabelFarmerName.Text = IIf(.IsDBNull(1), "", .Item("First_name").ToString()) + " " + IIf(.IsDBNull(2), "", .Item("Last_name").ToString())

                .Close()
            End If
            Call CloseConnection()
        End With

    End Sub

    Public Sub PopulateListView()

        Me.LvRecord.Items.Clear()
        Dim OleDr As OleDb.OleDbDataReader

        OleDr = OleDa.SelectCommand.ExecuteReader()

        Do While OleDr.Read()
            Dim Item As New ListViewItem

            'If OleDr.IsDBNull(0),"" nothing  , OleDr.Item(0)) 1st Field(EmployeeID)
            Item.Text = IIf(OleDr.IsDBNull(0), "", OleDr.Item(0)) 'Or ,Oledr.GetValue(0))

            'shtCntr Declaration...
            'For shtCntr = 1 (2nd Field(FirstName))
            'OleDr.FieldCount() - 1 To get the Number of Columns
            For shtCntr = 1 To OleDr.FieldCount() - 1
                If Not OleDr.IsDBNull(shtCntr) Then
                    Item.SubItems.Add(OleDr.Item(shtCntr)) 'Or (Oledr.GetString(shtCntr))
                Else
                    Item.SubItems.Add("") 'Syntax Nothing...

                End If
            Next shtCntr

            Me.LvRecord.Items.Add(Item) 'Populate Listview...
        Loop
    End Sub
  
    Private Sub List_View()

        With LvRecord

            .Columns.Add("Stock:", 55, HorizontalAlignment.Left)
            .Columns.Add("Product", 105, HorizontalAlignment.Left)
            .Columns.Add("Product ID", 105, HorizontalAlignment.Left)
            .FullRowSelect = True
            .MultiSelect = True 'To Delete Multiple record(s) by pressing(CTRL + CLICK)
            .GridLines = True
            .HideSelection = False
            .View = View.Details
            .HoverSelection = False
            .HotTracking = False
            .Activation = ItemActivation.OneClick

        End With
    End Sub


    Private Sub AddStockLabels()



        'if Edit record State, Textboxes Fill
        Dim oledr As OleDb.OleDbDataReader



        Call OpenConnection()
        Call Initialized()
        With OleDa
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Products] WHERE ([Stock_ID] =[@StockID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@StockID", System.Data.OleDb.OleDbType.VarWChar, 50, "Stock ID").Value = LvRecord.SelectedItems(0).Text
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

    Private Function EditValidate() As Boolean
        'If zero record or no item
        If Me.LvRecord.Items.Count = 0 Then
            MsgBox("No record...", MsgBoxStyle.Information, "No record...")
            Return True
            Exit Function
        End If
        'If not selected the record...
        If Me.LvRecord.SelectedItems.Count = 0 Then
            MsgBox("Select a product...", MsgBoxStyle.Information, "Select a products...")
            Return True
            Exit Function
        End If
        'If selected record is more than 1...
        If Me.LvRecord.SelectedItems.Count > 1 Then
            MsgBox("Select one product only...", MsgBoxStyle.Information, "Select a products")
            Me.LvRecord.SelectedItems.Clear()
            Return True
            Exit Function
        End If

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If EditValidate() = True Then
            Return
        End If
        AddStockLabels()

        AddStockBtn.Enabled = True


    End Sub


 
    
    Private Sub TxtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRestock.KeyPress
        Try
            Dim NotAllowedSpaces As String = " "
            Dim AllowedNumbers As String = "1234567890"

            If e.KeyChar <> ControlChars.Back Then
                If NotAllowedSpaces.IndexOf(e.KeyChar) = False Then
                    MsgBox("Spaces not allowed...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attention...")
                    e.Handled = True
                    Exit Sub
                End If
                If AllowedNumbers.IndexOf(e.KeyChar) = True Then
                    MsgBox("Only number allowed...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attentio...")
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddStockBtn_Click(sender As Object, e As EventArgs) Handles AddStockBtn.Click
        Try


            If TxtRestock.Text = "" Then
                MsgBox("Please enter stock.", MsgBoxStyle.Information)

            Else

                'Add new stock to current stock
                Dim x As Integer
                Dim y As Integer
                Dim a As Integer

                x = TxtRestock.Text
                y = LabelStock.Text

                a = x + y

                Call OpenConnection()
                With OleDa

                    .UpdateCommand = New OleDb.OleDbCommand()
                    .UpdateCommand.CommandText = "UPDATE [Products] SET [Stock] =@Add WHERE (Stock_ID= ?)"
                    .UpdateCommand.Connection = OleCn
                    .UpdateCommand.Parameters.Add("@Add", OleDb.OleDbType.VarWChar, 50, "Add").Value = a
                    .UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("StockID", OleDb.OleDbType.VarWChar, 50, _
                                                                                         System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StockID", DataRowVersion.Original, Nothing)).Value = LvRecord.SelectedItems(0).Text
                    .UpdateCommand.ExecuteNonQuery()

                    'Insert in to stockin

                    .InsertCommand = New OleDb.OleDbCommand()
                    .InsertCommand.CommandText = "INSERT INTO [Stock_in] ( [Farmer_ID] , [Product_ID], [Quantity] ,[Total_Buying_price], [Status])" & _
                        "VALUES  ( @Farner_ID , @Product_ID, @Quantity , @Total,@Status)"
                    .InsertCommand.Connection = OleCn
                    .InsertCommand.Parameters.Add("@FarmerID", OleDb.OleDbType.VarWChar, 50, "FarmerID").Value = Me.LabelFamerID.Text
                    .InsertCommand.Parameters.Add("@ProductID", OleDb.OleDbType.VarWChar, 50, "ProductID").Value = Me.LableProID.Text
                    .InsertCommand.Parameters.Add("@Quantity", OleDb.OleDbType.VarWChar, 50, "Quantity").Value = Me.TxtRestock.Text
                    .InsertCommand.Parameters.Add("@Total", OleDb.OleDbType.VarWChar, 50, "Total").Value = Me.BuyingPrice.Text
                    .InsertCommand.Parameters.Add("@Status", OleDb.OleDbType.VarWChar, 50, "Status").Value = "Cart"


                    .InsertCommand.ExecuteNonQuery()


                End With
                Call CloseConnection()
                MsgBox("Added successfully...", MsgBoxStyle.Information, "Success...")

                Me.AddStockBtn.Enabled = False

                TxtRestock.Text = ""
                BuyingPrice.Text = ""



            End If
        Catch ex As Exception
          


        End Try

       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            Dim Pay As New Farmer_payment
            With Pay
                .ShowDialog()

                Me.Close()

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

