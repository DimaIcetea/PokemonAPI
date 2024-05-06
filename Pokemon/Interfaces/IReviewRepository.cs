using Pokemon.Models;

namespace PokemonReview.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        bool CreateReview(Review reviewCreate);
        bool UpdateReview(Review reviewUpdate);
        bool Save();
    }
}
