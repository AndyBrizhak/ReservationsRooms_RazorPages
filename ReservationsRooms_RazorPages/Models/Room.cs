﻿using System.ComponentModel.DataAnnotations;

namespace Reservations.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Status { get; set; } = SD.Renovation;
        public string? BtnStatusId { get; set; }
    }
}
