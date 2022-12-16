using GildedRose;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit.Sdk;

namespace GildedRose.Tests
{
    [TestClass]
    public class ShopTests
    {
        private Shop _shop;
        private ItemsRepository _itemsRepository;

        [TestInitialize]
        public void Setup()
        {
            /*
            var path = @"C:\\Users\\pc\\OneDrive - Ifag Paris\\Bureau\\EPSI COUR 4eme\\cv architecture  applicatives\\seance 1 le 02-11-2022\\gilded-rose-main\\csharpcore\\GildedRose\\File.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            Console.WriteLine(lines[0]);
            */

            _itemsRepository = new InMemoryItemsRepository();
            _shop = new Shop(_itemsRepository);
        }

        [TestMethod]
        public void ShouldUpdateItems()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(9, _itemsRepository.GetInventory()[0].SellIn);
            Assert.AreEqual(9, _itemsRepository.GetInventory()[0].Quality);
        }

        [TestMethod]
        public void ShouldDecreaseQualityFaster()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(8, _itemsRepository.GetInventory()[1].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveNegativeQuality()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(0, _itemsRepository.GetInventory()[2].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseAgedBrieQuality()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(6, _itemsRepository.GetInventory()[3].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveQualityHaveOver50()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(50, _itemsRepository.GetInventory()[4].Quality);
        }

        [TestMethod]
        public void ShouldNotChangeSulfurasQuality()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(80, _itemsRepository.GetInventory()[5].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQuality()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(6, _itemsRepository.GetInventory()[6].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQualityFaster()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(7, _itemsRepository.GetInventory()[7].Quality);
        }

        [TestMethod]
        public void ShouldUpdateBackstagepassesQualityTo0()
        {
            _shop.UpdateQuality();
            Assert.AreEqual(0, _itemsRepository.GetInventory()[9].Quality);
        }
    }
}