using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Presentacion
{
    public partial class FrmProductos : FormBase
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Productos Productos = new CDO_Productos();
        CE_Productos Producto = new CE_Productos();

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//IDPRODUCTO

            dataGridView1.Columns[1].Width = 140;//CODIGOPRODUCTO
            dataGridView1.Columns[2].Width = 260;//NOMBRE PRODUCTO
            dataGridView1.Columns[3].Width = 300;//DESCRIPCION PRODUCTO
            dataGridView1.Columns[4].Width = 150;//PRESENTACIONPRODUCTO
            dataGridView1.Columns[5].Width = 140;//COSTOUNITARIO
            dataGridView1.Columns[6].Width = 140;//PRECIOVENTA
            dataGridView1.Columns[7].Width = 150;//TIPODECARGO

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGrid(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AgPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgregarProducto = new FrmAgregarProducto(this);
            AgregarProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0) 
            {
                MessageBox.Show("No hay registros para editar","Editar Producto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarProducto EditarProducto = new FrmEditarProducto(this);
                        EditarProducto.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProducto.txtId_Producto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProducto.txtCodProducto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProducto.txtNomProducto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProducto.txtDesProducto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProducto.txtPresProducto.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProducto.txtCostoUnitario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProducto.txtPrecioVenta.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProducto.comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarProducto.ShowDialog();

                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Por favor seleccione un registro", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public override void Eliminar()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este registro","Eliminar Producto",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(Resultados == DialogResult.Yes)
                        {
                            Producto.Id_Productos = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Por favor seleccione un registro para eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        public override void Buscar()
        {
            try
            {
                if(cboTipoBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = txtBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Codigo(Producto);

                }
                else if(cboTipoBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = txtBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (cboTipoBusqueda.Text == "Descripcion")
                {
                    Producto.Buscar = txtBuscarProducto.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Descripcion(Producto);
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show("El producto no fue encontrado por : "+ex.Message, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
