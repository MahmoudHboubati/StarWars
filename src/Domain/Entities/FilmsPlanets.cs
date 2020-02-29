namespace Domain.Entities
{
    public class FilmsPlanets
    {
        public int FilmId { get; set; } //(reference to films table)
        public int PlanetId { get; set; } //(reference to planets table)
    }
}
