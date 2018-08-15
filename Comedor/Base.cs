using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comedor
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Eliminar()
        {

        }

        public virtual void Nuevo()
        {

        }
        
        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }

    }
}
