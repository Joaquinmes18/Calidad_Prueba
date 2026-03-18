using System.ComponentModel.DataAnnotations;

namespace ImpulseClub.Models.DTOS
{
    public record CreateEntrenamientoDto
    {
        [Required]
        public required string Nombre { get; init; } // <-- Aquí agregamos "required"

        [Required]
        public DateTime Fecha { get; init; }

        [Required]
        public int Duracion { get; init; }

        [Required]
        public Guid ClubId { get; init; }
    }
}