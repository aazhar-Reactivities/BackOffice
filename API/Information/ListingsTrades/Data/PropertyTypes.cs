using System;

namespace ListingsTrades.Data
{
    public class PropertyTypes
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Boolean Type { get; set; }
        public string ShortName { get; set; }
        public Boolean Report2HO { get; set; }
        public Boolean RentalType { get; set; }  
    }
}