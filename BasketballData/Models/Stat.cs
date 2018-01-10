using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballData.Models
{
    public class Stat
    {
        //Numeric stat line
        public int Id { get; set; }
        public int OREB { get; set; }
        public int REB { get; set; }
        public int AST { get; set; }
        public int STL { get; set; }
        public int BLK { get; set; }
        public int TO { get; set; }
        public int PF { get; set; }
        public int PTS { get; set; }
        public int FGA { get; set; }
    }
}
