using System;

namespace Domain.Entities
{
    public class StarshipsPilots
    {
        public int StarshipId { get; set; } //(reference to starships table)
        public int PeopleId { get; set; } //(reference to people table)
    }
}
