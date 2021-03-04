using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelResortBooking.Web.Infrastructure.Domain.Models.Enums;

namespace HotelResortBooking.Web.Infrastructure.Domain.Models
{
    public class Room : BaseModel
    {
        public string RoomNumber { get; set; }

        public string RoomDescription { get; set; }

        public decimal Price { get; set; }

        public string Occupants { get; set; }

        public RoomStatus RoomStatus { get; set; }
    }
}
