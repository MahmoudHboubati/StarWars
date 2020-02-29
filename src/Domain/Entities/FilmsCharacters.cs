namespace Domain.Entities
{
    public class FilmsCharacters
    {
        public int FilmId { get; set; } //(reference to films table)
        public int PeopleId { get; set; } //(reference to person table)
    }
}
