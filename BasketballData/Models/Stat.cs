using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballData.Models
{
    public class Stat : Players
    {
        //Numeric stat line
        public int Id { get; set; }
        public int OREB { get; set; }
        public int DREB { get; set; }
        public int REB { get; set; }
        public int AST { get; set; }
        public int STL { get; set; } 
        public int BLK { get; set; }
        public int TO { get; set; }
        public int PF { get; set; }
        public int PTS { get; set; }
        public int FGA { get; set; }
        public int FGM { get; set; }
        public int TPA { get; set; } // Three pointers attempted
        public int TPM { get; set; } // Three pointers made
        public int FTA { get; set; } // Free Throws attempted
        public int FTM { get; set; }
        public int Year { get; set; }

    }
}
