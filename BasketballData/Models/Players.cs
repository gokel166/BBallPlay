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
        
        public Team TeamName { get; set; }

        [Required]
        public int JerseyNo { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public string Position { get; set; }
        public string Drafted { get; set; }
        public DateTime DOB { get; set; }


    }
}
