Public Class Products

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FrmSettings.ChkRefresh.Checked = My.Settings.ChkRefresh
        'FrmSettings.ChkSearch.Checked = My.Settings.ChkSearch

        'Me.TxtSearch.CharacterCasing = CharacterCasing.Upper

        Try

            'Dim Loading As New FrmLoading
            'With Loading
            '    'MyState = Loading_Refreshing_Searching.Load_State
            '    '.LblStatus.Text = "   Loading please wait..."
            '    '.LblRecord.Text = "Record(s).."
            '    .ShowDialog()
            'End With
            Call OpenConnection()
            Call List_View()
            Call Get_Stock()
            Call PopulateListView()
            Call CloseConnection()

        Catch ex As Exception
            MsgBox("Sorry failed to connect, please check the connection...", MsgBoxStyle.Critical, "Error...")
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
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
    'Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'FrmSettings.ChkRefresh.Checked = My.Settings.ChkRefresh
    '    'FrmSettings.ChkSearch.Checked = My.Settings.ChkSearch

    '    'Me.TxtSearch.CharacterCasing = CharacterCasing.Upper

    '    Try

    '        'Dim Loading As New FrmLoading
    '        'With Loading
    '        '    'MyState = Loading_Refreshing_Searching.Load_State
    '        '    '.LblStatus.Text = "   Loading please wait..."
    '        '    '.LblRecord.Text = "Record(s).."
    '        '    .ShowDialog()
    '        'End With
    '        Call OpenConnection()
    '        Call List_View()
    '        Call Get_Customers()
    '        Call PopulateListView()
    '        Call CloseConnection()

    '    Catch ex As Exception
    '        MsgBox("Sorry failed to connect, please check the connection...", MsgBoxStyle.Critical, "Error...")
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
    '    End Try
    'End Sub
    Private Sub List_View()
        With LvRecord
            .Columns.Add("ID:", 55, HorizontalAlignment.Left)
            .Columns.Add("Product Name", 135, HorizontalAlignment.Left)
            .Columns.Add("Price", 135, HorizontalAlignment.Left)
            .Columns.Add("Stock", 180, HorizontalAlignment.Left)
            .Columns.Add("Date added", 135, HorizontalAlignment.Left)
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

    Private Sub BNew_Click(sender As Object, e As EventArgs) Handles BNew.Click
        Try
            Call OpenConnection()
            Call Get_Stock()
            Call PopulateListView()
            Call CloseConnection()

            'If Add record state...
            Dim Addnew As New FrmAddPro
            With Addnew
                '.State = Add_Or_Edit_state.AddRecordstate
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Try
            Call OpenConnection()
            Call Get_Stock()
            Call PopulateListView()
            Call CloseConnection()

            'If Add record state...
            Dim Addnew As New Edit_staff
            With Addnew
                '.State = Add_Or_Edit_state.AddRecordstate
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        If TxtSearch.Text = "" Then
            MsgBox("Please enter keyword to search...", MsgBoxStyle.Information, "Keyword to search...")
            TxtSearch.Focus()
            Exit Sub

            'If FrmLoading closed ... the record(s) filtered...
            Call OpenConnection()
            With OleDa
                Call Get_Stock()
                .SelectCommand = New OleDb.OleDbCommand()
                .SelectCommand.CommandText = "SELECT * FROM [Products] WHERE  [Stock_ID] Like '%%" & TxtSearch.Text & "%%' or [Product_name] Like '%%" & TxtSearch.Text & "%%'" & _
                "Or [Stock] Like '%%" & TxtSearch.Text & "%%'  ORDER By [Stock_ID] ASC"
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
        End If
    End Sub

    Private Sub BRefresh_Click(sender As Object, e As EventArgs) Handles BRefresh.Click
        Try

            Call OpenConnection()
            Call Get_Stock()
            Call PopulateListView()
            Call CloseConnection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BClose_Click_1(sender As Object, e As EventArgs) Handles BClose.Click
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LvRecord_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvRecord.SelectedIndexChanged

    End Sub
End Class