using System.Collections.Concurrent;

namespace ExampleExerciseForPass
{
    internal class Data
    {
        public ConcurrentBag<City> cities;

        public Data()
        {
            cities = new ConcurrentBag<City>();
            GenerateCities();
            Task.WaitAll();
            AnalyzeData();
            Task.WaitAll();
        }

        private void GenerateCities()
        {
            int progress = 0;
            Parallel.For(0, 100, i =>
            {
                cities.Add(new City(i));
                Console.Write($"\rProgress of genarating cities: {progress}%");
                progress += 1;
                Thread.Sleep(500);
            });
        }

        public void AnalyzeData()
        {
            Parallel.ForEach(cities, elem =>
            {
                elem.minTemp = elem.temperaturesList.Min();
                elem.maxTemp = elem.temperaturesList.Max();
            });


        }


    }
}
