using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FSD_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IHellowService
    {
        public string SayHello(string name)
        {
            String Message = null;
            if (DateTime.Now.Hour < 12)
            {
                Message = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                Message = "Good Afternoon";
            }
            else
            {
                Message = "Good Evening";
            }
            return Message + " " + name;
        }
        public string TodayProgram(string name)
        {
            DayOfWeek day = new DayOfWeek();
            day = DateTime.Now.DayOfWeek;
            String Message = null;
            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
                Message = "Happy weekend";
            else
                Message = "Enjoy Working day";
            return Message + " " + name;
        }
    }
}
