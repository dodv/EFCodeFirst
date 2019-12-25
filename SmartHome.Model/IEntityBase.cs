using System;

namespace SmartHome.Model
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
