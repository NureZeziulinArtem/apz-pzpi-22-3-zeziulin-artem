using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMaze
{
    public class SimpleMazeBuilder : IMazeBuilder
    {
        private Maze _maze = new();

        public void AddRoom(string roomName)
        {
            if (!_maze.Rooms.Contains(roomName))
            {
                _maze.Rooms.Add(roomName);
            }
        }

        public void AddPath(string fromRoom, string toRoom)
        {
            if (_maze.Rooms.Contains(fromRoom) && _maze.Rooms.Contains(toRoom))
            {
                _maze.Paths.Add($"{fromRoom} <--> {toRoom}");
            }
            else
            {
                Console.WriteLine($"Cannot create path: one or both rooms do not exist.");
            }
        }

        public Maze GetMaze()
        {
            return _maze;
        }

        public void Reset()
        {
            _maze = new();
        }
    }
}

