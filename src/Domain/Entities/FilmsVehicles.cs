namespace Domain.Entities
{
    public class FilmsVehicles
    {
        public int FilmId { get; set; } //(reference to films table)
        public int VehicleId { get; set; } //(reference to vehicles table)
    }
}
