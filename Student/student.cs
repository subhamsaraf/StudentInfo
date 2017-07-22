using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class student
    {
        public string firstName { get;  set; }
        public string lastName { get; set; }
        public string phoneNumber { get;  set; }
        public string emailId { get; set; }
        public string Adress { get; set; }
        public string dateOfBirth { get; set; }
        public string course { get; set; }
        public string mentorName { get; set; }
        public string emergencyContactNo { get; set; }
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
