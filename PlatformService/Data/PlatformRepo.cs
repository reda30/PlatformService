using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        public AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;    
        }
        public void CreatePlatform(Platform platform)
        {

            if (platform is not null) _context.Add(platform);

            throw new ArgumentNullException(nameof(platform));
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            var platforms= _context.platforms.ToList();
            return platforms;
        }

        public Platform GetPlatformById(int id)
        {
            var platform = _context.platforms.FirstOrDefault(x=>x.Id==id);

            return platform!;
          

        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
