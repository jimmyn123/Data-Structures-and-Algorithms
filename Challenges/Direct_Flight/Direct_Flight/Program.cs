using Graphs.Classes;
using System;

namespace Direct_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Added vertices: Seattle, LA, NYC, Vancouver");

            Vertex v1 = new Vertex("Seattle");
            Vertex v2 = new Vertex("LA");
            Vertex v3 = new Vertex("NYC");
            Vertex v4 = new Vertex("Vancouver");

            Graph routeMap = new Graph();

            routeMap.AddVertex(v1);
            routeMap.AddVertex(v2);
            routeMap.AddVertex(v3);
            routeMap.AddVertex(v4);

            routeMap.AddUndirectedEdge(v1, v2, 300.0);
            routeMap.AddUndirectedEdge(v1, v3, 500.0);
            routeMap.AddUndirectedEdge(v1, v4, 80.0);
            routeMap.AddUndirectedEdge(v2, v3, 600.0);

            Console.WriteLine("Created False Array: La, Vancouver");
            Console.WriteLine("Created True Array: NYC, Seattle, Vancouver");
            Vertex[] arrayFalse = { v4, v2 };
            Vertex[] arrayTrue = { v3, v1, v4 };

            Console.WriteLine("Testing false array, should return: False, 0.0");
            (bool, double) result = DirectFlight(routeMap, arrayFalse);
            Console.WriteLine("Direct flight: " + result.Item1 + ", Price: " + result.Item2);

            (bool, double) resultTwo = DirectFlight(routeMap, arrayTrue);
            Console.WriteLine("Testing True array, should return: True, 580.0");
            Console.WriteLine("Direct flight: " + resultTwo.Item1 + ", Price: " + resultTwo.Item2);

        }

        public static (bool, double) DirectFlight(Graph routeMap, Vertex[] cities)
        {
            double total = 0.0;
            for (int i = 0; i < cities.Length - 2; i++)
            {
                double weight = (double)routeMap.WeightList[(cities[i], cities[i + 1])];
                if (weight > 0)
                {
                    total += weight;
                }
                else
                {
                    return (false, 0);
                }
            }
            return (true, total);
        }
    }
}
