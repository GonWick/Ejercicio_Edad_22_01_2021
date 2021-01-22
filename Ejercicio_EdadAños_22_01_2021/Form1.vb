Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Años As Integer = CStr(TextBox1.Text)
        Select Case Años
            Case 0 To 1
                Label1.Text = "Eres un niñ@"
            Case 2 To 5
                Label1.Text = "Eres un@ niñ@ preescolar"
            Case 6 To 11
                Label1.Text = "Que lindo es ser niñ@"
            Case 12 To 18
                Label1.Text = "Recuerda la reveldia de la adolescencia"
            Case 19 To 30
                Label1.Text = "A estudiar o trabajar"
            Case Else
                Label1.Text = "La vida es bella"
        End Select

    End Sub



    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub
End Class
