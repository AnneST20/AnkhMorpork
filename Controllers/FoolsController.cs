using AnkhMorpork.Models;
using System;
using System.Linq;

namespace AnkhMorpork.Controllers
{
    public class FoolsController : GuildController
    {
        Fool fool;
        public FoolsController(GuildsContext context, Inventory inventory)
            : base(context, inventory)
        {
            Random random = new Random();
            int randomFool = random.Next(_context.Fools.Count() - 1);
            fool = _context.Fools.ToList()[randomFool];
        }

        public override bool ApplyGuildRequest()
        {
            _inventory.Money += fool.Fee;
            return true;
        }

        public override string ShowGuildInfo()
        {
            return $"Here is {fool.Type}\n" +
                $"who asks you to help.\n" +
                $"Will you help him?";
        }
    }
}
