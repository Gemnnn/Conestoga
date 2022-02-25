using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Identity;

namespace QuarterlySales.Models
{
    public class SalesContext : IdentityDbContext<User>
    {
        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        { }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Firstname = "Ada",
                    Lastname = "Lovelace",
                    DOB = new DateTime(1956, 12, 10),
                    DateOfHire = new DateTime(1995, 1, 1),
                    ManagerId = 0  // has no manager
                },
                new Employee
                {
                    EmployeeId = 2,
                    Firstname = "Katherine",
                    Lastname = "Johnson",
                    DOB = new DateTime(1966, 8, 26),
                    DateOfHire = new DateTime(1999, 1, 1),
                    ManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 3,
                    Firstname = "Grace",
                    Lastname = "Hopper",
                    DOB = new DateTime(1975, 12, 9),
                    DateOfHire = new DateTime(1999, 1, 1),
                    ManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 4,
                    Firstname = "Homer",
                    Lastname = "Simpson",
                    DOB = new DateTime(1960, 3, 1),
                    DateOfHire = new DateTime(1996, 1, 1),
                    ManagerId = 0  // has no manager
                },
                new Employee
                {
                    EmployeeId = 5,
                    Firstname = "Bart",
                    Lastname = "Simpson",
                    DOB = new DateTime(1980, 5, 8),
                    DateOfHire = new DateTime(2002, 1, 1),
                    ManagerId = 4
                },
                new Employee
                {
                    EmployeeId = 6,
                    Firstname = "Marge",
                    Lastname = "Simpson",
                    DOB = new DateTime(1962, 12, 9),
                    DateOfHire = new DateTime(1999, 1, 1),
                    ManagerId = 0
                },
                new Employee
                {
                    EmployeeId = 7,
                    Firstname = "Lisa",
                    Lastname = "Simpson",
                    DOB = new DateTime(1982, 8, 5),
                    DateOfHire = new DateTime(2005, 1, 1),
                    ManagerId = 6
                },
                new Employee
                {
                    EmployeeId = 8,
                    Firstname = "Maggie",
                    Lastname = "Simpson",
                    DOB = new DateTime(2005, 8, 26),
                    DateOfHire = new DateTime(2010, 1, 1),
                    ManagerId = 6
                }
            );

            modelBuilder.Entity<Sales>().HasData(
                new Sales
                {
                    SalesId = 1,
                    Quarter = 4,
                    Year = 2019,
                    Amount = 23456,
                    EmployeeId = 2
                },
                new Sales
                {
                    SalesId = 2,
                    Quarter = 1,
                    Year = 2020,
                    Amount = 34567,
                    EmployeeId = 2
                },
                new Sales
                {
                    SalesId = 3,
                    Quarter = 4,
                    Year = 2019,
                    Amount = 19876,
                    EmployeeId = 3
                },
                new Sales
                {
                    SalesId = 4,
                    Quarter = 1,
                    Year = 2020,
                    Amount = 31009,
                    EmployeeId = 3
                },
                new Sales
                {
                    SalesId = 5,
                    Quarter = 3,
                    Year = 2019,
                    Amount = 33476,
                    EmployeeId = 4
                },
                new Sales
                {
                    SalesId = 6,
                    Quarter = 2,
                    Year = 2020,
                    Amount = 24555,
                    EmployeeId = 5
                },
                new Sales
                {
                    SalesId = 7,
                    Quarter = 3,
                    Year = 2019,
                    Amount = 29123,
                    EmployeeId = 6
                },
                new Sales
                {
                    SalesId = 8,
                    Quarter = 4,
                    Year = 2020,
                    Amount = 21111,
                    EmployeeId = 7
                },
                new Sales
                {
                    SalesId = 9,
                    Quarter = 2,
                    Year = 2019,
                    Amount = 33456,
                    EmployeeId = 6
                },
                new Sales
                {
                    SalesId = 10,
                    Quarter = 3,
                    Year = 2020,
                    Amount = 14567,
                    EmployeeId = 5
                },
                new Sales
                {
                    SalesId = 11,
                    Quarter = 4,
                    Year = 2019,
                    Amount = 29876,
                    EmployeeId = 4
                },
                new Sales
                {
                    SalesId = 12,
                    Quarter = 1,
                    Year = 2020,
                    Amount = 21009,
                    EmployeeId = 3
                }
            );
        }
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "P@ssw0rd";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
            // if username doesn't exist, create it and add it to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
