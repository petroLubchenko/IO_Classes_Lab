using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public abstract class Base
    {
        private Guid id;
        public Guid Id {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        public Base()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return Id;
        }

    }
}
