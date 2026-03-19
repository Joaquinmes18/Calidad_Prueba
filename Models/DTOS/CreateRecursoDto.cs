using System.ComponentModel.DataAnnotations;

namespace ImpulseClub.Models.DTOS
{
    public record CreateRecursoDto
    {
        [Required]
        public required string Nombre { get; init; }

        [Required]
        public required string Tipo { get; init; }
    }
}