Public Class FrmAddPro

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmAddPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cleartext()
        'Kapag ng Close ang Form
        Me.TxtProName.Clear()
        Me.TxtProPrice.Clear()
        Me.TxtStock.Clear()
       
    End Sub
    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        Try
            If TxtProName.Text = "" Or TxtProPrice.Text = "" Then
                MsgBox("No empty field allowed.", MsgBoxStyle.Information)

            Else



                Call OpenConnection()
                With OleDa

                    .InsertCommand = New OleDb.OleDbCommand()
                    .InsertCommand.CommandText = "INSERT INTO [Products] ( [Product_name] , [Price], [Stock] , [Date_added])" & _
                        "VALUES  ( @pro_name, @price, @Stock,@Date_added)"
                    .InsertCommand.Connection = OleCn
                    .InsertCommand.Parameters.Add("@pro_name", OleDb.OleDbType.VarWChar, 50, "pro_name").Value = Me.TxtProName.Text
                    .InsertCommand.Parameters.Add("@price", OleDb.OleDbType.VarWChar, 50, "price").Value = Me.TxtProPrice.Text
                    .InsertCommand.Parameters.Add("@Stock", OleDb.OleDbType.VarWChar, 50, "Stock").Value = Me.TxtStock.Text
                    .InsertCommand.Parameters.Add("@Date_added", OleDb.OleDbType.VarWChar, 50, "Date_added").Value = Date.Today


                    .InsertCommand.ExecuteNonQuery()

                End With
                Call CloseConnection()
                MsgBox("Record saved...", MsgBoxStyle.Information, "Record saved...")
                If MsgBox("Do you want to add new record(s) ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmarion...") = MsgBoxResult.Yes Then


                    Call Cleartext() 'cleat all text from the input


                    Exit Sub
                End If
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Unable to save new record(s), please try again...", MsgBoxStyle.Exclamation, "Attention...")
            'TxtEmployeeID.Focus()
            'TxtEmployeeID.SelectAll()
            Call CloseConnection()
        End Try


        Exit Sub


    End Sub

    Private Sub TxtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProPrice.KeyPress

        Try
            Dim NotAllowedSpaces As String = " "
            Dim AllowedNumbers As String = "1234567890"

            If e.KeyChar <> ControlChars.Back Then
                If NotAllowedSpaces.IndexOf(e.KeyChar) = False Then
                    MsgBox("No white space allowed...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attention...")
                    e.Handled = True
                    Exit Sub
                End If
                If AllowedNumbers.IndexOf(e.KeyChar) = True Then
                    MsgBox("Only deigits allowed...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attentio...")
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

  

End Class