Public Class Form1

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim first_name As String = tb_first_name.Text ' Assuming the TextBox for first name is named tb_first_name and .text is used to get the input
        Dim last_name As String = tb_last_name.Text
        Dim email As String = tb_email.Text
        Dim age As Integer = tb_age.Text ' Assuming the TextBox for age is named tb_age and .text is used to get the input

        ' Validate age input
        If Not Integer.TryParse(tb_age.Text, age) OrElse age < 18 Then
            MessageBox.Show("Sorry! You are not eligiblale for Voting.")
            Return
        End If
        ' Display the greeting message
        MessageBox.Show("Hello, " & first_name & " " & last_name & "! You are " & age & " years old." & Environment.NewLine &
        "Your are eligiblale for Voting and your application is Submited.") 'Environment.NewLine is used to add a new line in the message box

    End Sub

End Class
