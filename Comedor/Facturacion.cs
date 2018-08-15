using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Comedor
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where Id_User = " + Login.Codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            Atiende.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BCodigo.Text.Trim()) == false)
            {
                string cmd = string.Format("select * from cliente where id_cleinte = '{0}'", BCodigo.Text.Trim());
                DataSet ds;
                ds = Utilidades.Ejecutar(cmd);
                Cliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                SCodigo.Focus();
            }
        }
    }
}
