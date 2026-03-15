using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Models
{
   public class AttendanceView
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string ServiceName { get; set; }

        public DateTime? CheckInTime { get; set; }

        public string CheckedBy { get; set; }

        public override string ToString()
        {
            return $"{ClientName} | {ServiceName} | {CheckInTime:dd.MM.yyyy HH:mm} | Checked by: {CheckedBy}";
        }
    }
}
