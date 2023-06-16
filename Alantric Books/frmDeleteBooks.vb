Public Class frmDeleteBooks
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim currentIndex As Integer = GetCurrentIndex()
        If currentIndex >= 0 Then
            frmMainMenu.BookArray.RemoveAt(currentIndex)
            ClearTextBoxes()
            MessageBox.Show("The record has been deleted.")
            UpdateRecordCount()
        End If
    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        LoadObjectAtIndex(0)
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

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        LoadObjectAtIndex(frmMainMenu.BookArray.Count - 1)
    End Sub

    Private Sub frmDeleteBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ClearTextBoxes()
        txtBookID.Text = ""
        txtAuthor.Text = ""
        txtTitle.Text = ""
        txtPurchasePrice.Text = ""
        txtSalePrice.Text = ""
        txtInventory.Text = ""
    End Sub

    Private Sub UpdateRecordCount()
        lblNumberRecords.Text = frmMainMenu.BookArray.Count.ToString()
    End Sub
End Class
