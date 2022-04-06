using System.Data;
using System.Linq;
using AnkhMorpork.Models;
using System.Collections.Generic;
using System;

namespace AnkhMorpork.Controllers
{
    public class AssassinsController : GuildController
    {
        public AssassinsController(GuildsContext context, Inventory inventory)
            : base(context, inventory) { }

        public decimal Reward { get; set; }
        

        public override bool ApplyGuildRequest()
        {
            bool alive = false;
            SetMissions();

            var activeAssassins = GetActiveAssassins();
            var selectAssassin = activeAssassins.Where(a => a.MinReward <= Reward && a.MaxReward >= Reward)
                .FirstOrDefault();
            if (selectAssassin != null)
            {
                if (_inventory.Money > Reward)
                {
                    alive = true;
                    _inventory.Money -= Reward;
                }
            }

            RefreshMissions();

            return alive;
        }

        private List<Assassin> GetActiveAssassins()
        {
            var activeAssassins = _context.Assassins.Where(a => a.Missions == 0);
            return activeAssassins.ToList();
        }

        private void SetMissions()
        {
            Random random = new Random();
            foreach(Assassin assassin in _context.Assassins)
            {
                assassin.Missions += random.Next(2);
            }
            _context.SaveChanges();
        }

        private void RefreshMissions()
        {
            foreach(Assassin assassin in _context.Assassins)
            {
                if (assassin.Missions > 0)
                    assassin.Missions--;
            }
            _context.SaveChanges();
        }

        public override string ShowGuildInfo()
        {
            return "Someone hired an assassin to kill you.\n" +
                "But there is a way out:\n" +
                "you can try to outbid the contract\n" +
                "by offering some amount of money";
        }
    }
}
