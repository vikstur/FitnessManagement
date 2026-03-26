using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Models
{
    public class VisitsView
    {
        public string ClientName { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime CheckInTime { get; set; }

        public override string ToString()
        {
            return $"{ClientName} | {SubscriptionType} | {CheckInTime:dd.MM.yyyy HH:mm}";
        }
    }
}
