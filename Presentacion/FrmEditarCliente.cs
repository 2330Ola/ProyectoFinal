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
    public partial class FrmEditarCliente : FormBase
    {
        public FrmEditarCliente(FrmClientes Clientes)
        {
            InitializeComponent();
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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            
        }



        private void txtNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRNCCliente.Focus();
                e.Handled = true;
            }
        }

        private void txtRNCCliente_KeyPress(object sender, KeyPressEventArgs e)
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
                mtxtTelCliente.Focus();
                e.Handled = true;
            }
        }

        private void mtxtTelCliente_KeyPress(object sender, KeyPressEventArgs e)
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
                cbEstadoCliente .Focus();
                e.Handled = true;
            }
        }

        private void cbEstadoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEditar.Focus();
                e.Handled = true;
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public override void Editar()
        {
            try
            {
                if (txtCodCliente.Text == string.Empty || txtNomCliente.Text == string.Empty || txtRNCCliente.Text == string.Empty ||
                   txtDirecCliente.Text == string.Empty || mtxtTelCliente.Text == string.Empty || txtEmailCliente.Text == string.Empty ||
                    cbEstadoCliente.Text == string.Empty)

                {
                    MessageBox.Show("Por favor debe Completar todos los campos ", "Editar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cliente.Id_Cliente = Convert.ToInt32(txtId_Cliente.Text);   
                    Cliente.Codigo = txtCodCliente.Text.Trim();
                    Cliente.Nombre = txtNomCliente.Text.Trim();
                    Cliente.RNC_Cliente = txtRNCCliente.Text.Trim();
                    Cliente.Direccion = txtDirecCliente.Text.Trim();
                    Cliente.Telefono = mtxtTelCliente.Text.Trim();
                    Cliente.Email = txtEmailCliente.Text.Trim();
                    Cliente.Estado = cbEstadoCliente.Text.Trim();



                    Clientes.EditarCliente(Cliente);
                    MessageBox.Show("El Cliente fue editado Correctamente", "Editar Clientes ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente no fue editado por : " + ex.Message, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }



}
