using HMS.BAL.Interface;
using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManageHotel.Controllers
{
    public class BookingsController : ApiController
    {
        private readonly IBookingsManager _bookingManager;
        public BookingsController(IBookingsManager bookingManager)
        {
            _bookingManager = bookingManager;


        }

        // GET: api/Bookings/5
        [Route("api/Bookings/")]
        public bool Get(Bookings bookings)
        {
            return _bookingManager.GetAvailabilityOfRoom(bookings);
        }
        [Route("api/Bookings")]
        // POST: api/Bookings
        public string Post([FromBody]Bookings booking)
        {
            return _bookingManager.CreateBooking(booking);
        }
        [Route("api/Bookings")]
        // PUT: api/Bookings/5
        public string Put([FromBody]Bookings model)
            
        {
            return _bookingManager.UpdateBooking(model);
        }
        [Route("api/Bookings/")]
        // DELETE: api/Bookings/5
        public string Delete(int id)
        {
            return _bookingManager.DeleteBooking(id);
        }
    }
}
