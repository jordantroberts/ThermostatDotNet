﻿using System;
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

        public ThermostatController()
        {
            _Temperature = 0;
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