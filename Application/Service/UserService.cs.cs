using Application.Interface;
using Application.Interfaces;
using Domain.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Register a new user and hash their password
        public async Task<User> RegisterUserAsync(User user, string password)
        {
            // Hash the password
            var hashedPassword = HashPassword(password);
            user.PasswordHash = hashedPassword;
            user.AddedOn = DateTime.Now;

            // Store the user in the database
            await _unitOfWork.UserRepository.CreateUserAsync(user);
            await _unitOfWork.CompleteAsync();
            return user;
        }

        // Login the user by verifying the password
        public async Task<User> LoginUserAsync(string phone, string password)
        {
            var user = await _unitOfWork.UserRepository.GetUserByPhoneAsync(phone);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            // Verify the password
            var isPasswordValid = VerifyPassword(password, user.PasswordHash);
            if (!isPasswordValid)
            {
                throw new Exception("Invalid credentials.");
            }

            return user;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.UserRepository.GetUserByIdAsync(id);
        }

        // Helper method to hash the password
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Helper method to verify the password
        private bool VerifyPassword(string password, string storedHash)
        {
            var hashedPassword = HashPassword(password);
            return hashedPassword == storedHash;
        }

    }
}
