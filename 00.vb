Public Class _00

    Private Sub _00_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "vbtesting" Then
            Me.Hide()
            main.Show()
        End If
    End Sub
End Class