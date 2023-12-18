using System.Text.RegularExpressions;


namespace Blog_Project.Models
{
    public class ValidateUser
    {
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid email address.");
                return false;
            }
        }
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z]).{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password Must Be more Than 8 char With one Letter ");
                return false;
            }
        }
        public static bool ValidateAge(int? age)
        {
            if (age > 15) return true;
            else
            {
                MessageBox.Show("Age Must Be more Than 15");
                return false;
            }
        }
        public static bool IsUserNameValid(string userName, BlogContext context)
        {
            string pattern = @"^(?=.*[A-Z])[a-zA-Z]{3,20}$";
            if (userName == null)
            {
                MessageBox.Show(" Invalid Username");
                return false;
            }
            else if (context.Authers.Any(i => i.userName == userName))
            {
                MessageBox.Show(" Username Isn't available");
                return false;
            }
            else if (Regex.IsMatch(userName, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show(" Username Must Be More Than 2 char less than 20 char ");
                return false;
            }
        }
    }
}
