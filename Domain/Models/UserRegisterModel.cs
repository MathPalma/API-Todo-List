using System.Security.Cryptography;
using System.Text;

namespace Domain.Models
{
    public class UserRegisterModel
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRegisterModel(string firstName, string lastName, string username, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Email = email;
            Password = HashPassword(password);
        }

        static string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();
            byte[] passwordBytes = Encoding.Default.GetBytes(password);
            var hashedPassword = hash.ComputeHash(passwordBytes);

            return Convert.ToHexString(hashedPassword);
        }

    }
}
