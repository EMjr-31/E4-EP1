using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_EP1
{
    class Empleado
    {
        ///Propiedades
        string nombre;
        string apellido;
        string cargo;
        int horas;
        double sueldo;
        double sueldoliquido;
        double iss;
        double afp;
        double renta;
        ///Metodos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Horas { get => horas; set => horas = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public double Sueldoliquido { get => sueldoliquido; set => sueldoliquido = value; }
        public double Iss { get => iss; set => iss = value; }
        public double Afp { get => afp; set => afp = value; }
        public double Renta { get => renta; set => renta = value; }
    }
}
