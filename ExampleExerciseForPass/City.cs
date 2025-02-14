using System.Collections.Concurrent;

namespace ExampleExerciseForPass
{
    internal class City
    {

        public ConcurrentBag<double> temperaturesList;
        public double minTemp;
        public double maxTemp;
        public string name;

        public City(int cityNumber)
        {
            name = "City " + cityNumber;
            temperaturesList = new ConcurrentBag<double>();
            GenerateRandomTemperatures();
        }

        private void GenerateRandomTemperatures()
        {
            Parallel.For(0, 365, i =>
            {
                double temp = Random.Shared.NextDouble() * 40 - 10;
                temp = Math.Round(temp, 2);
                temperaturesList.Add(temp);

            });
        }
    }
}
