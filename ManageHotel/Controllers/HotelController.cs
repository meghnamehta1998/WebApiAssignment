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
    public class HotelController : ApiController
    {
        private readonly IHotelManager _hotelManager;
        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;


        }
        public Hotel Get(int id) {
            return _hotelManager.GetHotel(id);
        }
        // GET api/values
        public List<Hotel> Get()
        {
            //HotelManager hotelManager = new HotelManager();
            //hotelManager.GetHotel();
            //var hotel = _hotelManager.GetHotel();
            //return hotel;
            return _hotelManager.GetAllHotels();
        }


        // POST: api/Hotel
        public string Post([FromBody]Hotel model)
        {
            return _hotelManager.CreateHotel(model);
        }

        // PUT: api/Hotel/5
        public string Put([FromBody]Hotel model)
        {
            return _hotelManager.UpdateHotel(model);
        }

        // DELETE: api/Hotel/5
        public string Delete(int id)
        {
            return _hotelManager.DeleteHotel(id);
        }
    }
}
