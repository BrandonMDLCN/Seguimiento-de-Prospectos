using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguimiento_De_Prospectos
{
    public partial class Frm_Evaluacion : Form
    {
        public Frm_Evaluacion(string Nombre, string ApellidoP, string ApellidoM, string Estatus)
        {
            InitializeComponent();            
            D_Prospectos datos= new D_Prospectos();
            DataTable resultado = datos.editar(Nombre, ApellidoP, ApellidoM, Estatus);
            if (resultado.Rows.Count > 0)
            {
                // Asignar valores a los TextBoxes
                txtE_nombre.Text = resultado.Rows[0]["Nombre"].ToString();
                txtE_apellidop.Text = resultado.Rows[0]["ApellidoP"].ToString();
                txtE_apellidom.Text = resultado.Rows[0]["ApellidoM"].ToString();
                txtE_calle.Text = resultado.Rows[0]["Calle"].ToString();
                txtE_numero.Text = resultado.Rows[0]["Numero"].ToString();
                txtE_colonia.Text = resultado.Rows[0]["Colonia"].ToString();
                txtE_cp.Text = resultado.Rows[0]["CP"].ToString();
                txtE_telefono.Text = resultado.Rows[0]["Telefono"].ToString();
                txtA_rfc.Text = resultado.Rows[0]["RFC"].ToString();
                lblestatus.Text = resultado.Rows[0]["Estatus"].ToString();
                txtE_observaciones.Text = resultado.Rows[0]["Observaciones"].ToString();
                if (lblestatus.Text == "Autorizado" || lblestatus.Text == "Rechazado")
                {
                    txtE_observaciones.ReadOnly = true;
                    btnE_Autorizar.Visible = false;
                    btnE_rechazar.Visible = false;
                }
                dgvarchivos.DataSource = datos.ConsultaArchivos(Convert.ToString(txtA_rfc.Text));
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la consulta.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnE_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnE_Autorizar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            P_Prospectos oPro = new P_Prospectos();
            oPro.Estatus_Pro = "Autorizado";
            oPro.Observaciones_Pro = Convert.ToString(txtE_observaciones.Text);
            oPro.RFC_Pro = Convert.ToString(txtA_rfc.Text);
            D_Prospectos Datos = new D_Prospectos();
            rpta = Datos.Guardar_pro(2, oPro);
            if (rpta.Equals("Ok"))
            {
                MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable nuevoResultado = Datos.actualizarformeditar(Convert.ToString(txtA_rfc.Text));
                if (nuevoResultado.Rows.Count > 0)
                {
                    txtE_observaciones.Text = nuevoResultado.Rows[0]["Observaciones"].ToString();
                    lblestatus.Text = nuevoResultado.Rows[0]["Estatus"].ToString();
                    txtE_observaciones.ReadOnly = true;
                    btnE_Autorizar.Visible = false;
                    btnE_rechazar.Visible = false;
                    Frm_Listado listados = Owner as Frm_Listado;
                    listados.Listado_pro();
                }
                else
                {
                    MessageBox.Show("No se pudieron recuperar los datos actualizados.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show(rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnE_rechazar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            P_Prospectos oPro = new P_Prospectos();
            oPro.Estatus_Pro = "Rechazado";
            oPro.Observaciones_Pro = Convert.ToString(txtE_observaciones.Text);
            oPro.RFC_Pro = Convert.ToString(txtA_rfc.Text);
            if (string.IsNullOrEmpty(txtE_observaciones.Text))
            {
                MessageBox.Show("Necesitas agregar Observacion", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            D_Prospectos Datos = new D_Prospectos();
            rpta = Datos.Guardar_pro(2, oPro);
            if (rpta.Equals("Ok"))
            {
                MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable nuevoResultado = Datos.actualizarformeditar(Convert.ToString(txtA_rfc.Text));
                if (nuevoResultado.Rows.Count > 0)
                {
                    txtE_observaciones.Text = nuevoResultado.Rows[0]["Observaciones"].ToString();
                    lblestatus.Text = nuevoResultado.Rows[0]["Estatus"].ToString();
                    txtE_observaciones.ReadOnly = true;
                    btnE_Autorizar.Visible = false;
                    btnE_rechazar.Visible = false;
                    Frm_Listado listados = Owner as Frm_Listado;
                    listados.Listado_pro();
                }
                else
                {
                    MessageBox.Show("No se pudieron recuperar los datos actualizados.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show(rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            byte[] contenidoPDF;
            string rfc = Convert.ToString(txtA_rfc.Text);
            if (string.IsNullOrEmpty(Convert.ToString(dgvarchivos.CurrentRow.Cells["NombreArchivo"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string NombreArchivo = Convert.ToString(dgvarchivos.CurrentRow.Cells["NombreArchivo"].Value);
                MySqlDataReader Resultado;
                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    string sqlTarea = "select NombreArchivo, Archivo from Archivos where RFC = '" + rfc + "' AND NombreArchivo = '" + NombreArchivo + "'";
                    MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlCon);
                    sqlCon.Open();
                    Resultado = Comando.ExecuteReader();
                    if (Resultado.Read())
                    {
                        contenidoPDF = (byte[])Resultado.GetValue(1);
                        MostrarSaveFileDialog(NombreArchivo, contenidoPDF);
                    }
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
        public void MostrarSaveFileDialog(string nombreArchivo, byte[] contenidoArchivo)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guardar el contenido en el archivo seleccionado
                File.WriteAllBytes(saveFileDialog.FileName, contenidoArchivo);
                MessageBox.Show("Archivo guardado exitosamente en: ", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Evaluacion_Load(object sender, EventArgs e)
        {

        }

        private void dgvarchivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvarchivos.CurrentRow.Cells["NombreArchivo"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                byte[] contenidoPDF;
                string rfc = Convert.ToString(txtA_rfc.Text);
                if (string.IsNullOrEmpty(Convert.ToString(dgvarchivos.CurrentRow.Cells["NombreArchivo"].Value)))
                {
                    MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string NombreArchivo = Convert.ToString(dgvarchivos.CurrentRow.Cells["NombreArchivo"].Value);
                    MySqlDataReader Resultado;
                    MySqlConnection sqlCon = new MySqlConnection();
                    try
                    {
                        sqlCon = Conexion.getInstancia().CrearConexion();
                        string sqlTarea = "select NombreArchivo, Archivo from Archivos where RFC = '" + rfc + "' AND NombreArchivo = '" + NombreArchivo + "'";
                        MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlCon);
                        sqlCon.Open();
                        Resultado = Comando.ExecuteReader();
                        if (Resultado.Read())
                        {
                            contenidoPDF = (byte[])Resultado.GetValue(1);
                            MostrarSaveFileDialog(NombreArchivo, contenidoPDF);
                        }
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
