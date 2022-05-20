using System;
using System.Collections.Generic;

namespace T06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(input);
            
            while (songs.Count > 0)
            {
                string command = Console.ReadLine();
                

                string[] commands = command.Split(' ');

                if (commands[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if(commands[0] == "Add")
                {
                    string currSong = command.Substring(4, command.Length - 4);
                    if (songs.Contains(currSong))
                    {
                        Console.WriteLine($"{currSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(currSong);
                    }
                }
                else if(commands[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                }
            }
        }
    }
}
