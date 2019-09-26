using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Cp { get; set; }
        public bool AceptoTerminos { get; set; }
    }
}
