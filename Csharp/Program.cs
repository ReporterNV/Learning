
namespace CSharp
{
	internal class Program{
		static void Main(string[] args){
			Console.WriteLine("Hello, World!");
			char [,] map = ReadMap("map.txt");
			DrawMap(map);
			
		}

		private static void DrawMap(char[,] map)
		{
			for(int y = 0; y < map.GetLength(1); y++){
				for(int x = 0; x < map.GetLength(0); x++)
					Console.Write(map[x,y]);
				Console.WriteLine();
			}


		}

		private static char[,] ReadMap(string path)
		{
			string[]file = File.ReadAllLines("map.txt");
			char [,] map = new char[GetMaxLengthOfLine(file), file.Length];
			Console.WriteLine("INIT MAP {0:D} {0:D}", file[0].Length, file.Length);
			for(int y = 0; y < GetMaxLengthOfLine(file); y++)
				for(int x = 0; x < file.Length; x++)
					map[x, y] = file[y][x];
			return map;
		}

		private static int GetMaxLengthOfLine(string[] lines)
		{
			int MaxLength = lines.Length;
			foreach(var line in lines)
				if(line.Length > MaxLength)
					MaxLength = line.Length;
			return MaxLength;
		}
	}
}
