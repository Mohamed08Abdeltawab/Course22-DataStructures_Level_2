using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GraphImplementationList.Graph;

namespace GraphImplementationList
{
    class Graph
    {
        public enum enGraphDirectionType { Directed, unDirected }

        public Dictionary<string, List<Tuple<string, int>>> _adjacencyList;

        private Dictionary<string, int> _vertexDictionary;

        private int _numberOfVertices;

        private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;

        public Graph(List<string> vertices, enGraphDirectionType graphDirectionType)
        {
            _GraphDirectionType = graphDirectionType;

            _adjacencyList = new Dictionary<string, List<Tuple<string, int>>>();//init the adjacency list

            _numberOfVertices = vertices.Count;

            _vertexDictionary = new Dictionary<string, int>();

            for (int i = 0; i < vertices.Count; i++)
            {
                _vertexDictionary.Add(vertices[i], i);//fill the vertex dictionary with the vertices and their corresponding index
                _adjacencyList.Add(vertices[i], new List<Tuple<string, int>>());//fill the adjacency list with the vertices and an empty list of adjacent vertices
            }
        }

        public void AddEdge(string source, string destination, int weight)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                _adjacencyList[source].Add(new Tuple<string, int>(destination, weight));

                if (_GraphDirectionType == enGraphDirectionType.unDirected)
                {
                    _adjacencyList[destination].Add(new Tuple<string, int>(source, weight));
                }
            }
            else
            {
                Console.WriteLine($"\n\nIgnored: Invalid vertices. {source} ==> {destination}\n\n");
            }
        }

        public void RemoveEdge(string source, string destination)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                _adjacencyList[source].RemoveAll(edge => edge.Item1 == destination);//any edge that has the destination as the first item in the tuple will be removed from the adjacency list of the source vertex
                if (_GraphDirectionType == enGraphDirectionType.unDirected)
                {
                    _adjacencyList[destination].RemoveAll(edge => edge.Item1 == source);//any edge that has the source as the first item in the tuple will be removed from the adjacency list of the destination vertex
                }
            }
            else
            {
                Console.WriteLine("One or both of the vertices do not exist in the graph.");
            }
        }

        public void DisplayGraph(string message)
        {
            Console.WriteLine(message);
            foreach (var vertex in _adjacencyList)
            {
                Console.Write($"{vertex.Key} => ");
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"({edge.Item1}, {edge.Item2}) ");
                }
                Console.WriteLine();
            }
        }

        public bool IsEdge(string source, string destination)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                return _adjacencyList[source].Any(edge => edge.Item1 == destination);
            }
            else
            {
                Console.WriteLine("One or both of the vertices do not exist in the graph.");
                return false;
            }
        }

        public int GetInDegree(string vertex)
        {
            int inDegree = 0;  // Initialize the indegree count to zero

            // Check if the vertex exists in the map
            if (_vertexDictionary.ContainsKey(vertex))
            {
                // Loop through each vertex in the adjacency list
                foreach (var source in _adjacencyList)
                {
                    // Loop through the edges of the current vertex
                    foreach (var edge in source.Value)//edge is a tuple of (destination, weight)
                    {
                        // If the destination of the edge is the given vertex, increment the indegree
                        if (edge.Item1 == vertex)//if item1 in value of others verteses and that is the vertex we are looking for, then we will increase the indegree by 1
                        {
                            inDegree++;
                        }
                    }
                }
            }

            return inDegree;  // Return the total indegree of the vertex
        }

        public int GetOutDegree(string vertex)
        {
            int outDegree = 0;  // Initialize the outdegree count to zero

            // Check if the vertex exists in the map
            if (_vertexDictionary.ContainsKey(vertex))
            {
                // The outdegree is simply the number of edges in the adjacency list of the vertex
                outDegree = _adjacencyList[vertex].Count;
            }

            return outDegree;  // Return the total outdegree of the vertex
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of vertices with string labels
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

            // Example 1 in Slides: Undirected Graph
            Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

            // Add some edges with default weights=1 between vertices
            graph1.AddEdge("A", "B", 1);
            graph1.AddEdge("A", "C", 1);
            graph1.AddEdge("B", "D", 1);
            graph1.AddEdge("C", "D", 1);
            graph1.AddEdge("B", "E", 1);
            graph1.AddEdge("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph1.DisplayGraph("Adjacency List for Example1 (Undirected Graph):");

            Console.WriteLine("\n------------------------------\n");

            // Example 2 in Slides: Directed Graph
            Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

            // Add some edges with weights between vertices
            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph2.DisplayGraph("Adjacency List for Example2 (Directed Graph):");

            // Get and display the indegree and outdegree of vertex 'D'
            Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));
            Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

            Console.WriteLine("\n------------------------------\n");

            // Example 3 in Slides: Weighted Graph
            Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

            // Add some edges with weights between vertices
            graph3.AddEdge("A", "B", 5);
            graph3.AddEdge("A", "C", 3);
            graph3.AddEdge("B", "D", 12);
            graph3.AddEdge("C", "D", 10);
            graph3.AddEdge("B", "E", 2);
            graph3.AddEdge("D", "E", 7);

            // Display the adjacency list to visualize the graph
            graph3.DisplayGraph("Adjacency List for Example3 (Weighted Graph):");

            // Check if there is an edge between 'A' and 'B' and display the result
            Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));

            // Remove the edge between 'E' and 'D'
            graph3.RemoveEdge("E", "D");

            // Display the updated adjacency list after removing the edge
            graph3.DisplayGraph("After Removing Edge between E and D:");

        }
    }
}
