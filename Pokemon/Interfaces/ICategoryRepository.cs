using Pokemon.Models;

namespace PokemonReview.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon.Models.Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);

    }
}
