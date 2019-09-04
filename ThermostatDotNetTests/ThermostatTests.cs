using System.Web.Mvc;
using NUnit.Framework;
using ThermostatDotNet.Controllers;

namespace ThermostatTests
{
    public class ThermostatTests
    {

        [Test]
        public void ReturnsCurrentTemperature()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            int actual = thermostat.GetTemp();
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ResetsTemperatureOnThermostat()
        {
            var thermostat = new ThermostatController();
            int actual = thermostat.Reset();
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncreasesTempByOne()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            int actual = thermostat.Increase();
            int expected = 21;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreasesTempByOne()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            int actual = thermostat.Decrease();
            int expected = 19;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreasesAndIncreases()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            thermostat.Decrease();
            thermostat.Decrease();
            thermostat.Increase();
            int actual = thermostat.Decrease();
            int expected = 18;
            Assert.AreEqual(expected, actual);
        }
    }
}
