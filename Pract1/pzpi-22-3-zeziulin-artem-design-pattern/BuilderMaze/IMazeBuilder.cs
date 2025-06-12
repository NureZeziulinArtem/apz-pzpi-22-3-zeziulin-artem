using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMaze
{
    public interface IMazeBuilder
    {
        void AddRoom(string roomName);
        void AddPath(string fromRoom, string toRoom);
        void Reset();
        Maze GetMaze();
    }
}

