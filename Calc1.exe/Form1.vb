Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check if a numeric value has been used and that the textbox is not empty
        If TextBox2.Text = "" Or TextBox3.Text = "" Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Then
            MsgBox("Please enter a valid value into the text box")
        Else
            'sets label to display action which has occurred e.g '+', '-' etc 
            Label3.Text = "+"
            'defines text box variables as Double to enable use of decimal point when adding
            Dim num1 As Double
            Dim num2 As Double
            Dim ans1 As String
            num1 = TextBox2.Text
            num2 = TextBox3.Text
            ans1 = TextBox1.Text
            ans1 = CDbl(num1) + CDbl(num2)
            'prints output in TextBox1 
            TextBox1.Text = ans1
            'uncomment line below if you want a popup box to display the calculated output
            'MsgBox(TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'check if a numeric value has been used and that the textbox is not empty
        If TextBox2.Text = "" Or TextBox3.Text = "" Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Then
            MsgBox("Please enter a valid value into the text box")
        Else
            'sets label to display action which has occurred e.g '+', '-' etc 
            Label3.Text = "-"
            'defines text box variables as Double to enable use of decimal point when adding
            Dim num1 As Double
            Dim num2 As Double
            Dim ans1 As String
            num1 = TextBox2.Text
            num2 = TextBox3.Text
            ans1 = TextBox1.Text
            ans1 = CDbl(num1) - CDbl(num2)
            'prints output in TextBox1 (ans1) 
            TextBox1.Text = ans1
            'uncomment line below if you want a popup box to display the calculated output
            'MsgBox(TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'check if values are clear/empty, if they are show a popup else clear them
        If TextBox2.Text = "" Or TextBox3.Text = "" Or Label3.Text = "" Then
            MsgBox("Nothing to clear :(")
        Else
            Label3.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Text = ""
            MsgBox("Cleared!")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'check if a numeric value has been used and that the textbox is not empty
        If TextBox2.Text = "" Or TextBox3.Text = "" Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Then
            MsgBox("Please enter a valid value into the text box")
        Else
            'sets label to display action which has occurred e.g '+', '-' etc 
            Label3.Text = "*"
            'defines text box variables as Double to enable use of decimal point when adding
            Dim num1 As Double
            Dim num2 As Double
            Dim ans1 As String
            num1 = TextBox2.Text
            num2 = TextBox3.Text
            ans1 = TextBox1.Text
            ans1 = CDbl(num1) * CDbl(num2)
            'prints output in TextBox1 (ans1) 
            TextBox1.Text = ans1
            'uncomment line below if you want a popup box to display the calculated output
            'MsgBox(TextBox1.Text)
        End If
    End Sub
End Class
