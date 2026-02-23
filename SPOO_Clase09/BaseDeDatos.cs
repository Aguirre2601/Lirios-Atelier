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
    class BaseDeDatos
    {
        private DataTable Tabla= new DataTable(); 
        private SqlConnection Conexion = new SqlConnection(@"Data Source= DESKTOP-V9JS652\MSSQLSERVER01;Initial Catalog=atelier_lilies;Trusted_Connection=True;");
        private SqlCommand Comando;
        public void Conectar()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                try { Conexion.Open(); }
                catch { MessageBox.Show("No se pudo abrir la base de datos"); }
            }
        }
        public void Desconectar()
        {
            if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();
        }
        public DataTable Actualizar ()
        {
            Tabla.Clear();
            Tabla.Load(Leer("SELECT *FROM clientes02"));
            return Tabla;
        }
        public SqlDataReader Leer(string consulta)
        {
            Conectar();
            Comando = new SqlCommand(consulta, Conexion);
            SqlDataReader Lector;
            try
            {
                Lector = Comando.ExecuteReader();
            }
            catch  { Lector = null; }
            return Lector;
            Desconectar();
        }
        public DataTable Filtrardatos  (string txtFiltroDNI)
        {     
            if (txtFiltroDNI != "")
            {
                Tabla.Clear();
                Conectar();
                Comando = new SqlCommand("SELECT *FROM clientes02 where DNI like '" + txtFiltroDNI + "%'", Conexion);
                SqlDataReader Lector;
                try
                {
                  Lector = Comando.ExecuteReader();
                }
                catch
                {
                  Lector = null;
                }
                Tabla.Load(Lector);
                return Tabla;
            }
            else
            {
                return Actualizar();
            } 
            Desconectar();
         }  
        public bool ABM(string consulta)
        {
            bool Resultado = false;
            Conectar();
            Comando = new SqlCommand(consulta, Conexion);
            try
            {
                Comando.ExecuteNonQuery();
                Resultado = true;
            }
            catch
            {
                Resultado = false;
            }
            Desconectar();
            return Resultado;
        }
    }
}
