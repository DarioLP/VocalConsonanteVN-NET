Public Class Form1
    Public inop1, cadena1, valCVocal1, ValCcons, voc, con As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        inop1 = ""
        voc = ""


        inop1 = InputBox("Introducir texto")

        For x = 1 To inop1.Length

            'LCase es está utilizando para detectar las letras tanto mayusculas como minúsculas
            'Mid es una forma de espesificar la posicion de un caracter de una cadena
            cadena1 = LCase(Mid(inop1, x, 1))

            If cadena1 = "a" Or cadena1 = "e" Or cadena1 = "i" Or cadena1 = "o" Or cadena1 = "u" Then
                voc = voc + cadena1
            End If

        Next

        MessageBox.Show("letras de vocales: " + voc, "opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Dim CVocal, Ccons As Integer



    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        inop1 = ""
        CVocal = 0
        Ccons = 0
        voc = ""
        con = ""

        inop1 = InputBox("Introducir texto")

        For x = 1 To inop1.Length

            cadena1 = LCase(Mid(inop1, x, 1))

            If cadena1 = "a" Or cadena1 = "e" Or cadena1 = "i" Or cadena1 = "o" Or cadena1 = "u" Then

                CVocal = CVocal + 1
                voc = voc + cadena1

            Else
                Ccons = Ccons + 1
                con = con + cadena1
            End If

        Next
        valCVocal1 = Convert.ToString(CVocal)
        valCcons = Convert.ToString(Ccons)
        MessageBox.Show(inop1 + vbNewLine & "Cantidad de Vocales: " + valCVocal1 + " | " + voc + vbNewLine & "Cantidad de Consonantes: " + ValCcons + " | " + con, "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub




End Class
