using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Student
{
    public class Input
    {
        Validate validate = new Validate();
        student inputObject = new student();
        public void SendToFile()
        {
            String path = @"D:\Student";
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                Console.WriteLine("Folder already exists");
            }
            else
            {
                directory.Create();
                {
                    Console.WriteLine("Directory has been created");
                }
            }
            if (!File.Exists(path+@"\" + inputObject.firstName + inputObject.phoneNumber + ".txt"))
            {
                using (File.Create(path + @"\"+ inputObject.firstName + inputObject.phoneNumber + ".txt")) ;


                }
            File.WriteAllText(path + @"\" + inputObject.firstName + inputObject.phoneNumber + ".txt", inputObject.ToString());

        }

        public void FirstName()
        {
            Console.WriteLine("Enter the First Name :");
            string input = Console.ReadLine();
            if (validate.NameValidation(input))
            {
                inputObject.firstName = input;
            }
            else
            {
                FirstName();
            }
        }

        public void LastName()
        {
            Console.WriteLine("Enter the Last Name :");
            string input = Console.ReadLine();
            if (validate.NameValidation(input))
            {
                inputObject.lastName = input;
            }
            else
            {
                LastName();
            }
        }
        public void MobileNumber()
        {
            Console.WriteLine("Enter the Phone Number:");
            string input = Console.ReadLine();
            if (validate.ValidatePhoneNumber(input))
            {
                inputObject.phoneNumber = input;
            }
            else
            {
                MobileNumber();
            }
        }
        public void Email()
        {
            Console.WriteLine("Enter the Email Adress");
            string input = Console.ReadLine();
            if (validate.EmailValidation(input))
            {
                inputObject.emailId = input;
            }
            else
            {
                Email();
            }
        }
        public void Adress()
        {
            Console.WriteLine("Enter the Adress:");
            string input = Console.ReadLine();
            if (validate.NameValidation(input))
            {
                inputObject.Adress = input;
            }
            else
            {
                Adress();
            }
        }
        //}
        //public void DateOfBirth()
        //{
        //    Console.WriteLine("Enter the Date of birth:");
        //    DateTime input;
        //    bool isDob = DateTime.TryParse(Console.ReadLine(), out input);
        //    if (!isDob)
        //    {

        //    }
        //    inputObject.dateOfBirth = input;
        //}

        public void DateOfBirth()
        {
            Console.WriteLine("Enter the Date of birth:");
            string input = Console.ReadLine();
            //bool isDob = DateTime.TryParse(Console.ReadLine(), out input);
           // if (isDob)
            //{
                inputObject.dateOfBirth = input;
            //}
            //else
            //{
            //    DateOfBirth();
            //}
        }
        public void Course()
        {
            Console.WriteLine("Enter the Currently Persuing Course:");
            string input = Console.ReadLine();
            if (validate.NameValidation (input))
            {
                inputObject.course = input;
            }
            else
            {
                Course();
            }
        }
        public void MentorName()
        {
            Console.WriteLine("Enter the Mentor Name:");
            string input = Console.ReadLine();
            if (validate.NameValidation(input))
            {
                inputObject.mentorName = input;
            }
            else
            {
                MentorName();
            }
        }
        public void AlternateContactNumber()
        {
            Console.WriteLine("Enter the Alternate Mobile Number:");
            string input = Console.ReadLine();
            if (validate.ValidatePhoneNumber(input))
            {
                inputObject.emergencyContactNo = input;
            }
            else
            {
                AlternateContactNumber();
            }
        }
    }
}
