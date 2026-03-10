using System;
using System.Collections.Generic;
using System.Text;
using FitnessManagement.Models;
using FitnessManagement.Core;

namespace FitnessManagement.Services
{
   
    public class AttendanceServices
    {
        private FitnessManagementDBContext _db;

        public AttendanceServices()
        {
            _db = new FitnessManagementDBContext();
        }

        // Get users with ACTIVE subscriptions
        public List<User> GetUsersWithActiveSubscriptions()
        {
            return _db.Subscriptions
                .Where(s => s.Status == "Active" && s.EndDate >= DateOnly.FromDateTime(DateTime.Now))
                .Select(s => s.Client)
                .Distinct()
                .ToList();
        }

        // Get active subscription for user
        public Subscription GetActiveSubscription(int userId)
        {
            return _db.Subscriptions
                .FirstOrDefault(s =>
                    s.ClientId == userId &&
                    s.Status == "Active" &&
                    s.EndDate >= DateOnly.FromDateTime(DateTime.Now));
        }

        // Create attendance
        public void CreateAttendance(int clientId, int serviceId, DateTime checkInTime)
        {
            var subscription = GetActiveSubscription(clientId);

            if (subscription == null)
                return;

            var attendance = new Attendance
            {
                ClientId = clientId,
                SubscriptionId = subscription.Id,
                ServiceId = serviceId,
                CheckInTime = checkInTime,
                CheckedBy = UserSession.CurrentUser.Id
            };

            _db.Attendances.Add(attendance);

            // decrease visits if basic subscription
            if (subscription.Visits != null)
            {
                subscription.Visits -= 1;

                if (subscription.Visits <= 0)
                    subscription.Status = "Expired";
            }

            _db.SaveChanges();
        }

        // Check if subscription is BASIC
        public bool IsBasicSubscription(int userId)
        {
            var sub = _db.Subscriptions
                .FirstOrDefault(s => s.ClientId == userId && s.Status == "Active");

            if (sub == null)
                return false;

            return sub.Visits != null;
        }
    }
}
