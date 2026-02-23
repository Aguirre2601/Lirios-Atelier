using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SPOO_Clase09
{
    class Herramientas
    {
        public void Limpiartxt(List<TextBox> ListadeTxtBox, DataGridView dgv)
        {
            
           foreach (TextBox txtBox in ListadeTxtBox)
            {
               int index = ListadeTxtBox.IndexOf(txtBox); 
               txtBox.Text="";
            }
        }
        public void Cargatxt(List<TextBox> ListadeTxtBox, DataGridView dgv )
        {
            foreach (TextBox txtBox in ListadeTxtBox)
            {
               int index = ListadeTxtBox.IndexOf(txtBox); 
               txtBox.Text=dgv.CurrentRow.Cells[index].Value.ToString();
            }
        }
    }
}
