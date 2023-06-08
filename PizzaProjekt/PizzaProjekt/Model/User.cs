using PizzaProjekt.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PizzaProjekt.Model
{
    public class User
    {

        private int _id;
        private string _name, _password;

        public User(string name, string password)
        {
            _id = 0;
            _name = password;
            _password = password;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new PasswordMustBeLongerThan5Char();
                }
                _password = value;
            }
        }


    }
}
