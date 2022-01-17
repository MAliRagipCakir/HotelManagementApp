using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class Service
    {
        public Service()
        {
            ReservationServices = new List<ReservationService>();
        }
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
