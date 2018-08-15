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
    public partial class MProducto : Mantenimiento
    {
        public MProducto()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario (this, Provider) == false)
            {
                try
                {
                    string cmd = string.Format("Exec ActulizarArticulo '{0}','{1}','{2}'"
                        + "", CCodigo.Text.Trim(), CDescrip.Text.Trim(), CPrec.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Guardado Correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha Ocurrido un Error: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public override void Eliminar()
        {
            try
            {
                string elim = string.Format("Exec EliminarArticulo '{0}'", CCodigo.Text.Trim());
                Utilidades.Ejecutar(elim);
                MessageBox.Show("El Producto se ha Eliminado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha Ocurrido un Error: " + e.Message);
            }
        }

        private void CCodigo_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }

        private void CDescrip_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }

        private void CPrec_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }
    }
}
