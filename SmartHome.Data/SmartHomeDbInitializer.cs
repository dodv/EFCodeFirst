using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using SmartHome.Model.Entities;
namespace SmartHome.Data
{
    public class SmartHomeDbInitializer
    {
        private static SmartHomeContext context;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var serviceScope = serviceProvider.CreateScope()) {
                var context = serviceScope.ServiceProvider.GetService<SmartHomeContext>();
                InitializeSchedules(context);
            }
        }

        private static void InitializeSchedules(SmartHomeContext context) 
        {
            if (!context.Users.Any())
            {
                User user_01 = new User { NickName= "User1",UserName="user1",Password="xx" };
                context.Users.Add(user_01);
                context.SaveChanges();
            }

            context.SaveChanges();
        }
    }
}
