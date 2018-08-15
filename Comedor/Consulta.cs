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
    public partial class Consulta : Base
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public DataSet LlenarDGV (string tabla)
        {
            DataSet DS;

            string comd = string.Format("Select * from " + tabla);
            DS = Utilidades.Ejecutar(comd);

            return DS;
        }
        //selecciona del data grid y lleva a otra pantalla para poder usar los datos
        private void BSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
