namespace Domain.Entities
{
    public class FilmsSpecies
    {
        public int FilmId { get; set; } //(reference to films table)
        public int SpeciesId { get; set; } //(reference to species table)
    }
}
