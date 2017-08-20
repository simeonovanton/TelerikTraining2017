using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companyWebSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerSecondName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + companyPhone);
            Console.WriteLine("Fax: {0}", string.IsNullOrEmpty(companyFax) ? "(no fax)" : companyFax);
            Console.WriteLine("Web site: " + companyWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerSecondName, managerAge, managerPhone);
        }
    }
}
