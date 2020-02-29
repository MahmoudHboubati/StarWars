using System;

namespace Domain.Entities
{
    public class VehiclesPilots
    {
        public int VehicleId { get; set; } //(reference to vehicles table)
        public int PeopleId { get; set; } //(reference to people table)
    }
}
