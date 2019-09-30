using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Repository
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context>options):base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Service_Provider> Service_Providers { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Service_Requester> Service_Requesters{ get;set; }
        public DbSet<Gender> Genders { get; set; }

    }
}
