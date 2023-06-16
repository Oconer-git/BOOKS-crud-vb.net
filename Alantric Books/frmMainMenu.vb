Public Class frmMainMenu
    Public Shared BookArray As New List(Of Object())

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBooks.Click
        Me.Hide()
        Dim frmAddBooksGUI = New frmAddBooks()
        frmAddBooksGUI.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnUpdateBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBooks.Click
        Me.Hide()
        Dim frmUpdateBooksGUI = New frmUpdateBooks()
        frmUpdateBooksGui.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnDeleteBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBooks.Click
        Me.Hide()
        Dim frmDeleteBooksGUI = New frmDeleteBooks()
        frmDeleteBooksGUI.ShowDialog()
        Me.Show()
    End Sub
End Class
