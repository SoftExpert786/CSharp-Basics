using PokemonAPI.Data;
using PokemonAPI.Interface;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _dataContext;

        public PokemonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return _dataContext.pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}
