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
        PictureBox61.Hide()
        PictureBox62.Hide()
        Label2.Text = "0"
        Button3.Hide()
        Button4.Hide()
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
        TextBox1.ForeColor = Color.White
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
        TextBox1.ForeColor = Color.White
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
        TextBox1.ForeColor = Color.White
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
        TextBox1.ForeColor = Color.White
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
        If Label2.Text = "1" Then
            TextBox1.Show()
            TextBox1.Text = "ye..s i am feel good, you are pass, no passport, good"
            Button1.Hide()
            Button2.Hide()
            timer4.start()
        Else
            Button1.Hide()
            Button2.Hide()
            TextBox1.Show()
            TextBox1.Text = "Yes.. just make sure no one can see.."
            Timer3.Start()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label2.Text = "1" Then
            Me.Hide()
            _04.show()
        Else
            Button1.Hide()
            Button2.Hide()
            TextBox1.Show()
            TextBox1.Text = "If you don't give me your passport you'll have to leave!"
            timer5.start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ProgressBar3.Increment(1)
        If ProgressBar3.Value = 25 Then
            TextBox1.Text = "*sip*"
        End If
        If ProgressBar3.Value = 40 Then
            PictureBox26.Hide()
            PictureBox25.Hide()
            PictureBox61.Show()
            PictureBox62.Show()
        End If
        If ProgressBar3.Value = 45 Then
            Timer2.Stop()
            Timer3.Stop()
            Button1.Show()
            Button2.Show()
            Label2.Text = "1"
            Button1.Text = "Are you okay?"
            Button2.Text = "(Bypass officer)"
            TextBox1.Hide()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        ProgressBar4.Increment(1)
        If ProgressBar4.Value = 25 Then
            TextBox1.Hide()
            Button3.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ProgressBar5.Increment(1)
        If ProgressBar5.Value = 25 Then
            Button4.Show()
            TextBox1.Hide()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Show()
        TextBox1.Text = "I can not let you pass in."
        Button4.Hide()
        timer6.start()
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        ProgressBar6.Increment(1)
        If ProgressBar6.Value = 25 Then
            gameover_03.Show()
            Me.Hide()
        End If
    End Sub
End Class