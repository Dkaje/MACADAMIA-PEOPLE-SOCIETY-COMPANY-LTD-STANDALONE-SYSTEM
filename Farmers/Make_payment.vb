Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Make_payment
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
    Private Sub Make_payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            LabelCustID.Text = Make_sales.LabelCustID.Text
            LabelCustrName.Text = Make_sales.LabelCustName.Text

            LabelDate.Text = Today






            Call OpenConnection()
            Call List_View()
            Call Get_Cart_items()
            Call PopulateListView()
            Get_Cart_totol()
            Call CloseConnection()




        Catch ex As Exception
            MsgBox("Sorry failed to connect, please check the connection...", MsgBoxStyle.Critical, "Error...")
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub

    Private Sub List_View()
        With LvRecord
            .Columns.Add("Product Name:", 90, HorizontalAlignment.Left)
            .Columns.Add("Price", 75, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 55, HorizontalAlignment.Left)
            .Columns.Add("Total", 75, HorizontalAlignment.Left)
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

    Public Sub Get_Cart_items()
        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT p.Product_name,p.Price, s.Quantity,s.Total  FROM (SALES s INNER JOIN Products p ON s.Product_ID = p.StocK_ID)WHERE(s.Status = 'Cart') AND (s.Customer_ID=[@custID])"
            '.SelectCommand.CommandText = "SELECT p.Product_name,p.Price, s.Quantity  FROM (Sales s INNER JOIN Products p ON s.Product_ID = p.Product_ID)WHERE(s.Status = 'Cart') AND (s.Customer_ID = [@custID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@custID", System.Data.OleDb.OleDbType.VarWChar, 50, "custID").Value = Customers.LvRecord.SelectedItems(0).Text
        End With
    End Sub
    Public Sub Get_Cart_totol()


        Dim oledr As OleDb.OleDbDataReader
        Call OpenConnection()
        Call Initialized()

        With OleDa
            .SelectCommand = New OleDbCommand()
            .SelectCommand.CommandText = "SELECT SUM(s.Total) AS total FROM    (sales s INNER JOIN Products p ON s.Product_ID = p.StocK_ID) WHERE (s.Status = 'Cart') AND (s.customer_ID=[@custID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@custID", System.Data.OleDb.OleDbType.VarWChar, 50, "farmerID").Value = Customers.LvRecord.SelectedItems(0).Text
        End With

        oledr = OleDa.SelectCommand.ExecuteReader()

        With oledr

            .Read()
            Me.Label1.Text = IIf(.IsDBNull(0), "", .Item("total").ToString())
            Me.TxbTotal.Text = IIf(.IsDBNull(0), "", .Item("total").ToString())
            Me.LabelTotalCost.Text = IIf(.IsDBNull(0), "", .Item("total").ToString())
            .Close()

            Call CloseConnection()
        End With

    End Sub

    Private Sub TxbCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbCash.KeyPress
        Try
            Dim NotAllowedSpaces As String = " "
            Dim AllowedNumbers As String = "1234567890"


            If e.KeyChar <> ControlChars.Back Then

                If AllowedNumbers.IndexOf(e.KeyChar) = True Then
                    MsgBox("Not allowed letters and symbols...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attentio...")
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try

            Dim x As Integer
            Dim y As Integer
            Dim b As Integer

            x = TxbCash.Text.ToString
            y = TxbTotal.Text



            If x < y Then
                MessageBox.Show("Cash should not be less than total cost")

            Else

                Call OpenConnection()
                With OleDa

                    .UpdateCommand = New OleDb.OleDbCommand()
                    .UpdateCommand.CommandText = "UPDATE [sales] SET [Status] = @status WHERE Status=@cart AND customer_ID=@custID"
                    .UpdateCommand.Connection = OleCn
                    .UpdateCommand.Parameters.Add("@status", OleDb.OleDbType.VarWChar, 50, "status").Value = "Submitted"
                    .UpdateCommand.Parameters.Add("@cart", OleDb.OleDbType.VarWChar, 50, "cart").Value = "Cart"
                    .UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("custID", OleDb.OleDbType.VarWChar, 50, _
                                                                                         System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "custID", DataRowVersion.Original, Nothing)).Value = LabelCustID.Text
                    .UpdateCommand.ExecuteNonQuery()

                End With
                Call CloseConnection()

                TxbBal.Text = x - y

                LabelCash.Text = TxbCash.Text
                LabelBal.Text = TxbBal.Text

                MsgBox("Submitted successfully...", MsgBoxStyle.Information, "submitted...")



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




            End If
        Catch ex As Exception

        End Try
    End Sub
End Class