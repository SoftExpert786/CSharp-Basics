namespace PokemonAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<pokemonCategory> pokemonCategories { get; set; }
    }
}
