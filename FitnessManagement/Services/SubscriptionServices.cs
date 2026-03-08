using FitnessManagement.Core;
using FitnessManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Services
{
    public class SubscriptionServices
    {
        private FitnessManagementDBContext _db;
        public SubscriptionServices()
        {
            _db = new FitnessManagementDBContext();
        }
        public List<RequestViewModel> GetPendingRequests() => _db.PurchaseRequests
        .Where(r => r.Status == "Pending")
        .Select(r => new RequestViewModel
        {
            Id = r.Id,
            FirstName = r.Client.FirstName,
            LastName = r.Client.LastName,
            Status = r.Status,
            RequestedAt = r.RquestedAt
        })
        .ToList();

        public bool CreateRequest(int subscriptionTypeId)
        {
            var existingRequest = _db.PurchaseRequests
                .FirstOrDefault(r =>
                    r.ClientId == UserSession.CurrentUser.Id &&
                    r.TypeId == subscriptionTypeId &&
                    r.Status == "Pending");

            if (existingRequest != null)
            {
                return false;
            }

            var request = new PurchaseRequest
            {
                ClientId = UserSession.CurrentUser.Id,
                TypeId = subscriptionTypeId,
                Status = "Pending",
                RquestedAt = DateTime.Now,
                ProcessedAt = null
            };

            _db.PurchaseRequests.Add(request);
            _db.SaveChanges();

            return true;
        }
        
        public void ApproveRequest(int requestId)
        {
            var request = _db.PurchaseRequests
                .FirstOrDefault(r => r.Id == requestId);

            if (request == null)
                return;

            request.Status = "Approved";
            request.ProcessedAt = DateTime.Now;

            // Get subscription type
            var type = _db.SubscriptionTypes
                .FirstOrDefault(t => t.Id == request.TypeId);

            if (type == null)
                return;

            var subscription = new Subscription
            {
                ClientId = request.ClientId,
                TypeId = request.TypeId,
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(type.DurationDays)),
                Visits = type.Visits,
                Status = "Active",
                CreatedAt = DateTime.Now
            };

            _db.Subscriptions.Add(subscription);
            _db.SaveChanges();
        }
        public void RejectRequest(int requestId)
        {
            var request = _db.PurchaseRequests
                .FirstOrDefault(r => r.Id == requestId);

            if (request == null)
                return;

            request.Status = "Rejected";
            request.ProcessedAt = DateTime.Now;

            _db.SaveChanges();
        }
       
    }
}
