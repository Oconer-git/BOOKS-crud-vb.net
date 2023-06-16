Public Class frmAddBooks

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBookID.Text = ""
        txtAuthor.Text = ""
        txtTitle.Text = ""
        txtPurchasePrice.Text = ""
        txtSalePrice.Text = ""
        txtInventory.Text = ""
        txtBookID.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtBookID.Text.Length = 0 Or txtAuthor.Text.Length = 0 Or
        txtTitle.Text.Length = 0 Or txtPurchasePrice.Text.Length = 0 Or
        txtSalePrice.Text.Length = 0 Or txtInventory.Text.Length = 0 Then
            MessageBox.Show("Please enter all data")

        ElseIf Not IsNumeric(txtPurchasePrice.Text) Then
            MessageBox.Show("Please enter a numeric Purchase Price.")
            txtPurchasePrice.Focus()

        ElseIf Not IsNumeric(txtSalePrice.Text) Then
            MessageBox.Show("Please enter a numeric Sale Price.")
            txtSalePrice.Focus()

        ElseIf Not IsNumeric(txtInventory.Text) Then
            MessageBox.Show("Please enter a numeric Number of items on Stock.")
            txtInventory.Focus()

        Else
            MessageBox.Show("The system will store the new record into the database.")
            Dim bookID As String = txtBookID.Text
            Dim author As String = txtAuthor.Text
            Dim title As String = txtTitle.Text
            Dim purchasePrice As Decimal = Convert.ToDecimal(txtPurchasePrice.Text)
            Dim salePrice As Decimal = Convert.ToDecimal(txtSalePrice.Text)
            Dim inventory As Integer = Convert.ToInt32(txtInventory.Text)

            Dim bookDetails As Object() = {bookID, author, title, purchasePrice, salePrice, inventory}


            frmMainMenu.BookArray.Add(bookDetails)



            btnClear.PerformClick()
            lblNumberRecords.Text = lblNumberRecords.Text + 1
        End If


    End Sub

    Private Sub txtBookID_TextChanged(sender As Object, e As EventArgs) Handles txtBookID.TextChanged

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub
End Class