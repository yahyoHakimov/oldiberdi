namespace Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string NameUz { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
        public int CountryCode { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
