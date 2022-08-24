using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation ");
            //calculate employee Wage
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 30, 25, 100);
            EmpWageBuilderObject Infosys = new EmpWageBuilderObject("Infosys", 40, 35, 100);
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.Result());
            Infosys.ComputeEmpWage();
            Console.WriteLine(Infosys.Result());
        }
    }
}
