using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        // the list of adjacent vertices and weights
        public Dictionary<Vertex,List<Vertex>> AdjacencyList { get; set; }
        public Dictionary<(Vertex, Vertex), double> WeightList { get; set; }

        /// <summary>
        /// Creates a new graph instance with new adjacency list and weight list
        /// </summary>
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex, List<Vertex>>();
            WeightList = new Dictionary<(Vertex, Vertex), double>();
        }

        /// <summary>
        /// Adds a vertex to the list
        /// </summary>
        /// <param name="vertex">the vertex to add</param>
        public void AddVertex(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
        }

        /// <summary>
        /// Adds a directed edge, only one direction has a weight
        /// </summary>
        /// <param name="vertexStart">the starting edge</param>
        /// <param name="vertexEnd">the end edge</param>
        /// <param name="weight">the weight of the edge</param>
        public void AddDirectedEdge(Vertex vertexStart, Vertex vertexEnd, double weight = 1.0)
        {
            WeightList.Add((vertexStart, vertexEnd), weight);
            AdjacencyList[vertexStart].Add(vertexEnd);
        }

        /// <summary>
        /// Adds an undirected edge by calling the add directed edge
        /// </summary>
        /// <param name="vertexOne">One edge</param>
        /// <param name="vertexTwo">the second edge</param>
        /// <param name="weight">the weight in between</param>
        public void AddUndirectedEdge(Vertex vertexOne, Vertex vertexTwo, double weight = 1.0)
        {
            AddDirectedEdge(vertexOne, vertexTwo, weight);
            AddDirectedEdge(vertexTwo, vertexOne, weight);
        }

        /// <summary>
        /// Returns a list of all the vertices
        /// </summary>
        /// <returns>The list of vertices</returns>
        public List<Vertex> GetVertices()
        {
            return new List<Vertex>(AdjacencyList.Keys);
        }

        /// <summary>
        /// Returns all the neighbors of the target vertex
        /// </summary>
        /// <param name="vertex">The target vertex</param>
        /// <returns></returns>
        public List<Vertex> GetNeighbors(Vertex vertex)
        {
            return AdjacencyList.GetValueOrDefault(vertex);
        }

        /// <summary>
        /// returns the amount of vertices
        /// </summary>
        /// <returns>the count of all of the vertices</returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }
    }
}
