﻿using IdeventAPI.Managers;
using IdeventLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeventTests.IntegrationTests
{
    [TestClass]
    public class ChipManagerTests : TestBase
    {
        private ChipManager _chipManager;

        protected override void TestSpecificInitialization()
        {
            _chipManager = new ChipManager(TestSettings.ConnectionString);
        }

        [TestMethod]
        public void GetAllReturnsList()
        {
            List<ChipModel> chips = _chipManager.GetAll();

            Assert.IsInstanceOfType(chips, typeof(List<ChipModel>));
            Assert.IsTrue(chips.Count >= 0);
        }
        [TestMethod]
        public void GetByIdReturnsModel()
        {
            ChipModel chip = _chipManager.GetById(1);

            Assert.IsInstanceOfType(chip, typeof(ChipModel));
        }
        [TestMethod]
        public void GetByIdReturnsNullIfNotFound()
        {
            ChipModel chip = _chipManager.GetById(-1);
            Assert.IsNull(chip);
        }

        [TestMethod]
        public void GetChipByHashedId()
        {
            ChipModel chip = _chipManager.GetByHashedId("urna");

            Assert.IsInstanceOfType(chip, typeof(ChipModel));
        }

        [TestMethod]
        public void GetByHashedIdReturnsNullIfNotFound()
        {
            ChipModel chip = _chipManager.GetByHashedId("findes_ikke");
            Assert.IsNull(chip);
        }


    }
}
