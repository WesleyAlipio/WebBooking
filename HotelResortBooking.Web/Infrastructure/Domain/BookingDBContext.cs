using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelResortBooking.Web.Infrastructure.Domain
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext(DbContextOptions<BookingDBContext> options) : base(options)
        {   }


    }
}
