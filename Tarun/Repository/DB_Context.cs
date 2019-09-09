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
        DbSet<Admin> Admins { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Report> Reports { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Service_Provider> Service_Providers { get; set; }
        DbSet<ServiceRequest> ServiceRequests { get; set; }
        DbSet<ServiceRequester> ServiceRequesters { get; set; }

    }
}
