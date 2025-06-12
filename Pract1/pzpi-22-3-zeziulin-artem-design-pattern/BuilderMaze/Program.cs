namespace BuilderMaze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMazeBuilder builder = new SimpleMazeBuilder();

            builder.AddRoom("Entrance");
            builder.AddRoom("Hallway");
            builder.AddRoom("Treasure Room");
            builder.AddPath("Entrance", "Hallway");
            builder.AddPath("Hallway", "Treasure Room");

            Maze maze = builder.GetMaze();
            maze.Show();
        }
    }
}

