using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab
{
    public class Transportation : Base
    {
        public static List<Transportation> Transportations = new List<Transportation>();
        private decimal income;
        private TransportType transporttype;
        public double Income {
            get
            {
                return (double)income;
            }
            private set
            {
                income = Convert.ToDecimal(value);
            }
        }
        public decimal Spending { get; private set; }
        public readonly int Length;
        public TransportType TransportType {
            get
            {
                return transporttype;
            }
            set
            {
                transporttype = value == null ? transporttype : value;
            }
        }

        public Transportation(int length, double income, decimal spending, TransportType transporttype = null)
        {
            Income = income;
            Spending = spending;
            Length = length;
            if (transporttype != null)
                TransportType = transporttype;
            Transportations.Add(this);
        }
        ~Transportation()
        {
            transporttype = null;
            RouteTransportationAgreement.Delete(this);
        }
        public List<Route> GetRoutes()
        {
            List<Route> routes = new List<Route>();
            foreach (var rta in RouteTransportationAgreement.Agreements)
            {
                if (rta.Transportation == this)
                    routes.Add(rta.Route);
            }
            return routes;
        }
        public void ChangeTransportType(TransportType transporttype)
        {
            TransportType = transporttype;
        }

        public override string ToString()
        {
            if (TransportType != null)
                return String.Format("{0} - {1} km. | ${2}", TransportType.ToString(), Length.ToString(), (income - Spending).ToString());
            return String.Format("No Type - {0} km. | ${1}", Length.ToString(), (income - Spending).ToString());
        }
        public void ChangeIncome(double income)
        {
            Income = income;
        }
        public void ChangeSpending(decimal spending)
        {
            Spending = spending;
        }
        public static void Delete(Transportation transportation)
        {
            Transportations.Remove(transportation);
            RouteTransportationAgreement.Delete(transportation);
        }
    }
}
