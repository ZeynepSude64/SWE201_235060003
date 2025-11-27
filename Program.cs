using System;
using System.Collections.Generic;


namespace SWE201_235060003
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Weather> weatherList = new List<Weather>();


            Console.Write("Kaç şehir gireceksiniz: ");
            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}. Şehir adı: ");
                string city = Console.ReadLine();


                Console.Write($"{city} sıcaklık değeri (°C): ");
                int temp = int.Parse(Console.ReadLine());


                Weather w = new Weather(city, temp);
                weatherList.Add(w);
            }


            Console.WriteLine("\nGirilen Şehirler ve Sıcaklıkları:");
            foreach (var w in weatherList)
            {
                Console.WriteLine(w.Describe());
            }


            // Ortalama sıcaklık hesaplama
            double average = 0;
            foreach (var w in weatherList)
            {
                average += w.Temperature;
            }
            average /= weatherList.Count;


            Console.WriteLine($" Ortalama sıcaklık: { average}°C");
        

// En sıcak şehir
Weather hottest = weatherList[0];
            foreach (var w in weatherList)
            {
                if (w.Temperature > hottest.Temperature)
                    hottest = w;
            }


            Console.WriteLine($"En sıcak şehir: {hottest.City} ({hottest.Temperature}°C)");
        }
    }
}
