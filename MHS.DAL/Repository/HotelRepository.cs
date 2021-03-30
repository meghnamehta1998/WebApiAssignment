using System;
using System.Collections.Generic;
using System.Linq;
using HMS.Models;
using AutoMapper;
using MHS.DAL;

namespace HMS.DAL.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly MHS.DAL.Database.db_HotelEntities _dbContext;
      
        public HotelRepository() {
            _dbContext = new MHS.DAL.Database.db_HotelEntities();
        }
        public string CreateHotel(Hotel hotel)
        {
            try {
                if (hotel != null) {
                    MHS.DAL.Database.Hotel entity = new MHS.DAL.Database.Hotel();
                    
                     //creating map  
                    //var userDto = mapper.CreateMap<MHS.DAL.Database.Hotel, Hotel>(hotel);
                    entity.Id = hotel.Id;
                    entity.Name = hotel.Name;
                    entity.Address = hotel.Address;
                    entity.City = hotel.City;
                    entity.Pincode = hotel.Pincode;
                    entity.ContactNumber = hotel.ContactNumber;
                    entity.ContactPerson = hotel.ContactPerson;
                    entity.Website = hotel.Website;
                    entity.Facebook = hotel.Facebook;
                    entity.Twitter = hotel.Twitter;
                    entity.isActive = hotel.isActive;
                    entity.CreatedDate = (DateTime.Now);
                    entity.CreatedBy = hotel.CreatedBy;
                    entity.UpdatedDate = (DateTime.Now);
                    entity.UpdatedBy = hotel.UpdatedBy;
                    _dbContext.Hotels.Add(entity);
                    _dbContext.SaveChanges();
                    return "Successfully Added";
                }
                return "Model is null!";
                
            }
            catch (Exception ex) {
                return ex.Message;
            }
            
        }

        public string DeleteHotel(int id)
        {
            try
            {
                var entity = _dbContext.Hotels.Find(id);
                if (entity != null)
                {

                    _dbContext.Hotels.Remove(entity);
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

        public List<Hotel> GetAllHotels()
        {
            var entities = _dbContext.Hotels.ToList();
            List<Hotel> list = new List<Hotel>();
            List<Hotel> list_sorted = new List<Hotel>();
            if (entities != null) {
                foreach (var item in entities)
                {
                    Hotel hotel = new Hotel();
                    hotel.Id = item.Id;
                    hotel.Name = item.Name;
                    hotel.Address = item.Address;
                    hotel.City = item.City;
                    hotel.Pincode = item.Pincode;
                    hotel.ContactNumber =item.ContactNumber;
                    hotel.ContactPerson = item.ContactPerson;
                    hotel.Website = item.Website;
                    hotel.Facebook = item.Facebook;
                    hotel.Twitter = item.Twitter;
                    hotel.isActive = (item.isActive);
                    hotel.CreatedDate = (DateTime)item.CreatedDate;
                    hotel.CreatedBy = item.CreatedBy;
                    hotel.UpdatedDate = (DateTime)item.UpdatedDate;
                    hotel.UpdatedBy = item.UpdatedBy;
                    list.Add(hotel);
                }
                list_sorted=list.OrderBy(hotel => hotel.Name).ToList();
            }
            return list_sorted;
        }

        public Hotel GetHotel()
        {
            Hotel hotel = new Hotel
            {
                Id = 1,
                Name = "Hotel Ashish",
                Address = "Near Dinbhai Tower, Mirzapur Road, Opp. Sarabhai Compound,",
                City = " Ahmedabad",
                Pincode = 380001,
                ContactNumber = 07925505015,
                ContactPerson = "Mr.Ashish",
                Website = "www.hotelashish.com",
                Facebook = "@HotelAshish",
                Twitter = "@HotelAshishAhmedabad",
                isActive = "true",
                CreatedDate = DateTime.Now,
                CreatedBy = "Meghna",
                UpdatedBy = "",
                UpdatedDate = DateTime.Now
            };
            return hotel;
        }

        public Hotel GetHotel(int id)
        {
            var entity = _dbContext.Hotels.Find(id);
            Hotel hotel = new Hotel();
            if (entity != null) {
                hotel.Id = entity.Id;
                hotel.Name = entity.Name;
                hotel.Address = entity.Address;
                hotel.City = entity.City;
                hotel.Pincode = entity.Pincode;
                hotel.ContactNumber = entity.ContactNumber;
                hotel.ContactPerson = entity.ContactPerson;
                hotel.Website = entity.Website;
                hotel.Facebook = entity.Facebook;
                hotel.Twitter = entity.Twitter;
                hotel.isActive = (entity.isActive);
                hotel.CreatedDate = (DateTime)entity.CreatedDate;
                hotel.CreatedBy = entity.CreatedBy;
                hotel.UpdatedDate = (DateTime)entity.UpdatedDate;
                hotel.UpdatedBy = entity.UpdatedBy;
            }
            

            return hotel;
        }

        public string UpdateHotel(Hotel hotel)
        {
            try
            {
                var entity = _dbContext.Hotels.Find(hotel.Id);
                if (entity != null)
                {
                    
                    entity.Id = hotel.Id;
                    entity.Name = hotel.Name;
                    entity.Address = hotel.Address;
                    entity.City = hotel.City;
                    entity.ContactNumber = (long)hotel.ContactNumber;
                    entity.ContactPerson = hotel.ContactPerson;
                    entity.Website = hotel.Website;
                    entity.Facebook = hotel.Facebook;
                    entity.Twitter = hotel.Twitter;
                    entity.isActive = "true";
                    entity.CreatedDate = (DateTime.Now);
                    entity.CreatedBy = hotel.CreatedBy;
                    entity.UpdatedDate = (DateTime.Now);
                    entity.UpdatedBy = hotel.UpdatedBy;
                   // _dbContext.Hotels.Add(entity);
                    _dbContext.SaveChanges();
                    return "Successfully Updated!";
                }
                return "No Data Found!";
            }
            catch (Exception ex) {
                
                return ex.Message;
            }
        }
    }
}
