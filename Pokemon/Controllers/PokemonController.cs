using Microsoft.AspNetCore.Mvc;
using Pokemon.Interfaces;

namespace Pokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController:Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Models.Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemons);
        }
    }
}
