using System;
using System.Collections.Generic;
using System.Text;
using SmartHome.Model.Entities;

namespace SmartHome.Data.Abstract
{
    public interface IHomeRepository : IEntityBaseRepository<Home> { }

    public interface IDeviceRepository : IEntityBaseRepository<Device> { }

    public interface IRoomRepository : IEntityBaseRepository<Room> { }

    public interface IUserRepository : IEntityBaseRepository<User> { }
   
}
