using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Freeware : Software
    {
        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Производитель: {Manufacturer}, Дата установки: {InstallationDate}");
        }
    }
}
