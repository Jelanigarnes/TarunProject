﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Data;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ServiceRequestRepository : IServiceRequest
    {
        private ApplicationDbContext db;
        public ServiceRequestRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<ServiceRequest> GetServiceRequests => db.ServiceRequests.Include(sr=>sr.Service_Requester).Include(s => s.Service);

        public void Add(ServiceRequest _ServiceRequest)
        {
            db.ServiceRequests.Add(_ServiceRequest);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Find(ID);
            db.ServiceRequests.Remove(dbEntity);
            db.SaveChanges();
        }

        public ServiceRequest GetServiceRequest(int? ID)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Include(sr => sr.Service_Requester)
                                                        .Include(s => s.Service)
                                                        .SingleOrDefault(sm => sm.ServiceRequestID == ID);
            return dbEntity;
        }
    }
}
