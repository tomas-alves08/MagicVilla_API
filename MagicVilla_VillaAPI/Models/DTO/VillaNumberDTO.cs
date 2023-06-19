using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        
        [MaxLength(50)]
        public string SpecialDetails { get; set; }
        
    }
}
