Public Class Form1
    Public inop1, cadena1, valCVocal1, voc As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        voc = ""
        inop1 = InputBox("Introducir texto")

        For x = 1 To inop1.Length
            cadena1 = Mid(inop1, x, 1)

            If cadena1 = "a" Or cadena1 = "e" Or cadena1 = "i" Or cadena1 = "o" Or cadena1 = "u" Then
                voc = voc + cadena1
            End If

        Next

        MessageBox.Show("Letras de vocales: " + voc, "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Dim CVocal As Integer



    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        CVocal = 0
        inop1 = InputBox("Introducir texto")

        For x = 1 To inop1.Length
            cadena1 = Mid(inop1, x, 1)

            If cadena1 = "a" Or cadena1 = "e" Or cadena1 = "i" Or cadena1 = "o" Or cadena1 = "u" Then
                CVocal = CVocal + 1
            End If

        Next
        valCvocal1 = Convert.ToString(CVocal)
        MessageBox.Show("cantidad de vocales: " + valCVocal1, "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub




End Class
