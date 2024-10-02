Public Class Form1
    Public equipo As Aire
    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        Dim marca As String = TxtMarca.Text
        Dim frigorias As Integer = Integer.Parse(TxtFrigorias.Text)
        Dim split As Boolean = ChkSplit.Checked
        Dim pais As String = TxtPais.Text
        Dim frioSolo As Boolean = RbFrioSolo.Checked

        equipo = New Aire(marca, frigorias, split, pais, frioSolo)
        TxtModelo.Text = equipo.Modelo
        TxtTemperatura.Text = equipo.ObtenerTemperatura().ToString()
    End Sub

    Private Sub BtnPower_Click(sender As Object, e As EventArgs) Handles BtnPower.Click
        If equipo IsNot Nothing Then
            equipo.Power()
            If equipo.EstadoEncendido() Then
                LblEstado.Text = "On"
            Else
                LblEstado.Text = ""
            End If
        End If
    End Sub
    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        If equipo IsNot Nothing AndAlso equipo.EstadoEncendido() Then
            equipo.Bajar()
            TxtTemperatura.Text = equipo.ObtenerTemperatura().ToString()
        End If
    End Sub


    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir.Click
        If equipo IsNot Nothing AndAlso equipo.EstadoEncendido() Then
            equipo.Bajar(1)
            TxtTemperatura.Text = equipo.ObtenerTemperatura().ToString()
        End If
    End Sub

    Private Sub BtnBajar_Click(sender As Object, e As EventArgs) Handles BtnBajar.Click
        If equipo IsNot Nothing AndAlso equipo.EstadoEncendido() Then
            equipo.Bajar(1)
            TxtTemperatura.Text = equipo.ObtenerTemperatura().ToString()
        End If
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        If equipo IsNot Nothing AndAlso equipo.EstadoEncendido() Then
            equipo.Subir()
            TxtTemperatura.Text = equipo.ObtenerTemperatura().ToString()
        End If
    End Sub
End Class
