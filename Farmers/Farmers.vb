Public Class Farmers


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
    Private Sub Farmers_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SellBtn.Visible = False  ' hide the sell btn

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
            Call Get_Farmers()
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
            .Columns.Add("Phone number", 180, HorizontalAlignment.Left)
            .Columns.Add("Email address", 180, HorizontalAlignment.Left)
            .Columns.Add("National ID No", 180, HorizontalAlignment.Left)
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

            Dim Addnew As New frmAddfarm
            With Addnew
                '.State = Add_Or_Edit_state.AddRecordstate
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
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
    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Try


            If EditValidate() = True Then
                Return
            End If

            'If Add record state...
            Dim Edit As New Edit_farmer
            With Edit
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
        End If



        'If FrmLoading closed ... the record(s) filtered...
        Call OpenConnection()
        With OleDa
            Call Get_Farmers()
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [farmers] WHERE  [First_name] Like '%%" & TxtSearch.Text & "%%' or [Last_name] Like '%%" & TxtSearch.Text & "%%'" & _
            "Or [Email] Like '%%" & TxtSearch.Text & "%%' or [Phone_no] Like '%%" & TxtSearch.Text & "%%' ORDER By [Farmer_ID] ASC"
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
            Call Get_Farmers()
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

    Private Sub SellBtn_Click(sender As Object, e As EventArgs)
        Try
            If EditValidate() = True Then
                Return
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LvRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles LvRecord.MouseClick
        Try

            SellBtn.Visible = True



        Catch ex As Exception

        End Try
    End Sub

    Private Sub SellBtn_Click_1(sender As Object, e As EventArgs) Handles SellBtn.Click
        Try
            SellBtn.Visible = False

            AddStock.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class