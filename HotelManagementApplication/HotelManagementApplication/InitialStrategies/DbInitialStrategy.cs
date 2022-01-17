using HotelManagementData.Data;
using HotelManagementData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication.InitialStrategies
{
    public class DbInitialStrategy : CreateDatabaseIfNotExists<HotelManagementApplicationDb>
    {
        protected override void Seed(HotelManagementApplicationDb context)
        {
            List<Feature> featureList = new List<Feature>();
            if (!context.Features.Any())
            {
                featureList.Add(new Feature() { Id = 1, FeatureName = "TV" });
                featureList.Add(new Feature() { Id = 2, FeatureName = "Bathroom" });
                featureList.Add(new Feature() { Id = 3, FeatureName = "Clean Towels" });
                featureList.Add(new Feature() { Id = 4, FeatureName = "Wi-Fi" });
                featureList.Add(new Feature() { Id = 5, FeatureName = "Mini Bar" });
                featureList.Add(new Feature() { Id = 6, FeatureName = "Hammock" });
                featureList.Add(new Feature() { Id = 7, FeatureName = "Jacuzzi" });
                featureList.Add(new Feature() { Id = 8, FeatureName = "Balcony" });
                featureList.Add(new Feature() { Id = 9, FeatureName = "Sea View" });
                featureList.Add(new Feature() { Id = 10, FeatureName = "Safe Box" });
                featureList.Add(new Feature() { Id = 11, FeatureName = "Balcony with Sea View" });
                featureList.Add(new Feature() { Id = 12, FeatureName = "King Size Bed" });
                featureList.Add(new Feature() { Id = 13, FeatureName = "Honeymoon Features" });
                foreach (Feature item in featureList)
                {
                    context.Features.Add(item);
                }
            }

            if (!context.Rooms.Any())
            {
                List<Room> roomList = new List<Room>();
                roomList.Add(new Room()
                {
                    Id = 1,
                    RoomName = "Room 101",
                    Capacity = 2,
                    PricePerDay = 300m,
                    Features = new List<Feature>()
                    {
                        featureList.FirstOrDefault(x => x.Id == 1),
                        featureList.FirstOrDefault(x => x.Id == 2),
                        featureList.FirstOrDefault(x => x.Id == 3),
                        featureList.FirstOrDefault(x => x.Id == 4),
                        featureList.FirstOrDefault(x => x.Id == 5)
                    }
                });
                roomList.Add(new Room()
                {
                    Id = 2,
                    RoomName = "Room 102",
                    Capacity = 2,
                    PricePerDay = 300m,
                    Features = new List<Feature>()
                    {
                        featureList.FirstOrDefault(x => x.Id == 1),
                        featureList.FirstOrDefault(x => x.Id == 2),
                        featureList.FirstOrDefault(x => x.Id == 3),
                        featureList.FirstOrDefault(x => x.Id == 4),
                        featureList.FirstOrDefault(x => x.Id == 5)
                    }
                });
                roomList.Add(new Room()
                {
                    Id = 3,
                    RoomName = "Suit 101",
                    Capacity = 3,
                    PricePerDay = 400m,
                    Features = new List<Feature>()
                    {
                        featureList.FirstOrDefault(x => x.Id == 1),
                        featureList.FirstOrDefault(x => x.Id == 2),
                        featureList.FirstOrDefault(x => x.Id == 3),
                        featureList.FirstOrDefault(x => x.Id == 4),
                        featureList.FirstOrDefault(x => x.Id == 5),
                        featureList.FirstOrDefault(x => x.Id == 7)
                    }
                });
                roomList.Add(new Room()
                {
                    Id = 4,
                    RoomName = "Suit 102",
                    Capacity = 3,
                    PricePerDay = 400m,
                    Features = new List<Feature>()
                    {
                        featureList.FirstOrDefault(x => x.Id == 1),
                        featureList.FirstOrDefault(x => x.Id == 2),
                        featureList.FirstOrDefault(x => x.Id == 3),
                        featureList.FirstOrDefault(x => x.Id == 4),
                        featureList.FirstOrDefault(x => x.Id == 7)
                    }
                });
                foreach (Room item in roomList)
                {
                    context.Rooms.Add(item);
                }
            }

            if (!context.Services.Any())
            {
                List<Service> serviceList = new List<Service>();
                serviceList.Add(new Service() { Id = 1, ServiceName = "Spa", UnitPrice = 250m});
                serviceList.Add(new Service() { Id = 2, ServiceName = "Hairdresser", UnitPrice = 50m});
                serviceList.Add(new Service() { Id = 3, ServiceName = "Room Service", UnitPrice = 50m});
                serviceList.Add(new Service() { Id = 4, ServiceName = "Gym Access", UnitPrice = 100m});
                serviceList.Add(new Service() { Id = 5, ServiceName = "Car Rental", UnitPrice = 300m});
                serviceList.Add(new Service() { Id = 6, ServiceName = "Laundry & Dry Cleaning", UnitPrice = 80m});
                serviceList.Add(new Service() { Id = 7, ServiceName = "Massage", UnitPrice = 225m});
                foreach (Service item in serviceList)
                {
                    context.Services.Add(item);
                }
            }
            context.SaveChanges();
        }
    }
}
