using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnkhMorpork.Models;
using AnkhMorpork.Controllers;

namespace AnkhMorporkTests.Controllers
{
    [TestClass]
    public class BeggarsControllerTests
    {
        [TestMethod]
        public void ApplyGuildRequest_EnoughMoney_AliveTrue()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 4m, Beers = 0 };

            _falseContext.Beggars.Add(new Beggar { Id = 1, Type = "Beggar1", Fee = 1m, Beer = 0 });
            _falseContext.Beggars.Add(new Beggar { Id = 2, Type = "Beggar2", Fee = 2m, Beer = 0 });
            _falseContext.Beggars.Add(new Beggar { Id = 3, Type = "Beggar3", Fee = 3m, Beer = 0 });

            _falseContext.SaveChanges();

            var controller = new BeggarsController(_falseContext, _falseInventory);
            var result = controller.ApplyGuildRequest();

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void ApplyGuildRequest_NotEnoughMoney_AliveFalse()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 0.4m, Beers = 0 };

            _falseContext.Beggars.Add(new Beggar { Id = 1, Type = "Beggar1", Fee = 1m, Beer = 0 });
            _falseContext.Beggars.Add(new Beggar { Id = 2, Type = "Beggar2", Fee = 2m, Beer = 0 });
            _falseContext.Beggars.Add(new Beggar { Id = 3, Type = "Beggar3", Fee = 3m, Beer = 0 });

            _falseContext.SaveChanges();

            var controller = new BeggarsController(_falseContext, _falseInventory);
            var result = controller.ApplyGuildRequest();

            Assert.IsFalse(result);

        }
    }
}
