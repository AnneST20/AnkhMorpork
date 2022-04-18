
using AnkhMorpork.Models;
using System;
using System.Linq;

namespace AnkhMorpork.Controllers
{
    public class FoolsController : GuildController
    {
        Fool fool;
        private bool isApplied = false;
        public FoolsController(GuildsContext context, Inventory inventory)
            : base(context, inventory)
        {
            Random random = new Random();
            int randomFool = random.Next(_context.Fools.Count() - 1);
            fool = _context.Fools.ToList()[randomFool];
        }

        public override bool ApplyGuildRequest()
        {
            isApplied = true;
            _inventory.Money += fool.Fee;
            return true;
        }

        public override string ShowGuildInfo()
        {
            return $"Here is {fool.Type}\n" +
                $"who asks you to help.\n" +
                $"He promises to give you money for this\n" + 
                $"Will you help him?";
        }

        public override string ShowMeetingResult()
        {
            if (isApplied) return $"You hepled {fool.Type} \n and he gave you {fool.Fee} AM$";
            return $"You decided not to help {fool.Type}. \n Nothing has changed.";
        }
    }
}
