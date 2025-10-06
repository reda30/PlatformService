
using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformReadDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Publisher { get; set; } = string.Empty;
        [Required]
        public string Cost { get; set; } = string.Empty;
    }
}
