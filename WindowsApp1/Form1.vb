Public Class Form1
    Dim y0, v0, g, t As Double


    Dim y, v As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y = -0.5 * g * t ^ 2 + v0 * t + y0
        v = -g * t + v0



        Chart1.Series(0).Points.AddXY(t, y)
        Chart1.Series(1).Points.AddXY(t, v)

        Label5.Text = t
        Label6.Text = v

        PictureBox1.Location = New Point(PictureBox1.Location.X,
        PictureBox2.Location.Y - y - PictureBox1.Height)

        t = t + 0.1


        If y <= 0 And t > 0 Then
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox2.Location.Y - Val(TextBox1.Text) - PictureBox1.Height)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        y0 = TextBox1.Text
        v0 = TextBox2.Text
        g = TextBox3.Text
        t = 0
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
