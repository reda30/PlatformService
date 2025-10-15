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
        public void CreatePlatform(Platform plat)
        {
            if (plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }

            _context.Platforms.Add(plat);
        }


        public IEnumerable<Platform> GetAllPlatforms()
        {
            var platforms= _context.Platforms.ToList();
            return platforms;
        }

        public Platform GetPlatformById(int id)
        {
            var platform = _context.Platforms.FirstOrDefault(x=>x.Id==id);

            return platform!;
          

        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
