using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Models
{
    public class RequestViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Status { get; set; }

        public DateTime? RequestedAt { get; set; }

        public string Display
        {
            get
            {
                return $"{Id} | {FirstName} {LastName} | {Status} | {RequestedAt}";
            }
        }
    }
}
