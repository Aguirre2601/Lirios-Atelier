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
    public partial class Eliminar : Form
    {
        BaseDeDatos BasedeDatos;
        Validaciones validaciones;
        Herramientas herramientas;
        List<TextBox> ListadeTxtBox;
        public Eliminar()
        {
            InitializeComponent();
            validaciones = new Validaciones();
            BasedeDatos = new BaseDeDatos();
            herramientas = new Herramientas();
            ListadeTxtBox = new List<TextBox>();
            ListadeTxtBox.Add(txtDni);
            ListadeTxtBox.Add(txtApellido);
            ListadeTxtBox.Add(txtNombre);
            ListadeTxtBox.Add(txtTelefono);
            ListadeTxtBox.Add(txtemail);
            ListadeTxtBox.Add(txtModelo);
            ListadeTxtBox.Add(txtEntregado);
            ListadeTxtBox.Add(txtTotal);
        }

        private void txtFiltroDNI_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Filtrardatos(txtFiltroDNI.Text);
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Actualizar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramientas.Cargatxt(ListadeTxtBox, dgvClientes);
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea Eliminar este registro?", "Confirme Operación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
               if (BasedeDatos.ABM("DELETE FROM clientes02 WHERE DNI= " + txtDni.Text + ";") == true)
                 {
                    MessageBox.Show("Se eliminó correctamente el registro", "Proceso finalizado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    herramientas.Limpiartxt(ListadeTxtBox, dgvClientes);
                    BasedeDatos.Actualizar();
                 }  else MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
                 
        }


    }
}
