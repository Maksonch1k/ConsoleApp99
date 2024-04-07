using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class CommercialSoftware : Software
    {
        public decimal Price { get; set; } // Цена
        public DateTime LicenseExpirationDate { get; set; } // Дата истечения лицензии

        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Производитель: {Manufacturer}, Дата установки: {InstallationDate.ToString("dd.MM.yyyy HH:mm:ss")}");
        }

        public override bool CanUse(DateTime currentDate)
        {
            return currentDate <= LicenseExpirationDate; // Возвращаем true, если текущая дата меньше или равна дате истечения лицензии
        }
    }
}
