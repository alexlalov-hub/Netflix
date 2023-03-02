using System.ComponentModel.DataAnnotations;

namespace Netflix.Models
{
    public class Film
    {
        public Guid Id { get; set; }    

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Country> Countries { get; set; }

        public int Duration { get; set; }

        [Range(1900, 2023)]
        public int Year { get; set; }

        public Genre Genre { get; set; }

        public Director Director { get; set; }

        public ICollection<Actor> Actors { get; set; }
    }
}
