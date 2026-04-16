
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a linked list
        LinkedList<string> songs = new LinkedList<string>();

        // 2. Add elements
        songs.AddLast("Song A"); // Adds to the end
        songs.AddFirst("Song B"); // Adds to the beginning
        songs.AddFirst("Song C"); // Adds to the beginning
        songs.AddFirst("Song D"); // Adds to the beginning
        songs.AddFirst("Song E"); // Adds to the beginning
        songs.AddBefore(songs.First, "Song F"); // Adds before the first node
        Console.WriteLine("First Node: " + songs.First.Value);
        Console.WriteLine("Last Node: " + songs.Last.Value);
        Console.WriteLine("After First Node: " + songs.First.Next.Value);
        Console.WriteLine("After after First Node: " + songs.First.Next.Next.Value);
        Console.WriteLine("Before last Node: " + songs.Last.Previous?.Value);
        Console.WriteLine("Last Node: " + songs.Last.Value);


        // 3. Find a specific node
        LinkedListNode<string> nodeA = songs.Find("Song A");

        // 4. Insert before or after a specific node
        if (nodeA != null)
        {
            songs.AddAfter(nodeA, "Song C");
        }

        // 5. Display the list
        foreach (var song in songs)
        {
            // Output: Song B -> Song A -> Song C
            Console.WriteLine(song);
        }
    }
}