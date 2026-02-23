using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace SPOO_Clase09
{
    class Validaciones
    {
        private bool c1=false;
        public bool ControlVacio(List<TextBox> ListadeTxtBox)
        {
           foreach (TextBox n in ListadeTxtBox)
            {
               if (string.IsNullOrEmpty(n.Text))
                  {
                    DialogResult respuesta = MessageBox.Show("Complete todos los campos para poder agregar el registro. \nFalta : "+n.Name.Substring(3)+"", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    c1 = false;
                   }
               else { c1 = true;  }
            } 
            return c1;
         }
        public void ControlaSoloNumeros(KeyPressEventArgs e, TextBox txt, Label infor)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
               {
                   e.Handled = true;
                   infor.Text = "*Coloque solo números.";
               } else
                 {
                     e.Handled =false;
                 }
        }
        public void ControlaSoloLetras (KeyPressEventArgs e,TextBox txt, Label infor)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                infor.Text = "*Coloque solo letras.";
            }
            else
            {
                e.Handled = false;
            }
        }
        public bool ControlaEmail(string email, Label infor)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                infor.Text = "*Ingrese un email.";
                return false; 
            }
            try
            {
                MailAddress correo = new MailAddress(email);
                return true;
            } 
            catch (FormatException)
            {
                infor.Text = "*El email ingresado es incorrecto.";
                return false;
            }
        }
        public bool ControlaDni8(string texto, Label infor)
        {
            int i = 0;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                   i++;
                    if (i >= 8)
                        return true;
                }
            }
            infor.Text= "*Coloque 8 Digitos";
            return false;
        }
        public bool ControlaTelefono10(string texto, Label infor)
        {
            int i = 0;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    i++;
                    if (i >= 10)
                        return true;
                }
            }
            infor.Text = "*Coloque 10 Digitos para el télefono.";
            return false;
        }

    }
}
