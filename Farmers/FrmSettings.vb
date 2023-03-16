Public Class FrmSettings

    'Settings po ito ng kung Gustong meron Pop-Up ung FrmLoading o Hi
    'Sa Quick Search Or Quick Refresh hindi mgpopop-up ung FrmLoading... para po hindi mainip yung gumagamit kakahintay ng refreshing 0 searching  >(^_^)<
    'Pwede din wala na itong FrmSettings na ito dinagdag ko na po para sa iba pang gagamit nito kung gustong mabilis o mabagal ung refresh o search...


    '====== Para makagawa ng Settings =====

    '* Pumunta sa Solution Explorer Click ang My Project 0 kaya Menu Bar(Project) 
    '* Punta sa Settings Tab
    '* May makikita po doon na (Name , Type , Scope at Value ) andon po nakadeclare na ChkRefresh at ChkSearch...
    '* Para kahit nakaclose ung program nakasave pa din po ung Settings....

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        MsgBox("Settings saved...", MsgBoxStyle.Information, "Saved...")
        'My.Settings.ChkRefresh = Me.ChkRefresh.Checked
        'My.Settings.ChkSearch = Me.ChkSearch.Checked
        Me.Close()
    End Sub

    Private Sub FrmSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim ApplyChanges As System.Configuration.SettingsProperty
            ApplyChanges = New System.Configuration.SettingsProperty(Me.ChkRefresh.Checked)
            ApplyChanges = New System.Configuration.SettingsProperty(Me.ChkSearch.Checked)
            My.Settings.Properties.Add(ApplyChanges)
            My.Settings.Save()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ChkRefresh.Checked = My.Settings.ChkRefresh
        'Me.ChkSearch.Checked = My.Settings.ChkSearch
    End Sub
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub
End Class