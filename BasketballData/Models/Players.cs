using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BasketballData.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public Team TeamName { get; set; }

        [Required]
        public int JerseyNo { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public string Position { get; set; }
        public string Drafted { get; set; }
        public DateTime DOB { get; set; }

        //Numeric stat line
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
