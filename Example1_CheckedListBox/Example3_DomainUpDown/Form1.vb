Public Class Form1
    Private Sub DayUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles DayUpDown.SelectedItemChanged
        Dim Day() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
        Dim count As Integer = DayUpDown.Items.Count - 1
        For i = 0 To count
            If DayUpDown.SelectedIndex = i Then
                LabelDay.Text = Day(i)

            End If
        Next
    End Sub
End Class
