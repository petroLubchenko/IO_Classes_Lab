using IO_Classes_Lab.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab.Classes
{
    class Passanger : Cargo, IHuman
    {
        public string Firstname { get; private set; }
        public string Secondname { get; private set; }


        public Passanger(string firstname, string secondname) : base("Passanger", firstname + secondname)
        {
            Firstname = firstname;
            Secondname = secondname;
        }

        public void ChangeName(string firstname)
        {
            Firstname = firstname;
        }

        public void ChangeName(string firstname, string secondname)
        {
            Firstname = firstname;
            Secondname = secondname;
        }

        public void ChangeSecondName(string secondname)
        {
            Secondname = secondname;
        }
    }
}
