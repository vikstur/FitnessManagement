using FitnessManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FitnessManagement.Services
{
    
    public class VisitsServices
    {
        private FitnessManagementDBContext _db;
        public VisitsServices()
        {
            _db = new FitnessManagementDBContext();
        }
        public List<VisitsView> GetVisitsByDate(DateTime date)
        {
            var visits = _db.Attendances
                .Where(a => a.CheckInTime.Date == date.Date)
                .Select(a => new VisitsView
                {
                    ClientName = a.Client.FirstName + " " + a.Client.LastName,
                    SubscriptionType = a.Subscription.Type.Name,
                    CheckInTime = a.CheckInTime
                })
                .ToList();

            return visits;
        }
    }
}
