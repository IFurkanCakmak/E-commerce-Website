using FurkanProject.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanProject.Core.Model
{
    public class FurkanDB :DbContext
    {

        //Tablolar
        public FurkanDB()
            :base(@"Data Source=.;Initial Catalog=FurkanProjectDB;Integrated Security=True")
        {
           
        }
        
        public DbSet<User> Users { get; set; }

        public DbSet<UserAddress>Addresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product>Products { get; set; }

        public DbSet<Status>Statuses  { get; set; }

        public DbSet<Cart>Carts { get; set; }

        public DbSet<Order>Orders { get; set; }

        public DbSet<OrderProduct>OrderProducts { get; set; }

        public DbSet<OrderPayment>OrderPayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
