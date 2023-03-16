Public Class Stock_history
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
    Private Sub Stock_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Call OpenConnection()
            Call List_View()
            Call Get_StockHistory()
            Call PopulateListView()
            Call CloseConnection()

        Catch ex As Exception
            MsgBox("Sorry failed to connect, please check the connection...", MsgBoxStyle.Critical, "Error...")
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub
    Private Sub List_View()
        With LvRecord
            .Columns.Add("ID:", 55, HorizontalAlignment.Left)
            .Columns.Add("First Name", 135, HorizontalAlignment.Left)
            .Columns.Add("Last Name", 135, HorizontalAlignment.Left)
            .Columns.Add("Product", 180, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 150, HorizontalAlignment.Left)
            .Columns.Add("Price", 100, HorizontalAlignment.Left)
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

    Private Function EditValidate() As Boolean
        'If zero record or no item
        If Me.LvRecord.Items.Count = 0 Then
            MsgBox("No record...", MsgBoxStyle.Information, "No record...")
            Return True
            Exit Function
        End If
        'If not selected the record...
        If Me.LvRecord.SelectedItems.Count = 0 Then
            MsgBox("Please select record to edit or double click the record...", MsgBoxStyle.Information, "Select record to edit...")
            Return True
            Exit Function
        End If
        'If selected record is more than 1...
        If Me.LvRecord.SelectedItems.Count > 1 Then
            MsgBox("Please select 1 record to edit or double click the record...", MsgBoxStyle.Information, "Select 1 record to edit...")
            Me.LvRecord.SelectedItems.Clear()
            Return True
            Exit Function
        End If

    End Function

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        If TxtSearch.Text = "" Then
            MsgBox("Please enter keyword to search...", MsgBoxStyle.Information, "Keyword to search...")
            TxtSearch.Focus()
            Exit Sub
        End If



        'If FrmLoading closed ... the record(s) filtered...
        Call OpenConnection()
        With OleDa
            Call Get_StockHistory()
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT si.stock_in_ID,f.first_name,f.last_name,p.product_name,si.quantity,si.total_buying_price FROM (farmers AS f INNER JOIN stock_in AS si ON f.farmer_ID=si.farmer_ID) INNER JOIN Products AS p ON si.Product_ID=p.StocK_ID WHERE  [First_name] Like '%%" & TxtSearch.Text & "%%' or [Last_name] Like '%%" & TxtSearch.Text & "%%'" & _
            "Or [product_name] Like '%%" & TxtSearch.Text & "%%' or [total_buying_price] Like '%%" & TxtSearch.Text & "%%' ORDER By [stock_in_ID] ASC"
            .SelectCommand.Connection = OleCn

            Call PopulateListView()

            If Me.LvRecord.Items.Count >= 1 Then
                MsgBox(Me.LvRecord.Items.Count & " Record(s) found for " & "( " & Me.TxtSearch.Text & " )", MsgBoxStyle.Information, "Record(s) found...")
            Else
                MsgBox("No record(s) found for " & "( " & Me.TxtSearch.Text & " )" & " , please try again... ", MsgBoxStyle.Critical, "No record found...")
                TxtSearch.Focus()
                TxtSearch.SelectAll()
            End If
        End With
        Call CloseConnection()
    End Sub

    Private Sub BRefresh_Click(sender As Object, e As EventArgs) Handles BRefresh.Click
        Try

            Call OpenConnection()
            Call Get_StockHistory()
            Call PopulateListView()
            Call CloseConnection()

        Catch ex As Exception

        End Try
    End Sub



    Private Sub BClose_Click_1(sender As Object, e As EventArgs) Handles BClose.Click
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class