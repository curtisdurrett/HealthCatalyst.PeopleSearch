using System;

namespace HealthCatalyst.Services.Models
{
    public class PersonResult
    {
        public string PictureFileName { get; set; }        
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
    }
}
