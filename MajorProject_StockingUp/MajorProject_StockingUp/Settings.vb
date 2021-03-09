Imports System.IO
Imports System.Windows.Media
Imports System.Net.Http

Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WidthCounter = 0 ''Used to position controls on form
        XResComboBox.Items.Clear() ''Clears previously added resolutions
        XResList.Clear() 'Clears previously added resolutions
        YResComboBox.Items.Clear() 'Clears previously added resolutions

        Me.Height = My.Settings.YResolution / 2 ''Sets form size to be half saved resoltion size
        Me.Width = My.Settings.XResolution / 2

        ''Adds predefined X resolutions

        XResList.Add(1280)
        XResList.Add(1366)
        XResList.Add(1600)
        XResList.Add(1920)
        XResList.Add(2560)
        XResList.Add(3840)

        ''Checks for Max resolution of current screen and deletes any X resolutions greater than it

        For AllInfoIndex = XResList.Count - 1 To 0 Step -1
            If XResList(AllInfoIndex) > Screen.PrimaryScreen.Bounds.Width Then
                XResList.RemoveAt(AllInfoIndex)
            End If
        Next

        ''Adds updated resolution list to combo box

        For Each XRes As Integer In XResList
            XResComboBox.Items.Add(XRes)
            Y = (XRes / 16) * 9
            YResComboBox.Items.Add(Y)
        Next

        Call Resize() ''Call Resize sub

        Me.CenterToScreen() ''Center form on screen

    End Sub

    Private Sub XResComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles XResComboBox.SelectedIndexChanged
        X = XResComboBox.SelectedIndex ''Once of combobox resolution is set, the other will change
        YResComboBox.SelectedIndex = X
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Height = YResComboBox.Text / 2 ''Updates resolution of settings form
        Me.Width = XResComboBox.Text / 2

        My.Settings.XResolution = XResComboBox.Text ''Saves updated resolution to program
        My.Settings.YResolution = YResComboBox.Text

        Call Resize() ''Calls Resize sub

    End Sub

    Private Sub YResComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YResComboBox.SelectedIndexChanged
        Y = YResComboBox.SelectedIndex ''Once of combobox resolution is set, the other will change
        XResComboBox.SelectedIndex = Y
    End Sub

    Public Sub C1Label_Click(sender As Object, e As EventArgs) Handles C1Label.Click

        cDialog.Color = C1Label.BackColor 'Initial selection is current colour.

        If (cDialog.ShowDialog() = DialogResult.OK) Then

            ''Updates label colours to selected colour

            C1Label.BackColor = cDialog.Color
            C1Label.ForeColor = cDialog.Color

            ''Saves colours to My.Settings and defines new series brushes for graph

            Dim TempColor As System.Drawing.Color = cDialog.Color
            My.Settings.Colour1 = TempColor

            Dim ARGB = cDialog.Color
            Dim StrokeBrush As Brush = New SolidColorBrush(Color.FromArgb(ARGB.A, ARGB.R, ARGB.G, ARGB.B))
            Dim FillBrush As Brush = New SolidColorBrush(Color.FromArgb(50, ARGB.R, ARGB.G, ARGB.B))

            StockEntry1.Stroke = StrokeBrush
            StockEntry1.Fill = FillBrush
        End If


    End Sub

    Private Sub C2Label_Click(sender As Object, e As EventArgs) Handles C2Label.Click

        cDialog.Color = C2Label.BackColor 'Initial selection is current colour.

        If (cDialog.ShowDialog() = DialogResult.OK) Then

            ''Updates label colours to selected colour

            C2Label.BackColor = cDialog.Color
            C2Label.ForeColor = cDialog.Color

            ''Saves colours to My.Settings and defines new series brushes for graph

            Dim TempColor As System.Drawing.Color = cDialog.Color
            My.Settings.Colour2 = TempColor

            Dim ARGB = cDialog.Color
            Dim StrokeBrush As Brush = New SolidColorBrush(Color.FromArgb(ARGB.A, ARGB.R, ARGB.G, ARGB.B))
            Dim FillBrush As Brush = New SolidColorBrush(Color.FromArgb(50, ARGB.R, ARGB.G, ARGB.B))

            StockEntry2.Stroke = StrokeBrush
            StockEntry2.Fill = FillBrush

        End If




    End Sub

    Private Sub C3Label_Click(sender As Object, e As EventArgs) Handles C3Label.Click

        cDialog.Color = C3Label.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then

            ''Updates label colours to selected colour

            C3Label.BackColor = cDialog.Color
            C3Label.ForeColor = cDialog.Color

            ''Saves colours to My.Settings and defines new series brushes for graph

            Dim TempColor As System.Drawing.Color = cDialog.Color
            My.Settings.Colour3 = TempColor

            Dim ARGB = cDialog.Color
            Dim StrokeBrush As Brush = New SolidColorBrush(Color.FromArgb(ARGB.A, ARGB.R, ARGB.G, ARGB.B))
            Dim FillBrush As Brush = New SolidColorBrush(Color.FromArgb(50, ARGB.R, ARGB.G, ARGB.B))

            StockEntry3.Stroke = StrokeBrush
            StockEntry3.Fill = FillBrush
        End If

    End Sub

    Private Sub C4Label_Click(sender As Object, e As EventArgs) Handles C4Label.Click

        cDialog.Color = C4Label.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then

            ''Updates label colours to selected colour

            C4Label.BackColor = cDialog.Color
            C4Label.ForeColor = cDialog.Color

            ''Saves colours to My.Settings and defines new series brushes for graph

            Dim TempColor As System.Drawing.Color = cDialog.Color
            My.Settings.Colour4 = TempColor

            Dim ARGB = cDialog.Color
            Dim StrokeBrush As Brush = New SolidColorBrush(Color.FromArgb(ARGB.A, ARGB.R, ARGB.G, ARGB.B))
            Dim FillBrush As Brush = New SolidColorBrush(Color.FromArgb(50, ARGB.R, ARGB.G, ARGB.B))

            StockEntry4.Stroke = StrokeBrush
            StockEntry4.Fill = FillBrush
        End If

    End Sub

    Private Sub C5Label_Click(sender As Object, e As EventArgs) Handles C5Label.Click

        cDialog.Color = C5Label.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then

            ''Updates label colours to selected colour

            C5Label.BackColor = cDialog.Color
            C5Label.ForeColor = cDialog.Color

            ''Saves colours to My.Settings and defines new series brushes for graph

            Dim TempColor As System.Drawing.Color = cDialog.Color
            My.Settings.Colour5 = TempColor

            Dim ARGB = cDialog.Color
            Dim StrokeBrush As Brush = New SolidColorBrush(Color.FromArgb(ARGB.A, ARGB.R, ARGB.G, ARGB.B))
            Dim FillBrush As Brush = New SolidColorBrush(Color.FromArgb(50, ARGB.R, ARGB.G, ARGB.B))

            StockEntry5.Stroke = StrokeBrush
            StockEntry5.Fill = FillBrush
        End If

    End Sub

    Private Sub Resize()

        ''Checks every control in the form, and applys custom font sizes to each one

        For Each cntrl As Control In Panel1.Controls

            If cntrl Is Heading Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 75), FontStyle.Bold)

            ElseIf cntrl Is SubHeading Or cntrl Is SubHeading2 Or cntrl Is SubHeading3 Or cntrl Is XResComboBox Or cntrl Is YResComboBox Or cntrl Is Button1 Or cntrl Is Button2 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 75), FontStyle.Regular)

            ElseIf cntrl.Text = "__" Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 75), FontStyle.Regular)

            End If

        Next

        ''Changes control dimensions based on form height and width

        Panel1.Height = Me.Height * 0.98
        Panel1.Width = Me.Width * 0.98
        Panel1.Location = New Point(Me.Width * 0.01, Me.Height * 0.01)

        Heading.Location = New Point(0, 0)

        SubHeading.Location = New Point(0, Heading.Height + Heading.Margin.Bottom)

        Button1.Location = New Point(YResComboBox.Location.X + YResComboBox.Width + YResComboBox.Margin.Right, SubHeading.Location.Y + SubHeading.Height + SubHeading.Margin.Bottom)
        XResComboBox.Location = New Point(0, Button1.Location.Y + Button1.Height / 3)
        YResComboBox.Location = New Point(XResComboBox.Width + XResComboBox.Margin.Left * 3, XResComboBox.Location.Y)

        SubHeading2.Location = New Point(0, Button1.Location.Y + Button1.Height + Button1.Margin.Bottom)

        For Each cntrl As Control In Panel1.Controls
            If cntrl.Text = "__" Then
                cntrl.Height = Button1.Height
                cntrl.Width = cntrl.Height
                cntrl.Location = New Point(Button1.Width + WidthCounter, SubHeading2.Location.Y + SubHeading2.Height + Button1.Height)
                WidthCounter += Button1.Width
            End If
        Next

        SubHeading3.Location = New Point(0, C1Label.Location.Y + C1Label.Height + SubHeading3.Height)
        Button2.Location = New Point((Panel1.Width - Button2.Width) / 2, SubHeading3.Location.Y + SubHeading3.Height)

        FormExit.Height = Me.Height * 0.1
        FormExit.Width = FormExit.Height
        FormExit.Location = New Point(Panel1.Width - FormExit.Width, 0)


    End Sub

    Private Sub FormExit_Click_1(sender As Object, e As EventArgs) Handles FormExit.Click

        ''User closes settings page

        Dim YN As DialogResult = MessageBox.Show("Are you sure you want to exit the settings page?",
                              "Exit settings??",
                              MessageBoxButtons.YesNo)

        ''Option given to restart program to apply changes

        If YN = DialogResult.Yes Then
            Dim SubYN As DialogResult = MessageBox.Show("To apply your new settings, the program needs to restart. Would you like to exit the program?",
                              "Exit settings??",
                              MessageBoxButtons.YesNo)
            If SubYN = DialogResult.Yes Then
                Application.Restart()
            Else
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ''Allows User to restart the program and start from the beginning

        Dim YN As DialogResult = MessageBox.Show("Are you sure you want to delete ALL save data?",
                              "Delete saves?",
                              MessageBoxButtons.YesNo)

        ''Deletes all XML files in the save data folder

        If YN = DialogResult.Yes Then
            For Each FileFound As String In Directory.GetFiles((Path.Combine(Directory.GetCurrentDirectory(), "SaveData/")), ".xml")
                File.Delete(FileFound)
            Next
        End If
    End Sub
End Class