using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Software
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate { get; set; }

        public abstract void PrintInfo();

        public virtual bool CanUse(DateTime currentDate)
        {
            return true;
        }
    }
}
