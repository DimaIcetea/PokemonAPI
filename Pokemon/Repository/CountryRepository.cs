using Pokemon.Data;
using Pokemon.Models;
using PokemonReview.Interfaces;

namespace PokemonReview.Repository
{
    public class CountryRepository:ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }

        public Country GetCountry(string name)
        {
            return _context.Countries.Where(c => c.Name == name).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return _context.Owners.Where(o => o.Country.Id == countryId).ToList();
        }


        public bool CountryExists(int countryId)
        {
            return _context.Countries.Any(c => c.Id == countryId);
        }

        public bool CreateCountry(Country countryCreate)
        {
            _context.Add(countryCreate);
            return Save();
        }

        public bool UpdateCountry(Country countryUpdate)
        {
            _context.Update(countryUpdate);
            return Save();
        }

        public bool DeleteCountry(Country countryDelete)
        {
            _context.Remove(countryDelete);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
