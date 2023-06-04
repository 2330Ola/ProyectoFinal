using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Proveedores
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;

        SqlDataAdapter Da;
        DataTable Dt;

        //Metodo para agregar un Proveedores a la base de datos

        public void AgregarProveedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("AgregarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Proveedor", Proveedores.RNC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        public void EditarProveedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("EditarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RNC_Proveedor", Proveedores.RNC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Proveedores.Id_Proveedor));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void EliminarProveedor(CE_Proveedores Proveedores)
        {
            
            Cmd = new SqlCommand("EliminarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Proveedores.Id_Proveedor));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
            
        }
        //Metodo que permite Buscar Proveedores por el codigo
        public DataTable Buscar_Proveedor_Codigo(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Proveedor_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Metodo que permite Buscar Proveedores por el Nombre
        public DataTable Buscar_Proveedor_Nombre(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Proveedor_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Metodo que permite Buscar Proveedor por el RNC_Proveedor
        public DataTable Buscar_Proveedor_RNC_Proveedor(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("RNC_Proveedor");
            Cmd = new SqlCommand("Buscar_Proveedor_RNC_Proveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
