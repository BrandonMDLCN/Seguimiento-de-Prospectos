using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Seguimiento_De_Prospectos
{
    public class D_Prospectos
    {
        public DataTable Listado_pro()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select Nombre, ApellidoP, ApellidoM, Estatus, Observaciones from Prospectos;";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable BuscarNombre_pro(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select Nombre, ApellidoP, ApellidoM, Estatus, Observaciones from Prospectos where Nombre like '%"+cTexto+"%';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable BuscarApellidoP_pro(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select Nombre, ApellidoP, ApellidoM, Estatus, Observaciones from Prospectos where ApellidoP like '%" + cTexto + "%';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable BuscarApellidoM_pro(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select Nombre, ApellidoP, ApellidoM, Estatus, Observaciones from Prospectos where ApellidoM like '%" + cTexto + "%';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string Guardar_pro(int nOpcion, P_Prospectos oPro)
        {
            string Rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                if (nOpcion ==1) //Guardar
                {
                    sqlTarea = "INSERT INTO Prospectos (Nombre, ApellidoP, ApellidoM, Calle, Numero, Colonia, " +
                        "CP, Telefono, RFC, Estatus) VALUES ('" + oPro.Nombre_pro + "', '" + oPro.ApellidoP_Pro + "', " +
                        "'" + oPro.ApellidoM_Pro + "', '" + oPro.Calle_Pro + "', " + oPro.Numero_Pro + ", '" + oPro.Colonia_Pro + "', " +
                        "" + oPro.Cp_Pro + ", '" + oPro.Telefono + "', '" + oPro.RFC_Pro + "', '" + oPro.Estatus_Pro + "');";
                }
                else //Acutalizar
                {
                    sqlTarea = "UPDATE Prospectos SET Estatus = '"+oPro.Estatus_Pro+"', Observaciones = '"+oPro.Observaciones_Pro+"' WHERE RFC = '"+oPro.RFC_Pro+"';";
                }
                MySqlCommand Comando= new MySqlCommand(sqlTarea, sqlCon);
                sqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "Ok" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }
        public DataTable editar(string Nombre, string ApellidoP, string ApellidoM, string Estatus)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select * from Prospectos where Nombre = '" + Nombre + "' AND ApellidoP = '"+ApellidoP+"' AND ApellidoM = '"+ApellidoM+"' AND Estatus = '"+Estatus+"';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable actualizarformeditar(string RFC)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select * from Prospectos where RFC = '" + RFC + "';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable eliminar(string Nombre, string ApellidoP, string ApellidoM, string Estatus)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "delete from Prospectos where Nombre = '" + Nombre + "' AND ApellidoP = '" + ApellidoP + "' AND ApellidoM = '" + ApellidoM + "' AND Estatus = '" + Estatus + "';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable consultarrfc(string Nombre, string ApellidoP, string ApellidoM, string Estatus)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select RFC from Prospectos where Nombre = '" + Nombre + "' AND ApellidoP = '" + ApellidoP + "' AND ApellidoM = '" + ApellidoM + "' AND Estatus = '" + Estatus + "';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable eliminarArchivorfc(string Nombre, string ApellidoP, string ApellidoM, string Estatus)
        {
            DataTable rfc = consultarrfc(Nombre, ApellidoP, ApellidoM, Estatus);
            string rfceliminar = rfc.Rows[0]["RFC"].ToString();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SET SQL_SAFE_UPDATES = 0; delete from Archivos where RFC = '" + rfceliminar + "';";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlCon);
                sqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string Guardar_Archivos(P_Prospectos oPro)
        {
            string Rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                //sqlTarea = "INSERT INTO Archivos (RFC, NombreArchivo, Archivo) VALUES ('" + oPro.RFC_Pro + "', '" + oPro.NombreArchivo_pro + "', '" + oPro.Archivo_pro + "');";
                sqlTarea = "INSERT INTO Archivos (RFC, NombreArchivo, Archivo) VALUES ('" + oPro.RFC_Pro + "', '" + oPro.NombreArchivo_pro + "', @Archivo_pro);";
                using (MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlCon))
                {
                    Comando.Parameters.AddWithValue("@Archivo_pro", oPro.Archivo_pro);
                    sqlCon.Open();
                    Rpta = Comando.ExecuteNonQuery() >= 1 ? "Ok" : "No se pudo ingresar el registro";
                }
                
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }
        public DataTable ConsultaArchivos(string RFC)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string sqlTarea = "select NombreArchivo from Archivos where RFC = '"+RFC+"'";
                MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlCon);
                sqlCon.Open();                
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
