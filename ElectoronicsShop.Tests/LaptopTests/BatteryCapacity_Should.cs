﻿using ElectronicsShop.Models.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LaptopTests
{
    [TestClass]
    public class BatteryCapacity_Should
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throw_ArgumentOutOfRangeException_WhenInvalidValuePassed()
        {
            //arrange & act
            string brand = "valid brand";
            string model = "valid model";
            int displaySize = 15;
            int batteryCapacity = 500; // invalid value
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;

            var laptop = new Laptop(brand, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);

        }
        [TestMethod]
        public void AssignCorrectly_WhenValidValuePassed()
        {
            //arrange & act
            string brand = "valid brand";
            string model = "valid model";
            int displaySize = 15;
            int batteryCapacity = 2500;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;

            var laptop = new Laptop(brand, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);
            //assert
            Assert.AreEqual(batteryCapacity, laptop.BatteryCapacity);
        }

    }
}

