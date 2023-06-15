namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<pokemonOwner> PokemonOwner { get; set; }
        public ICollection<pokemonCategory> PokemonCategory { get; set; }
    }
}
