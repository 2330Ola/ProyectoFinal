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
    public partial class FrmAgregarCliente : FormBase
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Cliente Clientes = new CDO_Cliente();
        CE_Cliente Cliente = new CE_Cliente();


        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            
        }



        private void GenerarCodigo()
        {
            txtCodCliente.Text = "Client" + Procedimientos.GenerarCodigo("Clientes");
        }

        private void txtNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRNCLiente.Focus();
                   e.Handled = true;
            }
        }


        private void txtRNCLiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDirecCliente.Focus();
                e.Handled = true;
            }
        }
        private void txtDirecCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                msxTelCliente.Focus();
                e.Handled = true;
            }
        }

        private void msxTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtEmailCliente.Focus();
                e.Handled = true;
            }
        }

        private void txtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbEstadoCliente.Focus();
                e.Handled = true;
            }
        }

        private void cbEstadoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {

            try
            {
                if (txtCodCliente.Text == string.Empty || txtNomCliente.Text == string.Empty || txtRNCLiente.Text == string.Empty ||
                   txtDirecCliente.Text == string.Empty || msxTelCliente.Text == string.Empty || txtEmailCliente.Text == string.Empty ||
                    cbEstadoCliente.Text == string.Empty)

                {
                    MessageBox.Show("Por favor ebe Completar todos los campos ", "Agregar Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cliente.Codigo = txtCodCliente.Text.Trim();
                    Cliente.Nombre = txtNomCliente.Text.Trim();
                    Cliente.RNC_Cliente = txtRNCLiente.Text.Trim();
                    Cliente.Direccion = txtDirecCliente.Text.Trim();
                    Cliente.Telefono = msxTelCliente.Text.Trim();
                    Cliente.Email = txtEmailCliente.Text.Trim();
                    Cliente.Estado = cbEstadoCliente.Text.Trim();



                    Clientes.AgregarCliente(Cliente);
                    MessageBox.Show("El Proveedor fue Agregado Correctamente", "Proveedores ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    txtNomCliente.Focus();
                    Agregar();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor no fue agregado por : " + ex.Message, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }

}
