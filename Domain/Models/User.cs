    namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public string Email { get; set; }
        public int Pinfl { get; set; }
        public DateTime Dob { get; set; }
        public string PassportNum { get; set; }
        public int PassportType { get; set; }
        public int CountryId { get; set; }  // FK to Country
        public int RegionId { get; set; }   // FK to Region
        public int DistrictId { get; set; } // FK to District
        public string Address { get; set; }
        public bool LivenessPassed { get; set; } = false;
        public bool Identified { get; set; } = false;
        public StatusEnum Status { get; set; } = StatusEnum.New;
        public int SubPlanId { get; set; }  // FK to Subscription Plan
        public DateTime? SubExpireDate { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public enum StatusEnum
    {
        New,
        PhoneVerified,
        IdVerified
    }
}
