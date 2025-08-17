Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCelcius.Click

    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = (9 / 5) * celcius + 32
        reamur = (4 / 5) * celcius
        kelvin = celcius + 273

        'ini kalau tampilin pake MsgBox
        'MsgBox("Fahrenheit = " & fahrenheit & vbCrLf & "Reamur = " & reamur & vbCrLf & "Kelvin = " & kelvin)

        'ini kalau tampilin pake label
        'lblFahrenheit.Text = CStr(fahrenheit)
        'lblReamur.Text = CStr(reamur)
        'lblKelvin.Text = CStr(kelvin)

        txtFahrenheit.Text = CStr(fahrenheit)
        txtReamur.Text = CStr(reamur)
        txtKelvin.Text = CStr(kelvin)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtReamur.TextChanged

    End Sub

    Private Sub txtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged

    End Sub
End Class
