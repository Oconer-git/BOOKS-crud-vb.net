<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnAddBooks = New System.Windows.Forms.Button()
        Me.btnDeleteBooks = New System.Windows.Forms.Button()
        Me.btnUpdateBooks = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddBooks
        '
        Me.btnAddBooks.Location = New System.Drawing.Point(10, 160)
        Me.btnAddBooks.Name = "btnAddBooks"
        Me.btnAddBooks.Size = New System.Drawing.Size(86, 23)
        Me.btnAddBooks.TabIndex = 0
        Me.btnAddBooks.Text = "Add Books"
        Me.btnAddBooks.UseVisualStyleBackColor = True
        '
        'btnDeleteBooks
        '
        Me.btnDeleteBooks.Location = New System.Drawing.Point(194, 160)
        Me.btnDeleteBooks.Name = "btnDeleteBooks"
        Me.btnDeleteBooks.Size = New System.Drawing.Size(86, 23)
        Me.btnDeleteBooks.TabIndex = 1
        Me.btnDeleteBooks.Text = "Delete Books"
        Me.btnDeleteBooks.UseVisualStyleBackColor = True
        '
        'btnUpdateBooks
        '
        Me.btnUpdateBooks.Location = New System.Drawing.Point(102, 160)
        Me.btnUpdateBooks.Name = "btnUpdateBooks"
        Me.btnUpdateBooks.Size = New System.Drawing.Size(86, 23)
        Me.btnUpdateBooks.TabIndex = 2
        Me.btnUpdateBooks.Text = "Update Books"
        Me.btnUpdateBooks.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(24, 24)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(237, 33)
        Me.lblLogo.TabIndex = 3
        Me.lblLogo.Text = "Alantric Books"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(102, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.btnUpdateBooks)
        Me.Controls.Add(Me.btnDeleteBooks)
        Me.Controls.Add(Me.btnAddBooks)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alantric Books-Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddBooks As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBooks As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBooks As System.Windows.Forms.Button
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
