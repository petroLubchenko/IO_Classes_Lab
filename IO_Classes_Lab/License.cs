using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class License : Base
    {
        public static List<License> Licenses = new List<License>();

        private Guid driverid;
        private Guid transporttypeid;

        public Driver Driver
        {
            get
            {
                foreach (var elem in Driver.Drivers)
                    if (elem.Id == driverid)
                        return elem;
                return null;
            }
            private set
            {
                driverid = value.Id;
            }
        }
        public TransportType TransportType
        {
            get
            {
                foreach (var elem in TransportType.TransportTypes)
                    if (elem.Id == transporttypeid)
                        return elem;
                return null;
            }
            private set
            {
                transporttypeid = value.Id;
            }
        }

        public License(Driver driver, TransportType transporttype)
        {
            Driver = driver;
            TransportType = transporttype;
            Licenses.Add(this);
        }
        ~License()
        {
            driverid = Guid.Empty;
            transporttypeid = Guid.Empty;
        }

        public string Show()
        {
            return String.Format("Driver: {0}\nTransport type: {1}", Driver.ToString(), TransportType.ToString());
        }
        public override string ToString()
        {
            int length = this.GetId().ToString().Length;
            return String.Format("{0}...{1}", this.GetId().ToString().Substring(0, 4), this.GetId().ToString().Substring(length - 6, 5));
        }
        public static bool IsExist(Driver driver, TransportType transporttype)
        {
            foreach (var lic in Licenses)
            {
                if (lic.Driver == driver && lic.TransportType == transporttype)
                    return true;
            }
            return false;
        }
        public static void Delete(License license)
        {
            Licenses.Remove(license);
        }
        public static void Delete(Driver driver)
        {
            List<License> lics = new List<License>();
            foreach (var lic in Licenses)
                if (lic.Driver == driver)
                    lics.Add(lic);
            foreach (var lic in lics)
                Delete(lic);
        }
        public static void Delete(TransportType tt)
        {
            List<License> lics = new List<License>();
            foreach (var lic in Licenses)
                if (lic.TransportType == tt)
                    lics.Add(lic);
            foreach (var lic in lics)
                Delete(lic);
        }
    }
}
