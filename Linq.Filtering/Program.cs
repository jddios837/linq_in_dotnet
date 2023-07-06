// See https://aka.ms/new-console-template for more information
using Linq.Core;

List<int> intList = Numbers.GetNumbers();

// Method Syntax
IEnumerable<int> filteredData = intList.Where(num => num > 0);

foreach (var number in filteredData)
{
    Console.WriteLine(number);
}

var OddNumbersWithIndexPosition = intList
    .Select((num, index) => new { Numbers = num, IndexPosition = index})
    .Where(x => x.Numbers % 2 != 0)
    .Select(data => new { Number = data.Numbers, IndexPosition = data.IndexPosition });

foreach (var item in OddNumbersWithIndexPosition)
{
    Console.WriteLine($"IndexPosition : {item.IndexPosition} , Value: {item.Number}");
}

List<Employee> employeesList = Employee.GetEmployees();

var MethodSyntax = employeesList
    .Select((Data, index) => new { employee = Data, Index = index})
    .Where(emp => emp.employee.Salary >= 500000 && emp.employee.Gender == "Male")
    .Select(emp => new
    {
        EmployeeName = emp.employee.Name,
        Gender = emp.employee.Gender,
        Salary = emp.employee.Salary,
        IndexPosition = emp.Index
    })
    .ToList();

foreach (var emp in MethodSyntax)
{
    Console.WriteLine($"Position : { emp.IndexPosition } Name: { emp.EmployeeName }, " +
                      $"Gender: { emp.Gender }, Salary: {emp.Salary}");
}  