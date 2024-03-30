using System.Security.Cryptography;
using System.Text;

namespace BlazorWasm.HospitalManagementSystem.Services
{
    public static class DevCode
    {
        public static string ToInitials(this string fullName)
        {
            string[] words = fullName.Split(' ');
            string initials = "";
            foreach (string word in words)
            {
                initials += word[0];
            }
            return initials.ToUpper();
        }

        public static string ToHexColor(this string name)
        {
            using SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(name);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            byte r = hashBytes[0];
            byte g = hashBytes[1];
            byte b = hashBytes[2];

            // Convert RGB values to hexadecimal string
            string hexColor = $"#{r:X2}{g:X2}{b:X2}";
            return hexColor;
        }
    }
}
