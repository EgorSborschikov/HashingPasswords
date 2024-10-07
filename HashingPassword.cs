using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp{
    public static class HashingPassword{

        public static string HashPassword(string password){
            using (SHA256 sha256 = SHA256.Create()){
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }

        }

    }

}