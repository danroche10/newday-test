namespace Diamond
{
	public class Program
	{
		public static void Main()
		{

			try
			{
				string diamond = Diamond.Create('Z');
				Console.WriteLine(diamond);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}	
	}
}