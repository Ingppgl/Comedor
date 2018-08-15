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
    public partial class Login : Base
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select *from Usuarios where Cuenta = '{0}' and Password = '{1}'", User.Text.Trim(), Pass.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["Id_User"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["Cuenta"].ToString().Trim();
                string pass = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == User.Text.Trim() && pass == Pass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status"]) == true)
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        User user = new User();
                        this.Hide();
                        user.Show();
                    }
                }
      
            }
            catch (Exception)
            {
                MessageBox.Show("        Usuario o Contraseña Incorrecto!!!");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
