using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_class_of_your_choice
{
    public class CarService
    {
        public string Name;
        public int Year;
        public int MaintDue;
        public string ServiceNeeds;
        public int Miles;
        public int MaintDate;

        public CarService()
        {
            Name = "No Name";
            Year = 1886;
            MaintDue = 0;
            ServiceNeeds = "No service";
            Miles = 0;
            MaintDate = 0;
        }

        public CarService(string name, int year, int maintDue, string serviceNeeds, int miles, int maintDate)
        {
            Name = name;
            Year = year;
            MaintDue = maintDue;
            ServiceNeeds = serviceNeeds;
            Miles = miles;
            MaintDate = maintDate;
        }

        public void Drive()
        {
            Miles += 10;
            MaintDue -= 10;
        }
        public void Fix()
        {
            ServiceNeeds = "No service needed";
        }
        public void tick()
        {
            MaintDate--;
            if (MaintDue <= 0)
            {
                MaintDue = 1000;
            }
            else
            {
                MaintDue -= MaintDue / MaintDate;
                Miles = MaintDue - MaintDate;
            }

        }

    }
}
