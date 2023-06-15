using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Data;
using PokemonAPI.Interface;
using PokemonAPI.Models;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly DataContext _dataContext;

        public PokemonController(IPokemonRepository pokemonRepository,DataContext dataContext)
        {
            _pokemonRepository = pokemonRepository;
            _dataContext = dataContext;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemons);
        }
    }
}
