namespace Assignment_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading in colours

            List <string> colours = new List<string> { "Red", "Yellow", "Violet", "Green", "Orange" };
            for (int i = 0; i < colours.Count; i++)
            {
                Console.WriteLine(colours[i]);
            }

            // Random Numbers

            int numbersAmount, min, max;
            Console.WriteLine("Please enter how many numbers you need:");
            numbersAmount = Int32(Console.ReadLine());
            List<int> numbers = new List<int> {  };
        }
    }
}
