<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblNumberRecords = New System.Windows.Forms.Label()
        Me.txtSalePrice = New System.Windows.Forms.TextBox()
        Me.txtInventory = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblNumRecs = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(238, 259)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 23)
        Me.btnMoveLast.TabIndex = 11
        Me.btnMoveLast.Text = ">>"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(174, 259)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(30, 23)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(142, 259)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 23)
        Me.btnMoveFirst.TabIndex = 8
        Me.btnMoveFirst.Text = "<<"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(44, 148)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 60
        Me.lblTitle.Text = "Title:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(44, 125)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(41, 13)
        Me.lblAuthor.TabIndex = 59
        Me.lblAuthor.Text = "Author:"
        '
        'lblNumberRecords
        '
        Me.lblNumberRecords.AutoSize = True
        Me.lblNumberRecords.Location = New System.Drawing.Point(223, 73)
        Me.lblNumberRecords.Name = "lblNumberRecords"
        Me.lblNumberRecords.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberRecords.TabIndex = 58
        Me.lblNumberRecords.Text = "0"
        '
        'txtSalePrice
        '
        Me.txtSalePrice.Location = New System.Drawing.Point(132, 189)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(93, 20)
        Me.txtSalePrice.TabIndex = 5
        '
        'txtInventory
        '
        Me.txtInventory.Location = New System.Drawing.Point(177, 212)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Size = New System.Drawing.Size(48, 20)
        Me.txtInventory.TabIndex = 6
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(132, 166)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(93, 20)
        Me.txtPurchasePrice.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(95, 143)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(130, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(95, 120)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(130, 20)
        Me.txtAuthor.TabIndex = 2
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(44, 171)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(82, 13)
        Me.lblPurchasePrice.TabIndex = 52
        Me.lblPurchasePrice.Text = "Purchase Price:"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.AutoSize = True
        Me.lblSalePrice.Location = New System.Drawing.Point(44, 193)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(58, 13)
        Me.lblSalePrice.TabIndex = 51
        Me.lblSalePrice.Text = "Sale Price:"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Location = New System.Drawing.Point(44, 217)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(133, 13)
        Me.lblInventory.TabIndex = 50
        Me.lblInventory.Text = "Number of Items on Stock:"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(44, 102)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(35, 13)
        Me.lblISBN.TabIndex = 49
        Me.lblISBN.Text = "ISBN:"
        '
        'lblNumRecs
        '
        Me.lblNumRecs.AutoSize = True
        Me.lblNumRecs.Location = New System.Drawing.Point(44, 73)
        Me.lblNumRecs.Name = "lblNumRecs"
        Me.lblNumRecs.Size = New System.Drawing.Size(177, 13)
        Me.lblNumRecs.TabIndex = 48
        Me.lblNumRecs.Text = "Number of Records in the Database"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(95, 97)
        Me.txtBookID.MaxLength = 1
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(130, 20)
        Me.txtBookID.TabIndex = 47
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(104, 288)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(206, 259)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 23)
        Me.btnMoveNext.TabIndex = 10
        Me.btnMoveNext.Text = ">"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(7, 259)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(129, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete from Database"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(24, 24)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(237, 33)
        Me.lblLogo.TabIndex = 43
        Me.lblLogo.Text = "Alantric Books"
        '
        'frmDeleteBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 322)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblNumberRecords)
        Me.Controls.Add(Me.txtSalePrice)
        Me.Controls.Add(Me.txtInventory)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblPurchasePrice)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.lblInventory)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblNumRecs)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblLogo)
        Me.Name = "frmDeleteBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alantric Books-Delete Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblNumberRecords As System.Windows.Forms.Label
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtInventory As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents lblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents lblSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents lblNumRecs As System.Windows.Forms.Label
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblLogo As System.Windows.Forms.Label
End Class
