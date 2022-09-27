using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion cn = new Conexion();

        //Insertar puestos
        public void funInsertarPuesto(string Id, string Nombre, int estado)
        {
            string cadena = "INSERT INTO" +
            " puesto VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado + ");";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funModificarP(string Id, string Nombre, int estado)
        {
            string cadena = "UPDATE puesto set codigo_puesto ='" + Id
              + "',nombre_puesto ='" + Nombre + "',estatus_puesto = '" + estado + "'  where codigo_puesto= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminarP(string Id)
        {
            string cadena = "delete from puesto where codigo_puesto ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Insertar Empleados
        public void funInsertarEmpleado(string Id, string Nombre, string puesto, string departamento, float sueldo, string status)
        {
            string cadena = "INSERT INTO" +
            " empleado VALUES (" + "'" + Id + "', '" + Nombre + "' , '" + puesto +"', '"+ departamento + "'," + sueldo + ",'"+ status +"');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funModificarE(string Id, string Nombre, string puesto, string departamento, float sueldo, string status)
        {
            string cadena = "UPDATE empleado set codigo_empleado ='" + Id
              + "',nombre_empleado ='" + Nombre 
              + "',codigo_puesto = '" + puesto
              + "',codigo_departamento = '" + departamento
              + "',sueldo_empleado = '" + sueldo
              + "',estatus_empleado = '" + status
             
              + "'  where codigo_empleado= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminarE(string Id)
        {
            string cadena = "delete from empleado where codigo_empleado ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Insertar Encabezado

        public void funInsertarEncabezado(string Id, string fechaI, string fechaF, int status)
        {
            string cadena = "INSERT INTO" +
            " nominaE VALUES (" + "'" + Id + "', '" + fechaI + "' , '" + fechaF + "'," + status + ");";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funInsertarDetalle(string Id, string empleado, string concepto, float valor)
        {
            string cadena = "INSERT INTO" +
            " nominaD VALUES (" + "'" + Id + "', '" + empleado + "' , '" + concepto + "'," + valor + ");";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
    }
}
