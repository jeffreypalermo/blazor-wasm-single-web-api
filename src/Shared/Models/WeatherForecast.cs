namespace WebAssemblyWithAPI.Shared.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int Id { get; set; }
    }

    public class WeatherForecastData
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        private readonly WeatherForecast[]  AllForecasts;
        public WeatherForecastData()
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();
            for (int i = 1; i <= 5; i++)
            {
                WeatherForecast forecast = new WeatherForecast()
                    { Date = DateTime.Now.AddDays(i), Id = i, Summary = Summaries[Random.Shared.Next(Summaries.Length)], TemperatureC = Random.Shared.Next(-20, 55) };
                forecasts.Add(forecast);
            }

            AllForecasts = forecasts.ToArray();
        }

        public WeatherForecast[] GetAll()
        {
            return AllForecasts;
        }
    }
}