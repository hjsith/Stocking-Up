Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Net.Http
Imports System.Threading
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.ComponentModel
Imports MaterialSkin
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Imports System.Windows.Forms
Imports System.Linq

Public Class MyPortfolio

    Private Sub RealtimeMarket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = My.Settings.YResolution ''Sets the form height to match previously saved resolution
        Me.Width = My.Settings.XResolution ''Sets the form width to match previously saved resolution



        TransactionGridView.DataSource = HistoryData.Tables("Transaction") ''Displays history data table in transaction grid view

        Saves.AddToRecordData(RecordsData) ''Updates record data table with new data.

        For Each Col As DataGridViewColumn In TransactionGridView.Columns ''Loops through each column in the transaction grid view and freezes it, so it can be searched
            Col.Frozen = False
        Next

        Saves.LoadFromHistoryXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/transactions.xml")) ''Loads updated history data from XML file
        Saves.LoadFromRecordsXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/records.xml")) ''Loads updated records data from XML file

        ''Sets the minimum, maximum and current value of the progress bar

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000000
        ProgressBar1.Value = UserBalance


        Profit.Text = BiggestProfit ''Displays biggest profit as label
        Loss.Text = BiggestLoss ''Displays biggest loss as label

        If LTS Is Nothing Then
        Else
            LongTradingSess = TimeSpan.Parse(LTS) ''Parses Long Trading String (LTS) into TimeSpan
        End If

        If STS Is Nothing Then
        Else
            ShortTradingSess = TimeSpan.Parse(STS) ''Parses Shortest Trading String (STS) into TimeSpan
        End If

        ''Displays longest and shortest trading sessions as label in HH:MM:SS:MSMS format

        PTradeSess.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", LongTradingSess.Hours, LongTradingSess.Minutes, LongTradingSess.Seconds, LongTradingSess.Milliseconds / 10)
        STradeSess.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ShortTradingSess.Hours, ShortTradingSess.Minutes, ShortTradingSess.Seconds, ShortTradingSess.Milliseconds / 10)

        'Displays total money made and lost, and current user balance as label

        MMLbl.Text = TotalMoneyMade
        MLLbl.Text = TotalMoneyLost
        CBLbl.Text = UserBalance

        Call Resize() ''Resizes controls based on form dimensions
        Me.CenterToScreen() ''Centres form on screen

    End Sub

    Private Sub searchbox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.Text = "" ''On click, the searchbox becomes empty
    End Sub

    Private Sub searchbox_LostFocus(sender As Object, e As EventArgs) Handles SearchBox.LostFocus
        SearchBox.Text = "Please Search Stocks Here..." ''On lost focus, the searchbox holds placeholder text
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

        If Me.Text = "" Then

            TransactionDataTable.DefaultView.RowFilter = ""
            TransactionGridView.Refresh()
        ElseIf SearchBox.Text = "Please Search Stocks Here..." Then

        Else
            TransactionDataTable.DefaultView.RowFilter = String.Format("Code LIKE '%{0}%'", SearchBox.Text) ''Filters data table based on occurrence of searchbox text in "Code" column
            TransactionGridView.Refresh() ''Refreshes linked transaction gird view to show filters
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FormExit.Click
        ''Presents user with messagebox to exit form
        Dim YN As DialogResult = MessageBox.Show("Are you sure you want to exit the application?",
                                      "Exit the application?",
                                      MessageBoxButtons.YesNo)

        ''If they want to exit the application, casts for all open forms and closes them all
        If YN = DialogResult.Yes Then
            My.Application.OpenForms.Cast(Of Form)() _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        End If
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Close() ''Closes Portfolio Form
        Home.Show() ''Opens Home Form
    End Sub

    Private Sub SIMULATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIMULATIONToolStripMenuItem.Click
        Me.Close() ''Closes Portfolio Form
        Simulation.Show() ''Opens Simulation Form
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Settings.ShowDialog() ''Shows the settings form, as a dialog so you cannot click away, without properly closing it
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown

        ''Checks if mouse is held down on menustrip to allow repositioning of form
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Cross
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove

        ''Moves the form
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp

        ''Leaves the form in one location 
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub Resize()

        ''Checks every control in the form, and applys custom font sizes to each one

        For Each cntrl As Control In Me.Controls ''Looks at form controls

            If cntrl Is MenuStrip1 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is SetButton Then

                SetButton.Font = New Font("Arial Unicode MS", Convert.ToSingle(Me.ClientSize.Width / 150), FontStyle.Regular)
                SetButton.Text = ChrW(&H2699)


            End If
        Next

        For Each cntrl As Control In Panel1.Controls ''Looks at Panel 1 controls

            If cntrl Is TransactionGridView Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is MenuStrip1 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is Heading1 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 59), FontStyle.Bold)

            ElseIf cntrl Is InfoView Then

                For Each subcntrl As Label In InfoView.Controls

                    subcntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

                Next

            ElseIf cntrl Is SearchBox Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

            End If

        Next

        For Each cntrl As Control In Panel2.Controls ''Looks at Panel 2 controls
            If cntrl Is Heading2 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 59), FontStyle.Bold)

            End If
        Next

        For Each cntrl As Control In Panel3.Controls ''Looks at Panel 3 controls
            If cntrl Is Heading3 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 59), FontStyle.Bold)

            End If
        Next

        ''Changes control dimensions and location based on form height and width

        MenuStrip1.Height = Me.Height * 0.046
        MenuStrip1.Width = Me.Width

        Panel1.Height = Me.Height * 0.62
        Panel1.Width = Me.Width * 0.611
        Panel1.Location = New Point(Panel1.Margin.Left, MenuStrip1.Height + Panel1.Padding.Top)

        Panel2.Height = Me.Height * 0.3
        Panel2.Width = Me.Width * 0.611
        Panel2.Location = New Point(Panel2.Margin.Left, MenuStrip1.Height + Panel1.Height + Panel1.Margin.Top + Panel1.Margin.Bottom)

        Panel3.Height = Me.Height * 0.92
        Panel3.Width = Me.Width * 0.38
        Panel3.Location = New Point(Panel1.Width + Panel1.Margin.Left + Panel1.Margin.Right, Panel1.Location.Y)

        Heading1.Location = New Point(0, 0)
        Heading2.Location = New Point(0, 0)
        Heading2.Location = New Point(0, 0)

        SearchBox.Height = Me.Panel1.Height * 0.1
        SearchBox.Width = Me.Panel1.Width * 0.96
        SearchBox.Location = New Point(Panel1.Width * 0.02, Heading1.Height)

        TransactionGridView.Height = Me.Panel1.Height * 0.7
        TransactionGridView.Width = Me.Panel1.Width * 0.96
        TransactionGridView.Location = New Point(Panel1.Width * 0.02, Heading1.Height + SearchBox.Height)

        ProgressBar1.Height = Panel2.Height * 0.2
        ProgressBar1.Width = Panel2.Width * 0.8
        ProgressBar1.Location = New Point(Panel2.Width * 0.1, Panel2.Height * 0.4)

        InfoView.Width = Me.Panel3.Width * 0.96
        InfoView.Location = New Point(Panel3.Width * 0.02, Heading3.Height)
    End Sub
End Class