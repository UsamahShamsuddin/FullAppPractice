using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAPDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _textBoxEmail;

        public string TextBoxEmail
        {
            get { return _textBoxEmail; }
            set
            {
                _textBoxEmail = value;
                NotifyOfPropertyChange(() => TextBoxEmail);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        private string _password;

        public string TextPassword
        {
            get { return _password; }
            set 
            {
                _password = value;
                NotifyOfPropertyChange(() => TextPassword);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get 
            {
                bool output = false;

                if (TextBoxEmail?.Length > 0 && TextPassword?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }


        public void LogIn()
        {
            
        }
    }
}
