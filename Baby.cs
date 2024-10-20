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


        public Baby() //Default Constructor.
        {
            Console.WriteLine("Baby name is: Daisy " + "\nBaby lastname is: Pays " + "\nBaby birthdate is: " + "\nIngaaaaaaaaa " + DateTime.Now);
        }

        public Baby() //Alternative Constructor.
        {
            name = "Daisy";
            lastname = "Pays";
            birthDate = DateTime.Now;
        }

    }
}
