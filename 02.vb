Public Class _02

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub _02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            PictureBox25.Hide()
            PictureBox26.Hide()
            PictureBox27.Hide()
            PictureBox28.Hide()
        End If
        If ProgressBar1.Value = 10 Then
            PictureBox25.Show()
            PictureBox26.Show()
            PictureBox27.Show()
            PictureBox28.Show()
        End If
        If ProgressBar1.Value = 11 Then
            ProgressBar1.Value = 1
        End If
    End Sub

    Private Sub PictureBox75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox75.Click
        Me.Hide()
        _03.Show()
    End Sub

    Private Sub PictureBox74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        _03.Show()
    End Sub

    Private Sub PictureBox73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        _03.Show()
    End Sub

    Private Sub PictureBox74_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox74.Click
        Me.Hide()
        _03.Show()
    End Sub

    Private Sub PictureBox73_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox73.Click
        Me.Hide()
        _03.Show()
    End Sub
End Class