Imports System.Threading
<<<<<<< HEAD
Imports PMSsearch ' Ensure PMSsearch namespace or reference exists in your project
=======
Imports System.Diagnostics ' For Process.Start
Imports System.IO ' For file path checks
>>>>>>> d8e852b237919740ccb7323cb5cac5641ecf5329

Public Class Form1

    ' Declare a flag to check password visibility
    Private passwordVisible As Boolean = False

    ' Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the password field to password mode initially
        TextBox2.PasswordChar = "*"c
<<<<<<< HEAD
=======
        ' Set the default button text to "Show Password"
        Button3.Text = "Show Password"
>>>>>>> d8e852b237919740ccb7323cb5cac5641ecf5329
    End Sub

    ' TextBox1 (Username) TextChanged event
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Optional validation logic
    End Sub

    ' TextBox2 (Password) TextChanged event
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"c

    End Sub

    ' Handle Enter key to move from username to password field
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus() ' Move focus to TextBox2 (password) when Enter is pressed
        End If
    End Sub

    ' Handle Enter key to log in from password field
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick() ' Simulate Button1 click when Enter is pressed
        End If
    End Sub

    ' Button1 (Login) Click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Proceeding to log in...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Introduce a brief delay (2 seconds)
        Thread.Sleep(2000)

<<<<<<< HEAD
        ' Open the PMSsearch form after the delay
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
=======
        ' Now, attempt to launch PMSsearch.exe if it exists
        Dim pmsSearchPath As String = "C:\PMS2\PMD2\PMS\PMSsearch2.exe"

        If File.Exists(pmsSearchPath) Then
            ' Launch PMSsearch.exe
            Try
                Process.Start(pmsSearchPath)
            Catch ex As Exception
                ' If there is an error starting the process, show an error message
                MessageBox.Show("An error occurred while trying to launch PMSsearch2.exe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Show an error message if the file is not found
            MessageBox.Show("PMSsearch2.exe not found at the specified location: " & pmsSearchPath, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
>>>>>>> d8e852b237919740ccb7323cb5cac5641ecf5329
    End Sub

    ' Button2 (Quit) Click event
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the application
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Toggle password visibility
        If passwordVisible Then
            ' Hide the password
            TextBox2.PasswordChar = "*"c
            ' Set "eye" icon for Button3
            Button3.Image = Image.FromFile("C:\Users\User\Downloads\icons8-invisible-25.png") ' Update with the correct path
        Else
            ' Show the password
            TextBox2.PasswordChar = ControlChars.NullChar
            ' Set "hide" icon for Button3
            Button3.Image = Image.FromFile("C:\Users\User\Downloads\icons8-eye-25.png") ' Update with the correct path
        End If

        ' Toggle the flag
        passwordVisible = Not passwordVisible
    End Sub

<<<<<<< HEAD


=======
>>>>>>> d8e852b237919740ccb7323cb5cac5641ecf5329
End Class
