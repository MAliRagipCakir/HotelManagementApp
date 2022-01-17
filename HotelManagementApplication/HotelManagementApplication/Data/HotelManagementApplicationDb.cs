using HotelManagementApplication.InitialStrategies;
using HotelManagementData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Data
{
    public class HotelManagementApplicationDb : DbContext
    {
        public HotelManagementApplicationDb() : base("MyConnectionString")//Diğer projede appconfig'e eklemek de gerekli mi?
        {
            Database.SetInitializer(new DbInitialStrategy());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ReservationService> ReservationServices { get; set; }


    }
}
