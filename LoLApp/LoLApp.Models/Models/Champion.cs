namespace LoLApp.Models.Models
{
    //Champion information
    public class Champion
    {
        //Indicates if the champion is active
        public bool Active { get; set; }

        //Bot enabled flag (for custom games)
        public bool BotEnabled { get; set; }

        //Bot Match Made enabled flag (for Co-op vs AI games)
        public bool BotMmEnabled { get; set; }

        //Indicates if the champion is free to play
        public bool FreeToPlay { get; set; }

        //Champion ID. For static information correlating to champion IDs
        public long Id { get; set; }

        //Ranked play enabled flag
        public bool RankedPlayEnabled { get; set; }
    }
}
