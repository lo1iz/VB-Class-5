Public Class Form1
    Private Sub CardUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles CardUpDown.SelectedItemChanged
        If CardUpDown.SelectedIndex = 0 Then
            PictureBoxCard.Image = My.Resources.A1
        ElseIf CardUpDown.SelectedIndex = 1 Then
            PictureBoxCard.Image = My.Resources.A2
        ElseIf CardUpDown.SelectedIndex = 2 Then
            PictureBoxCard.Image = My.Resources.A3
        ElseIf CardUpDown.SelectedIndex = 3 Then
            PictureBoxCard.Image = My.Resources.A4
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged, RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBoxCard.SizeMode = PictureBoxSizeMode.Normal
        ElseIf RadioButton2.Checked Then
            PictureBoxCard.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf RadioButton3.Checked Then
            PictureBoxCard.SizeMode = PictureBoxSizeMode.CenterImage
        ElseIf RadioButton4.Checked Then
            PictureBoxCard.SizeMode = PictureBoxSizeMode.AutoSize
        ElseIf RadioButton5.Checked Then
            PictureBoxCard.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class
