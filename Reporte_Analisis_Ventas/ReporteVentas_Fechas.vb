Public Class ReporteVentas_Fechas
    Public fechainicial As Date
    Public fechafinal As Date
    Private Sub ReporteVentas_Fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objReporte As New Reporte_Ventas
        objReporte.SetParameterValue("@fecha_Inicial", fechainicial)
        objReporte.SetParameterValue("@fecha_Final", fechafinal)

        CrystalReportViewer1.ReportSource = objReporte


    End Sub
End Class