class Employee
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME= 1;
        int EMP_RATE_PER_HOUR = 20;

        int empHrs = 0;
        int empWage = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 2);
        Console.WriteLine(empCheck);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee is present");
            empHrs = 8;
        }
        else
        {
            Console.WriteLine("Employee is Absent");
            empHrs = 0;
        }
        empWage = empHrs*EMP_RATE_PER_HOUR;
        Console.WriteLine(empWage);
    }
}