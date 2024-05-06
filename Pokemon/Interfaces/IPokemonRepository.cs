namespace Pokemon.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Models.Pokemon> GetPokemons();
        Models.Pokemon GetPokemon(int pokeId);
        Models.Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
        bool CreatePokemon(int ownerId, int categoryId, Models.Pokemon pokemonCreate);
        bool UpdatePokemon(int ownerId, int categoryId, Models.Pokemon pokemonUpdate);
        bool Save();
    }
}
