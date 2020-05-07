using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zwaj2.Data;

namespace Zwaj2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext db;
        public WeatherForecastController(DataContext dbContext)
        {
            this.db = dbContext;

        }
        [HttpGet]

        public IActionResult GetValue()
        {

            var value = db.Values.ToList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {

            var value = db.Values.FirstOrDefault(x=>x.Id==id);
            return Ok(value);
        }
    }
}
