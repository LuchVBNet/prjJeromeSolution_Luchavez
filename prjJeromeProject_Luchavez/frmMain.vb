Imports MaterialSkin

Public Class frmMain
    Private decItem, decSubtotal, decTax, decShipping, decTotal As Decimal
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.CurrentCulture = New Globalization.CultureInfo("en-US")
        '
        'Initialize SkinManager
        '
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.DARK
        skinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue700, Primary.LightBlue900, Accent.LightBlue200, TextShade.WHITE)
        'Format Inputs and Outputs
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Get Inputs
        GetInputs()
        'Computation
        decSubtotal += decItem
        decTax = decSubtotal * 0.05D
        decShipping = If(decSubtotal < 100, 6.5D, 0)
        decTotal = decSubtotal + decTax + decShipping
        'Display
        FormatOutputs()
        'Reset Item
        decItem = 0
        FormatInputs()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decItem = 0
        FormatInputs()
        decSubtotal = 0
        decTax = 0
        decShipping = 0
        decTotal = 0
        FormatOutputs()
    End Sub

    Private Sub validate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem.KeyPress
        Dim t As TextBox = CType(sender, TextBox)
        'Check first if Enter button
        If e.KeyChar = ChrW(Keys.Enter) And t.TextLength <> 0 Then
            btnCalculate.PerformClick()
        Else
            'Then check for other stuff
            If Not (Char.IsDigit(e.KeyChar)) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
                'to be rejected
                e.Handled = True
            Else
                'to be accepted
                e.Handled = If(e.KeyChar = "." AndAlso t.Text.Contains("."), True, False)
            End If
        End If
    End Sub

    Private Sub txtItem_Enter(sender As Object, e As EventArgs) Handles txtItem.Enter, txtItem.Click
        Dim t As TextBox = CType(sender, TextBox)
        t.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub reject_Keypress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress, txtTax.KeyPress, txtSubtotal.KeyPress, txtShipping.KeyPress
        e.Handled = True
    End Sub

    Private Sub GetInputs()
        decItem = ProcessInput(txtItem.Text)
    End Sub

    Private Function ProcessInput(s As String) As Decimal
        Try
            ProcessInput = Decimal.Parse(s, Globalization.NumberStyles.Currency)
        Catch ex As Exception
            ProcessInput = 0
        End Try
    End Function

    Private Sub FormatInputs()
        txtItem.Text = decItem.ToString("C2")
    End Sub

    Private Sub FormatOutputs()
        txtSubtotal.Text = decSubtotal.ToString("C2")
        txtTax.Text = decTax.ToString("C2")
        txtShipping.Text = decShipping.ToString("C2")
        txtTotal.Text = decTotal.ToString("C2")
    End Sub
End Class
