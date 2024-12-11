using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1Progra3QUIZ.Controllers;

namespace WebApplication1Progra3QUIZ.Models
{
    public class MOVIMIENTOS
    {
        public int ID { get; set; }
        public int IdViajero { get; set; }
        public DateTime Fecha { get; set; }
        public string Destino { get; set; }
        public string Origen { get; set; }
        public string TipoSolicitud { get; set; }
        public int IdUsuario { get; set; }

      
    }
}