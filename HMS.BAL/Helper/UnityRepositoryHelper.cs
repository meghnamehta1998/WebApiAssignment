using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Extension;
using HMS.DAL.Repository;
using MHS.DAL.Repository;

namespace HMS.BAL.Helper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IHotelRepository, HotelRepository>();
            Container.RegisterType<IRoomRepository, RoomRepository>();
            Container.RegisterType<IBookingRepository, BookingsRepository>();
        }
    }
}
