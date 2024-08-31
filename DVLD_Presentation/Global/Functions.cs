using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Presentation.Global
    // thhis in
{
    public static class Functions
    {

        public static void TextValidation(TextBox text , CancelEventArgs e , ErrorProvider errorProvider , string message) {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                e.Cancel = true;
                text.Focus();
                errorProvider.SetError(text, message);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(text, "");
            }
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }



    }
}
