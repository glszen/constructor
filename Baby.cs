using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Baby
    {
        public string name;
        public string lastname;
        public DateTime birthDate;

        public string Name { get { return name; } set { name = value; } }

        public string LastName { get { return lastname; } set { lastname = value; } }

        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }


        public Baby() //Default Constructor.
        {
            birthDate = DateTime.Now;
            Console.WriteLine("Ingaaaaaaaaa ");
        }

        public Baby(string name, string lastname) //Alternative Constructor.
        {
            Name = name;
            LastName = lastname;
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaaaa ");
        }

    }
}
