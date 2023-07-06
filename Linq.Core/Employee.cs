namespace Linq.Core;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public int Salary { get; set; }
    public List<string>? Technology { get; set; }

    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 101, Name = "Preety", Gender = "Female", Salary = 60000,
                Technology = new List<string>() { "C#", "Jave", "C++" }
            },
            new Employee
            {
                Id = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
                Technology = new List<string>() { "WCF", "SQL Server", "C#" }
            },
            new Employee
            {
                Id = 103, Name = "Hina", Gender = "Female", Salary = 40000,
                Technology = new List<string>() { "MVC", "Jave", "LINQ" }
            },
            new Employee { Id = 104, Name = "Anurag", Gender = "Male", Salary = 450000 },
            new Employee { Id = 105, Name = "Sambit", Gender = "Male", Salary = 550000 },
            new Employee
            {
                Id = 106, Name = "Sushanta", Gender = "Male", Salary = 700000,
                Technology = new List<string>() { "ADO.NET", "C#", "LINQ" }
            }
        };

        return employees;
    }
}