using BCrypt.Net;
using FitnessManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessManagement.Core;


namespace FitnessManagement.Services
{
    public class UserServices
    {

        private FitnessManagementDBContext _db;
         public UserServices()
        {
            _db = new FitnessManagementDBContext();
        }

        public static class PasswordHelper
        {
            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }

            public static bool VerifyPassword(string enteredPassword, string storedHash)
            {
                return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
            }
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
        public void LoginUser(string email, string password)
        {
            var user = _db.Users
            .FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            bool isCorrect = PasswordHelper.VerifyPassword(password, user.Password);

            if (!isCorrect)
            {
                MessageBox.Show("Wrong password.");
                return;
            }
            UserSession.CurrentUser = user;
            MessageBox.Show("Login successful!");
        }
        public void CreateRequest(int subscriptionTypeId)
        {
            var existingRequest = _db.PurchaseRequests
               .FirstOrDefault(r =>
                   r.ClientId == UserSession.CurrentUser.Id &&
                   r.TypeId == subscriptionTypeId &&
                   r.Status == "Pending");

            if (existingRequest != null)
            {
                MessageBox.Show("You already have a pending request for this subscription.");
                return;

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

            
        }
    }
}
