Imports System.ComponentModel

Imports System.Net.Http
Imports System.IO
Imports AxAcroPDFLib ''Imported to gain acess to Adobe PDF
Imports System.Windows.Forms

Public Class Home

    Private PDFViewer As AxAcroPDF = New AxAcroPDF() ''Needed to dynamically create PDF control, as it gets deleted and created multiple times

    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button.Visible = False ''Button acts a hidden layer, only required when the PDF Viewer Appears

        Call Link.Main() ''Calls main sub program that contains the Google Sheets API and the save data loading

        watch = Stopwatch.StartNew() ''Starts a stopwatch to record time spent in the program

        Me.Height = My.Settings.YResolution ''Sets the form height to match previously saved resolution
        Me.Width = My.Settings.XResolution ''Sets the form width to match previously saved resolution

        Call Resize() ''Calls the resize function to scale all controls based on form size
        Me.CenterToScreen() ''Centers the form onto screen
    End Sub

    Private Sub REALTIMEMARKETPLACEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortfolioToolStripMenuItem.Click
        Me.Hide() ''Hides Home Form
        MyPortfolio.Show() 'Opens Portfolio Form
    End Sub

    Private Sub SIMULATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIMULATIONToolStripMenuItem.Click
        Me.Hide() ''Hides Home Form
        Simulation.Show() ''Opens Simulation Form
    End Sub

    Private Sub FormExit_Click(sender As Object, e As EventArgs) Handles FormExit.Click

        ''Presents user with messagebox to exit form
        Dim YN As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit the application?", MessageBoxButtons.YesNo)

        If YN = DialogResult.Yes Then ''If they want to exit the application, casts for all open forms and closes them all
            My.Application.OpenForms.Cast(Of Form)().ToList().ForEach(Sub(form) form.Close())
        End If
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

        For Each cntrl As Control In Me.Controls

            If cntrl Is MenuStrip1 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is SetButton Then

                SetButton.Font = New Font("Arial Unicode MS", Convert.ToSingle(Me.ClientSize.Width / 150), FontStyle.Regular)
                SetButton.Text = ChrW(&H2699)

            ElseIf cntrl Is Label1 Or cntrl Is Label2 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

            End If
        Next

        ''Changes control dimensions based on form height and width

        MenuStrip1.Height = Me.Height * 0.046
        MenuStrip1.Width = Me.Width

        PictureBox1.Height = Me.Width / 4
        PictureBox1.Width = Me.Width / 4
        PictureBox1.Location = New Point(Me.Width / 6, (Me.Height - MenuStrip1.Height) * (2 / 9))

        Label1.Location = New Point(PictureBox1.Location.X + (PictureBox1.Width - Label1.Width) / 2, PictureBox1.Location.Y + PictureBox1.Height - Label1.Height)

        PictureBox2.Height = Me.Width / 4
        PictureBox2.Width = Me.Width / 4
        PictureBox2.Location = New Point(PictureBox2.Width + 2 * (Me.Width / 6), (Me.Height - MenuStrip1.Height) * (2 / 9))

        Label2.Location = New Point(PictureBox2.Location.X + (PictureBox2.Width - Label2.Width) / 2, PictureBox2.Location.Y + PictureBox2.Height - Label2.Height)
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Settings.ShowDialog() ''Shows the settings form, as a dialog so you cannot click away, without properly closing it
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.BackgroundImage.Dispose() ''Clears previous image stored in memory (meant to free up RAM)
        PictureBox1.BackgroundImage = Stocking_Up.My.Resources.Tutorial2 ''Sets it to same image with a different colour
        Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D7443F") ''Changes label colour
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage.Dispose() ''Clears previous image stored in memory (meant to free up RAM)
        PictureBox1.BackgroundImage = Stocking_Up.My.Resources.Tutorial ''Sets it to same image with a different colour
        Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A6A5A1") ''Changes label colour

    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.BackgroundImage.Dispose() ''Clears previous image stored in memory (meant to free up RAM)
        PictureBox2.BackgroundImage = Stocking_Up.My.Resources.Eula2 ''Sets it to same image with a different colour
        Label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D7443F") ''Changes label colour
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage.Dispose() ''Clears previous image stored in memory (meant to free up RAM)
        PictureBox2.BackgroundImage = Stocking_Up.My.Resources.Eula ''Sets it to same image with a different colour
        Label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A6A5A1") ''Changes label colour
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ''Sets the button to be visible and full screen, while the PDF Viwer is loaded above it and centred
        Button.Visible = True
        Button.BringToFront()
        Me.Controls.Add(PDFViewer)
        PDFViewer.BringToFront()
        Button.Height = Me.Height
        Button.Width = Me.Width
        PDFViewer.Height = Me.Height * 0.8
        PDFViewer.Width = Me.Width * 0.8
        PDFViewer.Location = New Point(Me.Width * 0.1, Me.Height * 0.1)

        ''Opens the file and makes the PDF Viewer visible
        PDFViewer.src = Path.Combine(Directory.GetCurrentDirectory(), "Documents/html-eula.pdf")
        PDFViewer.Visible = True
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        ''When the button is clicked, the PDF Viewer is removed and the Button is hidden
        Me.Controls.Remove(PDFViewer)
        Button.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ''Sets the button to be visible and full screen, while the PDF Viwer is loaded above it and centred
        Button.Visible = True
        Button.BringToFront()
        Me.Controls.Add(PDFViewer)
        PDFViewer.BringToFront()
        Button.Height = Me.Height
        Button.Width = Me.Width
        PDFViewer.Height = Me.Height * 0.8
        PDFViewer.Width = Me.Width * 0.8
        PDFViewer.Location = New Point(Me.Width * 0.1, Me.Height * 0.1)

        ''Opens the file and makes the PDF Viewer visible
        PDFViewer.src = Path.Combine(Directory.GetCurrentDirectory(), "Documents/tutorial.pdf")
        PDFViewer.Visible = True
    End Sub
End Class