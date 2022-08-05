using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal interface IStudyVisaAdmissionRules
    {
        public int transcript { get; set; }

        public double Discipline(double grade , double studyGap);

        public bool PassPort(string PassPortType);

    }
}
