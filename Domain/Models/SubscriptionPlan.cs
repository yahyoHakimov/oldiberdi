namespace Domain.Models
{
    public class SubscriptionPlan
    {
        public int Id { get; set; }
        public string NameUz { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
        public PeriodTypeEnum PeriodType { get; set; }
        public int PeriodQty { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public enum PeriodTypeEnum
    {
        Year,
        Month,
        Week,
        Day
    }

    public enum StatusEnum
    {
        Draft,
        Active,
        Paused,
        Closed
    }
}
