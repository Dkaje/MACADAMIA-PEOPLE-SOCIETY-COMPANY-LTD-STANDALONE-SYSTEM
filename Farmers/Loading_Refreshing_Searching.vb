Imports System.Data
Imports System.Data.OleDb

Friend Module ModuleLoadRefreshSearch


    Public Enum Loading_Refreshing_Searching
        Load_State = 0 'Pop Up Frmloaing Before FrmMain show...
        Refresh_State = 1 'Click Refresh Button...
        Search_State = 2 'Click Search Button...
    End Enum

    Public Sub My_Event()

        Staff.LvRecord.Items.Clear()
        Dim OleDr As OleDb.OleDbDataReader

        OleDr = OleDa.SelectCommand.ExecuteReader()

        Do While OleDr.Read
            Dim Item As New ListViewItem
            Item.Text = IIf(OleDr.IsDBNull(0), "", OleDr.GetValue(0))
            For shtCntr = 1 To OleDr.FieldCount() - 1
                If Not OleDr.IsDBNull(shtCntr) Then
                    Item.SubItems.Add(OleDr.GetString(shtCntr))
                Else
                    Item.SubItems.Add("")
                End If
            Next shtCntr

            Staff.LvRecord.Items.Add(Item)

            My.Application.DoEvents()

        Loop
    End Sub
    Private DoEvent As ModuleLoadRefreshSearch.Loading_Refreshing_Searching
    Public Sub MyDoEvents()
        If DoEvent = ModuleLoadRefreshSearch.Loading_Refreshing_Searching.Load_State Then
            Call OpenConnection()
            Call Initialized()
            Call My_Event() 'Kung Loading Event kapag ni run ung program...
            Call CloseConnection()
            Exit Sub
        End If
        If DoEvent = ModuleLoadRefreshSearch.Loading_Refreshing_Searching.Refresh_State Then
            Call OpenConnection()
            Call Initialized()
            Call My_Event()  'Kung Refreshing Event...
            Call CloseConnection()
            Exit Sub
        End If
        If DoEvent = ModuleLoadRefreshSearch.Loading_Refreshing_Searching.Search_State Then
            Call OpenConnection()
            Call Initialized()
            Call My_Event()  'Kung Searching Event...
            Call CloseConnection()
            Exit Sub
        End If

    End Sub

End Module
