Public Class Form1
    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function


    Private Sub btnAmenos_Click(sender As Object, e As EventArgs) Handles btnAmenos.Click
        lbA.Text = Restar(lbA.Text)
    End Sub

    Private Sub btnAmas_Click(sender As Object, e As EventArgs) Handles btnAmas.Click
        lbA.Text = Aumentar(lbA.Text)
    End Sub

    Private Sub btnBmenos_Click(sender As Object, e As EventArgs) Handles btnBmenos.Click
        lbB.Text = Restar(lbB.Text)
    End Sub

    Private Sub btnBmas_Click(sender As Object, e As EventArgs) Handles btnBmas.Click
        lbB.Text = Aumentar(lbB.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)
        'MsgBox(resultadoSuma)
        lbResultado.Text = "El resultado de A + B es " + resultadoSuma.ToString()
    End Sub

    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        'MsgBox(resultadoResta)
        lbResultado.Text = "El resultado de A - B es " + resultadoResta.ToString()
    End Sub
    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMultiplicacion = Multiplicacion(numA, numB)
        'MsgBox(resultadoMultiplicacion)
        lbResultado.Text = "El resultado de A * B es " + resultadoMultiplicacion.ToString()
    End Sub
    Function Multiplicacion(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoDivision = Division(numA, numB)
        'MsgBox(resultadoDivision)
        lbResultado.Text = "El resultado de A / B es " + resultadoDivision.ToString()
    End Sub
    Function Division(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA / numB
        Return resultado
    End Function
End Class
