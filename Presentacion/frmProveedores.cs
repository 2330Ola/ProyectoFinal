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
using System.Data.Odbc;

namespace Presentacion
{
    public partial class frmProveedores : FormBase
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Proveedores Proveedores = new CDO_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false; //IdProveedor

            dataGridView1.Columns[1].Width = 120;//CODIGOPROVEEDOR
            dataGridView1.Columns[2].Width = 180;//NOMBRE PROVEEDOR
            dataGridView1.Columns[3].Width = 150;//RNC PROVEEDOR
            dataGridView1.Columns[4].Width = 350;//DIRECCION 
            dataGridView1.Columns[5].Width = 150;//TELEFONO
            dataGridView1.Columns[6].Width = 240;//EMAIL
          
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaDataGrid(dataGridView1);
        }
    

       
        private void EdProv_UpdateEventHandler(object sender, FrmEditarProveedor.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void AgProv_UpdateEventHandler(object sender, FrmAgregarProveedor.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Proveedores");
            dataGridView1.ClearSelection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor AgregarProveedor = new FrmAgregarProveedor(this);
            AgregarProveedor.UpdateEventHandler += AgProv_UpdateEventHandler;
            AgregarProveedor.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para editar", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarProveedor EditarProveedor = new FrmEditarProveedor(this);
                        EditarProveedor.UpdateEventHandler += EdProv_UpdateEventHandler;
                        EditarProveedor.txtId_Proveedor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProveedor.txtCodProveedor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProveedor.txtNomProveedor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProveedor.txtRNCProveedor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProveedor.txtDirecProveedor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProveedor.mtxtTelProveedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProveedor.txtEmailProveedor.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProveedor.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor seleccione un registro", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta seguro que desea eliminar este registro", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Proveedor.Id_Proveedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Proveedores.EliminarProveedor(Proveedor);

                            MessageBox.Show("El Proveedor fue Eliminado Correctamente", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Resultados == DialogResult.Yes)
                                CargarDatos();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor seleccione un registro para eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
