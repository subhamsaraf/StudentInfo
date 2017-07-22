using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Validate
    {
        public bool NameValidation(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            public bool ValidatePhoneNumber(string phoneNumber)
            {
                if (Regex.Match(phoneNumber, @"^([0-9]{10})$").Success)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        public bool EmailValidation(string email)
        {
            if(Regex.Match(email, @"^.+@[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool AdressValidation(string adress)
        //{

        //}
        //public bool 
    }
}
