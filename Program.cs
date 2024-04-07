using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Software> softwareDatabase = new List<Software>
        {
            new Freeware { Name = "Notepad++", Manufacturer = "Notepad++ Team", InstallationDate = new DateTime(2022, 10, 1, 18, 0, 16) },
            new Shareware { Name = "Adobe Photoshop", Manufacturer = "Adobe", InstallationDate = new DateTime(2024, 2, 14, 18, 0, 16), TrialExpirationDate = new DateTime(2024, 3, 14, 18, 0, 16) },
            new CommercialSoftware { Name = "Офисный пакет", Manufacturer = "Microsoft", InstallationDate = new DateTime(2022, 12, 1, 18, 0, 16), LicenseExpirationDate = new DateTime(2023, 12, 1, 18, 0, 16) }
        };

            Console.WriteLine("Информация о программном обеспечении:");
            foreach (var software in softwareDatabase)
            {
                software.PrintInfo();
            }

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("\nПрограммное обеспечение, доступное для использования на текущую дату:");
            foreach (var software in softwareDatabase)
            {
                if (software.CanUse(currentDate))
                {
                    software.PrintInfo();
                }
                Console.ReadKey();
            }
        }
    }
}
