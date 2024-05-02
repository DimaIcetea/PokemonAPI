using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokemon.Models;
using PokemonReview.Dto;
using PokemonReview.Interfaces;

namespace PokemonReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController:Controller
    {
        private readonly IMapper _mapper;
        private readonly IOwnerRepository _ownerRepository;

        public OwnerController(IMapper mapper, IOwnerRepository ownerRepository)
        {
            _mapper = mapper;
            _ownerRepository = ownerRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
        public IActionResult GetOwners()
        {
            var owners = _mapper.Map<List<OwnerDto>>
                (_ownerRepository.GetOwners());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(owners);
        }

        [HttpGet("{ownerId}")]
        [ProducesResponseType(200, Type = typeof(Owner))]
        [ProducesResponseType(400)]
        public IActionResult GetOwner(int ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId))
                return NotFound();
            var owner = _mapper.Map<OwnerDto>
                (_ownerRepository.GetOwner(ownerId));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(owner);
        }

        [HttpGet("pokemon/{pokeId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
        [ProducesResponseType(400)]
        public IActionResult GetOwnerOfAPokemon(int pokeId)
        {
            var owner = _mapper.Map<List<OwnerDto>>
                (_ownerRepository.GetOwnerOfAPokemon(pokeId));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(owner);
        }

        [HttpGet("{ownerId}/pokemon")]
        [ProducesResponseType(200, Type = typeof(Pokemon.Models.Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonByOwner(int ownerId)
        {
            if(!_ownerRepository.OwnerExists(ownerId))
                return NotFound();
            var pokemon = _mapper.Map<List<PokemonDto>>
                (_ownerRepository.GetPokemonByOwner(ownerId));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemon);
        }
    }
}
