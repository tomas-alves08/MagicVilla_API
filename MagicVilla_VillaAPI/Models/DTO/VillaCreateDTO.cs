﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Amenity { get; set; } = string.Empty;
    }
}
