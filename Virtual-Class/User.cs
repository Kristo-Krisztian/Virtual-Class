using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual_Class
{
    class User
    {
        private string _userName;
        private string _password;
        private bool _isAdmin;

        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return "This is a big secret,wait for md5";
            }
            set
            {
                _password = value;
            }
        }

        public bool IsAdmin
        {
            get
            {
                return _isAdmin;
            }

            set
            {
                _isAdmin = value;
            }
        }
    }
}
