namespace Pokemon.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Models.Pokemon> GetPokemons();
    }
}
