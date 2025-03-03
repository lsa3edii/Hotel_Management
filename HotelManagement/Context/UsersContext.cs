using Lab15.Configurations;
using Lab15.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab15.Context.ReservationContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab15.Context
{
    class UsersContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LOGIN_MANAGER2"].ConnectionString);
    
        
        public virtual DbSet<FrontendUser> FrontendUsers { get; set; }
        public virtual DbSet<KitchenUser> KitchenUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new FrontendUserConfiguration());
            //modelBuilder.ApplyConfiguration(new KitchenUserConfigurations());

            
            modelBuilder.Entity<FrontendUser>(builder =>
            {
                builder.HasIndex(u => u.Username)
                        .IsUnique();
            });


            modelBuilder.Entity<KitchenUser>(builder =>
            {
                builder.HasIndex(u => u.Username)
                       .IsUnique();
            });


            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<FrontendUser>().HasBaseType<User>();
            modelBuilder.Entity<KitchenUser>().HasBaseType<User>();
        }


        public User? AuthenticateUser(string username, string password)
        {
            return Database
                .SqlQueryRaw<User>($"exec AuthenticateUser @Username, @Password",
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password))
                .FirstOrDefault();
        }


        //public record UserRecord(
        //    int UserID,
        //    string Username,
        //    string Password,
        //    string Discriminator
        //);

        //public async Task<User?> AuthenticateUser(string username, string password)
        //{
        //    var result = await Database
        //        .SqlQueryRaw<UserRecord>(
        //            "EXEC AuthenticateUser @Username, @Password",
        //            new SqlParameter("@Username", username),
        //            new SqlParameter("@Password", password))
        //        .FirstOrDefaultAsync();

        //    if (result == null)
        //        return null;

        //    return result.Discriminator switch
        //    {
        //        "FrontendUser" => new FrontendUser { UserID = result.UserID, Username = result.Username, Password = result.Password },
        //        "KitchenUser" => new KitchenUser { UserID = result.UserID, Username = result.Username, Password = result.Password },
        //        _ => null // If an unknown type is encountered, return null.
        //    };
        //}

    }
}
