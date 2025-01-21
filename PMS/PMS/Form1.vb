Imports System.Threading
Imports PMSsearch2 ' Add this line at the top to fix the error

Public Class Form1

    ' Declare a flag to check password visibility
    Private passwordVisible As Boolean = False

    ' Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the password field to password mode initially
        TextBox2.PasswordChar = "*"c
        ' Set the default button text to "Show Password"
        Button3.Text = "Show Password" ' Set Button3 text
    End Sub

    ' TextBox1 (Username) TextChanged event
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' You can add validation or other logic here if necessary
    End Sub

    ' TextBox2 (Password) TextChanged event
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' You can add validation or other logic here if necessary
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
        ' Display the message "Proceeding to log in"
        MessageBox.Show("Proceeding to log in...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Introduce a brief delay (2 seconds)
        Thread.Sleep(2000) ' Use Thread.Sleep without System.Threading if you imported it

        ' Open the PMSsearch form after the delay
        Dim Form2 As New Form2()
        Form2.Show() ' Show the PMSsearch form
        Me.Hide() ' Hide the current form (Form1)
    End Sub

    ' Button2 (Quit) Click event
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the application
        Me.Close()
    End Sub

    ' Button3 (Show/Hide Password) Click event
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If passwordVisible Then
            ' Hide password (set to default)
            TextBox2.PasswordChar = "*"c
            passwordVisible = False
            ' Change Button3 text to "Show Password"
            Button3.Text = "Show Password"
        Else
            ' Show password (set to clear text)
            TextBox2.PasswordChar = ChrW(0)
            passwordVisible = True
            ' Change Button3 text to "Hide Password"
            Button3.Text = "Hide Password"
        End If
    End Sub
End Class
