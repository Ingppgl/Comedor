using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = Administracion; Integrated Security = True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();
            return DS;
        }

        public static Boolean ValidarFormulario( Control Objeto, ErrorProvider ErrorPro)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrortxtBox)
                {
                    ErrortxtBox Obj = (ErrortxtBox)Item;
                    if (Obj.Vacio == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorPro.SetError(Obj, "No puede estar Vacio");
                            HayErrores = true;
                        }
                    }
                    if (Obj.Numeros == true)
                    {
                        int Cont = 0, Letras = 0;

                        foreach(char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), Cont))
                            {
                                Letras++;
                            }
                            Cont++;
                        }

                        if (Letras != 0)
                        {
                            HayErrores = true;
                            ErrorPro.SetError(Obj, "Este Campo es Numérico");
                        }
                    }
                }
            }
            return HayErrores;
        }
    }
}
