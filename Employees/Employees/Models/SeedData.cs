using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace Employees.Models
{
    public static class SeedData
    {
        public static void SeedEmployee(IApplicationBuilder app)
        {
            ListDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ListDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {                       
                        Name = "Cuong",
                        Birthday = new DateTime(1992,01,05),
                        Address = "Ninh Binh",
                        Email = "cuongtrinh5192@gmail.com",
                        Phone = "0855919109"
                        
                    },
                    new Employee
                    {
                        Name = "Tuan",
                        Birthday = new DateTime(1990, 05, 05),
                        Address = "Ha Noi",
                        Email = "nvtuan90@gmail.com",
                        Phone = "0876534321"

                    },
                    new Employee
                    {
                        Name = "Huy",
                        Birthday = new DateTime(1996, 06, 19),
                        Address = "Quang Ninh",
                        Email = "huytc96@gmail.com",
                        Phone = "0987687853"

                    },
                    new Employee
                    {
                        Name = "Tu",
                        Birthday = new DateTime(1990, 01, 29),
                        Address = "Hai Phong",
                        Email = "tuhh90@gmail.com",
                        Phone = "0384732834"

                    },
                    new Employee
                    {
                        Name = "Thanh",
                        Birthday = new DateTime(1997, 07, 19),
                        Address = "Bac Ninh",
                        Email = "thanhtt97@gmail.com",
                        Phone = "0973826921"
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
