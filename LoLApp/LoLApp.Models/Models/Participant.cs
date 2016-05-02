using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class Participant
    {
        //Flag indicating whether or not this participant is a bot
        public bool Bot { get; set; }

        //ID of the champion played by this participant
        public long ChampionId { get; set; }
                
        //ID of the profile icon used by this participant
        public long ProfileIconId { get; set; }
                
        //ID of the first summoner spell used by this participant
        public long Spell1Ld { get; set; }

        //ID of the second summoner spell used by this participant
        public long Spell2Ld { get; set; }

        //Summoner name of this participant
        public string SummonerName { get; set; }

        //Team ID of this participant, indicating the participant's team
        public long TeamId { get; set; }
    }
}
