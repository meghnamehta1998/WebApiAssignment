using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Models;
namespace HMS.BAL.Interface
{
    public interface IRoomManager
    {
        string CreateRoom(RoomD room);
        List<RoomD> GetRoomDetails(HotelRoom room);
        // List<RoomD> GetRoomByHotelCity(string city);
    }
}
