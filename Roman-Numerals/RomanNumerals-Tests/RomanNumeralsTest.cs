﻿using System;
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
