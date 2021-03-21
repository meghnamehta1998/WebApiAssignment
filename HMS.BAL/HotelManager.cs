using System;
using System.Collections.Generic;
using System.Text;
using HMS.Models;
using HMS.DAL.Repository;
using HMS.BAL.Interface;

namespace HMS.BAL
{
    public class HotelManager : IHotelManager
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;


        }

        public string CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public string DeleteHotel(int id)
        {
            return _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
           return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotel(int id)
        {
            return _hotelRepository.GetHotel(id);
        }

        public string UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
        //public Hotel GetHotel()
        //{
        //    //Hotel hotel = new Hotel
        //    //{
        //    //    //Id = 1,
        //    //    //Name = "Hotel Ashish",
        //    //    //Address = "Near Dinbhai Tower, Mirzapur Road, Opp. Sarabhai Compound,",
        //    //    //City = "Ahmedabad",
        //    //    //Pincode = 380001,
        //    //    //ContactNumber = 07925505015,
        //    //    //ContactPerson = "Mr.Ashish",
        //    //    //Website = "www.hotelashish.com",
        //    //    //Facebook = "@HotelAshish",
        //    //    //Twitter = "@HotelAshishAhmedabad",
        //    //    //isActive = true,
        //    //    //CreatedDate = DateTime.Now,
        //    //    //CreatedBy = "Meghna",
        //    //    //UpdatedBy = "",
        //    //    //UpdatedDate = DateTime.Now



        //    //};
        //    var hotel = _hotelRepository.GetHotel();
        //    return hotel;

        //}

    }
}
