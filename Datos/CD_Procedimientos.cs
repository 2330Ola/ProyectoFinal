using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Procedimientos
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataReader Dr;
        DataTable Dt;

        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public DataTable CargarDatos(String Tabla)
        {
            Dt = new DataTable("Cargar_Datos");
            Cmd = new SqlCommand("Select * From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);
            Dr.Close();

            Con.Cerrar();
            return Dt;
        }

        //Metodo que me permite alterar los colores en las filas de una tabla
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;
        }

        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public string GenerarCodigo(String Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count (*) as TotalRegistros From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                   Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();

            if(Total < 10) 
            {
                Codigo = "0000000" + Total;
            }
            else if(Total < 100){
                Codigo = "000000" + Total;
            }
            else if (Total < 1000)
            {
                Codigo = "00000" + Total;
            }
            else if (Total < 10000)
            {
                Codigo = "0000" + Total;
            }
            else if (Total < 100000)
            {
                Codigo = "000" + Total;
            }
            else if (Total < 1000000)
            {
                Codigo = "00" + Total;
            }
            else if (Total < 10000000)
            {
                Codigo = "0" + Total;
            }
            Con.Cerrar();
            return Codigo;
        }
        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public string GenerarCodigoId(String Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count(*) as TotalRegistros From" + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();

           
            
            Con.Cerrar();
            return Codigo;
        }

        //Metodo que permite dar formato moneda a una caja de texto

        public void FormatoMoneda(TextBox XTBox)
        {
            if(XTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(XTBox.Text);  
                XTBox.Text = Monto.ToString("N2");
            }
        }
        //Metodo
        public void LimpiarControles(Form XForm)
        {
            foreach(var XCtrl in XForm.Controls)
            {
                if(XCtrl is TextBox)
                {
                    ((TextBox)XCtrl).Text = string.Empty;
                }
                else if (XCtrl is ComboBox)
                {
                    ((ComboBox)XCtrl).Text = string.Empty;
                }
            }
        }
        //Metodo
        public void LLenarComboBox(string Tabla, string Nombre, ComboBox XCbox)
        {
            Cmd = new SqlCommand("Select * From"+ Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            while(Dr.Read())
            {
                XCbox.Items.Add(Dr[Nombre].ToString()); 
            }
        }

    }
}
