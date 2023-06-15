namespace PokemonAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GYM { get; set; }
        public ICollection<pokemonOwner>pokemonOwners { get; set; }
    }
}
