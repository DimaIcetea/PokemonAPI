using Pokemon.Models;
using PokemonReview.Dto;

namespace PokemonReview.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon.Models.Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        bool CreateOwner(Owner ownerCreate);
        bool UpdateOwner(Owner ownerUpdate);
        bool DeleteOwner(Owner ownerDelete);
        bool Save();
    }
}
