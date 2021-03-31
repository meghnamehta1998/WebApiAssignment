using HMS.BAL;
using HMS.BAL.Helper;
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

            
            container.RegisterType<HMS.BAL.Interface.IHotelManager, HotelManager>();
            container.RegisterType<HMS.BAL.Interface.IRoomManager, RoomManager>();
            container.RegisterType<HMS.BAL.Interface.IBookingsManager, BookingsManager>();


            container.AddNewExtension<UnityRepositoryHelper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}