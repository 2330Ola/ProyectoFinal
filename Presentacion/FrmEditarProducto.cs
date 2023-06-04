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
    public partial class FrmEditarProducto : FormBase
    {
        public FrmEditarProducto(FrmProductos productos)
        {
            InitializeComponent();
        }

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {

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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

     

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public override void Editar()
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
                    Producto.Id_Productos = Convert.ToInt32(txtId_Producto.Text.Trim());
                    Producto.Codigo = txtCodProducto.Text.Trim();
                    Producto.Nombre = txtNomProducto.Text.Trim();
                    Producto.Descripcion = txtDesProducto.Text.Trim();
                    Producto.Presentacion = txtPresProducto.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = comboBox1.Text.Trim();

                    Productos.EditarProducto(Producto);
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

 
        

       
    }

}

