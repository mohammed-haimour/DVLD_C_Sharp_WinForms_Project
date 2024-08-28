using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Presentation.Global
{
    public static class Functions
    {

        public static void TextValidation(TextBox text , CancelEventArgs e , ErrorProvider errorProvider) {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                e.Cancel = true;
                text.Focus();
                errorProvider.SetError(text, "Please Fill The Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(text, "");
            }
        }

    }
}
