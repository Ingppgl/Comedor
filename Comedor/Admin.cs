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
    public partial class Admin : Base
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where Id_user = " + Login.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            NombreAd.Text = DS.Tables[0].Rows[0]["Nombre"].ToString();
            CuentaAd.Text = DS.Tables[0].Rows[0]["Cuenta"].ToString();
            CodigoAd.Text = DS.Tables[0].Rows[0]["Id_user"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.Show();
        }
    }
}
