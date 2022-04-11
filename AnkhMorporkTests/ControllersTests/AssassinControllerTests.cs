using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnkhMorpork.Models;
using AnkhMorpork.Controllers;

namespace AnkhMorporkTests.ControllersTests
{
    [TestClass]
    public class AssassinControllerTests
    {
        [TestMethod]
        public void ApplyGuildRequest_NotEnoughMoneyForContract_AliveFalse()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 3m, Beers = 0 };

            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 7, Missions = 0});
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 7, MaxReward = 10, Missions = 0 });
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 12, Missions = 0 });
            _falseContext.SaveChanges();

            var controller = new AssassinsController(_falseContext, _falseInventory) { Reward = 3m };
            var result = controller.ApplyGuildRequest();

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void ApplyGuildRequest_TooMuchMoneyForContract_AliveFalse()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 3m, Beers = 0 };

            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 7, Missions = 0 });
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 7, MaxReward = 10, Missions = 0 });
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 12, Missions = 0 });
            _falseContext.SaveChanges();

            var controller = new AssassinsController(_falseContext, _falseInventory) { Reward = 15m };
            var result = controller.ApplyGuildRequest();

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void ApplyGuildRequest_NotActiveAssassins_AliveFalse()
        {
            var _falseContext = new GuildsContext();
            var _falseInventory = new Inventory { Money = 10m, Beers = 0 };

            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 7, Missions = 1 });
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 7, MaxReward = 10, Missions = 1 });
            _falseContext.Assassins.Add(new Assassin { Id = 1, MinReward = 5, MaxReward = 12, Missions = 1 });
            _falseContext.SaveChanges();

            var controller = new AssassinsController(_falseContext, _falseInventory) { Reward = 3m };
            var result = controller.ApplyGuildRequest();

            Assert.IsFalse(result);

        }
    }
}
