using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Student
{
    class FirstWindow
    {
        public void display()
        {
            Console.WriteLine("Select the Function that you want to perform: \n 1.)Create a entry\n 2.)View all saved records\n 3.)View Particular Record \n 4.)Update a Particular Record");
            Console.WriteLine("Your Choice in the serial nuumber:");
            int choice = Convert.ToInt32 (Console.ReadLine());
            if(choice==1)
            {
                Console.Clear();
                Console.WriteLine("Enter the Details to be stored : \n \n ");
                Input input = new Input();
                input.FirstName();
                input.LastName();
                input.MobileNumber();
                input.Email();
                input.Adress();
                input.DateOfBirth();
                input.Course();
                input.MentorName();
                input.AlternateContactNumber();
                input.SendToFile();
            }
            else if(choice==2)
            {
                Console.Clear();
                Console.WriteLine("All the files are : \n \n");
                string[] fileEntries = Directory.GetFiles(@"D:\Student");
                for(int i=0;i<fileEntries.Length;i++)
                {
                    string res = fileEntries[i].Substring(11, fileEntries[i].Length - 15);
                    Console.WriteLine(res);
                }
                //foreach (string fileName in fileEntries)
                //    ProcessFile(fileName);


            }
            else if(choice==3)
            {

                while (true)
                {
                    Console.WriteLine("Enter the name of the record you want to view:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the phone number");
                    string phone = Console.ReadLine();
                    string filename = @"D:\Student\" + name + phone + ".txt";
                    if (File.Exists(filename))
                    {
                        student inputStudent = JsonConvert.DeserializeObject<student>(File.ReadAllText(filename));
                        PrintObject(inputStudent);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Record Doesn't Exist");

                    }
                }
            }
            else if(choice==4)
            {

            }
            else
            {
                Console.WriteLine("invalid choice : \n Enter a valid choice \n\n");
                display();
            }
            void PrintObject(student inputStudent)
            {
                Console.WriteLine(inputStudent);
            }
        }
    }
}
