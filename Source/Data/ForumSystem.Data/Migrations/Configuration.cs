namespace ForumSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ForumSystem.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

			// TODO: Remove in production
			this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ForumSystem.Data.ApplicationDbContext context)
        {
        }
    }
}
