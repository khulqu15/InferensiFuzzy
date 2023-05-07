Public Class Form1

    Function Segitiga(u As Single, a As Single, b As Single, c As Single) As Single
        If (u < a) Then
            Segitiga = 0
        ElseIf ((u >= a) And (u < b)) Then
            Segitiga = ((u - a) / (b - a))
        ElseIf ((u >= b) And (u < c)) Then
            Segitiga = ((c - u) / (c - b))
        Else
            Segitiga = 0
        End If
    End Function

    Function Minimal(inp1 As Single, inp2 As Single) As Single
        If inp1 > inp2 Then
            Minimal = inp2
        Else
            Minimal = inp1
        End If
    End Function

    Function TrapMin(u1 As Single, a1 As Single, b1 As Single) As Single
        If u1 < a1 Then
            TrapMin = 1
        ElseIf ((u1 > a1) And (u1 < b1)) Then
            TrapMin = ((b1 - u1) / (b1 - a1))
        ElseIf u1 > b1 Then
            TrapMin = 0
        Else
            TrapMin = 0
        End If
    End Function

    Function TrapPlus(u2 As Single, a2 As Single, b2 As Single) As Single
        If u2 < a2 Then
            TrapPlus = 0
        ElseIf ((u2 >= a2) And (u2 <= b2)) Then
            TrapPlus = ((u2 - a2) / (b2 - a2))
        ElseIf u2 > b2 Then
            TrapPlus = 1
        Else
            TrapPlus = 1
        End If
    End Function

    Private Sub HitungButton_Click(sender As Object, e As EventArgs) Handles HitungButton.Click
        Dim Kecepatan, SangatLambat, AgakLambat, Lambat, Cukup, AgakCepat, Cepat, SangatCepat As Single
        Dim Jarak, SangatDekat, AgakDekat, Sedang, AgakJauh, SangatJauh As Single
        Dim temp, tempf, SudutRem, Penuh, AgakPenuh, InjakSedang, Sedikit, SedikitSekali As Single
        Dim mi(25), rulef(25) As Single

        Kecepatan = Val(InputKecepatan.Text)
        SangatLambat = TrapMin(Kecepatan, 0, 10)
        Lambat = Segitiga(Kecepatan, 0, 20, 40)
        AgakLambat = Segitiga(Kecepatan, 0, 20, 40)
        Cukup = Segitiga(Kecepatan, 20, 40, 60)
        AgakCepat = Segitiga(Kecepatan, 20, 40, 60)
        Cepat = Segitiga(Kecepatan, 40, 60, 80)
        SangatCepat = TrapPlus(Kecepatan, 80, 100)

        SLambatInput.Text = SangatLambat
        LambatInput.Text = Lambat
        CukupInput.Text = Cukup
        CepatInput.Text = Cepat
        SCepatInput.Text = SangatCepat

        Jarak = Val(InputJarak.Text)
        SangatDekat = Segitiga(Jarak, -1, 0, 1)
        AgakDekat = Segitiga(Jarak, 0, 1, 2)
        Sedang = Segitiga(Jarak, 1, 2, 3)
        AgakJauh = Segitiga(Jarak, 2, 3, 4)
        SangatJauh = Segitiga(Jarak, 3, 4, 5)

        SDekatInput.Text = SangatDekat
        ADekatInput.Text = AgakDekat
        SedangInput.Text = Sedang
        AJauhInput.Text = AgakJauh
        SJauhInput.Text = SangatJauh

        Penuh = 0
        AgakPenuh = 10
        InjakSedang = 20
        Sedikit = 30
        SedikitSekali = 40

        AturanFuzzyListBox.Items.Clear()

        mi(1) = Minimal(SangatLambat, SangatDekat)
        mi(2) = Minimal(SangatLambat, AgakDekat)
        mi(3) = Minimal(SangatLambat, Sedang)
        mi(4) = Minimal(SangatLambat, AgakJauh)
        mi(5) = Minimal(SangatLambat, SangatJauh)
        mi(6) = Minimal(Lambat, SangatDekat)
        mi(7) = Minimal(Lambat, AgakDekat)
        mi(8) = Minimal(Lambat, Sedang)
        mi(9) = Minimal(Lambat, AgakJauh)
        mi(10) = Minimal(Lambat, SangatJauh)
        mi(11) = Minimal(Cukup, SangatDekat)
        mi(12) = Minimal(Cukup, AgakDekat)
        mi(13) = Minimal(Cukup, Sedang)
        mi(14) = Minimal(Cukup, AgakJauh)
        mi(15) = Minimal(Cukup, SangatJauh)
        mi(16) = Minimal(Cepat, SangatDekat)
        mi(17) = Minimal(Cepat, AgakDekat)
        mi(18) = Minimal(Cepat, Sedang)
        mi(19) = Minimal(Cepat, AgakJauh)
        mi(20) = Minimal(Cepat, SangatJauh)
        mi(21) = Minimal(SangatCepat, SangatDekat)
        mi(22) = Minimal(SangatCepat, AgakDekat)
        mi(23) = Minimal(SangatCepat, Sedang)
        mi(24) = Minimal(SangatCepat, AgakJauh)
        mi(25) = Minimal(SangatCepat, SangatJauh)

        rulef(1) = Minimal(SangatLambat, SangatDekat) * Sedikit
        rulef(2) = Minimal(SangatLambat, AgakDekat) * Sedikit
        rulef(3) = Minimal(SangatLambat, Sedang) * SedikitSekali
        rulef(4) = Minimal(SangatLambat, AgakJauh) * SedikitSekali
        rulef(5) = Minimal(SangatLambat, SangatJauh) * SedikitSekali
        rulef(6) = Minimal(Lambat, SangatDekat) * InjakSedang
        rulef(7) = Minimal(Lambat, AgakDekat) * InjakSedang
        rulef(8) = Minimal(Lambat, Sedang) * Sedikit
        rulef(9) = Minimal(Lambat, AgakJauh) * SedikitSekali
        rulef(10) = Minimal(Lambat, SangatJauh) * SedikitSekali
        rulef(11) = Minimal(AgakLambat, SangatDekat) * InjakSedang
        rulef(12) = Minimal(AgakLambat, AgakDekat) * Sedikit
        rulef(13) = Minimal(AgakLambat, Sedang) * SedikitSekali
        rulef(14) = Minimal(AgakLambat, AgakJauh) * SedikitSekali
        rulef(15) = Minimal(AgakLambat, SangatJauh) * SedikitSekali
        rulef(16) = Minimal(Cukup, SangatDekat) * AgakPenuh
        rulef(17) = Minimal(Cukup, AgakDekat) * InjakSedang
        rulef(18) = Minimal(Cukup, Sedang) * Sedikit
        rulef(19) = Minimal(Cukup, AgakJauh) * SedikitSekali
        rulef(20) = Minimal(Cukup, SangatJauh) * SedikitSekali
        rulef(21) = Minimal(Cepat, SangatDekat) * Penuh
        rulef(22) = Minimal(Cepat, AgakDekat) * AgakPenuh
        rulef(23) = Minimal(Cepat, Sedang) * InjakSedang
        rulef(24) = Minimal(Cepat, AgakJauh) * Sedikit
        rulef(25) = Minimal(Cepat, SangatJauh) * SedikitSekali

        For i = 1 To 25
            temp = temp + mi(i)
            tempf = tempf + rulef(i)
            If mi(i) > 0 Then
                AturanFuzzyListBox.Items.Add("Rule" + CStr(i) + " = " + CStr(rulef(i)))
            End If
        Next i
        If temp <> 0 Then
            SudutRem = tempf / temp
        Else
            SudutPengeramanInput.Text = "Tidak ada hasil"
        End If
        SudutPengeramanInput.Text = SudutRem
    End Sub
End Class
