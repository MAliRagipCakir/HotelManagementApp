using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class Room
    {
        public Room()
        {
            Features = new List<Feature>();
            Reservations = new List<Reservation>();
        }
        public int Id { get; set; }
        [Required,MaxLength(15, ErrorMessage ="Room Name is Max(15) characters")]
        public string RoomName { get; set; }

        [Required,Range(1,10,ErrorMessage="Room Capacity is Min(1) and Max(10)")]
        public int Capacity { get; set; }

        public decimal PricePerDay { get; set; }

        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
