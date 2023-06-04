using Entidad;
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

namespace Presentacion
{
    public partial class FrmClientes : FormBase
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Cliente Clientes = new CDO_Cliente();
        CE_Cliente Cliente = new CE_Cliente();


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false; //IdProveedor

            dataGridView1.Columns[1].Width = 120;//CODIGOPROVEEDOR
            dataGridView1.Columns[2].Width = 180;//NOMBRE PROVEEDOR
            dataGridView1.Columns[3].Width = 150;//RNC PROVEEDOR
            dataGridView1.Columns[4].Width = 350;//DIRECCION 
            dataGridView1.Columns[5].Width = 150;//TELEFONO
            dataGridView1.Columns[6].Width = 240;//EMAIL
            dataGridView1.Columns[7].Width = 240;//EMAIL

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaDataGrid(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Clientes");
            dataGridView1.ClearSelection();
        }

        private void EdProv_UpdateEventHandler(object sender, FrmEditarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }


        private void EdCliente_UpdateEventHandler(object sender, FrmEditarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void AgCliente_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void AgCli_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente AgregarCliente = new FrmAgregarCliente();
            AgregarCliente.UpdateEventHandler += AgCli_UpdateEventHandler;
            AgregarCliente.ShowDialog();
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
                        FrmEditarCliente EditarCliente = new FrmEditarCliente(this);
                        EditarCliente.UpdateEventHandler += EdCliente_UpdateEventHandler;
                        EditarCliente.txtId_Cliente.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarCliente.txtCodCliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarCliente.txtNomCliente.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarCliente.txtRNCCliente.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarCliente.txtDirecCliente.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarCliente.mtxtTelCliente.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarCliente.txtEmailCliente.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarCliente.cbEstadoCliente.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarCliente.ShowDialog();

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
                            Cliente.Id_Cliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Clientes.EliminarCliente(Cliente);

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
