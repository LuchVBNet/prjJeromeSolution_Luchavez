<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.txtItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblItem = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSubtotal = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSubtotal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnCalculate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblTax = New MaterialSkin.Controls.MaterialLabel()
        Me.txtTax = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblShipping = New MaterialSkin.Controls.MaterialLabel()
        Me.txtShipping = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblTotal = New MaterialSkin.Controls.MaterialLabel()
        Me.txtTotal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnClear = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnExit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Depth = 0
        Me.txtItem.Hint = ""
        Me.txtItem.Location = New System.Drawing.Point(144, 93)
        Me.txtItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItem.Name = "txtItem"
        Me.txtItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItem.SelectedText = ""
        Me.txtItem.SelectionLength = 0
        Me.txtItem.SelectionStart = 0
        Me.txtItem.Size = New System.Drawing.Size(200, 23)
        Me.txtItem.TabIndex = 0
        Me.txtItem.UseSystemPasswordChar = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Depth = 0
        Me.lblItem.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItem.Location = New System.Drawing.Point(57, 97)
        Me.lblItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(77, 19)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Item Price"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Depth = 0
        Me.lblSubtotal.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSubtotal.Location = New System.Drawing.Point(57, 222)
        Me.lblSubtotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(65, 19)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Depth = 0
        Me.txtSubtotal.Hint = ""
        Me.txtSubtotal.Location = New System.Drawing.Point(144, 218)
        Me.txtSubtotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.SelectionLength = 0
        Me.txtSubtotal.SelectionStart = 0
        Me.txtSubtotal.Size = New System.Drawing.Size(200, 23)
        Me.txtSubtotal.TabIndex = 2
        Me.txtSubtotal.UseSystemPasswordChar = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Depth = 0
        Me.btnCalculate.Location = New System.Drawing.Point(253, 136)
        Me.btnCalculate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Primary = True
        Me.btnCalculate.Size = New System.Drawing.Size(91, 36)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Depth = 0
        Me.lblTax.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(57, 251)
        Me.lblTax.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(74, 19)
        Me.lblTax.TabIndex = 6
        Me.lblTax.Text = "Sales Tax"
        '
        'txtTax
        '
        Me.txtTax.Depth = 0
        Me.txtTax.Hint = ""
        Me.txtTax.Location = New System.Drawing.Point(144, 247)
        Me.txtTax.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTax.Name = "txtTax"
        Me.txtTax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTax.SelectedText = ""
        Me.txtTax.SelectionLength = 0
        Me.txtTax.SelectionStart = 0
        Me.txtTax.Size = New System.Drawing.Size(200, 23)
        Me.txtTax.TabIndex = 5
        Me.txtTax.UseSystemPasswordChar = False
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Depth = 0
        Me.lblShipping.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblShipping.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblShipping.Location = New System.Drawing.Point(57, 280)
        Me.lblShipping.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(66, 19)
        Me.lblShipping.TabIndex = 8
        Me.lblShipping.Text = "Shipping"
        '
        'txtShipping
        '
        Me.txtShipping.Depth = 0
        Me.txtShipping.Hint = ""
        Me.txtShipping.Location = New System.Drawing.Point(144, 276)
        Me.txtShipping.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShipping.SelectedText = ""
        Me.txtShipping.SelectionLength = 0
        Me.txtShipping.SelectionStart = 0
        Me.txtShipping.Size = New System.Drawing.Size(200, 23)
        Me.txtShipping.TabIndex = 7
        Me.txtShipping.UseSystemPasswordChar = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Depth = 0
        Me.lblTotal.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(57, 309)
        Me.lblTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(72, 19)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total due"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotal
        '
        Me.txtTotal.Depth = 0
        Me.txtTotal.Hint = ""
        Me.txtTotal.Location = New System.Drawing.Point(144, 305)
        Me.txtTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.Size = New System.Drawing.Size(200, 23)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.UseSystemPasswordChar = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClear.Depth = 0
        Me.btnClear.Location = New System.Drawing.Point(241, 346)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Primary = False
        Me.btnClear.Size = New System.Drawing.Size(54, 36)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Depth = 0
        Me.btnExit.Location = New System.Drawing.Point(303, 346)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Primary = False
        Me.btnExit.Size = New System.Drawing.Size(41, 36)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.txtShipping)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtItem)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frmMain"
        Me.Text = "Jerome's Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblItem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSubtotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSubtotal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnCalculate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblTax As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtTax As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblShipping As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtShipping As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblTotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtTotal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnClear As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialFlatButton
End Class
