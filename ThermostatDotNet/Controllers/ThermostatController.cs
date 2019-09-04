using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThermostatDotNet.Controllers
{

    public interface ITemperature
    {
        string GetTemp();
    }

    public class Temperature : ITemperature
    {
        private int _Temperature { get; set; }

        public string GetTemp()
        {
            return _Temperature.ToString();
        }
    }

    [Route("api/[controller]")]
    public class ThermostatController : Controller
    {
        private readonly ITemperature _temperature;
        private int _Temperature { get; set; }

        public ThermostatController(ITemperature temperature)
        {
            _temperature = temperature;
        }

        [HttpGet, Route("GetTemp")]
        public string GetTemp()
        {
            return _Temperature.ToString();
        }

        [HttpGet, Route("Reset")]
        public int Reset()
        {
            _Temperature = 20;
            return _Temperature;
        }

        [HttpGet, Route("Increase")]
        public int Increase()
        {
            _Temperature += 1;
            return _Temperature;
        }

        [HttpGet, Route("Decrease")]
        public int Decrease()
        {
            _Temperature -= 1;
            return _Temperature;
        }
    }
}
