using HMS.BAL;
using HMS.DAL.Repository;
using MHS.DAL.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ManageHotel
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IHotelRepository, HotelRepository>();
            container.RegisterType<IRoomRepository, RoomRepository>();
            container.RegisterType<IBookingRepository, BookingsRepository>();
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<HMS.BAL.Interface.IHotelManager, HotelManager>();
            container.RegisterType<HMS.BAL.Interface.IRoomManager, RoomManager>();
            container.RegisterType<HMS.BAL.Interface.IBookingsManager, BookingsManager>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}