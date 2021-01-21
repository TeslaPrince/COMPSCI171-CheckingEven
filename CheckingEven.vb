Public Class CheckingEven
    'CheckingEven program
    'This program checks whether the input integer 
    'is an even or not.

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim userIn As Integer
        Dim result As Boolean
        userIn = CInt(txtInput.Text)
        'check is userIn is an even
        'if the number is divisible by 2
        result = (userIn Mod 2 = 0)
        lblDisplay.Text = CStr(result)
    End Sub
End Class
