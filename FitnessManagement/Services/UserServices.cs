using FitnessManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManagement.Services
{
    public class UserServices
    {
        private FitnessManagementDBContext _db;
         public UserServices()
        {
            _db = new FitnessManagementDBContext();
        }

        public void CreateUser(string email, string firstName,string lastName,string password,string phone)
        {
            bool emailExists = _db.Users.Any(u => u.Email == email);

            if (emailExists) 
                {
                MessageBox.Show("This email is already registered.");
                return;
            }
            User user = new User
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Phone = phone,
                Role = "Client",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            MessageBox.Show("Registration successful.");

        }
    }
}
