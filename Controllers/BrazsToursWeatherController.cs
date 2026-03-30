using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BrazsToursWeatherWebApi.Controllers
{
    public class BrazsToursWeatherController : ApiController
    {
        
        [Route("api/GetWeatherForecast/{location}/{date}")]

        public IHttpActionResult GetWeatherForecast(string location, DateTime date)

        {
            using (ConToStringAPIBrazsToursWeatherDB db = new ConToStringAPIBrazsToursWeatherDB())
            {
                {
                    var forecast = db.WeatherForecasts
                        .FirstOrDefault(w => w.Location == location && w.Date == date);

                    if (forecast == null)
                    {
                        return NotFound();
                    }

                    return Ok(new
                    {
                        Location = forecast.Location,
                        Date = forecast.Date.ToString("dd-MM-yyyy"),
                        Condition = forecast.Condition,
                        Temperature = forecast.Temperature + " degrees",
                    });
                }
            }
        }
    }
}
