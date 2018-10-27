Public Class Form1
    Dim vector(10) As persona
    Dim cont As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New persona(TextBox1.Text, Val(TextBox2.Text))
        vector(cont) = p
        cont = cont + 1
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nom As String
        Dim j As Integer = cont - 1
        For i As Integer = 0 To j
            nom = vector(i).setnom
            MsgBox(nom)
        Next
        End
        'finalizamos
    End Sub
End Class
