using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartHome.Model.Entities
{
    [Table("Room")]
    public class Room :IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string RoomName { get; set; }
        public DateTime LastUpdate { get; set; }

        public DateTime CreateDate { get; set; }

        //reference
        public Home Home { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
