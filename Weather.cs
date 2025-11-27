namespace SWE201_235060003;
 public class Weather
    {
        public string City { get; set; }
        public int Temperature { get; set; }

        public Weather() { }

        public Weather(string city, int temperature)
        {
            City = city;
            Temperature = temperature;
        }

        public string Describe()
        {
            return $"{City} bugün {Temperature}°C sıcaklığında.";
        }

        public override string ToString()
        {
            return $"Weather({City}, {Temperature})";
        }
    }

