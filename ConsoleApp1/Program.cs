using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertex> mojaLista = VertexFactory.StworzListeCoord();

            foreach (var c in mojaLista)
            {
                Console.WriteLine(c);
            }
        }
    }
}
