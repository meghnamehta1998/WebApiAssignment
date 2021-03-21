using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.DAL.Repository
{
    public class BookingsRepository:IBookingRepository
    {
        private readonly MHS.DAL.Database.db_HotelEntities _dbContext;
        public BookingsRepository()
        {
            _dbContext = new MHS.DAL.Database.db_HotelEntities();
        }

        public string CreateBooking(Bookings booking)
        {
            try
            {
                if (booking != null)
                {
                    MHS.DAL.Database.Booking entity = new MHS.DAL.Database.Booking();
                    entity.Id = booking.ID;
                    entity.BookingDate = DateTime.Now;
                    entity.RoomId = booking.RoomId;
                    entity.Status = "Optional";

                    _dbContext.Bookings.Add(entity);
                    _dbContext.SaveChanges();
                    return "Successfully Added";
                }
                return "Model is null!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateBooking(Bookings booking)
        {
            try
            {
                var entity = _dbContext.Bookings.Find(booking.ID);
                if (entity != null)
                {
                    entity.BookingDate = booking.BookingDate;
                    if (booking.Status.CompareTo("Definitive") == 0 || booking.Status.CompareTo("Cancelled") == 0)
                    {
                        entity.Status = booking.Status;
                    }
                    else {
                        entity.Status = "Optional";
                    }

                    _dbContext.SaveChanges();
                    return "Successfully Updated!";
                }
                return "No Data Found!";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }
        public string DeleteBooking(int id)
        {
            try
            {
                var entity = _dbContext.Bookings.Find(id);
                if (entity != null)
                {
                    entity.Status = "Deleted";
                    //_dbContext.Bookings.Remove(entity);
                    _dbContext.SaveChanges();
                    return "Successfully Deleted!";
                }
                return "No Data Found!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public bool GetAvailabilityOfRoom(Bookings bookings)
        {
            try
            {
               
                object[] parameters = { bookings.BookingDate,bookings.RoomId };
                var entity1 = _dbContext.Database.SqlQuery<Bookings>("select Status from Bookings where BookingDate = {0} and RoomId = {1}", parameters).ToList();
                if (entity1 != null)
                {
                    Bookings b = new Bookings();
                    foreach (var item in entity1) {
                        b.Status = item.Status;
                    }
                    if (b.Status != null)
                    {
                        if ((b.Status.CompareTo("Cancelled") == 0 || b.Status.CompareTo("Deleted") == 0))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
