using System.ComponentModel.DataAnnotations;

namespace ImpulseClub.Models.DTOS
{
    public record CreateRecursoDto
    {
        [Required]
        public required string Nombre { get; init; }

        [Required]
        public required string Tipo { get; init; }

        [Range(1, 10000)]
        public int CantidadTotal { get; init; }

        [Required]
        public Guid ClubId { get; init; }
    }
}