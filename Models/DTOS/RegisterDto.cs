namespace ImpulseClub.Models.DTOS
{
    public record RegisterDto
    {
        public required string Username { get; init; }
        public required string Email { get; init; }
        public required string Password { get; init; }
        public string Role { get; set; } = "User";
    }
}