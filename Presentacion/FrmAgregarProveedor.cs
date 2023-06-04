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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmAgregarProveedor : FormBase
    {
        public FrmAgregarProveedor(frmProveedores Proveedores)
        {
            InitializeComponent();
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

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }



        private void GenerarCodigo()
        {
            txtCodProveedor.Text = "Prov" + Procedimientos.GenerarCodigo("Proveedores");
        }



        private void txtNomProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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
                if (txtCodProveedor.Text == string.Empty || txtNomProveedor.Text == string.Empty || txtRNCProveedor.Text == string.Empty ||
                    txtDirecProveedor.Text == string.Empty || mtxtTelProveedor.Text == string.Empty || txtEmailProveedor.Text == string.Empty)
                   
                {
                    MessageBox.Show("Por favor ebe Completar todos los campos ", "Agregar Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Proveedor.Codigo = txtCodProveedor.Text.Trim();
                    Proveedor.Nombre = txtNomProveedor.Text.Trim();
                    Proveedor.RNC_Proveedor = txtRNCProveedor.Text.Trim();
                    Proveedor.Direccion = txtDirecProveedor.Text.Trim();
                    Proveedor.Telefono = mtxtTelProveedor.Text.Trim();
                    Proveedor.Email = txtEmailProveedor.Text.Trim();


                    Proveedores.AgregarProveedor(Proveedor);
                    MessageBox.Show("El Proveedor fue Agregado Correctamente", "Proveedores ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    txtNomProveedor.Focus();
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
