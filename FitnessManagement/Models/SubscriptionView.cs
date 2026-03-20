using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Models
{
    public class SubscriptionView
    {
        public string TypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Visits { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            string visitsText = Visits.HasValue ? $"Visits left: {Visits}" : "Unlimited visits";

            return $"{TypeName} | {StartDate:dd.MM.yyyy} - {EndDate:dd.MM.yyyy} | {visitsText} | {Status}";
        }
    }
}
