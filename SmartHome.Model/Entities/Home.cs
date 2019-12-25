using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartHome.Model.Entities
{
    [Table("Home")]
    public class Home : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public double Lon { get; set; }
        public double Lat { get; set; }
        public string GeoName { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }

        public DateTime CreateDate { get; set; }
        //reference

        public ICollection<User> Users { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
