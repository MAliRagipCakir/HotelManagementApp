using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementData.Entities
{
    public class Feature
    {
        public Feature()
        {
            Rooms = new List<Room>();
        }
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string FeatureName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
