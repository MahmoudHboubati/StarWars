using System;

namespace Domain.Entities
{
    public class People
    {
        public int Id { get; set; }
        public String BirthYear { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public String EyeColor { get; set; }
        public String Gender { get; set; }
        public String HairColor { get; set; }
        public String Height { get; set; }
        public int Homeworld { get; set; }
        public String Mass { get; set; }
        public String Name { get; set; }
        public String SkinColor { get; set; }
    }
}
