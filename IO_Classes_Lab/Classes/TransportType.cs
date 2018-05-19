using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class TransportType : Base
    {
        public static List<TransportType> TransportTypes = new List<TransportType>();

        public string Name { get; private set; }
        public string Cargo { get; private set; }



        public TransportType(string name, string cargo)
        {
            Name = name;
            Cargo = cargo;
            bool isExist = false;
            foreach (var tt in TransportTypes)
                if (tt.Name == name && tt.Cargo == cargo)
                {
                    isExist = true;
                    foreach (Transportation tr in Transportation.Transportations)
                        if (tr.TransportType == this)
                            tr.ChangeTransportType(tt);
                    break;
                }
            if (!isExist)
                TransportTypes.Add(this);
        }
        public TransportType()
        {
            Name = null;
            Cargo = null;

            TransportTypes.Add(this);
        }
        ~TransportType()
        {
            License.Delete(this);
            Name = null;
            Cargo = null;
        }
        public List<Driver> GetDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            foreach(var lic in License.Licenses)
            {
                if (lic.TransportType == this)
                    drivers.Add(lic.Driver);
            }
            return drivers;
        }
        public void ChangeData(string name)
        {
            Name = name;
        }
        public void ChangeCargo(string cargo)
        {
            Cargo = cargo;
        }
        public void ChangeData(string name, string cargo)
        {
            ChangeData(name);
            ChangeCargo(cargo);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Name, Cargo);
        }
        public static void Delete(TransportType transporttype)
        {
            License.Delete(transporttype);
            foreach (var route in Route.Routes)
                if (route.TransportType == transporttype)
                    route.SetTransportType(null);
            foreach (var trn in Transportation.Transportations)
                if (trn.TransportType == transporttype)
                    trn.TransportType = null;
            TransportTypes.Remove(transporttype);
        }
    }
}
