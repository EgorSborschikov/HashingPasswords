using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;

namespace registration_and_heshing_password{
    public class RegistrationMain{
        public void RegisterUser(){
            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = ReadPasswordFromConsole();

            Users user = new Users(fullName, email, password);
            string json = JsonSerializer.Serialize(user);

            string filePath = @"users.json";
            File.AppendAllText(filePath, json + Environment.NewLine);
        }

        private string ReadPasswordFromConsole(){
            string password = "";
            while (true){
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter){
                    Console.WriteLine();
                    break;
                }else if (cki.Key == ConsoleKey.Backspace){
                    if (password.Length > 0)
                    {
                        Console.Write("\b \b");
                        password = password.Substring(0, password.Length - 1);
                    }
                }else{
                    Console.Write("*");
                    password += cki.KeyChar;
                }
            }
            return password;
        }
    }
}