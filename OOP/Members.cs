using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Members
    {
        // member private field
        private string _memberName;
        private string _jobTitle;
        private int _salary;

        // mamber - public data

        public int age;
 
        // member - property
        public string Jobtitle { get
            {
                return _jobTitle;
            } set 
            {
                 _jobTitle = value;
            } 
        }

        // public memmber method
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }else
            {
                Console.WriteLine($"Hi,my name is {_memberName},and my job title is {_jobTitle}.I am {age} years old. ");
            }
        }

        private void SharingPrivateInfo ()
        {
            Console.WriteLine($"My salary is {_salary}.");
        }

        public Members()
        {
            age = 30;
            _memberName = "Ilija";
            _salary = 60000;
            _jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member  -  finaliser - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}
