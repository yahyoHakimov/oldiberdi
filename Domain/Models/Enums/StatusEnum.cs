using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public enum StatusEnum
    {
        New,
        PhoneVerified,
        IdVerified,
        Draft,
        Active,
        Confirmed,
        Closed,
        Archived,
        Sent,
        Received,
        Annulled,

        Sms,
        Email
    }   
}
