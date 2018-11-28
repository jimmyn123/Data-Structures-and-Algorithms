using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates 3 new vertices
            Vertex vertexA = new Vertex("A");
            Vertex vertexB = new Vertex("B");
            Vertex vertexC = new Vertex("C");

            // creates the graph
            Graph myGraph = new Graph();
            myGraph.AddVertex(vertexA);
            myGraph.AddVertex(vertexB);
            myGraph.AddVertex(vertexC);
            
            // gets a list of all the vertices
            List<Vertex> vertices = myGraph.GetVertices();

            Console.WriteLine("Getting a list of all vertices, should return A, B, C");
            foreach(Vertex v in vertices)
            {
                Console.WriteLine(v.value.ToString());
            }

            // adds the edges
            myGraph.AddUndirectedEdge(vertexA, vertexB);
            myGraph.AddUndirectedEdge(vertexB, vertexC);

            Console.WriteLine("Added edges from B to A and B to C.");
            Console.WriteLine("Testing to see neighbors of B, should return A and C.");
            List<Vertex> neighbors = myGraph.GetNeighbors(vertexB);
            foreach (Vertex v in neighbors)
            {
                Console.WriteLine(v.value.ToString());
            }

            // tests size
            Console.WriteLine("Testing size, should return 3.");
            Console.WriteLine(myGraph.Size());
        }
    }
}
