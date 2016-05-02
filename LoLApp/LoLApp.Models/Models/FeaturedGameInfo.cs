using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class FeaturedGameInfo
    {
        //Banned champion information
        public List<BannedChampion> BannedChampions { get; set; }

        //ID of the game
        public long GameId { get; set; }

        //Amount of time in seconds that has passed since the game started
        public long GameLength { get; set; }

        //Game mode (CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        public string GameMode { get; set; }

        //Queue type
        public long GameQueueConfigId { get; set; }

        //Game start time represented in epoch milliseconds
        public long GameStartTime { get; set; }

        //Game type (CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        public string GameType { get; set; }

        //ID of the map
        public long MapId { get; set; }

        //Observer information
        public Observer Observers { get; set; }

        //Participant information
        public List<Participant> Participants { get; set; }

        //ID of the platform on which the game is being played
        public string PlatformId { get; set; }
    }
}
