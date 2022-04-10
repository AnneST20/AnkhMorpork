using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnkhMorpork.Models;
using AnkhMorpork.Controllers;

namespace AnkhMorporkTests.ControllersTests
{
    [TestClass]
    public class ThiefesControllerTests
    {
        [TestMethod]
        public void ApplyGuildRequest_EnoughMoney_AliveTrue()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 11m, Beers = 0 };

            _falseContext.Thieves.Add(new Thief { Id = 1,  Fee = 10m });
            _falseContext.SaveChanges();

            var controller = new ThievesController(_falseContext, _falseInventory);
            var result = controller.ApplyGuildRequest();

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void ApplyGuildRequest_NotEnoughMoney_AliveFalse()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 9m, Beers = 0 };

            _falseContext.Thieves.Add(new Thief { Id = 1, Fee = 10m });
            _falseContext.SaveChanges();

            var controller = new ThievesController(_falseContext, _falseInventory);
            var result = controller.ApplyGuildRequest();

            Assert.IsFalse(result);

        }
    }
}
