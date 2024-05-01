namespace Pokemon.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Models.Pokemon> GetPokemons();
        Models.Pokemon GetPokemon(int id);
        Models.Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
    }
}
