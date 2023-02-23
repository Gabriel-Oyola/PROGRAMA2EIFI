using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tecnicos
    {
        #region Atributos
        private int Dni_Tecnico;

        private string Nombre;

        private string Apellido;

        #endregion

        #region Propiedades
        public int P_Dni
        {
            get { return Dni_Tecnico; }
            set { Dni_Tecnico = value; }
        }

        public string P_Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string p_Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        #endregion

        #region Constructor
        public Tecnicos(int DNI, string nombre, string apellido)
        {
            Dni_Tecnico = DNI;
            Nombre = nombre;
            Apellido = apellido;
        }
        #endregion
    }
}
