using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//Namespace para acceso a SQL Server
using System.Data.SqlClient; //SQL SERVER
using System.Data;           //Datos generales
using System.Configuration;  //Archivos de configuracion
namespace AccesoDatos
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //Acceder a la cadena de conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        //===========================================
        //               TABLA ESCUELA
        //===========================================

        //Listar tabla Escuela - (Inseguro)
        [WebMethod(Description = "Listar la tabla escuela")]
        public DataSet Listar()
        {
            string consulta = "select * from TEscuela";
            //Entorno desconectado para acceder a la tbla escuela
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        //Agregar registro a la tabla Escuela
        [WebMethod(Description ="Agregar un registro a la tabla Escuela")]
        public bool Agregar(string codEscuela,string escuela, string facultad)
        {
            try
            {
                string consulta = "insert into TEscuela values('" + codEscuela + "','" + escuela + "','" + facultad + "')";
                //Entorno conectado
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                //Ejecutar la consulta
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch(Exception)
            {
                conexion.Close();
                return false;
            }
        }

        //Actualizar registro a la tabla Escuela
        [WebMethod(Description = "Actualizar un registro de la tabla Escuela")]
        public bool Actualizar(string codEscuela, string escuela, string facultad)
        {
            try
            {
                string consulta = "UPDATE TEscuela SET Escuela = '"+escuela+"', Facultad = '"+facultad+"' WHERE CodEscuela = '"+codEscuela+"'";
                //Entorno conectado
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                //Ejecutar la consulta
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        //Eliminar registro de la tabla Escuela - (Mode - Sure)
        [WebMethod(Description = "Eliminar un registro a la tabla Escuela")]
        public bool Eliminar(string codEscuela)
        {
            try
            {
                string consulta = "delete from TEscuela where CodEscuela = @CodEscuela";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodEscuela", codEscuela);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        //===========================================
        //               TABLA ALUMNO
        //===========================================

        //Listar tabla Alumno - (PA)
        private static string cadena2 = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        [WebMethod(Description = "Listar con PA")]
        public DataSet ListarAlumno()
        {
            using (SqlConnection conexion = new SqlConnection(cadena2))
            {
                SqlCommand comando = new SqlCommand("spListarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        //Agregar registro a la tabla alumno - (PA)
        [WebMethod(Description = "Agregar con PA")]
        public string[] AgregarAlumno(string codAlumno, string apellidos, string nombres, string lugarNac, DateTime fechaNac,string codEscuela)
        {
            using (SqlConnection conexion = new SqlConnection(cadena2))
            {
                SqlCommand comando = new SqlCommand("spAgregarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodAlumno", codAlumno);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                comando.Parameters.AddWithValue("@Nombres", nombres);
                comando.Parameters.AddWithValue("@LugarNac", lugarNac);
                comando.Parameters.AddWithValue("@FechaNac", fechaNac);
                comando.Parameters.AddWithValue("@CodEscuela", codEscuela);
                string[] arreglo = new string[2]; // Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        //Eliminar registro a la tabla alumno - (PA)
        [WebMethod(Description = "Eliminar con PA")]
        public string[] EliminarAlumno(string codAlumno)
        {
            using (SqlConnection conexion = new SqlConnection(cadena2))
            {
                SqlCommand comando = new SqlCommand("spEliminarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodAlumno", codAlumno);
                string[] arreglo = new string[2]; // Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        //Actualizar registro a la tabla alumno - (PA)
        [WebMethod(Description = "Actualizar con PA")]
        public string[] ActualizarAlumno(string codAlumno, string apellidos, string nombres, string lugarNac, DateTime fechaNac, string codEscuela)
        {
            using (SqlConnection conexion = new SqlConnection(cadena2))
            {
                SqlCommand comando = new SqlCommand("spActualizarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodAlumno", codAlumno);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                comando.Parameters.AddWithValue("@Nombres", nombres);
                comando.Parameters.AddWithValue("@LugarNac", lugarNac);
                comando.Parameters.AddWithValue("@FechaNac", fechaNac);
                comando.Parameters.AddWithValue("@CodEscuela", codEscuela);
                string[] arreglo = new string[2]; // Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        //Buscar registro en la tabla alumno - (PA)
        [WebMethod(Description = "Buscar una alumna")]
        public DataSet BuscarAlumno(string codAlumno)
        {
            using (SqlConnection conexion = new SqlConnection(cadena2))
            {
                SqlCommand comando = new SqlCommand("spBuscarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodAlumno", codAlumno);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
    }
}
