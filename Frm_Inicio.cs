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
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void btn_anadir_Click(object sender, EventArgs e)
        {
            Frm_prospectos prospectos = new Frm_prospectos();
            prospectos.Show();
        }

        private void btn_listado_Click(object sender, EventArgs e)
        {
            Frm_Listado listado = new Frm_Listado();
            listado.Show();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
