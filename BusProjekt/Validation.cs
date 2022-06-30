using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusProjekt
{
    public class Validation
    {
        public bool EmailValidation(string email)
        {
            var trimmedEmail = email.Trim();
            bool mailBuit = string.IsNullOrEmpty(email);
            if (trimmedEmail.EndsWith(".") || mailBuit)
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }


        public bool NameValidation(string name)
        {
            bool nameHasNumbers = int.TryParse(name, out int number);
            if (!nameHasNumbers) { return true; } else { return false; }
        }



    }
}