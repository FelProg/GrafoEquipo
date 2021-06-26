using System;
using System.Collections.Generic;
using System.Text;

namespace GrafosE1
{
    class Vertice
    {
        Nodo VerticeInicial;
        Nodo VerticeActual;
        

        public Vertice()
        {
            VerticeInicial = new Nodo();
            
        }

        public void AgregarNodoVertice(string dato)
        {
            Nodo nuevoVertice = new Nodo(dato);
            VerticeInicial = nuevoVertice;
            
        }

        public void AgregarAdyacente(string dato)
        {
            VerticeActual = VerticeInicial;

            while (VerticeActual.Adyacente != null)
            {
                VerticeActual = VerticeActual.Adyacente;
            }

            Nodo nuevoVertice = new Nodo(dato);
            VerticeActual.Adyacente = nuevoVertice;
        }

        public string ImprimirVertices()
        {
            string enlaces = "";
            string indice = VerticeInicial.Dato;

            VerticeActual = VerticeInicial;

            while (VerticeActual.Adyacente != null)
            {
                VerticeActual = VerticeActual.Adyacente;
                enlaces += $"{indice} -> {VerticeActual.Dato}\n";
            }

            return enlaces;
        }
    }        
}
          
            