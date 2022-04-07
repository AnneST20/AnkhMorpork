using AnkhMorpork.Models;
using System;
using System.Linq;

namespace AnkhMorpork.Controllers
{
    public class BeggarsController : GuildController
    {
        Beggar beggar;
        public BeggarsController(GuildsContext context, Inventory inventory) 
            : base(context, inventory)
        {
            Random random = new Random();
            int randomBeggar = random.Next(_context.Beggars.Count() - 1);
            beggar = _context.Beggars.ToList()[randomBeggar];
        }

        public override bool ApplyGuildRequest()
        {
            if (beggar.Fee > 0)
            {
                if (_inventory.Money > beggar.Fee)
                {
                    _inventory.Money -= beggar.Fee;
                    return true;
                }
                else
                    return false;
            }

            return true;
        }

        public override string ShowGuildInfo()
        {
            return $"Here are {beggar.Type} \n" +
                $"who want {beggar.Fee} AM$ and {beggar.Beer} beer.\n" +
                $"Will you give them what they want?";
        }
    }
}
