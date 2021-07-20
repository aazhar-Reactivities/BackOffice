using System;

namespace ListingsTrades.Models
{
    public class PropertyTypes
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Boolean Type { get; set; }
        public string ShortName { get; set; }
        public bool Report2HO { get; set; }
        public bool RentalType { get; set; }
    }
}