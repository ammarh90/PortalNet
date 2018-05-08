using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.ViewModels
{
    public class RegistrationViewModel:BaseViewModels
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}