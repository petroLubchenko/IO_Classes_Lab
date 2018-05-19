using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab.Classes
{
    class Cargo
    {
        public string CargoName { get; private set; }
        public string Description { get; private set; }

        public Cargo(string name, string description)
        {
            CargoName = name;
            Description = description;
        }
    }
}
