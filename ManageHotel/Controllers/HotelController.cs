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
    [CustomAuthenticate]
    public class HotelController : ApiController
    {
        private readonly IHotelManager _hotelManager;
        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;


        }
        [Route("api/Hotel/")]
        public IHttpActionResult Get(int id) {
            return Ok(_hotelManager.GetHotel(id));
        }
        // GET api/values
        [Route("api/Hotel")]
        public IHttpActionResult Get()
        {
            //HotelManager hotelManager = new HotelManager();
            //hotelManager.GetHotel();
            //var hotel = _hotelManager.GetHotel();
            //return hotel;
            return Ok( _hotelManager.GetAllHotels());
        }

        [Route("api/Hotel")]
        // POST: api/Hotel
        public IHttpActionResult Post([FromBody]Hotel model)
        {
            return Ok(_hotelManager.CreateHotel(model));
        }
        [Route("api/Hotel")]
        // PUT: api/Hotel/5
        public IHttpActionResult Put([FromBody]Hotel model)
        {
            return Ok(_hotelManager.UpdateHotel(model));
        }
        [Route("api/Hotel/")]
        // DELETE: api/Hotel/5
        public IHttpActionResult Delete(int id)
        {
            return Ok(_hotelManager.DeleteHotel(id));
        }
    }
}
