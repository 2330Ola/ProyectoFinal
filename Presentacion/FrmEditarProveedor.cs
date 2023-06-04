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
using System.Data.Odbc;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmEditarProveedor : FormBase
    {
        public FrmEditarProveedor(frmProveedores Proveedores)
        {
            InitializeComponent();
        }

        private void FrmEditarProveedores_Load(object sender, EventArgs e)
        {

        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Proveedores Proveedores = new CDO_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();


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

        private void txtNomProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRNCProveedor.Focus();
                e.Handled = true;
            }
        }

        private void txtRNCProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDirecProveedor.Focus();
                e.Handled = true;
            }
        }

        private void txtDirecProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                mtxtTelProveedor.Focus();
                e.Handled = true;
            }
        }

        private void mtxtTelProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmailProveedor.Focus();
                e.Handled = true;
            }
        }

        private void txtEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEditar.Focus();
                e.Handled = true;
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }
        public override void Editar()
        {

            try
            {
                if (txtCodProveedor.Text == string.Empty || txtNomProveedor.Text == string.Empty || txtCodProveedor.Text == string.Empty ||
                    txtRNCProveedor.Text == string.Empty || txtDirecProveedor.Text == string.Empty || mtxtTelProveedor.Text == string.Empty ||
                    txtEmailProveedor.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ebe Completar todos los campos ", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Proveedor.Id_Proveedor = Convert.ToInt32(txtId_Proveedor.Text.Trim());
                    Proveedor.Codigo = txtNomProveedor.Text.Trim();
                    Proveedor.Nombre = txtNomProveedor.Text.Trim();
                    Proveedor.RNC_Proveedor = txtRNCProveedor.Text.Trim();
                    Proveedor.Direccion = txtDirecProveedor.Text.Trim();
                    Proveedor.Telefono = mtxtTelProveedor.Text.Trim();
                    Proveedor.Email = txtEmailProveedor.Text.Trim();
                   

                    Proveedores.EditarProveedor(Proveedor);
                    MessageBox.Show("El Producto Fue editado Correctamente", "Editar Producto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto no fue editado por : " + ex.Message, "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmEditarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void FrmEditarProveedor_Load_1(object sender, EventArgs e)
        {

        }
    }


}

        
    

