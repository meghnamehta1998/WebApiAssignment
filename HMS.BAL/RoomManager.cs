using HMS.BAL.Interface;
using HMS.Models;
using MHS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BAL
{
    public class RoomManager:IRoomManager
    {
        private readonly IRoomRepository _roomRepository;
        public RoomManager(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;


        }

        
        public string CreateRoom(RoomD room)
        {
            return _roomRepository.CreateRoom(room);
        }

        public List<RoomD> GetRoomDetails(RoomD room, Hotel hotel)
        {
            return _roomRepository.GetRoomDetails(room, hotel);
        }

        //public List<RoomD> GetRoomByHotelCity(string city)
        //{
        //    return _roomRepository.GetRoomByHotelCity(city);
        //}
    }
}
