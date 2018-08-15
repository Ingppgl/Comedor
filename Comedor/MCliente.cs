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
    public partial class MCliente : Mantenimiento
    {
        public MCliente()
        {
            InitializeComponent();
        }
        /*esta funcion guardar se hereda desde el form de mantenimiento y por medio al polimorfismo
         podemos utilizar en cualquier parte de forma que atualice lo que queremos y reusar el mismo boton
         cuantas veces querramos para que gastemos menos en codigos y espacio de memoria durante la ejecucion 
         lo que tambien permite que el programa no se relentice*/
        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this, Provider) == false)
            {
                try
                {
                    string cmd = string.Format("Exec ActulizarCliente '{0}','{1}','{2}'"
                        + "", CCodigoC.Text.Trim(), CNombreC.Text.Trim(), CApell.Text.Trim());
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
                string elim = string.Format("Exec EliminarArticulo '{0}'", CCodigoC.Text.Trim());
                Utilidades.Ejecutar(elim);
                MessageBox.Show("El Cliente se ha Eliminado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha Ocurrido un Error: " + e.Message);
            }
        }

        private void CCodigoC_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }

        private void CNombreC_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }

        private void CApell_TextChanged(object sender, EventArgs e)
        {
            Provider.Clear();
        }
    }
}
