using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class CurrentGameInfo
    {
        //Banned champion information
        public List<BannedChampion> BannedChampions { get; set; }

        //The ID of the game
        public long GameId { get; set; }

        //The amount of time in seconds that has passed since the game started
        public long GameLength { get; set; }

        //The game mode (CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        public string GameMode { get; set; }

        //The queue type
        public long GameQueueConfigId { get; set; }

        //The game start time represented in epoch milliseconds
        public long GameStartTime { get; set; }

        //The game type (CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        public string GameType { get; set; }

        //The ID of the map
        public long MapId { get; set; }

        //The observer information
        public Observer Observers { get; set; }
        
        //The participant information
        public List<CurrentGameParticipant> Participants { get; set; }
        
        //Platform ID
        public string PlatformId { get; set; } 
    }
}
