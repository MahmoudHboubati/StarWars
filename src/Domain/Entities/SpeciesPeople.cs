using System;

namespace Domain.Entities
{
    public class SpeciesPeople
    {
        public int SpeciesId { get; set; } //(reference to species table)
        public int PeopleId { get; set; } //(reference to people table)
    }
}
