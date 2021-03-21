using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.DAL.Repository
{
    public interface IRoomRepository
    {
        string CreateRoom(RoomD room);
        List<RoomD> GetRoomDetails(RoomD room, Hotel hotel);
        //List<RoomD> GetRoomByHotelCity(string city);
    }
}
