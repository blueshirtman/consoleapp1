using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }   
        public Address PersonalAddress { get; set; }
        public Address ProfessionalAddress { get; set; }



    }
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Address HomeAddress { get; set; }


    }
    public class Testing
    {
    public string Name { get; set; }
    }
} 

