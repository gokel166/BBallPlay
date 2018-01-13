using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballData.Models
{
    public class PlayerAward
    {
        public int Id { get; set; }
        public string MVP { get; set; }
        public string MIP { get; set; }
        public string DPOY { get; set; }
        public DateTime AwardYear { get; set; }
    }
}
