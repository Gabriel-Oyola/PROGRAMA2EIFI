using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NegTecnicos
    {
        AdminisTecnicos DatosObjTecnicos = new AdminisTecnicos();

        public int abmTecnicos(string accion, Tecnicos objProfesional)
        {
            return DatosObjTecnicos.abmTecnicos(accion, objProfesional);
        }
        public DataSet listadoTecnicos(string cual)
        {
            return DatosObjTecnicos.listadoTecnicos(cual);
        }
    }
}
