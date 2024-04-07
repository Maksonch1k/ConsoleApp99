using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Shareware : Software
    {
        public DateTime TrialExpirationDate { get; set; } // Дата истечения испытательного срока

        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Производитель: {Manufacturer}, Дата установки: {InstallationDate}, Дата истечения испытательного срока: {TrialExpirationDate}");
        }

        public override bool CanUse(DateTime currentDate)
        {
            return currentDate <= TrialExpirationDate; // Возвращаем true, если текущая дата меньше или равна дате истечения испытательного срока
        }
    }
}
