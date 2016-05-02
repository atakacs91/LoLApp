using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLApp.Models.Models
{
    public class Mastery
    {
        //ID of the mastery
        public long MasteryId { get; set; }

        //The number of points put into this mastery by the user
        public int Rank { get; set; }
    }
}
