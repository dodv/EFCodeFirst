using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SmartHome.Model.Entities
{
    [Table("User")]
    public class User : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public string PhoneCode { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public DateTime LastUpdate { get; set; }

        public DateTime CreateDate { get; set; }

        //references

        public ICollection<Home> Homes { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
