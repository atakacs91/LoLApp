using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class FeaturedGames
    {
        //Suggested interval to wait before requesting FeaturedGames again
        public long ClientRefreshInterval { get; set; }

        //List of featured games
        public List<FeaturedGameInfo> GameList { get; set; }
    }
}
