using System;
using System.Collections.Generic;
using System.Text;

namespace GrafosE1
{
    
    class Nodo
    {
        public string Dato { get; set; }
        public Nodo Adyacente { get; set; }
        public Nodo(string dato="", Nodo adyacente=null)
        {
            Dato = dato;
            Adyacente = adyacente;
        }
    }
}
