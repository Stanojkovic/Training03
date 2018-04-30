using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training03.Models.NHL
{
    public class Player
    {
        public int PlayerId { get; set; }   //ime klase + Id, automastski ce biti prepoznato kao primaryKey
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
      


        //Ovo zajedno cini FK
        public string TeamName { get; set; }        //ForeignKey
        //svakom igracu pripada neki tim koji je dataType Team
        public Team Team { get; set; }
    }
}