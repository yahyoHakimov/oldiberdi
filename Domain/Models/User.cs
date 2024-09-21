namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }  // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }  // Store the hashed password
        public DateTime Dob { get; set; }
        public string PassportNum { get; set; }
        public int PassportType { get; set; }
        public int Pinfl { get; set; }
        public int Country { get; set; }
        public int Region { get; set; }
        public int District { get; set; }
        public string Address { get; set; }
        public bool LivenessPassed { get; set; } = false;
        public bool Identified { get; set; } = false;
        public StatusEnum Status { get; set; } = StatusEnum.New;
        public int SubPlan { get; set; }
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
