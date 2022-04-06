using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnkhMorpork.Controllers;
using AnkhMorpork.Models;
using AnkhMorpork;

namespace TestProject
{
    [TestClass]
    public class BeggarsControllerTests
    {
        [TestMethod]
        public void ApplyGuildRequest_NotEnoughMoney_False()
        {
            var context = new GuildsContext();
            var inventory = new Inventory { Money = 0, Beers = 0 };
            var bc = new BeggarsController(context, inventory);

            var result = bc.ApplyGuildRequest();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ApplyGuildRequest_Money_True()
        {
            var context = new GuildsContext();
            var inventory = new Inventory { Money = 50, Beers = 0 };
            var bc = new BeggarsController(context, inventory);

            var result = bc.ApplyGuildRequest();

            Assert.IsTrue(result);
        }
    }
}
