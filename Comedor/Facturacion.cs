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
            try
            {
                if (string.IsNullOrEmpty(BCodigo.Text.Trim()) == false)
                {
                    string cmd = string.Format("select * from cliente where Id_Cliente = '{0}'", BCodigo.Text.Trim());
                    DataSet ds;
                    ds = Utilidades.Ejecutar(cmd);
                    Cliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                    SCodigo.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente no Existe");
            }
        }

        public static int Cont_Fila = 0;
        public static double Total;

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;
                /*Caundo el datagrid este vacio me agrega el articulo para ser facturado*/
                if (Cont_Fila == 0)
                {
                    dataGridView1.Rows.Add(SCodigo.Text, TDescripcion.Text, TPrecio.Text, TCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[Cont_Fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Cont_Fila].Cells[3].Value);

                    dataGridView1.Rows[Cont_Fila].Cells[4].Value = importe;

                    Cont_Fila++;
                }

                /*Si el articulo ya existe en el datagrid que me actualice la cantidad y el importe
                para no poner el mismo articulo mas de una vez dentro de la misma compra*/
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == SCodigo.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if (existe == true)
                    {   //busca para saber si el artuculo ya existe en el datagrid y actualiza la cantidad sumando la nueva cantidad junto a la anterior
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(TCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        //actuliza el importe de ese articulo segun se actuliza la cantidad de articulos a comprar
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {   // una vez mas busca entre los articulos si este ni existe lo agrega al datagrid
                        dataGridView1.Rows.Add(SCodigo.Text, TDescripcion.Text, TPrecio.Text, TCantidad.Text);
                        double importe= Convert.ToDouble(dataGridView1.Rows[Cont_Fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Cont_Fila].Cells[3].Value);
                        dataGridView1.Rows[Cont_Fila].Cells[4].Value = importe;

                        Cont_Fila++;
                    }
                }
                /*Para Sumar todos los importes y asignarlos al espacio reservado para el total*/
                Total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {       //suma los importes en la variable total      
                        Total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                //asigna los totales al espacio reservado para la suma del total
                TTotal.Text = "RD$ " + Total.ToString() +".00  ";
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Cont_Fila > 0)
            {   //resta del total el importe de la fila eliminada
                Total = Total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                TTotal.Text = "RD$ " + Total.ToString() + ".00  ";
                //elimina del datagrid la fila selccionada 
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                Cont_Fila--;
            }
        }

        private void BCliente_Click(object sender, EventArgs e)
        {
            /*Busca en el datagrid de Clientes registrados y al seleccionar 1 lleva el codigo y nombre a 
             sus celdas correspondientes*/
            CClientes concli = new CClientes();
            concli.ShowDialog();

            if (concli.DialogResult == DialogResult.OK)
            {
                //coloca el codigo y el nombre en sus celdas respectivas
                BCodigo.Text = concli.dataGridView1.Rows[concli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                Cliente.Text = concli.dataGridView1.Rows[concli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                SCodigo.Focus();
            }
        }

        private void BProducto_Click(object sender, EventArgs e)
        {
            /*Busca en el datagrid Articulo registrados y al seleccionar 1 lleva el codigo, 
             * descripcion y precio a sus celdas correspondientes*/
            CProductos conpro = new CProductos();
            conpro.ShowDialog();
            TCantidad.Text = "";
            if (conpro.DialogResult == DialogResult.OK)
            {
                //Coloca los campos antes llamados en sus respectivas celdas.
                SCodigo.Text = conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TDescripcion.Text = conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TPrecio.Text = conpro.dataGridView1.Rows[conpro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                TCantidad.Focus();
            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
         public override void Nuevo()
        {
            BCodigo.Text = "";
            Cliente.Text = "";
            SCodigo.Text = "";
            TDescripcion.Text = "";
            TPrecio.Text = "";
            TCantidad.Text = "";
            TTotal.Text = "RD$ ";
            Total = 0;
            dataGridView1.Rows.Clear();
            Cont_Fila = 0;
            SCodigo.Focus();
        }

    }
}
