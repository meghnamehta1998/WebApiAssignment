using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.DAL.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MHS.DAL.Database.db_HotelEntities _dbContext;
        public RoomRepository()
        {
            _dbContext = new MHS.DAL.Database.db_HotelEntities();
        }


        public string CreateRoom(RoomD room)
        {
            try
            {
                if (room != null)
                {
                    MHS.DAL.Database.RoomD entity = new MHS.DAL.Database.RoomD();
                    entity.RoomId = room.RoomId;
                    entity.HotelId = room.HotelId;
                    entity.Name = room.Name;
                    entity.Category = room.Category;
                    entity.Price = (int)(room.Price);
                    entity.isActive = room.isActive;
                    entity.CreatedDate = (DateTime.Now);
                    entity.CreatedBy = room.CreatedBy;
                    entity.UpdatedDate = (DateTime.Now);
                    entity.UpdatedBy = room.UpdatedBy;
                    _dbContext.RoomDs.Add(entity);
                    _dbContext.SaveChanges();
                    return "Successfully Added";
                }
                return "Model is null!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<RoomD> GetRoomDetails(HotelRoom room)
        {
            //try {
                List<RoomD> listsorted = new List<RoomD>();
                List<RoomD> roomD = new List<RoomD>();
                object[] parameters = { room.City,room.Pincode,room.Price,room.Category };
                var entity1 = _dbContext.Database.SqlQuery<RoomD>("Select * from RoomD,Hotel where Hotel.City={0} OR Hotel.Pincode={1} OR RoomD.Price={2} OR RoomD.Category={3}", parameters).ToList();
                if (entity1 != null) {
                    foreach (var item in entity1) {
                        RoomD r = new RoomD();
                        r.RoomId = item.RoomId;
                        r.HotelId = item.HotelId;
                        r.Name = item.Name;
                        r.Category = item.Category;
                        r.Price = item.Price;
                        r.isActive = item.isActive;
                        r.CreatedDate = item.CreatedDate;
                        r.CreatedBy = item.CreatedBy;
                        r.UpdatedDate = item.UpdatedDate;
                        r.UpdatedBy = item.UpdatedBy;
                        roomD.Add(r);
                    }
                    listsorted = roomD.OrderBy(room1=> room1.Price).ToList();

                }
                return listsorted;
            //} catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
        }

        
    }
}
