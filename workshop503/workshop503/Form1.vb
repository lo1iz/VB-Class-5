Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim x As Integer
        Dim ran As Random = New Random
        x = ran.Next(1, 5)
        Dim lose As Boolean = True
        picCard.SizeMode = PictureBoxSizeMode.StretchImage

        If x = 1 Then
            picCard.Image = My.Resources.A1
            If rdSpade.Checked Then
                MessageBox.Show("CONGRATULATION !!" & vbNewLine & "You're correct to random Card", "Guess The Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lose = False
            End If

        ElseIf x = 2 Then
            picCard.Image = My.Resources.A2
            If rdHeart.Checked Then
                MessageBox.Show("CONGRATULATION !!" & vbNewLine & "You're correct to random Card", "Guess The Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lose = False
            End If

        ElseIf x = 3 Then
            picCard.Image = My.Resources.A3
            If rdClub.Checked Then
                MessageBox.Show("CONGRATULATION !!" & vbNewLine & "You're correct to random Card", "Guess The Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lose = False
            End If

        ElseIf x = 4 Then
            picCard.Image = My.Resources.A4
            If rdDiamond.Checked Then
                MessageBox.Show("CONGRATULATION !!" & vbNewLine & "You're correct to random Card", "Guess The Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lose = False
            End If

        End If
        If lose Then
            MessageBox.Show("You're incorrect to random Card", "Guess The Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        picCard.Image = My.Resources.back
        rdSpade.Checked = True
        btnStart.Enabled = True
        btnAnswer.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim ch As String
        ch = MessageBox.Show("สุ่มการ์ดเรียบร้อย", "Random Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If ch = DialogResult.OK Then
            btnStart.Enabled = False
            btnAnswer.Enabled = True
        End If
    End Sub
End Class