using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class Reservation
    {
        public Reservation()
        {
            ReservationCustomers = new List<Customer>();
            ReservationServices = new List<ReservationService>();
        }
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        
        public decimal ReservationTotalPrice => Room == null ? ReservationServices.Sum(x => x.ServiceTotalPrice) : ReservationServices.Sum(x => x.ServiceTotalPrice) + (Room.PricePerDay * (CheckOutDate-CheckInDate).Days);

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        public virtual ICollection<Customer> ReservationCustomers { get; set; }
        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
