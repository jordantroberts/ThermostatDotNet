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
            var controller = new ThermostatController(18);
            int actual = controller.GetTemp();
            int expected = 18;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ResetsTemperatureOnThermostat()
        {
            var controller = new ThermostatController(18);
            int actual = controller.Reset();
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncreasesTempByOne()
        {
            var controller = new ThermostatController(18);
            int actual = controller.Increase();
            int expected = 19;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreasesTempByOne()
        {
            var controller = new ThermostatController(18);
            int actual = controller.Decrease();
            int expected = 17;
            Assert.AreEqual(expected, actual);
        }
    }
}
