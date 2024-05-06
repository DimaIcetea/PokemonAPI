using Pokemon.Data;
using Pokemon.Interfaces;
using Pokemon.Models;

namespace Pokemon.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Models.Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public Models.Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Models.Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);
            if (review.Count() <= 0)
                return 0;
            return ((decimal)review.Sum(r => r.Rating) / review.Count());

        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(p => p.Id == pokeId);
        }

        public bool CreatePokemon(int ownerId, int categoryId,Models.Pokemon pokemonCreate)
        {
            var pokemonOwnerEntity = _context.Owners.Where
                (a => a.Id == ownerId).FirstOrDefault();
            var category = _context.Categories.Where
                (a => a.Id == categoryId).FirstOrDefault();
            var pokemonOwner = new PokemonOwner()
            {
                Owner = pokemonOwnerEntity,
                Pokemon = pokemonCreate,
            };

            _context.Add(pokemonCreate);
            return Save();
        }

        public bool UpdatePokemon(int ownerId, int categoryId, Models.Pokemon pokemonUpdate)
        {
            _context.Update(pokemonUpdate);
            return Save();
        }

        public bool DeletePokemon(Models.Pokemon pokemonDelete)
        {
            _context.Remove(pokemonDelete);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
