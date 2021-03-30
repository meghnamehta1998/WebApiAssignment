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
        [Route("api/Hotel/")]
        public Hotel Get(int id) {
            return _hotelManager.GetHotel(id);
        }
        // GET api/values
        [Route("api/Hotel")]
        public List<Hotel> Get()
        {
            //HotelManager hotelManager = new HotelManager();
            //hotelManager.GetHotel();
            //var hotel = _hotelManager.GetHotel();
            //return hotel;
            return _hotelManager.GetAllHotels();
        }

        [Route("api/Hotel")]
        // POST: api/Hotel
        public string Post([FromBody]Hotel model)
        {
            return _hotelManager.CreateHotel(model);
        }
        [Route("api/Hotel")]
        // PUT: api/Hotel/5
        public string Put([FromBody]Hotel model)
        {
            return _hotelManager.UpdateHotel(model);
        }
        [Route("api/Hotel/")]
        // DELETE: api/Hotel/5
        public string Delete(int id)
        {
            return _hotelManager.DeleteHotel(id);
        }
    }
}
