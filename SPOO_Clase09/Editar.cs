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
    public partial class Editar : Form
    {
        BaseDeDatos BasedeDatos;
        Validaciones validaciones;
        Herramientas herramientas;
        List<TextBox> ListadeTxtBox;
        bool control;
        string entregado;
        public Editar()
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
       
        private void Editar_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Actualizar();
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            herramientas.Cargatxt(ListadeTxtBox, dgvClientes);
        }

        private void txtFiltroDNI_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Filtrardatos(txtFiltroDNI.Text);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloNumeros(e, sender as TextBox, lblInfor);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloLetras(e, sender as TextBox, lblInfor);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloLetras(e, sender as TextBox, lblInfor);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloNumeros(e, sender as TextBox, lblInfor);
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            control = validaciones.ControlaEmail(txtemail.Text, lblInfor);
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloLetras(e, sender as TextBox, lblInfor);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloNumeros(e, sender as TextBox, lblInfor);
        }

        private void txtEntregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 's' || e.KeyChar == 'S' || e.KeyChar == 'n' || e.KeyChar == 'N' ||
                 e.KeyChar == 'i' || e.KeyChar == 'I' || e.KeyChar == 'o' || e.KeyChar == 'O' ||
                 e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEntregado_TextChanged(object sender, EventArgs e)
        {
            if (txtEntregado.Text == "si" || txtEntregado.Text == "SI" || txtEntregado.Text == "Si" || txtEntregado.Text == "sI")
                txtEntregado.Text = "Si";
            else if (txtEntregado.Text == "no" || txtEntregado.Text == "NO" || txtEntregado.Text == "No" || txtEntregado.Text == "nO")
                txtEntregado.Text = "No";
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            if (validaciones.ControlVacio(ListadeTxtBox) == true && validaciones.ControlaDni8(txtDni.Text, lblInfor) == true && /*control == true &&*/ validaciones.ControlaTelefono10(txtTelefono.Text, lblInfor) == true)
            {
                 DialogResult respuesta = MessageBox.Show("Esta seguro que desea modifica este registro?", "Confirme Operación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                 if (respuesta == DialogResult.OK)
                 {
                     try
                     {
                         bool modif = false;
                         modif = BasedeDatos.ABM("UPDATE clientes02 SET Apellido ='" + txtApellido.Text
                             + "' ,Nombre= '" + txtNombre.Text + "',Télefono='" + txtTelefono.Text +
                             "', email ='" + txtemail.Text + "', Modelo='" + txtModelo.Text +
                             "' ,Entregado= '" + txtEntregado.Text + "',Total_a_pagar= '" + txtTotal.Text +
                             "' WHERE DNI= " + txtDni.Text + ";");
                         if (modif == true)
                         {
                             MessageBox.Show("Se modificó correctamente el registro", "Proceso finalizado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             herramientas.Limpiartxt(ListadeTxtBox, dgvClientes);
                             BasedeDatos.Actualizar();
                         }
                     }
                     catch (Exception)
                     {
                         MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
            }
        }




    }

}
            
