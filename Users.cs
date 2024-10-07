using ConsoleApp;

namespace registration_and_heshing_password{
    public class Users{
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public Users(string fullName, string email, string password){
            FullName = fullName;
            Email = email;
            PasswordHash = HashingPassword.HashPassword(password);
        }
    }
}