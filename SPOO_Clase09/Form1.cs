using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPOO_Clase09
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void abrirFormHijo(object formHijo)
        {
            try
            {
                if (this.splitContainer1.Panel2.Controls.Count > 0)
                    this.splitContainer1.Panel2.Controls.RemoveAt(0);
                Form formhijo = formHijo as Form; //creo UN formulario con un nombre y 
                //le ody el valor del objeto que le entra por parametro
                //al objeto lo convierto en un formulario
                formhijo.TopLevel = false; //formulario secundario
                formhijo.Dock = DockStyle.Fill;//propiedad que hace que se acomple al panel contenedor
                this.splitContainer1.Panel2.Controls.Add(formhijo);
                this.splitContainer1.Panel2.Tag = formhijo;//establecemos la instacnia como contenedor de datos de uestro panel
                formhijo.Show();
            } catch (Exception)
                 {
                     MessageBox.Show("No se pudo completar la operación, fallo en abrir el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        private void bttnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.splitContainer1.Panel2.Controls.Count > 0)
                    this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }catch (Exception )
                 {
                     MessageBox.Show("No se pudo completar la operación, error al actualizar la pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Buscar());//Enviamos nuestro formulario como nuevo parametro
            //Declarandolo como nuevo objeto
        }

        private void bttnAñadir_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Añadir());
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Editar());
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Eliminar());
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
             DialogResult respuesta = MessageBox.Show("Esta seguro que desea cerrar el programa?", "Confirme Operación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             if (respuesta == DialogResult.OK) this.Close();
        }

    }
}
