using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPOO_Clase09
{
    public partial class Buscar : Form
    {
        BaseDeDatos BasedeDatos;
        public Buscar()
        {
            InitializeComponent();
            BasedeDatos = new BaseDeDatos();
        }
        
        private void Buscar_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource=BasedeDatos.Actualizar();
        }

        private void txtFiltroDNI_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Filtrardatos(txtFiltroDNI.Text);
        }

    }
}
