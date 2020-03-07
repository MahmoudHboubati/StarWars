using System;

namespace Domain.Entities.SpeciesEntities
{
    public class Species
    {
        public int Id { get; set; }
        public string AverageHeight { get; set; }
        public string AverageLifespan { get; set; }
        public string Classification { get; set; }
        public DateTime Created { get; set; }
        public string Designation { get; set; }
        public DateTime Edited { get; set; }
        public string EyeColors { get; set; }
        public string HairColors { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public string SkinColors { get; set; }
    }
}
