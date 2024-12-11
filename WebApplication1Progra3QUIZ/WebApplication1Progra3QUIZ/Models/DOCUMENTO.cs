using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1Progra3QUIZ.Controllers;

namespace WebApplication1Progra3QUIZ.Models
{
    public class DOCUMENTO
    {
        public int ID { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int EstadoID { get; set; }
        public int IdViajero { get; set; }

        // Relaciones
        

    }
}