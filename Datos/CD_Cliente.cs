using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Cliente
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;

        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo para agregar un Proveedores a la base de datos

        public void AgregarCliente(CE_Cliente Clientes)
        {
            Cmd = new SqlCommand("AgregarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Cliente", Clientes.RNC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        public void EditarCliente(CE_Cliente Clientes)
        {
            Cmd = new SqlCommand("EditarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Cliente", Clientes.RNC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));
            Con.Cerrar();
            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", Clientes.Id_Cliente));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void EliminarCliente(CE_Cliente Clientes)
        {

            Cmd = new SqlCommand("EliminarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", Clientes.Id_Cliente));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
    }
    

}
