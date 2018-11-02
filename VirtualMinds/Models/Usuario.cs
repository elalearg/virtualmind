using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualMinds.Models
{
    public class Usuario
    {
        public int idUser { get; set; }
        public string usuario { get; set; }
        public string Password { get; set; }
        public string  Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        
    }

 
}