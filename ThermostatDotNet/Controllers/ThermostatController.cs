using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThermostatDotNet.Controllers
{
    [Route("api/[controller]")]
    public class ThermostatController : Controller
    {

        private int _Temperature { get; set; }
        private const int _MinTemp = 10;
        private const int _MaxTemp = 30;

        public ThermostatController()
        {
            _Temperature = 20;

        }

        [HttpGet, Route("GetTemp")]
        public int GetTemp()
        {
            return _Temperature;
        }

        [HttpGet, Route("Reset")]
        public int Reset()
        {
            _Temperature = 20;
            return _Temperature;
        }

        [HttpGet, Route("Increase")]
        public int Increase(int newTemp)
        {
            if (newTemp < _MaxTemp)
            {
                newTemp += 1;
            }

            return newTemp;
        }

        [HttpGet, Route("Decrease")]
        public int Decrease(int newTemp)
        {
            if (newTemp > _MinTemp)
            {
                newTemp -= 1;
            }
  
            return newTemp;
        }
    }
}