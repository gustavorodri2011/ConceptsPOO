using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new SalaryEmployee
            {
                Id = 1,
                FirstName = "Gustavo",
                LastName = "Rodriguez",
                BirthDate = new Date(1974, 10, 29),
                HiringDate = new Date(1999, 12, 13),
                IsActive = true,
                Salary = 54567.35M
            };
            Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee
            {
                Id = 2,
                FirstName = "Juliana",
                LastName = "Andrada",
                BirthDate = new Date(1983, 3, 12),
                HiringDate = new Date(2014, 9, 1),
                IsActive = true,
                CommissionPercentaje=0.03f,
                Sales=221300
            };
            Console.WriteLine(employee2);
        }
    }
}
