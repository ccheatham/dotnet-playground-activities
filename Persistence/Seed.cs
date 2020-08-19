
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
            UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        Id = "a",
                        DisplayName = "Bob",
                        UserName = "bob",
                        Email = "bob@test.com"
                    },
                    new AppUser
                    {
                        Id = "b",
                        DisplayName = "Tom",
                        UserName = "tom",
                        Email = "tom@test.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            // if (!context.Activities.Any())
            // {
            //     var activities = new List<Activity>
            //     {
            //         new Activity
            //         {
            //             Title = "Past Activity 1",
            //             Date = DateTime.Now.AddMonths(-2),
            //             Description = "Activity 2 months ago",
            //             Category = "drinks",
            //             City = "London",
            //             Venue = "Pub",
            //             UserActivities = new List<UserActivity>
            //             {
            //                 new UserActivity
            //                 {
            //                     AppUserId = "a",
            //                     IsHost = true,
            //                     DateJoined = DateTime.Now.AddMonths(-2)
            //                 }
            //             }
            //         }
            //     };

            //     await context.Activities.AddRangeAsync(activities);
            //     await context.SaveChangesAsync();
            // }
        }
    }
}
