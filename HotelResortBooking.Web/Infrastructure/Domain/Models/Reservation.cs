using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelResortBooking.Web.Infrastructure.Domain.Models.Enums;

namespace HotelResortBooking.Web.Infrastructure.Domain.Models
{
    public class Reservation
    {
        public Guid? CustomerId { get; set; }

        public Room Room { get; set; }

        public decimal Total { get; set; }

        public BillStatus BillStatus { get; set; }

    }
}
