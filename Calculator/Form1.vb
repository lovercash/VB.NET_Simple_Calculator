Public Class Form1
    Public opt As Object = ""
    Dim firstNum, secondNum, result As Double
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        opt = "+"
        Calculation()

    End Sub
    Private Sub Calculation()

        'Reset all 
        btnPlus.BackColor = Color.FromArgb(224, 224, 224)
        btnMinus.BackColor = Color.FromArgb(224, 224, 224)
        btnMultiply.BackColor = Color.FromArgb(224, 224, 224)



        'Do calculation based on operand
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then

            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)

            Select Case True
                Case opt = "+"
                    result = firstNum + secondNum
                    txtResults.Text = "The result of " & firstNum & " + " & secondNum & " = " & result
                    btnPlus.BackColor = Color.AliceBlue
                Case opt = "-"
                    result = firstNum - secondNum
                    txtResults.Text = "The result of " & firstNum & " - " & secondNum & " = " & result
                    btnMinus.BackColor = Color.AliceBlue
                Case opt = "x"
                    result = firstNum * secondNum
                    txtResults.Text = "The result of " & firstNum & " X " & secondNum & " = " & result
                    btnMultiply.BackColor = Color.AliceBlue
            End Select
        Else
            'MsgBox("Please enter the First and Second Numbers")
            MessageBox.Show("Please enter the First and Second Numbers")
        End If

    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        txtResults.Text = ""
    End Sub

    Private Sub txtSecond_TextChanged(sender As Object, e As EventArgs) Handles txtSecond.TextChanged
        txtResults.Text = ""
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        opt = "-"
        Calculation()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        opt = "x"
        Calculation()
    End Sub
End Class
