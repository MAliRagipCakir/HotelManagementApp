using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class ReservationService
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal ServiceTotalPrice { get; set; }
        public decimal Quantity { get; set; }


        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public int ReservationId { get; set; }
        public virtual Reservation Reservation{ get; set; }
    }
}
