using AnkhMorpork.Models;
using System.Linq;

namespace AnkhMorpork.Controllers
{
    public class ThievesController : GuildController
    {
        public ThievesController(GuildsContext context, Inventory inventory) 
            : base(context, inventory) { }

        public override bool ApplyGuildRequest()
        {
            _inventory.Money -= _context.Thieves.FirstOrDefault().Fee;
            if (_inventory.Money < 0) return false;
            return true;
        }

        public override string ShowGuildInfo()
        {
            return "The thief has put a dagger to your throat\n" +
                "and wants to take 10 AM$.\n" +
                "Will you give him money?";
        }

        public override string ShowMeetingResult()
        {
            return "Thanks Gods you're alive! \n But you spend 10 AM$";
        }
    }
}

      
