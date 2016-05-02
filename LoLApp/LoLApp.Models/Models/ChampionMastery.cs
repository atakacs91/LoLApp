using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    //Single Champion Mastery information for player and champion combination
    public class ChampionMastery
    {
        //Champion ID for this entry
        public long ChampionId { get; set; }

        //Champion level for specified player and champion combination
        public int ChampionLevel { get; set; }

        //Total number of champion points for this player and champion combination - they are used to determine ChampionLevel
        public int ChampionPoints { get; set; }

        //Number of point earned since current level has been achieved. Zero if player reached maximum champion level for this champion
        public long ChampionPointsSinceLastLevel { get; set; }

        //Number of point needed to achieve next level. Zero if player reached maximum champion level for this champion
        public long ChampionPointsUntilNextLevel { get; set; }

        //Is chest granted for this champion or not in current season.
        public bool ChestGranted { get; set; }

        //The highest grade of this champion of current season.
        public string HighestGrade { get; set; }

        //Last time this champion was played by this player - in Unix milliseconds time format
        public long LastPlayTime { get; set; }

        //Player ID for this entry
        public long playerId { get; set; }
    }
}
