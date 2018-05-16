Public Class Form2
' Vende a $1 cada rosa
' Compra a $8 la docena
' Rosas no vendidas, se venden a $0.10 c/u

'Vectores anterior y actual
' experimento(1) |stock inicial(2)|rnd tiempo(3)    |soleado?(4)    |rnd demanda(5) |cant. demanda(6)  |
' cuanto vende(7)|reembolso(8)    |costo faltante(9)|sum ingreso(10)|sum costo(11)  | sum beneficio(12)|
    
    Dim anterior(15) As Double
    Dim actual(15) As Double
    
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
    ' 1 es soleado, 0 es nublado
    Dim clima as Integer = 1

        If rnd > 0.75 And rnd < 1 Then
            clima = 0
        End If
        Return clima
End Function

Public Sub cargarTabla()
    Dim clima= climaDia(Math.rnd())
    Dim demanda as Integer
    Dim stockInicial as Integer
    If clima=1 Then
        demanda= diaSoleado(Math.rnd())
    Else 
        demanda= diaNublado(Math.rnd())
    End If

    If cbx_demandaAnterior.checked() Then
        stockInicial=8
    else
     stockInicial=cmb_cantidadDemanda.SelectedItem()

    end if
    
End Sub
End Class