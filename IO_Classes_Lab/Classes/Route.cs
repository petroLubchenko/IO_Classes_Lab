using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class Route : Base
    {
        public static List<Route> Routes = new List<Route>();
        private readonly int number;
        private List<Driver> drivers = new List<Driver>();
        public TransportType TransportType { get; private set; }
        public int Number {
            get
            {
                return number;
            }
            set
            {
                new Route(value, this);
                Delete(this);
            }
        }
        public List<Driver> Drivers
        {
            get
            {
                return drivers;
            }
        }
        public Driver SetDriver
        {
            set
            {
                drivers.Add(value);
            }
        }

        public Route(TransportType transporttype)
        {
            TransportType = transporttype;
            Number = Routes.Count >= 1 ? Routes.Count + 1 : 1;

            Routes.Add(this);
        }
        public Route(string cargo)
        {
            var tt = new TransportType(cargo, cargo);
            new Route(tt);
        }
        private Route(int number, Route route)
        {
            this.number = number;
            TransportType = route.TransportType;

            Routes.Add(this);
        }
        public Route()
        {
            new Route((string)null);
        }
        ~Route()
        {
            RouteTransportationAgreement.Delete(this);
            TransportType = null;
        }

        public Driver this[int i]
        {
            get
            {
                if (i > drivers.Count)
                    throw new IndexOutOfRangeException("Index is bigger than count of drivers");
                return drivers[i];
            }
            set
            {
                drivers.Insert(i, value);
            }
        }

        public List<Transportation> GetTransportations()
        {
            List<Transportation> transp = new List<Transportation>();
            foreach (var rta in RouteTransportationAgreement.Agreements)
            {
                if (rta.Route == this)
                    transp.Add(rta.Transportation);
            }
            return transp;
        }
        public void ChangeNumber(int number)
        {
            Number = number;
        }
        public void SetTransportType(TransportType transporttype)
        {
            TransportType = transporttype;
        }

        public static void Delete(Route route)
        {
            foreach (var dr in Driver.Drivers)
                if (dr.Route == route)
                    dr.SetRoute(null);
            RouteTransportationAgreement.Delete(route);
            Routes.Remove(route);
        }

        public override string ToString()
        {
            if (TransportType != null)
                return String.Format("№ {0} - {1}", Number.ToString(), TransportType.ToString());
            return String.Format("№ {0}", Number.ToString());
        }
    }
}
