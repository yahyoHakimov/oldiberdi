namespace Domain.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string NameUz { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
        public int RegionCode { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CountryCode { get; set; } // Foreign key to Country
        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; } // Navigation property


    }
}
