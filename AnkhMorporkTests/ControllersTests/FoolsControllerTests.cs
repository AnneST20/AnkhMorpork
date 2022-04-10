using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnkhMorpork.Models;
using AnkhMorpork.Controllers;

namespace AnkhMorporkTests.ControllersTests
{
    [TestClass]
    public class FoolsControllerTests
    {
        [TestMethod]
        public void ApplyGuildRequest_AnyInventory_AliveTrue()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 0.1m, Beers = 0 };

            _falseContext.Fools.Add(new Fool { Id = 1, Type = "Fool1", Fee = 1m});
            _falseContext.Fools.Add(new Fool { Id = 2, Type = "Fool2", Fee = 2m});
            _falseContext.Fools.Add(new Fool { Id = 3, Type = "Fool3", Fee = 3m});

            _falseContext.SaveChanges();

            var controller = new FoolsController(_falseContext, _falseInventory);
            var result = controller.ApplyGuildRequest();

            Assert.IsTrue(result);

        }
    }
}
