using Pokemon.Models;

namespace PokemonReview.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int categoryId);
        ICollection<Pokemon.Models.Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int categoryId);
        bool CreateCategory(Category category);
        bool Save();
    }
}
