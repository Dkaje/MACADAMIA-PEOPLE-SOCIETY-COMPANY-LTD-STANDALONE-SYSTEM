Imports System.Drawing.Printing

Public Class Sup_report
    Private BMP As Bitmap
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
    Private Sub Sup_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        Try

            Dim pd As New PrintDocument
            Dim pdialog As New PrintDialog
            Dim ppd As New PrintPreviewDialog
            BMP = New Bitmap(GpbReciept.Width, GpbReciept.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            GpbReciept.DrawToBitmap(BMP, New Rectangle(0, 0, GpbReciept.Width, GpbReciept.Height))
            AddHandler pd.PrintPage, (Sub(s, args)
                                          args.Graphics.DrawImage(BMP, 0, 0)
                                          args.HasMorePages = False
                                      End Sub)
            'choose a printer
            pdialog.ShowDialog(Me)
            pd.PrinterSettings.PrinterName = pdialog.PrinterSettings.PrinterName

            If pd.PrinterSettings.CanDuplex.ToString Then
                pd.PrinterSettings.Duplex = Duplex.Vertical
            End If

            ' Preview the document
            ppd.Document = pd
            pd.Print()      'actually print data


            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class