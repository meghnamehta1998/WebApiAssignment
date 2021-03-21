using HMS.BAL.Interface;
using HMS.Models;
using MHS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BAL
{
    public class BookingsManager : IBookingsManager
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingsManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;


        }

        public string CreateBooking(Bookings booking)
        {
            return _bookingRepository.CreateBooking(booking);
        }

        public string DeleteBooking(int id)
        {
            return _bookingRepository.DeleteBooking(id);
        }

        public bool GetAvailabilityOfRoom(Bookings bookings)
        {
            return _bookingRepository.GetAvailabilityOfRoom(bookings);
        }

        
        public string UpdateBooking(Bookings booking)
        {
            return _bookingRepository.UpdateBooking(booking);
        }
    }
}
