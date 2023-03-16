Imports System.Data.OleDb

Module ModConnection

    Public OleCn As New OleDbConnection()
    Public OleDa As New OleDbDataAdapter()

    Public Connection As String

    Public Function MS_Access_ConnectionString() As String
        Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\my_database.accdb"
        Return Connection
    End Function
    Public Enum Add_Or_Edit_state
        AddRecordstate = 0 'Para sa pagAdd
        EditRecordstate = 1 'Para sa pagEdit
    End Enum
    Public Sub OpenConnection()
        If OleCn.State <> ConnectionState.Open Then
            OleCn.ConnectionString = MS_Access_ConnectionString()
            OleCn.Open()
            Exit Sub
        End If
    End Sub
    Public Sub CloseConnection()
        If OleCn.State <> ConnectionState.Closed Then
            OleCn.Close()
            Exit Sub
        End If
    End Sub
    Public Sub Initialized()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Staff]"
            .SelectCommand.Connection = OleCn
        End With
    End Sub

    Public Sub Get_Customers()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Customers]"
            .SelectCommand.Connection = OleCn
        End With
    End Sub

    Public Sub Get_Stock()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Products]"
            .SelectCommand.Connection = OleCn
        End With
    End Sub

    Public Sub Get_Items()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT Stock_ID,Stock,Product_name FROM [Products]"
            .SelectCommand.Connection = OleCn
        End With
    End Sub


    Public Sub Get_Farmers()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [farmers]"
            .SelectCommand.Connection = OleCn
        End With
    End Sub

    Public Sub Get_Cart_items()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT Farmer_ID,Status  FROM [Stock_in] WHERE [Status]=[''] "
            .SelectCommand.Connection = OleCn
        End With
    End Sub


    Public Sub Get_StockHistory()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT si.stock_in_ID,f.first_name,f.last_name,p.product_name,si.quantity,si.total_buying_price FROM (farmers AS f INNER JOIN stock_in AS si ON f.farmer_ID=si.farmer_ID) INNER JOIN Products AS p ON si.Product_ID=p.StocK_ID"
            .SelectCommand.Connection = OleCn
        End With
    End Sub

    Public Sub Get_SalesHistory()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT s.Sales_ID,c.first_name,c.last_name,p.product_name,s.quantity,p.price,s.total FROM (customers AS c INNER JOIN sales  AS s ON c.customer_ID=s.customer_ID) INNER JOIN Products AS p ON s.Product_ID=p.StocK_ID"
            .SelectCommand.Connection = OleCn
        End With
    End Sub
End Module
