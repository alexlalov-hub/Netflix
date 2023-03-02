namespace Netflix.Models
{
    public class Director
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
