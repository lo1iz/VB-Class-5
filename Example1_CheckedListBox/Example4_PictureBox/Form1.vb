Public Class Form1
    Private Sub rdCard1_CheckedChanged(sender As Object, e As EventArgs) Handles rdCard1.CheckedChanged
        PictureBoxCard.Image = My.Resources.A1
    End Sub

    Private Sub rdCard2_CheckedChanged(sender As Object, e As EventArgs) Handles rdCard2.CheckedChanged
        PictureBoxCard.Image = My.Resources.A2
    End Sub

    Private Sub rdCard3_CheckedChanged(sender As Object, e As EventArgs) Handles rdCard3.CheckedChanged
        PictureBoxCard.Image = My.Resources.A3
    End Sub

    Private Sub rdCard4_CheckedChanged(sender As Object, e As EventArgs) Handles rdCard4.CheckedChanged
        PictureBoxCard.Image = My.Resources.A4
    End Sub
End Class
