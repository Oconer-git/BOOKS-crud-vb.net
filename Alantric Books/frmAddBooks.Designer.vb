<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBooks
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
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblNumRecs = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtInventory = New System.Windows.Forms.TextBox()
        Me.txtSalePrice = New System.Windows.Forms.TextBox()
        Me.lblNumberRecords = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(24, 24)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(237, 33)
        Me.lblLogo.TabIndex = 4
        Me.lblLogo.Text = "Alantric Books"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(34, 259)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add to Database"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 259)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(104, 288)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(95, 97)
        Me.txtBookID.MaxLength = 13
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(130, 20)
        Me.txtBookID.TabIndex = 1
        '
        'lblNumRecs
        '
        Me.lblNumRecs.AutoSize = True
        Me.lblNumRecs.Location = New System.Drawing.Point(44, 73)
        Me.lblNumRecs.Name = "lblNumRecs"
        Me.lblNumRecs.Size = New System.Drawing.Size(177, 13)
        Me.lblNumRecs.TabIndex = 9
        Me.lblNumRecs.Text = "Number of Records in the Database"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(44, 102)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(35, 13)
        Me.lblISBN.TabIndex = 10
        Me.lblISBN.Text = "ISBN:"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Location = New System.Drawing.Point(44, 217)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(133, 13)
        Me.lblInventory.TabIndex = 11
        Me.lblInventory.Text = "Number of Items on Stock:"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.AutoSize = True
        Me.lblSalePrice.Location = New System.Drawing.Point(44, 193)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(58, 13)
        Me.lblSalePrice.TabIndex = 12
        Me.lblSalePrice.Text = "Sale Price:"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(44, 171)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(82, 13)
        Me.lblPurchasePrice.TabIndex = 13
        Me.lblPurchasePrice.Text = "Purchase Price:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(95, 120)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(130, 20)
        Me.txtAuthor.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(95, 143)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(130, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(132, 166)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(93, 20)
        Me.txtPurchasePrice.TabIndex = 4
        '
        'txtInventory
        '
        Me.txtInventory.Location = New System.Drawing.Point(177, 212)
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.Size = New System.Drawing.Size(48, 20)
        Me.txtInventory.TabIndex = 6
        '
        'txtSalePrice
        '
        Me.txtSalePrice.Location = New System.Drawing.Point(132, 189)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(93, 20)
        Me.txtSalePrice.TabIndex = 5
        '
        'lblNumberRecords
        '
        Me.lblNumberRecords.AutoSize = True
        Me.lblNumberRecords.Location = New System.Drawing.Point(223, 73)
        Me.lblNumberRecords.Name = "lblNumberRecords"
        Me.lblNumberRecords.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberRecords.TabIndex = 19
        Me.lblNumberRecords.Text = "0"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(44, 125)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(41, 13)
        Me.lblAuthor.TabIndex = 20
        Me.lblAuthor.Text = "Author:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(44, 148)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Title:"
        '
        'frmAddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 322)
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
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblLogo)
        Me.Name = "frmAddBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alantric Books-Add Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents lblNumRecs As System.Windows.Forms.Label
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtInventory As System.Windows.Forms.TextBox
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberRecords As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
