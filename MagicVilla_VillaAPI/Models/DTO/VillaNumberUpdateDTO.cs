using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        
        [MaxLength(50)]
        public string SpecialDetails { get; set; }
        public int VillaId { get; set; }

    }
}
