﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int SqFt { get; set; }
    }
}
