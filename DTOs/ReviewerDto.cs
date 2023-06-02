using PokemonReviewApp.Models;

namespace PokemonReviewApp.DTOs
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}