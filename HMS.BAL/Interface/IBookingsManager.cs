using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BAL.Interface
{
    public interface IBookingsManager
    {
        string CreateBooking(Bookings booking);
        string UpdateBooking(Bookings booking);
        string DeleteBooking(int id);
        bool GetAvailabilityOfRoom(Bookings bookings);
       

    }
}
