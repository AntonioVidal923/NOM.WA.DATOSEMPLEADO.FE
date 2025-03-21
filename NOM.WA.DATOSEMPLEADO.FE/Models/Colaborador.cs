using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NOM.WA.DATOSEMPLEADO.FE.Models
{
    public class Colaborador
    {
        public int IdColaborador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Profesion { get; set; }
        public string Estado_Civil { get; set; }
    }
}