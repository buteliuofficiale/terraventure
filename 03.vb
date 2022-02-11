Public Class _03

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click

    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub _03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        Timer1.Start()
        Button1.Hide()
        Button2.Hide()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            TextBox1.Show()
            TextBox1.Text = "Hello, where is your passport?"
        End If
        If ProgressBar1.Value = 40 Then
            TextBox1.Text = "(*) New ITEM: Beer"
            TextBox1.ForeColor = Color.Yellow
        End If
        If ProgressBar1.Value = 60 Then
            TextBox1.Text = "Your passport, please!"
            TextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox5.Hide()
        PictureBox7.Hide()
        PictureBox11.Hide()
        PictureBox12.Hide()
        PictureBox6.Hide()
        TextBox1.Text = "What is this? Beer?"
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox5.Hide()
        PictureBox7.Hide()
        PictureBox11.Hide()
        PictureBox12.Hide()
        PictureBox6.Hide()
        TextBox1.Text = "What is this? Beer?"
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        PictureBox5.Hide()
        PictureBox7.Hide()
        PictureBox11.Hide()
        PictureBox12.Hide()
        PictureBox6.Hide()
        TextBox1.Text = "What is this? Beer?"
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox5.Hide()
        PictureBox7.Hide()
        PictureBox11.Hide()
        PictureBox12.Hide()
        PictureBox6.Hide()
        TextBox1.Text = "What is this? Beer?"
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 30 Then
            Button1.Show()
            Button2.Show()
            TextBox1.Hide()
        End If
    End Sub

    Private Sub ProgressBar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class