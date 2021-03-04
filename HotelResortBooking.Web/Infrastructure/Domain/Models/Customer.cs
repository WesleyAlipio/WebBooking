using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelResortBooking.Web.Infrastructure.Domain.Models
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string ContactNumber { get; set; }
    }
}
