using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        //Controlador Puestos

        public void insertarPuesto(string Id, string Nombre, int Estado)
        {
            sn.funInsertarPuesto(Id, Nombre, Estado);
        }

        public void modificarPuesto(string Id, string Nombre, int Estado)
        {
            sn.funModificarP(Id, Nombre, Estado);
        }

        public void eliminarPuesto(string id)
        {
            sn.funEliminarP(id);
        }

        //Controlador Empleado

        public void insertarEmpleado(string Id, string Nombre, string puesto, string departamento, float sueldo, string status)
        {
            sn.funInsertarEmpleado(Id, Nombre, puesto, departamento, sueldo, status);
        }

        public void modificarEmpleado(string Id, string Nombre, string puesto, string departamento, float sueldo, string status)
        {
            sn.funModificarE(Id, Nombre, puesto, departamento, sueldo, status);
        }

        public void eliminarEmpleado(string id)
        {
            sn.funEliminarE(id);
        }

        //Controlador Nomina
        public void insertarEncabezado(string Id, string fechaInicial, string fechaFinal, int status  )
        {
            sn.funInsertarEncabezado(Id, fechaInicial, fechaFinal, status);
        }
        public void insertarDetalle(string Id, string fechaInicial, string fechaFinal, float valor)
        {
            sn.funInsertarDetalle(Id, fechaInicial, fechaFinal, valor);
        }
    }
}
