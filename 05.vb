Public Class _05

    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox39.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            PictureBox5.Show()
            PictureBox6.Show()
            PictureBox7.Show()
            PictureBox4.Show()
        End If
        If ProgressBar1.Value = 10 Then
            PictureBox5.Hide()
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox4.Hide()
            ProgressBar1.Value = 1
        End If
    End Sub

    Private Sub _05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Hide()
        _06.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Me.Hide()
        _04.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Me.Hide()
        _04.Show()
    End Sub
End Class