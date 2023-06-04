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

namespace Presentacion
{
    public partial class FrmAgregarProducto : FormBase
    {
        public FrmAgregarProducto(FrmProductos productos)
        {
            InitializeComponent();

        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDO_Productos Productos = new CDO_Productos();
        CE_Productos Producto = new CE_Productos();


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            txtCodProducto.Text = "Prod" + Procedimientos.GenerarCodigo("Productos");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDesProducto.Focus();
                e.Handled = true;
            }
        }

        private void txtDesProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPresProducto.Focus();
                e.Handled = true;
            }
        }

        private void txtPresProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVenta.Focus();
                e.Handled = true;
            }
        }
        private void txtCostoUnitario_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(txtCostoUnitario);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                comboBox1.Focus();
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(txtPrecioVenta);
        }


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
                e.Handled = true;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
         }
            public override bool Guardar()
        {

            try
            {
                if (txtCodProducto.Text == string.Empty || txtNomProducto.Text == string.Empty || txtCodProducto.Text == string.Empty ||
                    txtDesProducto.Text == string.Empty || txtCostoUnitario.Text == string.Empty || txtPrecioVenta.Text == string.Empty ||
                    comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ebe Completar todos los campos ", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } 
                else
                {
                    Producto.Codigo = txtCodProducto.Text.Trim();
                    Producto.Nombre = txtNomProducto.Text.Trim();
                    Producto.Descripcion = txtDesProducto.Text.Trim();
                    Producto.Presentacion = txtPresProducto.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = comboBox1.Text.Trim();

                   Productos.AgreagrProducto(Producto);
                    MessageBox.Show("El Producto Fue Agregado Correctamente", "Agregar Producto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    txtNomProducto.Focus();
                    Agregar();
                    return true;

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("El Producto no fue agregado por : " + ex.Message, "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
