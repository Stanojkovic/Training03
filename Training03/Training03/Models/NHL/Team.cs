using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //zobg atributa []
using System.Linq;
using System.Web;

namespace Training03.Models.NHL
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; }        //PrimaryKey
        public string City { get; set; }
        public string Province { get; set; }

        //Pravimo listu od klase Player jer su u vezi 1:N
        //Players ce biti naziv tabele
        public List<Player> Players { get; set; }
    }
}