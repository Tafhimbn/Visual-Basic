Public Class Form1
    Private Sub number_click(sender As Object, e As EventArgs) Handles Button5.Click, Button6.Click, Button7.Click,
        Button9.Click, Button10.Click, Button11.Click,
        Button13.Click, Button14.Click, Button15.Click ' Handles click events for multiple buttons; each button represents a number; when clicked, it appends its text to TextBox1


        Dim ButtonValue As Button = CType(sender, Button) ' Cast sender to Button type to access its properties and assign it to ButtonValue; this allows us to get the text of the clicked button 

        TextBox1.Text &= ButtonValue.Text ' Append button text to TextBox1; this builds the number being entered by the user

    End Sub

    Private Sub Button2_Zero(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then             ' Do nothing to prevent leading zeros; if TextBox1 is empty, do not append "0"

        Else
            TextBox1.Text &= "0"                         ' Append "0" to TextBox1 only if it is not empty; prevents leading zeros"

        End If
    End Sub

    Private Sub Button3_Dot(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0."                         ' If TextBox1 is empty, append "0." to start a decimal number
        ElseIf Not TextBox1.Text.Contains(".") Then       ' Check if TextBox1 already contains a decimal point
            TextBox1.Text &= "."                          ' Append "." to TextBox1 only if it does not already contain a decimal point

        End If
    End Sub

    Private Sub Button17_Clear(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = String.Empty                          ' Clear TextBox1 when the clear button is clicked
    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles ButtonPlus.Click, ButtonMinus.Click,
        ButtonMultiply.Click, ButtonDivide.Click
        TextBox1.Text &= CType(sender, Button).Text  ' Append the operator text to TextBox1 when an operator button is clicked

    End Sub

    Private Sub EqualsClick(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Dim expression As String = TextBox1.Text ' Get the expression from TextBox1; store it in a variable called "expression".
            Dim table As New DataTable 'Create a DataTable object
            ' DataTable is normally used to store data, but it has a
            ' "Compute" method that can evaluate simple arithmetic expressions.

            Dim result As Object = table.Compute(expression, String.Empty)  ' Evaluate the expression
            ' The Compute method calculates the value of the expression.
            ' The second parameter is a filter, which we don't need, so we pass an empty string.
            ' Example: expression = "5+3*2" → result = 11

            TextBox1.Text = result.ToString

        Catch ex As Exception
            TextBox1.Text = "Error in Expression"
        End Try



    End Sub

    Private Sub Button18_parentheses(sender As Object, e As EventArgs) Handles Button18.Click

        Dim expression As String = TextBox1.Text                       ' Get the expression from TextBox1; store it in a variable called "expression".
        Dim table As New DataTable                                     ' Create a DataTable object to use its Compute method for evaluating expressions
        Dim result As Object = table.Compute(expression, String.Empty) ' Evaluate the expression; store the result in "result" variable from DataTable's Compute method; string.empty is used as no filter is needed
        TextBox1.Text = result.ToString                                ' Display the result in TextBox1 by converting it to a string

    End Sub

    Private Sub Button19_percentage(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            Dim expression As String = TextBox1.Text

            ' Replace % with /100 to make it mathematically valid
            expression = expression.Replace("%", "/100")

            Dim table As New DataTable
            Dim result As Object = table.Compute(expression, String.Empty)

            TextBox1.Text = result.ToString()

        Catch ex As Exception
            TextBox1.Text = "Error in Expression"
        End Try

    End Sub
End Class
