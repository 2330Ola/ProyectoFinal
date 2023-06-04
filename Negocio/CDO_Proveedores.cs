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
    public class CDO_Proveedores
    {
        CD_Proveedores ObjProveedores = new CD_Proveedores();

        //Metodo que permite agregar Proveedor a la base de datos

        public void AgregarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.AgregarProveedor(Proveedores);
        }
        public void EditarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.EditarProveedor(Proveedores);
        }


        public void EliminarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.EliminarProveedor(Proveedores);
        }

        public DataTable Buscar_Proveedor_Codigo(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Proveedor_Codigo(Proveedores);
        }

        public DataTable Buscar_Proveedor_Nombre(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Proveedor_Nombre(Proveedores);
        }

        public DataTable Buscar_Proveedor_RNC_Proveedor(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Proveedor_RNC_Proveedor(Proveedores);
        }

    }
}
