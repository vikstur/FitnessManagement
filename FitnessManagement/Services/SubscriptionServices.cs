using FitnessManagement.Core;
using FitnessManagement.Models;
using Microsoft.EntityFrameworkCore;
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
                    r.Status == "Pending");

            if (existingRequest != null)
            {
                return false; 
            }

            var activeSubscription = _db.Subscriptions
                .FirstOrDefault(s =>
                    s.ClientId == UserSession.CurrentUser.Id &&
                    s.Status == "Active");

            if (activeSubscription != null)
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
        public List<string> GetCurrentUserSubscriptionInfo()
        {
            var result = new List<string>();

            if (UserSession.CurrentUser == null)
                return result;

            var subscriptions = _db.Subscriptions
                .Include(s => s.Type)
                .Where(s =>
                    s.ClientId == UserSession.CurrentUser.Id &&
                    s.Status == "Active")
                .ToList();

            if (subscriptions.Count == 0)
            {
                result.Add("No active subscription.");
                return result;
            }

            foreach (var subscription in subscriptions)
            {
                result.Add($"--- {subscription.Type.Name} ---");

                var services = _db.SubscriptionTypeServices
                    .Where(st => st.SubscriptionTypeId == subscription.TypeId)
                    .Select(st => st.Service.Name)
                    .ToList();

                bool fitness = services.Contains("Fitness");
                bool spa = services.Contains("SPA");
                bool pool = services.Contains("Pool");

                if (subscription.Visits == null)
                {
                    result.Add($"Fitness: {(fitness ? "Available" : "Not available")}");
                    result.Add($"Swimming Pool: {(pool ? "Available" : "Not available")}");
                    result.Add($"SPA: {(spa ? "Available" : "Not available")}");
                }
                else
                {
                    result.Add($"Fitness: {(fitness ? $"Visits left: {subscription.Visits}" : "Not available")}");
                    result.Add($"Swimming Pool: {(pool ? "Available" : "Not available")}");
                    result.Add($"SPA: {(spa ? "Available" : "Not available")}");
                }

                result.Add($"Valid to: {subscription.EndDate}");
                result.Add(""); 
            }


            return result;
        }
        public List<SubscriptionType> GetAllSubscriptionTypes()
        {
            return _db.SubscriptionTypes
                .Include(st => st.SubscriptionTypeServices)
                    .ThenInclude(sts => sts.Service)
                .ToList();
        }
        public List<SubscriptionView> GetUserSubscriptions(int userId)
        {
            return _db.Subscriptions
                .Where(s => s.ClientId == userId)
                .Include(s => s.Type)
                .AsEnumerable()
                .Select(s => new SubscriptionView
                {
                    TypeName = s.Type != null ? s.Type.Name : "Unknown",
                    StartDate = s.StartDate.ToDateTime(TimeOnly.MinValue),
                    EndDate = s.EndDate.ToDateTime(TimeOnly.MinValue),
                    Visits = s.Visits,
                    Status = s.Status
                })
                .OrderByDescending(s => s.StartDate)
                .ToList();
        }
        public void UpdateSubscriptionType(int typeId, decimal price, int duration, int? visits, List<string> serviceNames)
        {
            var subType = _db.SubscriptionTypes
                .Include(t => t.SubscriptionTypeServices)
                .FirstOrDefault(t => t.Id == typeId);

            if (subType == null) return;

            subType.Price = price;
            subType.DurationDays = duration;
            subType.Visits = visits;

            _db.SubscriptionTypeServices.RemoveRange(subType.SubscriptionTypeServices);
            var selectedServices = _db.Services
                .Where(s => serviceNames.Contains(s.Name))
                .ToList();

            foreach (var service in selectedServices)
            {
                subType.SubscriptionTypeServices.Add(new SubscriptionTypeService
                {
                    SubscriptionTypeId = typeId,
                    ServiceId = service.Id
                });
            }

            _db.SaveChanges();
        }
        public bool DeleteSubscriptionType(int typeId)
        {
            try
            {                var subType = _db.SubscriptionTypes
                    .Include(t => t.SubscriptionTypeServices)
                    .FirstOrDefault(t => t.Id == typeId);

                if (subType == null) return false;

                if (subType.SubscriptionTypeServices.Any())
                {
                    _db.SubscriptionTypeServices.RemoveRange(subType.SubscriptionTypeServices);
                }

                _db.SubscriptionTypes.Remove(subType);

                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CreateNewSubscriptionType(string name, int duration, decimal price, int? visits, List<string> selectedServiceNames)
        {
            var newType = new SubscriptionType
            {
                Name = name,
                DurationDays = duration,
                Price = price,
                Visits = visits,
                CreatedAt = DateTime.Now
            };

            _db.SubscriptionTypes.Add(newType);
            _db.SaveChanges(); 

            var dbServices = _db.Services
                .Where(s => selectedServiceNames.Contains(s.Name))
                .ToList();

            foreach (var service in dbServices)
            {
                _db.SubscriptionTypeServices.Add(new SubscriptionTypeService
                {
                    SubscriptionTypeId = newType.Id,
                    ServiceId = service.Id
                });
            }

            _db.SaveChanges();
        }
    }
}
