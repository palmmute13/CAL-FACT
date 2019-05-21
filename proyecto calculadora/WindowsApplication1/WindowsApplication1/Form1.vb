Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        If TbxDCosto.Text = "" Then
            TbxDCosto.Text = 0
        End If

        Dim totalItebis As Double

        Dim Transporte As Double
        Dim itebis As Double
        Dim itebisDos As Double
        Dim costo As Double

        Dim Porciento As Double

        Porciento = 0

        Dim salidaTotal As Double
        Dim TotalTransporte As Double

        itebis = 1.18
        costo = TbxDCosto.Text
        itebisDos = 0.18



        If RbDiez.Checked = True Then
            Porciento = 1.1

        End If

        If RbVente.Checked = True Then
            Porciento = 1.2

        End If

        If RbTrenta.Checked = True Then
            Porciento = 1.3


        End If

        If RbCuarenta.Checked = True Then
            Porciento = 1.4

        End If

        If RbCincuenta.Checked = True Then
            Porciento = 1.5


        End If





        If ChbTransporte.Checked = True Then
            Transporte = 0.07

        End If







        totalItebis = costo / itebis
        LblItebis.Text = totalItebis







        TotalTransporte = costo * Transporte
        salidaTotal = totalItebis * Porciento + TotalTransporte
        'TbxDCosto.Focus()


        MsgBox(TotalTransporte)
        MsgBox(Porciento)
        MsgBox(salidaTotal)
        LblFerreteria.Text = salidaTotal

    End Sub



    'Private Sub TbxDCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbxDCosto.KeyDown

    '    If e.KeyCode = Keys.Enter Then
    '        BtnCalcular.PerformClick()

    '    End If
    '    If e.KeyCode = Keys.Delete Then
    '        TbxDCosto.Text = ""
    '        BtnCalcular.PerformClick()

    '    End If









    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class
