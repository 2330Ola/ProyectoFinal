using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Negocio
{
    public class CDo_Procedimientos
    {
        CD_Procedimientos ObjProcedimientos = new CD_Procedimientos();


        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public DataTable CargarDatos(String Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }

        //Metodo que me permite alterar los colores en las filas de una tabla
        public void AlternarColorFilaDataGrid(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);
        }

        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public string GenerarCodigo(String Tabla)
        {
            return ObjProcedimientos.GenerarCodigo(Tabla);
        }

        //Metodo que me permite Cargar los Datos de una tabla a un DataGridView
        public string GenerarCodigoId(String Tabla)
        {
            return ObjProcedimientos.GenerarCodigoId(Tabla);
        }

        //Metodo que permite dar formato moneda a una caja de texto

        public void FormatoMoneda(TextBox XTBox)
        {
            ObjProcedimientos.FormatoMoneda(XTBox);
        }

        //Metodo
        public void LimpiarControles(Form XForm)
        {
            ObjProcedimientos.LimpiarControles(XForm);
        }

        //Metodo
        public void LLenarComboBox(string Tabla, string Nombre, ComboBox XCbox)
        {
            ObjProcedimientos.LLenarComboBox(Tabla, Nombre, XCbox);
        }




    }



}

