using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class RouteTransportationAgreement : Base
    {
        public static List<RouteTransportationAgreement> Agreements = new List<RouteTransportationAgreement>();
        
        private Guid routeid;
        private Guid transportationid;

        public Route Route
        {
            get
            {
                foreach (var elem in Route.Routes)
                    if (elem.Id == routeid)
                        return elem;
                return null;
            }
            private set
            {
                routeid = value.Id;
            }
        }
        public Transportation Transportation {
            get
            {
                foreach (var elem in Transportation.Transportations)
                    if (elem.Id == Route.Id)
                        return elem;
                return null;
            }
            private set
            {
                transportationid = value.Id;
            }
        }


        public RouteTransportationAgreement(Route route, Transportation transportation)
        {
            Route = route;
            Transportation = transportation;
            Agreements.Add(this);
        }
        ~RouteTransportationAgreement()
        {
            routeid = Guid.Empty;
            transportationid = Guid.Empty;
        }
        public string ToStringFull()
        {
            Route route = Route;
            Transportation transportation = Transportation;
            return String.Format("Driver: {0}\nTransport type: {1}", route.ToString(), transportation.ToString());
        }
        public override string ToString()
        {
            int length = this.GetId().ToString().Length;
            return String.Format("{0}...{1}", this.GetId().ToString().Substring(0, 4), this.GetId().ToString().Substring(length - 6, 5));
        }
        public static void Delete(RouteTransportationAgreement rta)
        {
            Agreements.Remove(rta);
        }
        public static void Delete(Route rt)
        {
            List<RouteTransportationAgreement> rtas = new List<RouteTransportationAgreement>();
            foreach (var rta in Agreements)
                if (rta.Route == rt)
                    rtas.Add(rta);
            foreach (var rta in Agreements)
                Delete(rta);
        }
        public static void Delete(Transportation tr)
        {
            List<RouteTransportationAgreement> rtas = new List<RouteTransportationAgreement>();
            foreach (var rta in Agreements)
                if (rta.Transportation == tr)
                    rtas.Add(rta);
            foreach (var rta in Agreements)
                Delete(rta);
        }

    }
}
