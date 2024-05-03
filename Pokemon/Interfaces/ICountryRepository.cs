using Pokemon.Models;

namespace PokemonReview.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int countryId);
        Country GetCountry(string name);
        Country GetCountryByOwner(int ownerId);

        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int countryId);
        bool CreateCountry(Country countryCreate);
        bool Save();
    }
}
