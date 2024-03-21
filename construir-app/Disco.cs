using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construir_app
{
    internal class Disco
    {
        public string Album {get; set;}
        public int CantidadCanciones { get; set;}
        public DateTime FechaLanzamiento { get; set;}
        
        public string UrlImagenTapa { get; set;}
        public Estilo Genero { get; set;}
        public Edicion Edicion { get; set;}

    }
}
