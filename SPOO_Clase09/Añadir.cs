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
    public partial class Añadir : Form
    {
        BaseDeDatos BasedeDatos;
        Validaciones validaciones;
        Herramientas herramientas;
        List<TextBox> ListadeTxtBox;
        bool control=false;
        public Añadir()
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
            ListadeTxtBox.Add(txtTotal);
        }
        private void Añadir_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = BasedeDatos.Actualizar();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (validaciones.ControlVacio( ListadeTxtBox) == true && validaciones.ControlaDni8(txtDni.Text, lblInfor) == true && control == true && validaciones.ControlaTelefono10(txtTelefono.Text, lblInfor) == true)
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea agregar este registro?", "Confirme Operación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        bool alta = false;
                        alta = BasedeDatos.ABM("INSERT INTO clientes02(DNI, Apellido ,Nombre ,Télefono ,email, Modelo ,Entregado,Total_a_pagar) VALUES ('" +
                         txtDni.Text + "', '" + txtApellido.Text + "', '" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtemail.Text + "', '" +
                         txtModelo.Text + "','No','" + "$" + txtTotal.Text + "')");
                        if (alta == true)
                        {
                            MessageBox.Show("Se creó correctamente el registro", "Registro Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            herramientas.Limpiartxt(ListadeTxtBox, dgvClientes);
                            dgvClientes.DataSource = BasedeDatos.Actualizar();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
         }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
           validaciones.ControlaSoloNumeros(e,sender as TextBox,lblInfor);   
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

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloLetras(e, sender as TextBox, lblInfor);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ControlaSoloNumeros(e, sender as TextBox, lblInfor);
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
          control=validaciones.ControlaEmail(txtemail.Text, lblInfor);
        }
    }
}
