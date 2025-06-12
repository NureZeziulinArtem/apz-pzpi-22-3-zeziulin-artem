using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMaze
{
    public class Maze
    {
        public List<string> Rooms { get; } = new();
        public List<string> Paths { get; } = new();

        public void Show()
        {
            Console.WriteLine("Rooms:");
            foreach (var room in Rooms)
                Console.WriteLine($"- {room}");

            Console.WriteLine("Paths:");
            foreach (var path in Paths)
                Console.WriteLine($"- {path}");
        }
    }
}

