using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Models
{
    public class Bookings
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public int RoomId { get; set; }
        public string Status { get; set; }
    }
}
