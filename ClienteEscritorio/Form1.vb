Public Class Form1
    'Objeto para acceder al servicio'
    Dim Servicio As New ServiceReference1.WebService3SoapClient
    Public Sub Listar() Handles MyClass.Load
        gvAlumno.DataSource = Servicio.ListarAlumno().Tables(0)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodAlumno.Text = ""
        txtApellidos.Text = ""
        txtNombres.Text = ""
        txtLugNac.Text = ""
        dtpFecNac.Value = Now.ToLongDateString
        txtCodEscuela.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Servicio.EliminarAlumno(txtCodAlumno.Text)
        Listar()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Servicio.AgregarAlumno(txtCodAlumno.Text, txtApellidos.Text, txtNombres.Text, txtLugNac.Text, dtpFecNac.Value, txtCodEscuela.Text)
        Listar()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        gvAlumno.DataSource = Servicio.BuscarAlumno(txtBuscar.Text, cbBuscar.Text).Tables(0)
        txtCodAlumno.Text = gvAlumno.Rows(0).Cells(0).Value
        txtApellidos.Text = gvAlumno.Rows(0).Cells(1).Value
        txtNombres.Text = gvAlumno.Rows(0).Cells(2).Value
        txtLugNac.Text = gvAlumno.Rows(0).Cells(3).Value
        dtpFecNac.Value = gvAlumno.Rows(0).Cells(4).Value
        txtCodEscuela.Text = gvAlumno.Rows(0).Cells(5).Value
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Servicio.ActualizarAlumno(txtCodAlumno.Text, txtApellidos.Text, txtNombres.Text, txtLugNac.Text, dtpFecNac.Value, txtCodEscuela.Text)
        Listar()
    End Sub
End Class

