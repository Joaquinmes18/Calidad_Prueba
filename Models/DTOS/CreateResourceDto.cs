using System.ComponentModel.DataAnnotations;

namespace ImpulseClub.Models.DTOS
{
    public class CreateResourceDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Type { get; set; } = string.Empty;

        [Required]
        [Range(1, 10000)]
        public required int TotalQuantity { get; set; } = 1; // <-- Ojo al "required" aquí

        [Required]
        public Guid ClubId { get; set; }

        public string Status { get; set; } = "Available"; // Available, In Use, Maintenance
    }
}