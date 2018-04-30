namespace Training03.Migrations.NHL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Training03.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Training03.Data.NhlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\NHL";
        }

        protected override void Seed(Training03.Data.NhlContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(
                t => t.TeamName, TablesData.getTeams().ToArray());
            context.SaveChanges();

            context.PLayers.AddOrUpdate(
                p => new { p.FirstName, p.LastName }, TablesData.getPlayers(context).ToArray());
                

        }
    }
}
