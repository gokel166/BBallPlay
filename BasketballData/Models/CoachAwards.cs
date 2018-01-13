using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballData.Models
{
    public class CoachAwards : Coahes
    {
        public int Id { get; set; }
        public string CoachOfTheYear { get; set; }
        public bool Active { get; set; }
    }
}
