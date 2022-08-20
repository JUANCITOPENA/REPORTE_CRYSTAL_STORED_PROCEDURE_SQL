Public Class Form1
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim fechainicio As Date = CDate(dtpFecha_inicial.Value.ToString())
        Dim fechafinal As Date = CDate(dtpFecha_final.Value.ToString())

        Dim ReporteVentas_fechas As New ReporteVentas_Fechas

        ReporteVentas_fechas.fechainicial = fechainicio
        ReporteVentas_fechas.fechafinal = fechafinal

        ReporteVentas_fechas.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()


    End Sub
End Class
