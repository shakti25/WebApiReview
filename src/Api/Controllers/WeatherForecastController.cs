using Microsoft.AspNetCore.Mvc;

namespace WebApiReview.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // In-memory storage for demonstration purposes
    // Summary property options: "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    private static readonly List<WeatherForecast> _forecasts = new()
    {
        new WeatherForecast { Id = 1, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 25, Summary = "Warm" },
        new WeatherForecast { Id = 2, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), TemperatureC = 15, Summary = "Mild" },
        new WeatherForecast { Id = 3, Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), TemperatureC = 5, Summary = "Chilly" }
    };
    private static int _nextId = 4;

    [HttpGet(Name = "GetWeatherForecasts")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        return Ok(_forecasts);
    }

    [HttpGet("{id}", Name = "GetWeatherForecastById")]
    public ActionResult<WeatherForecast> GetById(int id)
    {
        var forecast = _forecasts.FirstOrDefault(f => f.Id == id);
        if (forecast == null)
        {
            return NotFound(new { message = $"Weather forecast with ID {id} not found." });
        }
        return Ok(forecast);
    }

    [HttpPost(Name = "CreateWeatherForecast")]
    public ActionResult<WeatherForecast> Post([FromBody] WeatherForecast forecast)
    {
        if (forecast == null)
        {
            return BadRequest(new { message = "Weather forecast data is required." });
        }

        forecast.Id = _nextId++;
        _forecasts.Add(forecast);

        return CreatedAtRoute("GetWeatherForecastById", new { id = forecast.Id }, forecast);
    }

    [HttpPut("{id}", Name = "UpdateWeatherForecast")]
    public ActionResult<WeatherForecast> Put(int id, [FromBody] WeatherForecast forecast)
    {
        if (forecast == null)
        {
            return BadRequest(new { message = "Weather forecast data is required." });
        }

        var existingForecast = _forecasts.FirstOrDefault(f => f.Id == id);
        if (existingForecast == null)
        {
            return NotFound(new { message = $"Weather forecast with ID {id} not found." });
        }

        existingForecast.Date = forecast.Date;
        existingForecast.TemperatureC = forecast.TemperatureC;
        existingForecast.Summary = forecast.Summary;

        return Ok(existingForecast);
    }

    [HttpDelete("{id}", Name = "DeleteWeatherForecast")]
    public ActionResult Delete(int id)
    {
        var forecast = _forecasts.FirstOrDefault(f => f.Id == id);
        if (forecast == null)
        {
            return NotFound(new { message = $"Weather forecast with ID {id} not found." });
        }

        _forecasts.Remove(forecast);
        return NoContent();
    }
}
