using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenWEB.Entitites
{
    public class EstudianteEnt
    {
        public int Consecutivo { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public long Monto { get; set; }
        public int TipoCurso { get; set; }
     

    }
}