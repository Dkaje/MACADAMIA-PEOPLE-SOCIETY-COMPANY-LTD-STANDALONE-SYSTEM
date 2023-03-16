Imports System.Text.RegularExpressions
Imports System.Windows.Forms.AxHost
Public Class Edit_cust



    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex(" ^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CapitalLetters()
        ' Capital letters disabled  Capslock...
        Me.TxtFirstName.CharacterCasing = CharacterCasing.Upper
        Me.TxtLastName.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub FillTextbox()

        'if Edit record State, Textboxes Fill
        Dim oledr As OleDb.OleDbDataReader

        Call OpenConnection()
        Call Initialized()
        With OleDa
            .SelectCommand = New OleDb.OleDbCommand()
            .SelectCommand.CommandText = "SELECT * FROM [Customers] WHERE ([Customer_ID] =[@CustID])"
            .SelectCommand.Connection = OleCn
            .SelectCommand.Parameters.Add("@CustID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustID").Value = Customers.LvRecord.SelectedItems(0).Text
        End With

        oledr = OleDa.SelectCommand.ExecuteReader()

        With oledr
            If Not .HasRows Then
                'Nothing
            Else
                .Read()
                Me.LableCustID.Text = IIf(.IsDBNull(0), "", .Item("Customer_ID").ToString())
                Me.TxtFirstName.Text = IIf(.IsDBNull(1), "", .Item("First_name").ToString())
                Me.TxtLastName.Text = IIf(.IsDBNull(2), "", .Item("Last_name").ToString())
                Me.TxtAddress.Text = IIf(.IsDBNull(3), "", .Item("Email").ToString())
                Me.TxtPhoneNum.Text = IIf(.IsDBNull(4), "", .Item("Phone_no").ToString())
                Me.TxtIDNo.Text = IIf(.IsDBNull(3), "", .Item("ID_number").ToString())
                .Close()
            End If
            Call CloseConnection()
        End With

    End Sub
    Private Sub Edit_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call FillTextbox()
    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        Try
            Try

                If TxtFirstName.Text = "" Or TxtLastName.Text = "" Or TxtPhoneNum.Text = "" Or TxtAddress.Text = "" Then
                    MsgBox("No empty field allowed.", MsgBoxStyle.Information)

                ElseIf TxtPhoneNum.Text.Length <> 10 Then
                    MessageBox.Show("Phone number should contain 10 digits")
                ElseIf validateEmail(TxtAddress.Text) = False Then
                    MessageBox.Show("Email format not valid")
                Else


                    Call OpenConnection()
                    With OleDa

                        .UpdateCommand = New OleDb.OleDbCommand()
                        .UpdateCommand.CommandText = "UPDATE [Customers] SET [First_name] = @FirstName, [Last_name] = @LastName,[Email] = @Address ," & _
                        "[Phone_no] = @Phone_no,[ID_number]=@IDNo WHERE (Customer_ID = ?)"
                        .UpdateCommand.Connection = OleCn
                        .UpdateCommand.Parameters.Add("@FirstName", OleDb.OleDbType.VarWChar, 50, "FirstName").Value = Me.TxtFirstName.Text
                        .UpdateCommand.Parameters.Add("@LastName", OleDb.OleDbType.VarWChar, 50, "LastName").Value = Me.TxtLastName.Text
                        .UpdateCommand.Parameters.Add("@Address", OleDb.OleDbType.VarWChar, 50, "Address").Value = Me.TxtAddress.Text
                        .UpdateCommand.Parameters.Add("@Phone_no", OleDb.OleDbType.VarWChar, 50, "Phone_no").Value = Me.TxtPhoneNum.Text
                        .UpdateCommand.Parameters.Add("@IDNo", OleDb.OleDbType.VarWChar, 50, "IDNo").Value = Me.TxtIDNo.Text
                        .UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustID", OleDb.OleDbType.VarWChar, 50, _
                                                                                             System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUSTID", DataRowVersion.Original, Nothing)).Value = Customers.LvRecord.SelectedItems(0).Text
                        .UpdateCommand.ExecuteNonQuery()

                    End With
                    Call CloseConnection()
                    MsgBox("Record has been Updated...", MsgBoxStyle.Information, "Record(s) Updated...")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("Unable to update record...", MsgBoxStyle.Exclamation, "Attention...")
                'TxtEmployeeID.Focus()
                'TxtEmployeeID.SelectAll()
                Call CloseConnection()

            End Try

            Exit Sub

        Catch ex As Exception

        End Try
    End Sub
End Class