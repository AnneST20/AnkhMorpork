using AnkhMorpork.Models;

namespace AnkhMorpork.Controllers
{
    public abstract class GuildController
    {
        protected GuildsContext _context;
        protected Inventory _inventory;

        public GuildController(GuildsContext context, Inventory inventory)
        {
            _context = context;
            _inventory = inventory;
        }

        public abstract bool ApplyGuildRequest();

        public abstract string ShowGuildInfo(); 
    }
}
