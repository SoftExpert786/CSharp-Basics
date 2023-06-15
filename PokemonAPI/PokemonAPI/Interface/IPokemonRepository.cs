using PokemonAPI.Models;

namespace PokemonAPI.Interface
{
    public interface IPokemonRepository
    {
         ICollection<Pokemon> GetPokemons();
    }
}
