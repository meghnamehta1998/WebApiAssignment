using System;
using System.Collections.Generic;
using System.Text;
using HMS.Models;
namespace HMS.BAL.Interface
{
    public interface IHotelManager
    {
        Hotel GetHotel(int id);
        List<Hotel> GetAllHotels();
        string CreateHotel(Hotel hotel);
        string UpdateHotel(Hotel hotel);
        string DeleteHotel(int id);
    }
}