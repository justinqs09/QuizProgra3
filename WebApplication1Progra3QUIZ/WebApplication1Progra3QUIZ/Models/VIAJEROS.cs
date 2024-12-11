using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApplication1Progra3QUIZ.Controllers;

namespace WebApplication1Progra3QUIZ.Models
{
    public class VIAJEROS
    {
        
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Segundo { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public DateTime FechaNacimiento { get; set; } 
            public string Nacionalidad { get; set; }
            public string CorreoElectronico { get; set; }
            public string Genero { get; set; }
            public string Telefono { get; set; }
       

    }
}