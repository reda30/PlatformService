namespace PlatformService.Data
{
    public static  class PrebDb
    {

        public static void prepPopulation(IApplicationBuilder app)
        {
            using (var serviceScop = app.ApplicationServices.GetService<AppDbContext>())
            {
               SeedData(serviceScop);
            }
        }

        public static void SeedData(AppDbContext context)
        {
            if (!context.platforms.Any())
            {
                Console.WriteLine("Seeding Data....");
                context.platforms.AddRange(
                    new Models.Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Models.Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new Models.Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data");
            }
        }
    }
}
