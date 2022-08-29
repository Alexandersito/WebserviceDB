using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        // Acceder al servicio web
        private static ServiceReference2.WebService3SoapClient servicio = new ServiceReference2.WebService3SoapClient();
        
        //===========================================
        //               TABLA ALUMNO
        //===========================================

        //Listar registros
        private void Listar()
        {
            gvEscuela.DataSource = servicio.ListarAlumno().Tables[0];
            gvEscuela.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        //Agregar un registro
        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            servicio.AgregarAlumno(txtCodAlumno.Text, txtApellidos.Text, txtNombres.Text, txtLugarNac.Text, Convert.ToDateTime(txtFechaNac.Text), txtCodEscuela.Text);
            Listar();
        }

        //Actualizar un registro
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            servicio.ActualizarAlumno(txtCodAlumno.Text, txtApellidos.Text, txtNombres.Text, txtLugarNac.Text, Convert.ToDateTime(txtFechaNac.Text), txtCodEscuela.Text);
            Listar();
        }

        //Eliminar un registro
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            servicio.EliminarAlumno(txtCodAlumno.Text);
            Listar();
        }

        //Buscar un registro
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = Buscar.Text.Trim();
            string criterio = Busqueda.SelectedItem.Text;
            gvEscuela.DataSource = servicio.BuscarAlumno(texto, criterio);
            gvEscuela.DataBind();
            txtCodAlumno.Text = gvEscuela.Rows[0].Cells[0].Text.ToString();
            txtApellidos.Text = (gvEscuela.Rows[0].Cells[1].Text).ToString();
            txtNombres.Text = gvEscuela.Rows[0].Cells[2].Text.ToString();
            txtLugarNac.Text = gvEscuela.Rows[0].Cells[3].Text.ToString();
            txtFechaNac.Text = gvEscuela.Rows[0].Cells[4].Text.ToString();
            txtCodEscuela.Text = gvEscuela.Rows[0].Cells[5].Text.ToString();

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodAlumno.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtLugarNac.Text = "";
            txtFechaNac.Text = "";
            txtCodEscuela.Text = "";
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}