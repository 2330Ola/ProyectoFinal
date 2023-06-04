using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CDO_Cliente
    {
        CD_Cliente objClientes = new CD_Cliente();

        //Metodo que permite agregar Proveedor a la base de datos

        public void AgregarCliente(CE_Cliente Clientes)
        {
            objClientes.AgregarCliente(Clientes);
        }
        public void EditarCliente(CE_Cliente Clientes)
        {
            objClientes.EditarCliente(Clientes);
        }


        public void EliminarCliente(CE_Cliente Clientes)
        {
            objClientes.EliminarCliente(Clientes);
        }


    }
}


    

