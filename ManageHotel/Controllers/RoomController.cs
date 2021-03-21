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
    public class RoomController : ApiController
    {
        private readonly IRoomManager _roomManager;
        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;


        }

       // GET: api/Room/5
        public List<RoomD> Get([FromBody] RoomD room, [FromBody] Hotel hotel)
        {
            return _roomManager.GetRoomDetails(room, hotel);
        }

        // POST: api/Room
        public string Post([FromBody]RoomD model)
        {
            return _roomManager.CreateRoom(model);
        }

        // PUT: api/Room/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Room/5
        public void Delete(int id)
        {
        }
    }
}
