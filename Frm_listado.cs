using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguimiento_De_Prospectos
{
    public partial class Frm_Listado : Form
    {
        public Frm_Listado()
        {
            InitializeComponent();
        }

        #region "Mis metodos"

        public void Listado_pro()
        {
            D_Prospectos Datos = new D_Prospectos();
            dgvB_listado.DataSource = Datos.Listado_pro();
        }

        private void limpiar_texto()
        {
            txtB_nombre.Text = "";
            txtB_apellidop.Text = "";
            txtB_apellidom.Text = "";
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvB_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Listado_Load(object sender, EventArgs e)
        {
            this.Listado_pro();
        }

        private void btnB_Buscar_Click(object sender, EventArgs e)
        {
            D_Prospectos Datos = new D_Prospectos();
            if (txtB_apellidop.Enabled == false && txtB_apellidom.Enabled == false)
            {
                dgvB_listado.DataSource = Datos.BuscarNombre_pro(txtB_nombre.Text);
            }
            if (txtB_nombre.Enabled == false && txtB_apellidom.Enabled == false)
            {
                dgvB_listado.DataSource = Datos.BuscarApellidoP_pro(txtB_apellidop.Text);
            }
            if (txtB_apellidop.Enabled == false && txtB_nombre.Enabled == false)
            {
                dgvB_listado.DataSource = Datos.BuscarApellidoM_pro(txtB_apellidom.Text);
            }
            if (txtB_apellidop.Text == "" && txtB_apellidom.Text == "" && txtB_nombre.Text == "")
            {
                dgvB_listado.DataSource = Datos.Listado_pro();
            }
            this.limpiar_texto();          
        }

        private void txtB_nombre_TextChanged(object sender, EventArgs e)
        {
            if (txtB_nombre.Text != "")
            {
                txtB_apellidom.Enabled = false;
                txtB_apellidop.Enabled = false;
            }
            if (txtB_nombre.Text == "")
            {
                txtB_apellidom.Enabled = true;
                txtB_apellidop.Enabled = true;
            }
        }

        private void txtB_nombre_Click(object sender, EventArgs e)
        {
        }

        private void txtB_apellidop_TextChanged(object sender, EventArgs e)
        {
            if (txtB_apellidop.Text != "")
            {
                txtB_apellidom.Enabled = false;
                txtB_nombre.Enabled = false;
            }
            if (txtB_apellidop.Text == "")
            {
                txtB_apellidom.Enabled = true;
                txtB_nombre.Enabled = true;
            }
        }

        private void txtB_apellidom_TextChanged(object sender, EventArgs e)
        {
            if (txtB_apellidom.Text != "")
            {
                txtB_nombre.Enabled = false;
                txtB_apellidop.Enabled = false;
            }
            if (txtB_apellidom.Text == "")
            {
                txtB_nombre.Enabled = true;
                txtB_apellidop.Enabled = true;
            }
        }

        private void btnB_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre = Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value);
                string apellidop = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoP"].Value);
                string apellidom = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoM"].Value);
                string estatus = Convert.ToString(dgvB_listado.CurrentRow.Cells["Estatus"].Value);
                Frm_Evaluacion evaluacion = new Frm_Evaluacion(nombre, apellidop, apellidom, estatus);
                AddOwnedForm(evaluacion);
                evaluacion.Show();
            }            
        }

        private void dgvB_listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre = Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value);
                string apellidop = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoP"].Value);
                string apellidom = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoM"].Value);
                string estatus = Convert.ToString(dgvB_listado.CurrentRow.Cells["Estatus"].Value);
                Frm_Evaluacion evaluacion = new Frm_Evaluacion(nombre, apellidop, apellidom, estatus);
                AddOwnedForm(evaluacion);
                evaluacion.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value)))
            {
                MessageBox.Show("Selecciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre = Convert.ToString(dgvB_listado.CurrentRow.Cells["Nombre"].Value);
                string apellidop = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoP"].Value);
                string apellidom = Convert.ToString(dgvB_listado.CurrentRow.Cells["ApellidoM"].Value);
                string estatus = Convert.ToString(dgvB_listado.CurrentRow.Cells["Estatus"].Value);
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminar Prospecto?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    D_Prospectos prospectos = new D_Prospectos();
                    prospectos.eliminarArchivorfc(nombre, apellidop, apellidom, estatus);
                    prospectos.eliminar(nombre, apellidop, apellidom, estatus);                    
                    this.Listado_pro();
                }           
            }
        }
    }
}
