using System;
using System.Net.Security;

namespace ALXCourse.Assignments.M2.L1
{
    public static class SeniorityServiceTest
    {
        public static void Run()
        {
            var Emp001 = new Employee("Marcin", "Dziadzio", 9999.99, 1.7);
            var Emp002 = new Employee("Tomasz", "Kowalski", 15000.57, 2.7);
            var Emp003 = new Employee("Daniel", "Nowak", 25000, 8.3);
            var Emp004 = new Employee("Ireneusz", "Pawłowski", 3000, 0.3);
            var Emp005 = new Employee("Roman", "Wilchelmi", 11452.58, 2.4);
            var Emp006 = new Employee("Krystian", "Fedorczuk", 19475.36, 3.3);
            var seniorityService = new SeniorityService();

            // BlOK Salary
            seniorityService.ClassifySeniorityBySalary(Emp001);
            seniorityService.ClassifySeniorityBySalary(Emp002);
            seniorityService.ClassifySeniorityBySalary(Emp003);
            seniorityService.ClassifySeniorityBySalary(Emp004);
            seniorityService.ClassifySeniorityBySalary(Emp005);
            seniorityService.ClassifySeniorityBySalary(Emp006);
            Console.WriteLine("podział poprzez Wypłatę ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine();
            seniorityService.ClearLists();

            // BlOK Experience
            seniorityService.ClassifySeniorityByExperience(Emp001);
            seniorityService.ClassifySeniorityByExperience(Emp002);
            seniorityService.ClassifySeniorityByExperience(Emp003);
            seniorityService.ClassifySeniorityByExperience(Emp004);
            seniorityService.ClassifySeniorityByExperience(Emp005);
            seniorityService.ClassifySeniorityByExperience(Emp006);
            Console.WriteLine("podział poprzez Doświadczenie ");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine();
            seniorityService.ClearLists();
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
            }
        }
    }
}
