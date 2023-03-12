using Enttylayer.concrate;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact = Enttylayer.concrate.Contact;

namespace DataAcsesLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MKUMRU\\MSSQLSERVER01;database=CoreProjeDb;User Id=MKUMRU\\Mkumru; integrated security=true;TrustServerCertificate=True");
          


        }
        public DbSet<About>  Abouts { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<sosıalMedia> SosıalMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
