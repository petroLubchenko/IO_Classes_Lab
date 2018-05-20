using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Classes_Lab.Classes
{
    class StudyingDriver : Driver
    {
        private TransportType transporttype;
        private DateTimeOffset studyingtime = new DateTimeOffset(DateTime.Now, new TimeSpan(120, 0, 0, 0));
        public TransportType StudyingTransportType
        {
            private get
            {
                return transporttype;
            }
            set
            {
                transporttype = value;
                studyingtime = new DateTimeOffset(DateTime.Now, new TimeSpan(120, 0, 0, 0));
            }
        }
        public StudyingDriver(string firstname, string secondname, TransportType studyingtt, DateTime birthday = new DateTime()) : base(firstname, secondname, birthday)
        {
            StudyingTransportType = studyingtt;
            Driver.Drivers.Add(this);
        }
        public StudyingDriver(Driver driver, TransportType studyingtt) : base(driver.Firstname, driver.Secondname, driver.Birthday)
        {
            Delete(driver);
            StudyingTransportType = studyingtt;
            Drivers.Add(this);
        }
    }
}
