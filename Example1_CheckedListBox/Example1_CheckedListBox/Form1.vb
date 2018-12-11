Public Class Form1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim item As String = TextBoxItem.Text
        CheckedListBox.Items.Add(item)
        TextBoxItem.Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim countItem As Integer = CheckedListBox.Items.Count - 1
        For i = countItem To 0 Step -1
            If CheckedListBox.GetItemChecked(i) Then
                CheckedListBox.Items.RemoveAt(i)
            End If
        Next
    End Sub
End Class
