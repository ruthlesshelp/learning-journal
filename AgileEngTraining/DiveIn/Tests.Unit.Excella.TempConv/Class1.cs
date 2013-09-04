using Excella.TempConv;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Excella.TempConv
{
    public class TemperatureConverterTests
    {
        [Test]
        public void ToFahrenheit_WhenZeroCelsius_Expect32()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var temperature = converter.ToFahrenheit(0);

            // Assert
            Assert.AreEqual(32, temperature);
        }

        [Test]
        public void ToFahrenheit_When100Celsius_Expect212()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var actual = converter.ToFahrenheit(100);

            // Assert
            Assert.AreEqual(212, actual);
        }

        [Test]
        public void ToCelsius_When32F_Expect0C()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var actual = converter.ToCelsius(32);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void ToCelsius_When212F_Expect100C()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var actual = converter.ToCelsius(212);

            // Assert
            Assert.AreEqual(100, actual);
        }
    }
}
