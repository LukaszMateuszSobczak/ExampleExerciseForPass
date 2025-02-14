namespace ExampleExerciseForPass
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Data data = new Data();

            Console.Clear();
            foreach (var item in data.cities)
            {
                Console.WriteLine("Data for " + item.name);
                Console.WriteLine("=====================================================================");
                foreach (var tmp in item.temperaturesList)
                {
                    Console.Write(tmp + ", ");

                }
                Console.WriteLine();
                Console.WriteLine("=====================================================================");

                Console.WriteLine("Min temp: " + item.minTemp);
                Console.WriteLine("Max temp: " + item.maxTemp);
                Console.WriteLine();
            }


        }
    }
}
