Public Class Form1


    Private Sub Button1_Operator(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
        Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click

        Dim Input_num1 As Integer = TextBox1.Text
        Dim Input_num2 As Integer = TextBox2.Text
        Dim Result As Integer


        Dim button As Button = CType(sender, Button)
        If button Is Button1 Then                      ' Addition
            Result = Input_num1 + Input_num2
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button2 Then                 ' Subtraction
            Result = Input_num1 - Input_num2
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button3 Then
            Result = -Input_num1                     ' Negation
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button4 Then
            Result = Input_num1 * Input_num2          ' Multiplication
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button5 Then
            Result = Input_num1 / Input_num2          ' Division
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button6 Then                 ' Quotient
            Result = Input_num1 \ Input_num2
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button7 Then
            Result = -Input_num1 Mod Input_num2       ' Remainder
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button8 Then
            Result = Input_num1 ^ Input_num2          ' Power
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button9 Then                ' Left Shift
            Result = Convert.ToString(Input_num1, 2)
            Result = Result << 1
            MessageBox.Show("Result: " & Result)
        ElseIf button Is Button10 Then               ' Right Shift
            Result = Convert.ToString(Input_num1, 2)
            Result = Result >> 1
            MessageBox.Show("Result: " & Result)
        End If

    End Sub


End Class
