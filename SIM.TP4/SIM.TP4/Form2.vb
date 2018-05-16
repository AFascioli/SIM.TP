Public Class Form2
' Vende a $1 cada rosa
' Compra a $8 la docena
' Rosas no vendidas, se venden a $0.10 c/u

Public Function diaSoleado(rnd As Double) 'Toma un random y devuelte la demanda para un dia soleado
        Dim demanda As Integer
        Select Case rnd
        Case 0 To 0.1
            demanda = 6
        Case 0.1 To 0.3
            demanda = 7
        Case 0.3 To 0.75
            demanda = 8
        Case 0.75 To 1
            demanda = 9
        Case Else
            demanda = 0
    End Select
    return demanda
End Function

Public Function diaNublado(rnd as Double) 'Toma un random y devuelve la demanda para un dia nublado
    dim demanda as integer
    Select Case rnd 
        Case 0 To 0.05
        demanda = 3
        Case 0.05 to 0.2
        demanda = 4
        Case 0.2 to 0.6
        demanda = 5
        Case 0.6 to 0.85
        demanda = 6
        Case 0.85 to 0.99
        demanda = 7
        Case Else
                demanda = 0
        End Select
    return demanda
End Function

Public Function climaDia(rnd as Double)
    Dim clima as String ="Soleado"

        If rnd > 0.75 And rnd < 1 Then
            clima = "Nublado"
        End If
        Return clima
End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class