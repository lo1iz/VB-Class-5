Public Class Form1
    Private Sub Chk1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk4.CheckedChanged, Chk3.CheckedChanged, Chk2.CheckedChanged, Chk1.CheckedChanged
        If Chk1.Checked = True Then
            Num1.Enabled = True
        Else
            Num1.Enabled = False
            Num1.Value = 0
        End If

        If Chk2.Checked = True Then
            Num2.Enabled = True
        Else
            Num2.Enabled = False
            Num2.Value = 0
        End If

        If Chk3.Checked = True Then
            Num3.Enabled = True
        Else
            Num3.Enabled = False
            Num3.Value = 0
        End If

        If Chk4.Checked = True Then
            Num4.Enabled = True
        Else
            Num4.Enabled = False
            Num4.Value = 0
        End If
    End Sub

    Private Sub Chk5_CheckedChanged(sender As Object, e As EventArgs) Handles Chk7.CheckedChanged, Chk6.CheckedChanged, Chk5.CheckedChanged
        If Chk5.Checked = True Then
            Num5.Enabled = True
        Else
            Num5.Enabled = False
            Num5.Value = 0
        End If

        If Chk6.Checked = True Then
            Num6.Enabled = True
        Else
            Num6.Enabled = False
            Num6.Value = 0
        End If

        If Chk7.Checked = True Then
            Num7.Enabled = True
        Else
            Num7.Enabled = False
            Num7.Value = 0
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Chk1.Checked = False
        Chk2.Checked = False
        Chk3.Checked = False
        Chk4.Checked = False
        Chk5.Checked = False
        Chk6.Checked = False
        Chk7.Checked = False
        lblTotalPrice.Text = ""
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        'ไม่ติ๊กอะไรเลย'
        If Chk1.Checked = False And Chk2.Checked = False And Chk3.Checked = False And Chk4.Checked = False And Chk5.Checked = False And Chk6.Checked = False And Chk7.Checked = False Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        'จำนวนเป็น0แจ้งเตือน'
        If Chk1.Checked = True And Num1.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk2.Checked = True And Num2.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk3.Checked = True And Num3.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk4.Checked = True And Num4.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk5.Checked = True And Num5.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk6.Checked = True And Num6.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Chk7.Checked = True And Num7.Value = 0 Then
            MessageBox.Show("กรุณาเลือกเมนู", "Warning", MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim total As Double = 0
        total += (Num1.Value * 19) + (Num2.Value * 19) + (Num3.Value * 19) + (Num4.Value * 19) + (Num5.Value * 19) + (Num6.Value * 19) + (Num7.Value * 19)

        Dim MesRe As DialogResult = MessageBox.Show("มีบัตรสมาชิกหรือไม่?", "Member card", MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question)
        If MesRe = DialogResult.Yes Then
            Dim totalEX = total - (total * 10) / 100
            lblTotalPrice.Text = Format(totalEX, "#,###.00 Baht")
        Else
            lblTotalPrice.Text = Format(total, "#,###.00 Baht")
        End If



    End Sub
End Class