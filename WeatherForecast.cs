namespace PsiicApi
{
	public class WeatherForecast
	{
		public DateOnly Date { get; private set; }

		public int TemperatureC { get; private set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; private set; }
	}
}