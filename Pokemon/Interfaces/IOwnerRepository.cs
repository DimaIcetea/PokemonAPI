using Pokemon.Models;

namespace PokemonReview.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon.Models.Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
    }
}
