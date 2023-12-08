using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Seguimiento_De_Prospectos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuiario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "berqnsrytsp7qogeumkn";
            this.Servidor = "berqnsrytsp7qogeumkn-mysql.services.clever-cloud.com";
            this.Puerto = "3306";
            this.Usuiario = "uiyiniqpt1ogqter";
            this.Clave = "gmo8RIYpeokIALRawAQ3";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString="datasource="+this.Servidor +
                    "; port="+this.Puerto +
                    ";username=" + this.Usuiario +
                    ";password=" + this.Clave +
                    "; Database=" + this.Base;
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
