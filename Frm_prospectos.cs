using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguimiento_De_Prospectos
{
    public partial class Frm_prospectos : Form
    {
        public Frm_prospectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnA_salir_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtA_nombre.Text.Trim());
            string apellidop = txtA_apellidop.Text.Trim();
            string apellidom = txtA_apellidom.Text.Trim();
            string calle = txtA_calle.Text.Trim();
            string numero = Convert.ToString(txtA_numero.Text);
            string colonia = txtA_colonia.Text.Trim();
            string cp = Convert.ToString(txtA_cp.Text);
            string telefono = txtA_telefono.Text.Trim();
            string rfc = txtA_rfc.Text.Trim();
            if (nombre == "" && apellidop == "" && apellidom == "" && calle == "" && numero == "" && colonia == "" && cp == "" && telefono == "" && rfc == "" && dataGridView1.RowCount == 0)
            {
                this.Close();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Si cierras la ventana se perderan los datos de captura", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }                       
        }

        public int validar()
        {
            string nombre = Convert.ToString(txtA_nombre.Text.Trim());
            string apellidop = txtA_apellidop.Text.Trim();
            string calle = txtA_calle.Text.Trim();
            string numero = Convert.ToString(txtA_numero.Text);
            string colonia = txtA_colonia.Text.Trim();
            string cp = Convert.ToString(txtA_cp.Text);
            string telefono = txtA_telefono.Text.Trim();
            string rfc = txtA_rfc.Text.Trim();
            int error_count = 0;
            if (nombre =="" || apellidop == "" || calle == "" || numero == "" || colonia == "" || cp == "" || telefono == "" || rfc == "" || dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Falta de llenar un campo! \n Recuerda adjuntar al menos un documento.", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error_count += 1;
            }
            return error_count;
        }

        private void btnA_enviar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (this.validar() == 0)
            {
                P_Prospectos oPro = new P_Prospectos();
                oPro.Nombre_pro = txtA_nombre.Text.Trim();
                oPro.ApellidoP_Pro = txtA_apellidop.Text.Trim();
                oPro.ApellidoM_Pro = txtA_apellidom.Text.Trim();
                oPro.Calle_Pro = txtA_calle.Text.Trim();
                oPro.Numero_Pro = Convert.ToInt32(txtA_numero.Text);
                oPro.Colonia_Pro = txtA_colonia.Text.Trim();
                oPro.Cp_Pro = Convert.ToInt32(txtA_cp.Text);
                oPro.Telefono = txtA_telefono.Text.Trim();
                oPro.RFC_Pro = txtA_rfc.Text.Trim();
                oPro.Estatus_Pro = "Enviado";

                D_Prospectos Datos = new D_Prospectos();
                rpta = Datos.Guardar_pro(1, oPro);
                int indiceColumnaNombre = 1;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[indiceColumnaNombre].Value != null)
                    {
                        string ruta = fila.Cells["RutaArchivo"].Value.ToString();
                        byte[] contenidoPDF = File.ReadAllBytes(ruta);
                        string archivo = fila.Cells["NombreArchivo"].Value.ToString();
                        oPro.NombreArchivo_pro = archivo;
                        oPro.Archivo_pro = contenidoPDF;
                        Datos.Guardar_Archivos(oPro);
                    }
                }                
                
                if (rpta.Equals("Ok"))
                {
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtA_nombre.Text = "";
                    txtA_apellidop.Text = "";
                    txtA_apellidom.Text = "";
                    txtA_calle.Text = "";
                    txtA_numero.Text = "";
                    txtA_colonia.Text = "";
                    txtA_cp.Text = "";
                    txtA_telefono.Text = "";
                    txtA_rfc.Text = "";
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                    button1.Visible = false;
                }
                else
                {
                    MessageBox.Show(rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_prospectos_Load(object sender, EventArgs e)
        {

        }

        private void txtA_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_apellidop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_apellidom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }

        private void txtA_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar la entrada
                e.Handled = true;
            }
        }


        private void btnabrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Visible = true;
                button1.Visible = true;
                string ruta = Convert.ToString(openFileDialog1.FileName);
                string nombre = Convert.ToString(openFileDialog1.SafeFileName);
                dataGridView1.Rows.Add(ruta, nombre);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridView1.CurrentRow.Cells["RutaArchivo"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                if (dataGridView1.RowCount == 0)
                {
                    dataGridView1.Visible=false;
                    button1.Visible=false;
                }
            }
        }
    }
}
