using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class FrmInventario : FormBase
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        public static double Total;

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            SumarInventario();

            dataGridView1.Columns[0].Visible = false;//IDINVENTARIO

            dataGridView1.Columns[1].Width = 140;//CODIGOPRODUCTO
            dataGridView1.Columns[2].Width = 290;//NOMBRE PRODUCTO
            dataGridView1.Columns[3].Width = 150;//CANTIDAD
            dataGridView1.Columns[4].Width = 150;//COSTOUNITARIO
            dataGridView1.Columns[5].Width = 150;//PRECIODE VENTA
            dataGridView1.Columns[6].Width = 150;//MONTOTOTAL
            dataGridView1.Columns[7].Width = 150;//TIPODECARGO

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGrid(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Inventario");
            dataGridView1.ClearSelection();
        }

        private void SumarInventario()
        {
            Total = 0;
            foreach(DataGridViewRow Row in dataGridView1.Rows) 
            {
                Total += Convert.ToDouble(Row.Cells[6].Value);

            }

            txtMontoTotalInventario.Text = Total.ToString("N2");
        }
    }
}
