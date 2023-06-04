using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
    public class CDO_Productos
    {
        CD_Productos ObjProductos = new CD_Productos();

        //Metodo que permite agregar producto a la base de datos

        public void AgreagrProducto(CE_Productos Productos)
        {
            ObjProductos.AgregarProducto(Productos);
        }
        public void EditarProducto(CE_Productos Productos)
        {
            ObjProductos.EditarProducto(Productos);
        }


        public void EliminarProducto(CE_Productos Productos)
        {
            ObjProductos.EliminarProducto(Productos);
        }

        public DataTable Buscar_Producto_Codigo(CE_Productos Productos)
        {
           return ObjProductos.Buscar_Producto_Codigo(Productos);
        }

        public DataTable Buscar_Producto_Nombre(CE_Productos Productos)
        {
           return ObjProductos.Buscar_Producto_Nombre(Productos);
        }

        public  DataTable Buscar_Producto_Descripcion(CE_Productos Productos)
        {
            return ObjProductos.Buscar_Producto_Descripcion(Productos);
        }
    }
}
