using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class VertexFactory
    {
        public static List<Vertex> StworzListeCoord()
        {
            var lista = new List<Vertex>
        {
            new Vertex(1.0, 2.0, 3.0),
            new Vertex(4.0, 5.0, 6.0),
            new Vertex(7.0, 8.0, 9.0)
        };

            return lista;
        }
    }
}
