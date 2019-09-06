using System.Web.Mvc;
using NUnit.Framework;
using ThermostatDotNet.Controllers;

namespace ThermostatTests {

    [TestFixture]
    public class ThermostatTests {

        private ThermostatController thermostat;

        [SetUp]
        public void Init () {
            thermostat = new ThermostatController ();
            thermostat.Reset ();

        }

        [Test]
        public void ReturnsCurrentTemperature () {

            int actual = thermostat.GetTemp ();
            int expected = 20;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void ResetsTemperatureOnThermostat () {
            int actual = thermostat.Reset ();
            int expected = 20;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void IncreasesTempByOne () {

            int actual = thermostat.Increase (20);
            int expected = 21;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void DecreasesTempByOne () {

            int actual = thermostat.Decrease (20);
            int expected = 19;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void DecreasesAndIncreases () {

            var temp1 = thermostat.Decrease (20);
            var temp2 = thermostat.Decrease (temp1);
            var temp3 = thermostat.Increase (temp2);
            int actual = thermostat.Decrease (temp3);
            int expected = 18;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void WillNotExceedMaximumTemperature () {

            int actual = thermostat.Increase (30);
            int expected = 30;
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void WillNotGoBelowMinTemperature () {

            int actual = thermostat.Decrease (10);
            int expected = 10;
            Assert.AreEqual (expected, actual);
        }
    }
}