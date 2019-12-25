using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartHome.Model.Entities
{
    [Table("Device")]
    public class Device : IEntityBase
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        //device icon
        public string IconUrl { get; set; }
       
        //Whether the device is online (LAN or Cloud Online)
        public bool IsOnline { get; set; }
        
        //device's name
        public string Name { get; set; }
        
        //Device Control Data Point Type Information
        public string Schema { get; set; }

        //Product ID, the same product ID, Schema information consistent
        public string ProductId { get; set; }

        //Device Activation Time
        public long Time { get; set; }

        //Gateway Protocol Version
        public string GPV { get; set; }

        //Gateway Universal Firmware Version
        public string GUFV { get; set; }

        //Schema Cached Data
        public string SchemaMap { get; set; }

        //a shared device
        public bool IsShare { get; set; }

        public bool Virtual { get; set; }

        public double Lon { get; set; }
        public double Lat { get; set; }

        public int Type { get; set; }

        //Device for gateway and subdevice type, which is an attribute of subdevice and identifies its gateway ID
        public string MeshId { get; set; }

        public bool SpZigbee { get; set; }

        public bool SpWifi { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime CreateDate { get; set; }

        public User User { get; set; }
        public Home Home { get; set; }

        public Room Room { get; set; }
    }
}
