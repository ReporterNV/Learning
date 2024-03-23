
namespace CSharp
{
	internal class Program{
		static void Main(string[] args){
			Console.WriteLine("Hello, World!");
			char [,] map = null;
			string[]file = File.ReadAllLines("map.txt");
			Console.WriteLine(file[0]);

		}
	}
}
