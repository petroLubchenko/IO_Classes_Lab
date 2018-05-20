using IO_Classes_Lab.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class Driver : Base, IHuman
    {
        private static String LastOperation
        {
            set
            {
                LastOperation = value;
            }
        }

        public static List<Driver> Drivers = new List<Driver>();
        private Route route;

        public string Firstname { get; private set; }
        public string Secondname { get; private set; }
        public string Name
        {
            get
            {
                return String.Format("{0} {1}", Firstname, Secondname);
            }
        }
        public readonly DateTime Birthday;
        public Route Route {
            get
            {
                return route;
            }
            set
            {
                route.Drivers.Remove(this);
                route = value;
                route.SetDriver = this;
            }
        }
        public List<License> Licenses
        {
            get
            {
                List<License> lics = new List<License>();
                foreach (var lic in License.Licenses)
                {
                    if (lic.Driver == this)
                        lics.Add(lic);
                }
                return lics;
            }
        }
        public List<TransportType> TransportTypes
        {
            get
            {
                List<TransportType> types = new List<TransportType>();
                foreach (var lic in License.Licenses)
                {
                    if (lic.Driver == this)
                        types.Add(lic.TransportType);
                }
                return types;
            }
        }

        public Driver(string firstname, string secondname, DateTime birthday = new DateTime())
        {
            Firstname = firstname;
            Secondname = secondname;
            Birthday = birthday;
            Drivers.Add(this);
            LastOperation = this.ToString() + " : Initialising object";
        }
        public Driver(DateTime birthday = new DateTime())
        {
            Firstname = "";
            Secondname = "";
            Drivers.Add(this);
            LastOperation = this.ToString() + " : Initialising object";
        }
        public Driver(string[] firstnames, string secondname)
        {
            if (firstnames.Length < 1)
                throw new ArgumentException("Empty first name");
            Firstname = firstnames[0];
            Secondname = secondname;
            Drivers.Add(this);
            for (int i = 1; i < firstnames.Length - 1; i++)
                new Driver(firstnames[i], secondname);
            LastOperation = this.ToString() + " : Initialising object";
        }
        public Driver(string firstname, string[] secondnames)
        {
            if (secondnames.Length < 1)
                throw new ArgumentException("Empty first name");
            Firstname = firstname;
            Secondname = secondnames[0];
            Drivers.Add(this);
            for (int i = 1; i < secondnames.Length - 1; i++)
                new Driver(firstname, secondnames[i]);
            LastOperation = this.ToString() + " : Initialising object";
        }

        ~Driver()
        {
            License.Delete(this);
            Route = null;
            Firstname = null;
            Secondname = null;
            LastOperation = this.ToString() + " : Destructing object";
        }

        public void ChangeName(string firstname, string secondname)
        {
            LastOperation = this.ToString() + " : Changing names of driver";
            Firstname = firstname;
            Secondname = secondname;
            LastOperation = this.ToString() + " : Changed names of driver";
        }
        public void ChangeName(string firstname)
        {
            Firstname = firstname;
        }
        public void ChangeSecondName(string secondname)
        {
            Secondname = secondname;
        }
        public void SetRoute(Route route)
        {
            LastOperation = this.ToString() + " : Setting route for the driver";
            Route = route;
            LastOperation = this.ToString() + " : Setted route for the driver";
        }
        public override string ToString()
        {
            LastOperation = this.ToString() + " : starting the ToString() method of the driver";
            return Name;
        }
        public static void Delete(Driver driver)
        {
            LastOperation = driver.ToString() + " : Deleting driver";
            Drivers.Remove(driver);
            LastOperation = driver.ToString() + " : Deleted driver";
        }
    }
}
