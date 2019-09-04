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
            int actual = thermostat.Increase(20);
            int expected = 21;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreasesTempByOne()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            int actual = thermostat.Decrease(20);
            int expected = 19;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreasesAndIncreases()
        {
            var thermostat = new ThermostatController();
            thermostat.Reset();
            var temp1 = thermostat.Decrease(20);
            var temp2 =thermostat.Decrease(temp1);
            var temp3 = thermostat.Increase(temp2);
            int actual = thermostat.Decrease(temp3);
            int expected = 18;
            Assert.AreEqual(expected, actual);
        }
    }
}
