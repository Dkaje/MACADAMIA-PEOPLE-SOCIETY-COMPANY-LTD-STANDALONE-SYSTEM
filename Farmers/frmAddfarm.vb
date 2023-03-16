Imports System.Text.RegularExpressions

Public Class frmAddfarm

    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex(" ^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub Cleartext()
        'Kapag ng Close ang Form
        Me.TxtFirstName.Clear()
        Me.TxtPhoneNum.Clear()
        Me.TxtLastName.Clear()
        Me.TxtIDNo.Clear()
        Me.TxtAddress.Clear()
    End Sub
    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        Try
            If TxtFirstName.Text = "" Or TxtLastName.Text = "" Or TxtPhoneNum.Text = "" Or TxtAddress.Text = "" Or TxtIDNo.Text = "" Then
                MsgBox("No empty field allowed.", MsgBoxStyle.Information)

            ElseIf TxtPhoneNum.Text.Length <> 10 Then
                MessageBox.Show("Phone number should contain 10 digits")
            ElseIf TxtIDNo.Text.Length <> 8 Then
                MessageBox.Show("National ID number should have 8 digits")
            ElseIf validateEmail(TxtAddress.Text) = False Then
                MessageBox.Show("Email format not valid")
            Else



                Call OpenConnection()
                With OleDa

                    .InsertCommand = New OleDb.OleDbCommand()
                    .InsertCommand.CommandText = "INSERT INTO [farmers] ( [First_name] , [Last_name], [Email] , [Phone_no],[ID_number], [Date_added])" & _
                        "VALUES  ( @FirstName , @LastName, @Email_Address , @Phone_Number,@ID_No,@Date_added)"
                    .InsertCommand.Connection = OleCn
                    .InsertCommand.Parameters.Add("@FirstName", OleDb.OleDbType.VarWChar, 50, "FirstName").Value = Me.TxtFirstName.Text
                    .InsertCommand.Parameters.Add("@LastName", OleDb.OleDbType.VarWChar, 50, "LastName").Value = Me.TxtLastName.Text
                    .InsertCommand.Parameters.Add("@Email_Address", OleDb.OleDbType.VarWChar, 50, "Email_Address").Value = Me.TxtAddress.Text
                    .InsertCommand.Parameters.Add("@Phone_Number", OleDb.OleDbType.VarWChar, 50, "Phone_Number").Value = Me.TxtPhoneNum.Text
                    .InsertCommand.Parameters.Add("@ID_No", OleDb.OleDbType.VarWChar, 50, "ID_No").Value = Me.TxtIDNo.Text
                    .InsertCommand.Parameters.Add("@Date_added", OleDb.OleDbType.VarWChar, 50, "Date_added").Value = Date.Today


                    .InsertCommand.ExecuteNonQuery()

                End With



                Call CloseConnection()
                MsgBox("Record saved...", MsgBoxStyle.Information, "Record saved...")
                If MsgBox("Add another farmer ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Add stock...") = MsgBoxResult.Yes Then


                    Call Cleartext() 'cleat all text from the input


                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox("Unable to save new record(s), please try again...", MsgBoxStyle.Exclamation, "Attention...")
            'TxtEmployeeID.Focus()
            'TxtEmployeeID.SelectAll()
            Call CloseConnection()
        End Try


        Exit Sub


    End Sub

    Private Sub TxtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhoneNum.KeyPress, TxtIDNo.KeyPress

        Try
            Dim NotAllowedSpaces As String = " "
            Dim AllowedNumbers As String = "1234567890"

            If e.KeyChar <> ControlChars.Back Then
                If NotAllowedSpaces.IndexOf(e.KeyChar) = False Then
                    MsgBox("Not allowed spaces for Phone number...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attention...")
                    e.Handled = True
                    Exit Sub
                End If
                If AllowedNumbers.IndexOf(e.KeyChar) = True Then
                    MsgBox("Not allowed letters and symbols...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attentio...")
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLastName.KeyPress, TxtFirstName.KeyPress
        Try
            Dim NotAllowedNumbersAndSymbols As String = "0987654321~`!@#$%^&*()-_=+{}[]:;'|\<>,.?/"
            If e.KeyChar <> ControlChars.Back Then
                If NotAllowedNumbersAndSymbols.IndexOf(e.KeyChar) = -1 = False Then
                    MsgBox("Numbers and symbols not allowed...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attention...")
                    e.Handled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class