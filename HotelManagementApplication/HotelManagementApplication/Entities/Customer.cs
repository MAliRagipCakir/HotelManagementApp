using HotelManagementApplication.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class Customer
    {
        public Customer()
        {
            MyReservations = new List<Reservation>();
        }
        public int Id { get; set; }

        [Required,MaxLength(30)]
        public string FullName { get; set; }

        [Required,MinLength(11),MaxLength(11)]
        public string IdentityNumber { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Reservation> MyReservations { get; set; }
    }
}
