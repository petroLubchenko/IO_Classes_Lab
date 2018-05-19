using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab.Interfaces
{
    interface IHuman
    {
        string Firstname { get; }
        string Secondname { get; }

        void ChangeName(string firstname);
        void ChangeName(string firstname, string secondname);
        void ChangeSecondName(string secondname);
    }
}
