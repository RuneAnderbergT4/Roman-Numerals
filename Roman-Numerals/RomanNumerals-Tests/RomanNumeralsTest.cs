using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman_Numerals;

namespace RomanNumerals_Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        private Converter _converter;

        [TestInitialize]
        public void Setup()
        {
            _converter = new Converter();
        }

        [TestMethod]
        public void ShouldReturnIFor1()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("I", _converter.IntToRomanNumerals(1));
        }

        [TestMethod]
        public void ShouldReturnIIFor2()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("II", _converter.IntToRomanNumerals(2));
        }

        [TestMethod]
        public void ShouldReturnIIIFor3()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("III", _converter.IntToRomanNumerals(3));
        }

        [TestMethod]
        public void ShouldReturnIVFor4()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("IV", _converter.IntToRomanNumerals(4));
        }

        [TestMethod]
        public void ShouldReturnVFor5()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("V", _converter.IntToRomanNumerals(5));
        }

        [TestMethod]
        public void ShouldReturnVIFor6()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("VI", _converter.IntToRomanNumerals(6));
        }
        [TestMethod]
        public void ShouldReturnVIIFor7()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("VII", _converter.IntToRomanNumerals(7));
        }

        [TestMethod]
        public void ShouldReturnVIIIFor8()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("VIII", _converter.IntToRomanNumerals(8));
        }

        [TestMethod]
        public void ShouldReturnIXFor9()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("IX", _converter.IntToRomanNumerals(9));
        }

        [TestMethod]
        public void ShouldReturnLXXVIFor76()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("LXXVI", _converter.IntToRomanNumerals(76));
        }
        
        [TestMethod]
        public void ShouldReturnDFor500()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("D", _converter.IntToRomanNumerals(500));
        }

        [TestMethod]
        public void ShouldReturnMFor1000()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("M", _converter.IntToRomanNumerals(1000));
        }

        [TestMethod]
        public void ShouldReturnMDFor1500()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("MD", _converter.IntToRomanNumerals(1500));
        }

        [TestMethod]
        public void ShouldReturnMMFor2000()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("MM", _converter.IntToRomanNumerals(2000));
        }

        [TestMethod]
        public void ShouldReturnMMMFor3000()
        {
            // Arrange via setup

            // Act

            // Assert
            Assert.AreEqual("MMM", _converter.IntToRomanNumerals(3000));
        }
    }
}
