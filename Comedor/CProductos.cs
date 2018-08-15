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
    public partial class CProductos : Consulta
    {
        public CProductos()
        {
            InitializeComponent();
        }

        private void CProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDGV("Articulo").Tables[0];
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * from Articulo where nombre like ('%" + textBox1.Text.Trim() + "%')";
                    ds = Utilidades.Ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];
                    AcceptButton = BSelecionar;                   
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido un Error: " + error.Message);
                }
            }
        }
    }
}
