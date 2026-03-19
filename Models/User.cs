using System.ComponentModel.DataAnnotations;

namespace ImpulseClub.Models
{
    public class User
    {
        public Guid Id { get; set; }

        // Agregamos 'required' para solucionar el warning de SonarQube
        [Required] public required string Username { get; set; }
        [Required] public required string Email { get; set; }
        [Required] public required string PasswordHash { get; set; }

        public string Role { get; set; } = "User";//"User" | "Admin" | "Fundador" 
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiresAt { get; set; }
        public DateTime? RefreshTokenRevokedAt { get; set; }
        public string? CurrentJwtId { get; set; }
    }
}