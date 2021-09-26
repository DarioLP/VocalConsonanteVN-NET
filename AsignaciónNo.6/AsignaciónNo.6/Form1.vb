Public Class Form1
    Public inop1, inop2, cadena1, valCVocal1, ValCcons, voc, con As String
    Dim cadena2(0 To 100) As String
    Dim x, f As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        inop2 = ""
        voc = ""
        x = 0
        f = 0
        Do While x <> -1
            cadena2(f) = ""
            inop2 = InputBox("Introducir texto")

            If inop2 = "a" Or inop2 = "e" Or inop2 = "i" Or inop2 = "o" Or inop2 = "u" Then
                x = -1
            Else
                cadena2(f) = inop2
                x = x + 1
                f = f + 1
            End If

        Loop

        x = 0
        For x = 0 To f

            con = con + cadena2(x)

        Next


        MessageBox.Show("cadena: " + con, "opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
