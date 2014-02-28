using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1WEB2.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cometario { get; set; }
        public string Fecha { get; set; }
    }
}