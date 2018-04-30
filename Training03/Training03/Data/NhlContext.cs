using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Training03.Models.NHL;    //add path

namespace Training03.Data
{
    public class NhlContext : DbContext
    {
        public NhlContext() : base("Default Connection")
        {  }
        //Teams & PLayers su nazivi tabela u bazi
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> PLayers { get; set; }
    }
}