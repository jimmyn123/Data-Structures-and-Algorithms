using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;

namespace GraphTest
{
    public class GraphTest
    {
        /// <summary>
        /// Tests adding the vertex
        /// </summary>
        /// <param name="count">the amount of vertices to add</param>
        [Theory]
        [InlineData(1)]
        [InlineData(12)]
        [InlineData(7)]
        public void TestAddVertex(int count)
        {
            Graph myGraph = new Graph();
            for(int i = 0; i < count; i++)
            {
                myGraph.AddVertex(new Vertex("A"));
            }

            Assert.True(myGraph.AdjacencyList.Count == count);
        }

        /// <summary>
        /// Tests to see if the proper size is returned
        /// </summary>
        /// <param name="count">the amount of vertices</param>
        [Theory]
        [InlineData(1)]
        [InlineData(12)]
        [InlineData(7)]
        public void TestSize(int count)
        {
            Graph myGraph = new Graph();
            for(int i = 0; i < count; i++)
            {
                myGraph.AddVertex(new Vertex("A"));
            }

            Assert.True(myGraph.Size() == count);
        }

        /// <summary>
        /// Tests adding edges
        /// </summary>
        /// <param name="valueOne">the first vertex</param>
        /// <param name="valueTwo">the second vertex of the edge</param>
        /// <param name="valueThree">has no edge</param>
        [Theory]
        [InlineData("A", "B", "C")]
        [InlineData("B", "A", "C")]
        [InlineData("C", "A", "B")]
        public void TestAddEdge(string valueOne, string valueTwo, string valueThree)
        {
            Vertex vertexOne = new Vertex(valueOne);
            Vertex vertexTwo = new Vertex(valueTwo);
            Vertex vertexThree = new Vertex(valueThree);

            Graph myGraph = new Graph();
            myGraph.AddVertex(vertexOne);
            myGraph.AddVertex(vertexTwo);
            myGraph.AddVertex(vertexThree);

            myGraph.AddUndirectedEdge(vertexOne, vertexTwo);

            Assert.True(myGraph.GetNeighbors(vertexOne).Contains(vertexTwo) && myGraph.GetNeighbors(vertexThree).Count == 0);
        }

        /// <summary>
        /// Tests the list to make sure it returns all of the vertices
        /// </summary>
        /// <param name="valueOne">value of the first vertex</param>
        /// <param name="valueTwo">value of the second vertex</param>
        /// <param name="valueThree">value of the third vertex</param>
        [Theory]
        [InlineData("A", "B", "C")]
        [InlineData("B", "A", "C")]
        [InlineData("C", "A", "B")]
        public void TestGetVertices(string valueOne, string valueTwo, string valueThree)
        {
            Vertex vertexOne = new Vertex(valueOne);
            Vertex vertexTwo = new Vertex(valueTwo);
            Vertex vertexThree = new Vertex(valueThree);

            Graph myGraph = new Graph();
            myGraph.AddVertex(vertexOne);
            myGraph.AddVertex(vertexTwo);
            myGraph.AddVertex(vertexThree);

            List<Vertex> vertices = myGraph.GetVertices();

            Assert.True(vertices.Contains(vertexOne) && vertices.Contains(vertexTwo) && vertices.Contains(vertexThree));
        }
    }
}
