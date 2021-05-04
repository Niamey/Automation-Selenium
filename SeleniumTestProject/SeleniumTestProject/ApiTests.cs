using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenweathermapRequestLib;

namespace SeleniumTestProject
{
    [TestClass]
    public class ApiTests
    {
        [TestMethod]
        public void Test1LonLat()
        {
            var req =
                new OpenweathermapRequest(
                    "http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b1b15e88fa797225412429c1c50c122a1/");
            Assert.AreEqual(req.Longitude, -0.13F);
            Assert.AreEqual(req.Latitude, 51.51F);
        }

        [TestMethod]
        public void Test2Temp()
        {
            var req =
                new OpenweathermapRequest(
                    "http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b1b15e88fa797225412429c1c50c122a1/");
            Assert.IsTrue(req.Temperature < 315);
        }
    }
}
