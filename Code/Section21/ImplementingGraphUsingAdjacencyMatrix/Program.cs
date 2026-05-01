using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingGraphUsingAdjacencyMatrix
{
    public enum enGraphDirectionType { Directed, unDirected }

    class Graph
    {
        private int[,] adjacencyMatrix;
        private int numOfVertices;
        private Dictionary<string, int> vertexDictionary;
        enGraphDirectionType graphDirectionType = enGraphDirectionType.unDirected;

        public Graph(List<string> vertices, enGraphDirectionType type)
        {
            graphDirectionType = type;
            numOfVertices = vertices.Count;
            adjacencyMatrix = new int[numOfVertices, numOfVertices];
            vertexDictionary = new Dictionary<string, int>();

            for (int i = 0; i < numOfVertices; i++)
            {
                vertexDictionary[vertices[i]] = i;
            }
        }

        public void AddEdge(string source, string destination, int weight)
        {
            if (vertexDictionary.ContainsKey(source) && vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = vertexDictionary[source];
                int destinationIndex = vertexDictionary[destination];

                adjacencyMatrix[sourceIndex, destinationIndex] = weight;

                if (graphDirectionType == enGraphDirectionType.unDirected)
                {
                    adjacencyMatrix[destinationIndex, sourceIndex] = weight;
                }
            }
            else
            {
                Console.WriteLine("Source or destination vertex does not exist.");
            }
        }



        public void RemoveEdge(string source, string destination)
        {
            if (vertexDictionary.ContainsKey(source) && vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = vertexDictionary[source];
                int destinationIndex = vertexDictionary[destination];

                adjacencyMatrix[sourceIndex, destinationIndex] = 0;
                adjacencyMatrix[destinationIndex, sourceIndex] = 0;

            }
            else
            {
                Console.WriteLine("Source or destination vertex does not exist.");
            }
        }

        public bool IsEdge(string source, string destination)
        {
            if (vertexDictionary.ContainsKey(source) && vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = vertexDictionary[source];
                int destinationIndex = vertexDictionary[destination];
                return adjacencyMatrix[sourceIndex, destinationIndex] != 0;
            }
            return false;
        }


        public void DisplayGraph(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("Adjacency Matrix:");
            Console.Write("\t");
            foreach(var vertex in vertexDictionary)
            {
                Console.Write(vertex.Key + "\t");
            }
            Console.WriteLine();
            foreach(var vertex in vertexDictionary)
            {
                Console.Write(vertex.Key + "\t");
                for (int j = 0; j < numOfVertices; j++)
                {
                    Console.Write(adjacencyMatrix[vertex.Value, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int GetInDegree(string vertex)
        {
            if (vertexDictionary.ContainsKey(vertex))
            {
                int vertexIndex = vertexDictionary[vertex];
                int inDegree = 0;
                for (int i = 0; i < numOfVertices; i++)
                {
                    if (adjacencyMatrix[i, vertexIndex] != 0)//[i, vertexIndex] is destination and [vertexIndex, i] is source
                    {
                        inDegree++;
                    }
                }
                return inDegree;
            }
            return 0;
        }

        public int GetOutDegree(string vertex)
        {
            if (vertexDictionary.ContainsKey(vertex))
            {
                int vertexIndex = vertexDictionary[vertex];
                int outDegree = 0;
                for (int j = 0; j < numOfVertices; j++)
                {
                    if (adjacencyMatrix[vertexIndex, j] != 0)//[i, vertexIndex] is destination and [vertexIndex, i] is source
                    {
                        outDegree++;
                    }
                }
                return outDegree;
            }
            return 0;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                // Create a list of vertices with string labels
                List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };


                //Example 1 in Slides: Undirected Graph
                // Create a new graph object with the specified vertices
                Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

                // Add some edges with default weights=1 between vertices
                graph1.AddEdge("A", "B", 1);
                graph1.AddEdge("A", "C", 1);
                graph1.AddEdge("B", "D", 1);
                graph1.AddEdge("C", "D", 1);
                graph1.AddEdge("B", "E", 1);
                graph1.AddEdge("D", "E", 1);



                // Display the adjacency matrix with weights to visualize the graph
                graph1.DisplayGraph("Adjacency Matrix for Example1 (Undirected Graph):");

                Console.WriteLine("\n------------------------------\n");

                //Example 2 in Slides: Directed Graph
                // Create a new graph object with the specified vertices
                Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

                // Add some edges with weights between vertices
                graph2.AddEdge("A", "A", 1);
                graph2.AddEdge("A", "B", 1);
                graph2.AddEdge("A", "C", 1);
                graph2.AddEdge("B", "E", 1);
                graph2.AddEdge("D", "B", 1);
                graph2.AddEdge("D", "C", 1);
                graph2.AddEdge("D", "E", 1);

                // Display the adjacency matrix with weights to visualize the graph
                graph2.DisplayGraph("Adjacency Matrix for Example2 (Directed Graph):");


                // Get and display the Indegree (number of edges) of vertex 'D'
                Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));

                // Get and display the Outdegree (number of edges) of vertex 'D'
                Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

                Console.WriteLine("\n------------------------------\n");

                //Example 3 in Slides: Weighted Graph
                // Create a new graph object with the specified vertices
                Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

                // Add some edges with weights between vertices
                graph3.AddEdge("A", "B", 5);
                graph3.AddEdge("A", "C", 3);
                graph3.AddEdge("B", "D", 12);
                graph3.AddEdge("C", "D", 10);
                graph3.AddEdge("B", "E", 2);
                graph3.AddEdge("D", "E", 7);

                // Display the adjacency matrix with weights to visualize the graph
                graph3.DisplayGraph("Adjacency Matrix for Example3 (Weighted Graph):");


                // Check if there is an edge between 'A' and 'B' and display the result
                Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));


                // Check if there is an edge between 'A' and 'B' and display the result
                Console.WriteLine("\nIs there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));


                // Check if there is an edge between 'A' and 'A' and display the result
                Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

                // Check if there is an edge between 'A' and 'A' and display the result
                Console.WriteLine("\nIs there an edge between A and A in Graph3? " + graph3.IsEdge("A", "A"));


                // Get and display the Indegree (number of edges) of vertex 'A'
                Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInDegree("A"));

                // Get and display the Indegree (number of edges) of vertex 'A'
                Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutDegree("A"));

                Console.WriteLine("\n------------------------------\n");


                Console.WriteLine("\nRemoveing Edge between E and D:");
                // Remove the edge between 'E' and 'D'
                graph3.RemoveEdge("E", "D");

                // Display the updated adjacency matrix after removing the edge
                graph3.DisplayGraph("After Removeing Edge between E and D:");


                // Check if there is an edge between 'A' and 'A' and display the result
                Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));


            }
        }
    }
}
