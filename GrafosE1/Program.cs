using System;
using System.Collections.Generic;

namespace GrafosE1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertice> Grafo = new List<Vertice>();
            
            Vertice verticeA = new Vertice();

            verticeA.AgregarNodoVertice("a");
            verticeA.AgregarAdyacente("b");
            verticeA.AgregarAdyacente("d");
            verticeA.AgregarAdyacente("n");

            Vertice verticeB = new Vertice();

            verticeB.AgregarNodoVertice("b");
            verticeB.AgregarAdyacente("c");

            Vertice verticeC = new Vertice();

            verticeC.AgregarNodoVertice("c");
            verticeC.AgregarAdyacente("a");
            verticeC.AgregarAdyacente("d");

            Vertice verticeD = new Vertice();

            verticeD.AgregarNodoVertice("d");
            verticeD.AgregarAdyacente("b");

            Grafo.Add(verticeA);
            Grafo.Add(verticeB);
            Grafo.Add(verticeC);
            Grafo.Add(verticeD);

            foreach (var vectores in Grafo)
            {
                Console.WriteLine(vectores.ImprimirVertices());
            }
        }
    }
}

      





