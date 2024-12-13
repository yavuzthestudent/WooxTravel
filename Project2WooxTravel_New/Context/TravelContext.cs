using Project2WooxTravel_New.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2WooxTravel_New.Context
{
    public class TravelContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL'de varsayılan şemayı public olarak ayarla
            modelBuilder.HasDefaultSchema("public");

            base.OnModelCreating(modelBuilder);
        }
       
        public TravelContext() : base("TravelContext") {  }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }   
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Message> Messages { get; set; }
       
    }
}