using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class BannedChampion
    {
        //ID of the banned champion
        public long ChampionId { get; set; }

        //The turn during which the champion was banned
        public int PickTurn { get; set; }

        //ID of the team that banned the champion
        public long TeamId { get; set; }

    }
}
