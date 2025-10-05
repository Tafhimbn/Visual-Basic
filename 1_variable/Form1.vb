Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_check_variable.Click

        ' Variable Declaration in VB.NET
        ' Syntax:
        '         Dim variable_name As DataType
        ' or
        '        Dim variable_name As DataType = value

        Dim frirst_name As String
        frirst_name = "Tafhim"
        Dim last_name As String = "Bin Nasir"
        Dim age As Integer = 28
        Dim height As Double = 5.8
        Dim isStudent As Boolean = False
        Dim joiningDate As Date = #10/5/2025#
        MsgBox("My name is " & frirst_name & " " & last_name)

    End Sub
End Class
