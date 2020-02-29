namespace Domain.Entities
{
    public class FilmsStarships
    {
        public int FilmId { get; set; } //(reference to films table)
        public int StarshipId { get; set; } //(reference to startship table)
    }
}
