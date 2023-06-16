Public Class frmUpdateBooks
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MessageBox.Show("The system will update the record into the database.")
        Dim currentIndex As Integer = GetCurrentIndex()
        If currentIndex >= 0 Then
            Dim bookDetails As Object() = frmMainMenu.BookArray(currentIndex)
            bookDetails(0) = txtBookID.Text
            bookDetails(1) = txtAuthor.Text
            bookDetails(2) = txtTitle.Text
            bookDetails(3) = txtPurchasePrice.Text
            bookDetails(4) = txtSalePrice.Text
            bookDetails(5) = txtInventory.Text

            MessageBox.Show("The record has been updated.")
        End If

    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        LoadObjectAtIndex(0)
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        LoadObjectAtIndex(frmMainMenu.BookArray.Count - 1)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim currentIndex As Integer = GetCurrentIndex()
        If currentIndex > 0 Then
            LoadObjectAtIndex(currentIndex - 1)
        End If
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Dim currentIndex As Integer = GetCurrentIndex()
        If currentIndex < frmMainMenu.BookArray.Count - 1 Then
            LoadObjectAtIndex(currentIndex + 1)
        End If
    End Sub

    Private Sub txtBookID_TextChanged(sender As Object, e As EventArgs) Handles txtBookID.TextChanged
        ' Handle the text changed event if needed
    End Sub

    Private Sub frmUpdateBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMainMenu.BookArray.Count > 0 Then
            LoadObjectAtIndex(0)
        End If

        UpdateRecordCount()
    End Sub

    Private Sub LoadObjectAtIndex(index As Integer)
        Dim bookDetails As Object() = frmMainMenu.BookArray(index)

        txtBookID.Text = bookDetails(0).ToString()
        txtAuthor.Text = bookDetails(1).ToString()
        txtTitle.Text = bookDetails(2).ToString()
        txtPurchasePrice.Text = bookDetails(3).ToString()
        txtSalePrice.Text = bookDetails(4).ToString()
        txtInventory.Text = bookDetails(5).ToString()
    End Sub

    Private Function GetCurrentIndex() As Integer
        Dim bookID As String = txtBookID.Text
        For i As Integer = 0 To frmMainMenu.BookArray.Count - 1
            Dim bookDetails As Object() = frmMainMenu.BookArray(i)
            If bookDetails(0).ToString() = bookID Then
                Return i
            End If
        Next

        Return -1
    End Function

    Private Sub UpdateRecordCount()
        lblNumberRecords.Text = frmMainMenu.BookArray.Count.ToString()
    End Sub
End Class
