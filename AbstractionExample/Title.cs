using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractionExample;

namespace AbstractionExample
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public abstract void Title();

        public void EmployeeInfo()
        {
            Console.WriteLine($"Ad: {Name}\nSoyad: {Surname}\nDepartman: {Department}");
        }

    }
    public class Developer : Employee
    {
        public override void Title()
        {
            Console.WriteLine("Yazılımcı olarak çalışıyorum.\n");
        }

    }
    public class ProjectManager : Employee
    {
        public override void Title()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.\n");
        }
    }

    
    public class SalesRep : Employee
    {
        public override void Title()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.\n");
        }
    }
}




